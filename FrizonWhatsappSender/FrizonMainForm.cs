using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using OpenQA.Selenium.Support.UI;

namespace FrizonWhatsappSender
{
    public partial class FrizonMainForm : Form
    {
        private AppSettings settings = new AppSettings();

        private IWebDriver driver;
        private List<Contato> contatos;
        private bool isRunning = false;
        private int totalEnviados = 0;

        public FrizonMainForm()
        {
            InitializeComponent();
            settings.Load();
            btnParar.Enabled = false;
            btnIniciar.Enabled = false;
            chkUsarMensagemPersonalizada_CheckedChanged(null, null);
            checkBoxEnviarImagem.CheckedChanged += CheckBoxEnviarMidia_CheckedChanged;
            checkBoxEnviarVideo.CheckedChanged += CheckBoxEnviarMidia_CheckedChanged;
        }

        private void SafeUpdateUI(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void CheckBoxEnviarMidia_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = sender as CheckBox;

            if (currentCheckBox == checkBoxEnviarImagem && checkBoxEnviarImagem.Checked)
            {
                checkBoxEnviarVideo.Checked = false;
            }
            else if (currentCheckBox == checkBoxEnviarVideo && checkBoxEnviarVideo.Checked)
            {
                checkBoxEnviarImagem.Checked = false;
            }
        }
        private void AppendToLog(string message)
        {
            SafeUpdateUI(() =>
            {
                if (!txtLog.IsDisposed && !txtLog.Disposing)
                {
                    txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\r\n");
                }
            });
        }


        private void btnSelecionarPlanilha_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Arquivos CSV|*.csv|Todos os arquivos|*.*";
                    openFileDialog.Title = "Selecione o arquivo de contatos";
                    openFileDialog.CheckFileExists = true;
                    openFileDialog.CheckPathExists = true;
                    openFileDialog.Multiselect = false;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtCaminhoPlanilha.Text = openFileDialog.FileName;
                        contatos = LerCSV(openFileDialog.FileName);
                        lblTotalContatos.Text = $"Total: {contatos.Count} contatos";
                        btnIniciar.Enabled = contatos.Count > 0;

                        MessageBox.Show($"Arquivo carregado com sucesso!\n\n" +
                                      $"Contatos encontrados: {contatos.Count}\n" +
                                      $"Primeiro contato: {contatos.First().Nome}\n" +
                                      $"Último contato: {contatos.Last().Nome}",
                                      "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO AO LER ARQUIVO:\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIniciar.Enabled = false;
            }
        }

        private List<Contato> LerCSV(string caminho)
        {
            var listaContatos = new List<Contato>();

            try
            {
                if (!File.Exists(caminho))
                    throw new FileNotFoundException("Arquivo não encontrado!");

                var linhas = File.ReadAllLines(caminho, Encoding.UTF8);

                if (linhas.Length < 2)
                    throw new Exception("Arquivo vazio ou sem dados!");

                // Detectar delimitador (verifica se a primeira linha contém vírgula ou ponto e vírgula)
                bool usarPontoEVirgula = linhas[0].Contains(';') && !linhas[0].Contains(',');

                for (int i = 1; i < linhas.Length; i++)
                {
                    var valores = usarPontoEVirgula ?
                        ParseCSVLine(linhas[i], ';') :
                        ParseCSVLine(linhas[i], ',');

                    if (valores.Length >= 2 && !string.IsNullOrWhiteSpace(valores[1]))
                    {
                        listaContatos.Add(new Contato
                        {
                            Nome = valores.Length > 0 ? valores[0].Trim() : "Sem Nome",
                            Telefone = FormatTelefone(valores[1].Trim()),
                            Mensagem = valores.Length > 2 ? valores[2].Trim() : ""
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao ler arquivo CSV: {ex.Message}");
            }

            return listaContatos;
        }

        private string[] ParseCSVLine(string linha, char delimitador)
        {
            List<string> valores = new List<string>();
            StringBuilder valorAtual = new StringBuilder();
            bool entreAspas = false;

            for (int i = 0; i < linha.Length; i++)
            {
                char c = linha[i];

                if (c == '"')
                {
                    entreAspas = !entreAspas;
                    if (entreAspas && i < linha.Length - 1 && linha[i + 1] == '"')
                    {
                        valorAtual.Append('"');
                        i++;
                    }
                }
                else if (c == delimitador && !entreAspas)
                {
                    valores.Add(valorAtual.ToString());
                    valorAtual.Clear();
                }
                else
                {
                    valorAtual.Append(c);
                }
            }

            valores.Add(valorAtual.ToString());
            return valores.ToArray();
        }

        private string FormatTelefone(string telefone)
        {
            string numeros = new string(telefone.Where(c => char.IsDigit(c)).ToArray());

            if (string.IsNullOrEmpty(numeros))
                throw new Exception("Número de telefone inválido!");

            if (numeros.Length == 11 && numeros.StartsWith("0"))
                return "55" + numeros.Substring(1);
            else if (numeros.Length == 10)
                return "55" + numeros;
            else if (numeros.Length == 12 && numeros.StartsWith("55"))
                return numeros;
            else if (numeros.Length == 13 && numeros.StartsWith("55"))
                return numeros;

            return numeros;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (checkBoxEnviarImagem.Checked && checkBoxEnviarVideo.Checked)
            {
                MessageBox.Show("Selecione apenas um tipo de mídia (imagem OU vídeo)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (chkUsarMensagemPersonalizada.Checked && string.IsNullOrWhiteSpace(txtMensagemPersonalizada.Text))
            {
                MessageBox.Show("Por favor, insira a mensagem personalizada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (contatos == null || contatos.Count == 0)
            {
                MessageBox.Show("Nenhum contato válido encontrado no arquivo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isRunning = true;
            totalEnviados = 0;
            btnIniciar.Enabled = false;
            btnParar.Enabled = true;
            btnSelecionarPlanilha.Enabled = false;

            var options = new ChromeOptions();
            options.AddArguments(
                "user-data-dir=C:\\FrizonWhatsappSession",
                "profile-directory=Default",
                "--app=https://web.whatsapp.com",
                "--window-size=1024,768",
                "--disable-infobars",
                "--disable-notifications",
                "--disable-popup-blocking",
                "--disable-extensions",
                "--disable-gpu",
                "--no-sandbox",
                "--no-first-run",
                "--no-default-browser-check"
            );

            // Remover a mensagem "Controlado por automação"
            options.AddExcludedArgument("enable-automation");
            options.AddArgument("--disable-blink-features=AutomationControlled");

            try
            {
                driver = new ChromeDriver(options);

                // Espera 3 segundos e tenta remover elementos manualmente
                Thread.Sleep(3000);
                RemoveChromeUIElements();

                AppendToLog("Aguardando confirmação do usuário...");

                SafeUpdateUI(() =>
                {
                    lblStatus.Text = "Pronto para iniciar";
                    lblStatus.ForeColor = Color.Blue;
                    btnPularAutenticacao.Enabled = true;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO AO INICIAR CHROME:\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FinalizarProcesso();
            }
        }

        private void RemoveChromeUIElements()
        {
            try
            {
                // Remove elementos via JavaScript
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript(@"
            // Remove a barra de endereço do modo 'app'
            const style = document.createElement('style');
            style.innerHTML = 'header { display: none !important; }';
            document.head.appendChild(style);
            
            // Remove qualquer popup de 'extensão instalada'
            const removeElements = [
                'div[role=banner]',
                'div[aria-label=Barra]',
                'header'
            ];
            
            removeElements.forEach(selector => {
                const elements = document.querySelectorAll(selector);
                elements.forEach(el => el.remove());
            });
        ");
            }
            catch { }
        }
        private void btnPularAutenticacao_Click(object sender, EventArgs e)
        {
            if (driver != null && isRunning)
            {
                AppendToLog("⚡ Iniciando envios por confirmação do usuário");
                SafeUpdateUI(() =>
                {
                    lblStatus.Text = "Iniciando envios...";
                    lblStatus.ForeColor = Color.Green;
                    btnPularAutenticacao.Enabled = false;
                });

                Task.Run(() => IniciarEnvios());
            }
        }

        private void IniciarEnvios()
        {
            try
            {
                foreach (var contato in contatos)
                {
                    if (!isRunning) break;

                    try
                    {
                        AppendToLog($"⏳ Preparando envio para {contato.Nome}...");
                        EnviarMensagem(contato);
                        totalEnviados++;

                        AppendToLog($"✅ {totalEnviados}/{contatos.Count} - {contato.Nome} ({contato.Telefone})" +
                          (contato.UsouMensagemPersonalizada ? " [Mensagem padrão]" : ""));
                        SafeUpdateUI(() =>
                        {
                            lblEnviados.Text = $"Enviados: {totalEnviados}/{contatos.Count}";
                        });

                        // Pausa maior apenas entre contatos diferentes
                        if (isRunning && totalEnviados < contatos.Count)
                        {
                            int delay = new Random().Next(settings.MinDelayBetweenContacts, settings.MaxDelayBetweenContacts + 1);
                            AppendToLog($"⏳ Aguardando {delay}s antes do próximo envio...");
                            Thread.Sleep(delay * 1000);
                        }
                    }
                    catch (Exception ex)
                    {
                        AppendToLog($"❌ Erro em {contato.Nome}: {ex.Message}");

                        // Pausa maior em caso de erro
                        if (isRunning)
                        {
                            Thread.Sleep(settings.ErrorDelay * 1000); // 15 segundos antes de tentar o próximo
                        }
                    }
                }

                AppendToLog("🎉 Processo concluído com sucesso!");
                SafeUpdateUI(() =>
                {
                    lblStatus.Text = $"Concluído - {totalEnviados}/{contatos.Count} enviados";
                });
            }
            catch (Exception ex)
            {
                AppendToLog($"❌ ERRO CRÍTICO: {ex.Message}");
                SafeUpdateUI(() =>
                {
                    lblStatus.Text = "Erro no processo";
                    lblStatus.ForeColor = Color.Red;
                });
            }
            finally
            {
                FinalizarProcesso();
            }
        }

        private void EnviarArquivoMidia()
        {
            try
            {
                int delayAbrirAnexos = 2000;
                int delaySelecionarAnexo = 3000;
                int delayCarregarArquivo = 0;
                int delayParaVideo = (settings.delayFoto * 1000);
                int delayParaFoto = (settings.delayVideo * 1000);

                if (checkBoxEnviarImagem.Checked || checkBoxEnviarVideo.Checked)
                {

                    if (checkBoxEnviarImagem.Checked)
                    {
                        delayCarregarArquivo = delayParaFoto;
                    }
                    else if (checkBoxEnviarVideo.Checked)
                    {
                        delayCarregarArquivo = delayParaVideo;
                    }



                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

                    // Passo 1: Abrir menu de anexos
                    // Aguarda até o botão de anexar estar presente no DOM
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    IWebElement botaoAnexar = wait.Until(d => d.FindElement(By.CssSelector("button[title='Anexar']")));

                    // Clica usando JavaScript (mais confiável em alguns contextos de UI dinâmica)
                    js.ExecuteScript("arguments[0].click();", botaoAnexar);

                    AppendToLog("✅ Clique no botão de anexos.");
                    Thread.Sleep(delayAbrirAnexos); // mantém sua pausa original se necessário para o próximo passo


                    // Passo 2: Clicar no botão 'Fotos e Vídeos'
                    string jsClickFotosVideos = @"
                const allButtons = document.querySelectorAll('span, div, button, li');
                const fotosVideosBtn = [...allButtons].find(el => {
                    return el.textContent.trim().toLowerCase().includes('fotos e vídeos') 
                           && el.closest('[role=""button""]');
                });
                if (fotosVideosBtn) {
                    fotosVideosBtn.closest('[role=""button""]').click();
                } else {
                    console.log('Botão ""Fotos e vídeos"" não encontrado.');
                }";
                    js.ExecuteScript(jsClickFotosVideos);
                    AppendToLog("✅ Clique no botão de fotos e vídeos.");
                    Thread.Sleep(delaySelecionarAnexo);

                    // Passo 3: Upload do arquivo no input correto (visível e recém-criado)
                    string caminhoArquivo = checkBoxEnviarImagem.Checked
                        ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Media", "imagem_padrao.jpg")
                        : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Media", "video_padrao.mp4");

                    // Procurar o botão de "Fotos e vídeos" e acessar o input dentro dele
                    var botoes = driver.FindElements(By.CssSelector("li[role='button']"));
                    IWebElement botaoFotoVideo = botoes.FirstOrDefault(el => el.Text.ToLower().Contains("fotos e vídeos"));

                    if (botaoFotoVideo != null)
                    {
                        IWebElement inputFile = botaoFotoVideo.FindElement(By.CssSelector("input[type='file']"));
                        inputFile.SendKeys(caminhoArquivo);
                        AppendToLog($"✅ Arquivo anexado ao input correto: {Path.GetFileName(caminhoArquivo)}");
                    }
                    else
                    {
                        AppendToLog("❌ Botão 'Fotos e vídeos' não encontrado para upload.");
                        return;
                    }

                    Thread.Sleep(delayCarregarArquivo);

                    // Passo 4: Enviar
                    try
                    {
                        IWebElement btnEnviar = driver.FindElement(By.CssSelector("div[role='button'][aria-label='Enviar']"));
                        btnEnviar.Click();
                        AppendToLog("✅ Clique no botão Enviar.");
                    }
                    catch (NoSuchElementException)
                    {
                        AppendToLog("⚠️ Botão Enviar não encontrado, pode ter sido enviado automaticamente.");
                    }

                    Thread.Sleep(3000);
                }
            }
            catch (Exception ex)
            {
                AppendToLog($"❌ Falha ao enviar arquivo: {ex.Message}");
                throw;
            }
        }



        private void EnviarMensagem(Contato contato)
        {
            if (string.IsNullOrWhiteSpace(contato.Telefone))
                throw new Exception("Número de telefone vazio!");

            const int maxTentativas = 5;
            int tentativas = 0;
            bool enviadoComSucesso = false;
            Exception ultimoErro = null;


            string mensagemFormatada;
            if (chkUsarMensagemPersonalizada.Checked)
            {
                mensagemFormatada = txtMensagemPersonalizada.Text.Replace("{nome}", contato.Nome);
                contato.UsouMensagemPersonalizada = true;
            }
            else
            {
                mensagemFormatada = contato.Mensagem.Replace("{nome}", contato.Nome);
                contato.UsouMensagemPersonalizada = false;
            }


            string url = $"https://web.whatsapp.com/send?phone={contato.Telefone}&text={Uri.EscapeDataString(mensagemFormatada)}";

            while (tentativas < maxTentativas && !enviadoComSucesso)
            {
                tentativas++;
                AppendToLog($"🔄 Tentativa {tentativas} de {maxTentativas} para {contato.Nome}");

                try
                {
                    // 1. Navega para a URL do chat
                    driver.Navigate().GoToUrl(url);
                    AppendToLog($"↗️ Abrindo chat com {contato.Nome}");

                    // 2. Espera fixa de 10 segundos para carregamento
                    AppendToLog($"⏳ Aguardando {settings.InitialLoadDelay} segundos para carregamento...");
                    Thread.Sleep(settings.InitialLoadDelay * 1000);

                    if (checkBoxEnviarImagem.Checked || checkBoxEnviarVideo.Checked)
                    {
                        EnviarArquivoMidia();
                    }

                    if (!checkBoxEnviarImagem.Checked && !checkBoxEnviarVideo.Checked)
                    {

                        // 3. Envia a mensagem via JavaScript clicando no botão de enviar
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

                        // Script para encontrar e clicar no botão de enviar
                        bool enviado = (bool)js.ExecuteScript(@"
                try {
                    // Localiza o botão pelo atributo data-tab='11'
                    const sendButton = document.querySelector('button[data-tab=""11""][aria-label=""Enviar""]');
                    
                    if (!sendButton) {
                        console.error('Botão de enviar não encontrado');
                        return false;
                    }
                    
                    // Simula um clique real no botão
                    const mouseDownEvent = new MouseEvent('mousedown', {
                        bubbles: true,
                        cancelable: true,
                        view: window
                    });
                    
                    const mouseUpEvent = new MouseEvent('mouseup', {
                        bubbles: true,
                        cancelable: true,
                        view: window
                    });
                    
                    const clickEvent = new MouseEvent('click', {
                        bubbles: true,
                        cancelable: true,
                        view: window
                    });
                    
                    sendButton.dispatchEvent(mouseDownEvent);
                    setTimeout(() => {
                        sendButton.dispatchEvent(mouseUpEvent);
                        setTimeout(() => {
                            sendButton.dispatchEvent(clickEvent);
                        }, 50);
                    }, 50);
                    
                    return true;
                } catch (error) {
                    console.error('Erro ao enviar mensagem:', error);
                    return false;
                }
            ");

                        if (!enviado)
                        {
                            throw new Exception("Falha ao localizar ou clicar no botão de enviar");
                        }

                    }

                    AppendToLog($"✓ Mensagem enviada para {contato.Nome} (via botão)");
                    enviadoComSucesso = true;

                    // 4. Pausa aleatória entre 5-8 segundos apenas se foi enviado com sucesso
                    int delay = new Random().Next(settings.MinSendDelay * 1000, settings.MaxSendDelay * 1000);
                    AppendToLog($"⏳ Aguardando {delay / 1000}s antes do próximo...");
                    Thread.Sleep(delay);
                }
                catch (Exception ex)
                {
                    ultimoErro = ex;
                    AppendToLog($"⚠️ Falha na tentativa {tentativas}: {ex.Message}");

                    if (tentativas < maxTentativas)
                    {
                        // Espera um tempo crescente antes de tentar novamente (2, 4, 6, 8 segundos)
                        int delayRetry = tentativas * (settings.RetryDelayMultiplier * 1000);
                        AppendToLog($"⏳ Aguardando {delayRetry / 1000}s antes de tentar novamente...");
                        Thread.Sleep(delayRetry);
                    }
                }
            }

            if (!enviadoComSucesso)
            {
                throw new Exception($"Falha ao enviar mensagem após {maxTentativas} tentativas. Último erro: {ultimoErro?.Message}", ultimoErro);
            }
        }

        private void FinalizarProcesso()
        {
            SafeUpdateUI(() =>
            {
                btnPularAutenticacao.Enabled = false;
                txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {(isRunning ? "✔️ Processo concluído!" : "⏸ Processo interrompido!")}\r\n");
                btnIniciar.Enabled = true;
                btnParar.Enabled = false;
                btnSelecionarPlanilha.Enabled = true;
            });

            isRunning = false;

            try
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver.Dispose();
                    driver = null;
                }
            }
            catch { }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            isRunning = false;
            AppendToLog("⏸ Parando envios...");
        }

        private void FrizonMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            try
            {
                if (driver != null)
                {
                    driver.Quit();
                    driver.Dispose();
                }
            }
            catch { }
        }

        private void chkUsarMensagemPersonalizada_CheckedChanged(object sender, EventArgs e)
        {
            txtMensagemPersonalizada.Enabled = chkUsarMensagemPersonalizada.Checked;
        }

        private void buttonHelpMensagens_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ao marcar a caixa de seleção, a mensagem abaixo será automaticamente enviada para todos os contatos.",
                           "Ajuda",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }

        private void groupBoxMensagens_Enter(object sender, EventArgs e)
        {

        }

        private void btnMidia_Click(object sender, EventArgs e)
        {
            frmConfigMidia frmConfigMidiaForm = new frmConfigMidia();
            frmConfigMidiaForm.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            SettingsForm frmConfigTimes = new SettingsForm(settings);
            frmConfigTimes.Show();
        }

        private void btnPlanilha_Click(object sender, EventArgs e)
        {
            planilhaModelo planilhaModeloUser = new planilhaModelo();
            planilhaModeloUser.Show();
        }

        private void SalvarLogEmArquivo()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Salvar log como...";
                    saveFileDialog.Filter = "Arquivo de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
                    saveFileDialog.FileName = $"log_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, txtLog.Text, Encoding.UTF8);
                        MessageBox.Show("Log salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o log:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalvarLogEmArquivo();
        }
    }


    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Mensagem { get; set; }
        public bool UsouMensagemPersonalizada { get; set; }
    }
}