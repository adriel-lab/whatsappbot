using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FrizonWhatsappSender
{
    public partial class planilhaModelo : Form
    {
        public planilhaModelo()
        {
            InitializeComponent();
        }

        private void planilhaModelo_Load(object sender, EventArgs e)
        {
            // Cria e preenche o DataGridView com dados de exemplo
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome");
            dt.Columns.Add("Telefone");
            dt.Columns.Add("Mensagem");

            dt.Rows.Add("João", "13996450000", "Mensagem para teste");
            dt.Rows.Add("Maria", "13996450000", "Mensagem para promoção");
            dt.Rows.Add("Eduardo", "13996450000", "Uma mensagem de teste");
            dt.Rows.Add("Geruncio", "13996450000", "Um novo teste");

            dataGridViewExample.DataSource = dt;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
                saveFileDialog.FileName = "modelo_contatos_whatsapp.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Escreve o cabeçalho
                        sw.WriteLine("Nome,Telefone,Mensagem");

                        // Escreve alguns exemplos
                        sw.WriteLine("João,13996453169,Teste ola1");
                        sw.WriteLine("Maria,13996453169,viva teste2");
                        sw.WriteLine("Eduardo,13996453169,Teste para o edu ver3");
                        sw.WriteLine("Geruncio,13996453169,Sou muito gostoso4");
                    }

                    MessageBox.Show("Modelo baixado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DownloadModeloPlanilha()
        {
            try
            {
                // Obter o diretório da aplicação
                string appDirectory = Application.StartupPath;
                string modeloPath = Path.Combine(appDirectory, "planilha_modelo.csv");

                // Verificar se o arquivo modelo existe
                if (!File.Exists(modeloPath))
                {
                    MessageBox.Show("Arquivo modelo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Configurar o SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Arquivo CSV (*.csv)|*.csv",
                    Title = "Salvar Planilha Modelo",
                    FileName = "planilha_modelo.csv",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    RestoreDirectory = true,
                    OverwritePrompt = true
                };

                // Mostrar o diálogo e verificar se o usuário selecionou um local
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Copiar o arquivo para o local selecionado
                    File.Copy(modeloPath, saveFileDialog.FileName, true);

                    // Mostrar mensagem de sucesso
                    MessageBox.Show($"Planilha modelo salva com sucesso em:\n{saveFileDialog.FileName}",
                                  "Sucesso",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Acesso negado ao tentar salvar o arquivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar a planilha:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDownload_Click_1(object sender, EventArgs e)
        {
            DownloadModeloPlanilha();
        }
    }
}