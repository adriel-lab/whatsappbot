namespace FrizonWhatsappSender
{
    partial class FrizonMainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnSelecionarPlanilha = new Button();
            btnIniciar = new Button();
            btnParar = new Button();
            txtCaminhoPlanilha = new TextBox();
            txtLog = new RichTextBox();
            lblTotalContatos = new Label();
            lblEnviados = new Label();
            lblStatus = new Label();
            btnPularAutenticacao = new Button();
            panelControles = new Panel();
            progressBar = new ProgressBar();
            btnPlanilha = new Button();
            btnConfig = new Button();
            btnMidia = new Button();
            checkBoxEnviarVideo = new CheckBox();
            checkBoxEnviarImagem = new CheckBox();
            panelLog = new Panel();
            lblTitulo = new Label();
            panelMensagens = new Panel();
            groupBoxMensagens = new GroupBox();
            lblMediaOptions = new Label();
            buttonHelpMensagens = new Button();
            txtMensagemPersonalizada = new TextBox();
            chkUsarMensagemPersonalizada = new CheckBox();
            panelStatus = new Panel();
            button1 = new Button();
            panelControles.SuspendLayout();
            panelLog.SuspendLayout();
            panelMensagens.SuspendLayout();
            groupBoxMensagens.SuspendLayout();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelecionarPlanilha
            // 
            btnSelecionarPlanilha.BackColor = Color.FromArgb(82, 112, 79);
            btnSelecionarPlanilha.FlatAppearance.BorderSize = 0;
            btnSelecionarPlanilha.FlatStyle = FlatStyle.Flat;
            btnSelecionarPlanilha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSelecionarPlanilha.ForeColor = Color.White;
            btnSelecionarPlanilha.Location = new Point(20, 79);
            btnSelecionarPlanilha.Name = "btnSelecionarPlanilha";
            btnSelecionarPlanilha.Size = new Size(180, 35);
            btnSelecionarPlanilha.TabIndex = 0;
            btnSelecionarPlanilha.Text = "SELECIONAR PLANILHA";
            btnSelecionarPlanilha.UseVisualStyleBackColor = false;
            btnSelecionarPlanilha.Click += btnSelecionarPlanilha_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(82, 112, 79);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(20, 9);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(180, 35);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "INICIAR ENVIOS";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnParar
            // 
            btnParar.BackColor = Color.FromArgb(204, 85, 67);
            btnParar.FlatAppearance.BorderSize = 0;
            btnParar.FlatStyle = FlatStyle.Flat;
            btnParar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnParar.ForeColor = Color.White;
            btnParar.Location = new Point(20, 161);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(180, 35);
            btnParar.TabIndex = 2;
            btnParar.Text = "PARAR ENVIOS";
            btnParar.UseVisualStyleBackColor = false;
            btnParar.Click += btnParar_Click;
            // 
            // txtCaminhoPlanilha
            // 
            txtCaminhoPlanilha.BackColor = Color.WhiteSmoke;
            txtCaminhoPlanilha.BorderStyle = BorderStyle.FixedSingle;
            txtCaminhoPlanilha.Font = new Font("Segoe UI", 8.25F);
            txtCaminhoPlanilha.Location = new Point(20, 50);
            txtCaminhoPlanilha.Name = "txtCaminhoPlanilha";
            txtCaminhoPlanilha.ReadOnly = true;
            txtCaminhoPlanilha.Size = new Size(180, 22);
            txtCaminhoPlanilha.TabIndex = 3;
            // 
            // txtLog
            // 
            txtLog.BackColor = Color.White;
            txtLog.BorderStyle = BorderStyle.None;
            txtLog.Dock = DockStyle.Fill;
            txtLog.Font = new Font("Consolas", 9F);
            txtLog.Location = new Point(10, 10);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(460, 330);
            txtLog.TabIndex = 4;
            txtLog.Text = "";
            // 
            // lblTotalContatos
            // 
            lblTotalContatos.AutoSize = true;
            lblTotalContatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalContatos.ForeColor = Color.FromArgb(82, 112, 79);
            lblTotalContatos.Location = new Point(20, 235);
            lblTotalContatos.Name = "lblTotalContatos";
            lblTotalContatos.Size = new Size(98, 15);
            lblTotalContatos.TabIndex = 10;
            lblTotalContatos.Text = "Total: 0 contatos";
            // 
            // lblEnviados
            // 
            lblEnviados.AutoSize = true;
            lblEnviados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEnviados.ForeColor = Color.FromArgb(82, 112, 79);
            lblEnviados.Location = new Point(20, 250);
            lblEnviados.Name = "lblEnviados";
            lblEnviados.Size = new Size(108, 15);
            lblEnviados.TabIndex = 11;
            lblEnviados.Text = "Enviados: 0/0 (0%)";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(82, 112, 79);
            lblStatus.Location = new Point(20, 270);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(87, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status: Inativo";
            // 
            // btnPularAutenticacao
            // 
            btnPularAutenticacao.BackColor = Color.FromArgb(82, 112, 79);
            btnPularAutenticacao.FlatAppearance.BorderSize = 0;
            btnPularAutenticacao.FlatStyle = FlatStyle.Flat;
            btnPularAutenticacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPularAutenticacao.ForeColor = Color.White;
            btnPularAutenticacao.Location = new Point(20, 120);
            btnPularAutenticacao.Name = "btnPularAutenticacao";
            btnPularAutenticacao.Size = new Size(180, 35);
            btnPularAutenticacao.TabIndex = 14;
            btnPularAutenticacao.Text = "CONFIRMAR";
            btnPularAutenticacao.UseVisualStyleBackColor = false;
            btnPularAutenticacao.Click += btnPularAutenticacao_Click;
            // 
            // panelControles
            // 
            panelControles.BackColor = Color.White;
            panelControles.Controls.Add(button1);
            panelControles.Controls.Add(progressBar);
            panelControles.Controls.Add(btnPlanilha);
            panelControles.Controls.Add(btnConfig);
            panelControles.Controls.Add(btnMidia);
            panelControles.Controls.Add(txtCaminhoPlanilha);
            panelControles.Controls.Add(btnSelecionarPlanilha);
            panelControles.Controls.Add(btnIniciar);
            panelControles.Controls.Add(btnPularAutenticacao);
            panelControles.Controls.Add(btnParar);
            panelControles.Controls.Add(lblTotalContatos);
            panelControles.Controls.Add(lblStatus);
            panelControles.Controls.Add(lblEnviados);
            panelControles.Location = new Point(20, 70);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(220, 518);
            panelControles.TabIndex = 15;
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.FromArgb(82, 112, 79);
            progressBar.Location = new Point(20, 300);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(180, 10);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 18;
            // 
            // btnPlanilha
            // 
            btnPlanilha.BackColor = Color.FromArgb(82, 112, 79);
            btnPlanilha.FlatAppearance.BorderSize = 0;
            btnPlanilha.FlatStyle = FlatStyle.Flat;
            btnPlanilha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPlanilha.ForeColor = Color.White;
            btnPlanilha.Location = new Point(20, 432);
            btnPlanilha.Name = "btnPlanilha";
            btnPlanilha.Size = new Size(180, 35);
            btnPlanilha.TabIndex = 17;
            btnPlanilha.Text = "PLANILHA";
            btnPlanilha.UseVisualStyleBackColor = false;
            btnPlanilha.Click += btnPlanilha_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(82, 112, 79);
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfig.ForeColor = Color.White;
            btnConfig.Location = new Point(20, 391);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(180, 35);
            btnConfig.TabIndex = 16;
            btnConfig.Text = "CONFIGURAÇÕES";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnMidia
            // 
            btnMidia.BackColor = Color.FromArgb(82, 112, 79);
            btnMidia.FlatAppearance.BorderSize = 0;
            btnMidia.FlatStyle = FlatStyle.Flat;
            btnMidia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMidia.ForeColor = Color.White;
            btnMidia.Location = new Point(20, 350);
            btnMidia.Name = "btnMidia";
            btnMidia.Size = new Size(180, 35);
            btnMidia.TabIndex = 15;
            btnMidia.Text = "MÍDIA";
            btnMidia.UseVisualStyleBackColor = false;
            btnMidia.Click += btnMidia_Click;
            // 
            // checkBoxEnviarVideo
            // 
            checkBoxEnviarVideo.AutoSize = true;
            checkBoxEnviarVideo.Font = new Font("Segoe UI", 9F);
            checkBoxEnviarVideo.ForeColor = Color.FromArgb(64, 64, 64);
            checkBoxEnviarVideo.Location = new Point(175, 32);
            checkBoxEnviarVideo.Name = "checkBoxEnviarVideo";
            checkBoxEnviarVideo.Size = new Size(96, 19);
            checkBoxEnviarVideo.TabIndex = 16;
            checkBoxEnviarVideo.Text = "Enviar Vídeo?";
            checkBoxEnviarVideo.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnviarImagem
            // 
            checkBoxEnviarImagem.AutoSize = true;
            checkBoxEnviarImagem.Font = new Font("Segoe UI", 9F);
            checkBoxEnviarImagem.ForeColor = Color.FromArgb(64, 64, 64);
            checkBoxEnviarImagem.Location = new Point(277, 32);
            checkBoxEnviarImagem.Name = "checkBoxEnviarImagem";
            checkBoxEnviarImagem.Size = new Size(110, 19);
            checkBoxEnviarImagem.TabIndex = 15;
            checkBoxEnviarImagem.Text = "Enviar Imagem?";
            checkBoxEnviarImagem.UseVisualStyleBackColor = true;
            // 
            // panelLog
            // 
            panelLog.BackColor = Color.White;
            panelLog.Controls.Add(txtLog);
            panelLog.Location = new Point(260, 70);
            panelLog.Name = "panelLog";
            panelLog.Padding = new Padding(10);
            panelLog.Size = new Size(480, 350);
            panelLog.TabIndex = 16;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(296, 32);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Frizon WhatsApp Sender";
            // 
            // panelMensagens
            // 
            panelMensagens.BackColor = Color.White;
            panelMensagens.Controls.Add(groupBoxMensagens);
            panelMensagens.Location = new Point(260, 426);
            panelMensagens.Name = "panelMensagens";
            panelMensagens.Size = new Size(480, 162);
            panelMensagens.TabIndex = 18;
            // 
            // groupBoxMensagens
            // 
            groupBoxMensagens.BackColor = Color.Transparent;
            groupBoxMensagens.Controls.Add(lblMediaOptions);
            groupBoxMensagens.Controls.Add(checkBoxEnviarImagem);
            groupBoxMensagens.Controls.Add(checkBoxEnviarVideo);
            groupBoxMensagens.Controls.Add(buttonHelpMensagens);
            groupBoxMensagens.Controls.Add(txtMensagemPersonalizada);
            groupBoxMensagens.Controls.Add(chkUsarMensagemPersonalizada);
            groupBoxMensagens.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxMensagens.ForeColor = Color.FromArgb(82, 112, 79);
            groupBoxMensagens.Location = new Point(10, 3);
            groupBoxMensagens.Name = "groupBoxMensagens";
            groupBoxMensagens.Size = new Size(460, 145);
            groupBoxMensagens.TabIndex = 0;
            groupBoxMensagens.TabStop = false;
            groupBoxMensagens.Text = "Configuração de Mensagens";
            // 
            // lblMediaOptions
            // 
            lblMediaOptions.AutoSize = true;
            lblMediaOptions.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMediaOptions.ForeColor = Color.FromArgb(82, 112, 79);
            lblMediaOptions.Location = new Point(10, 17);
            lblMediaOptions.Name = "lblMediaOptions";
            lblMediaOptions.Size = new Size(97, 13);
            lblMediaOptions.TabIndex = 17;
            lblMediaOptions.Text = "Opções de Mídia:";
            // 
            // buttonHelpMensagens
            // 
            buttonHelpMensagens.BackColor = Color.FromArgb(82, 112, 79);
            buttonHelpMensagens.FlatAppearance.BorderSize = 0;
            buttonHelpMensagens.FlatStyle = FlatStyle.Flat;
            buttonHelpMensagens.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHelpMensagens.ForeColor = Color.White;
            buttonHelpMensagens.Location = new Point(423, 14);
            buttonHelpMensagens.Name = "buttonHelpMensagens";
            buttonHelpMensagens.Size = new Size(27, 23);
            buttonHelpMensagens.TabIndex = 2;
            buttonHelpMensagens.Text = "?";
            buttonHelpMensagens.UseVisualStyleBackColor = false;
            buttonHelpMensagens.Click += buttonHelpMensagens_Click;
            // 
            // txtMensagemPersonalizada
            // 
            txtMensagemPersonalizada.BackColor = Color.WhiteSmoke;
            txtMensagemPersonalizada.BorderStyle = BorderStyle.FixedSingle;
            txtMensagemPersonalizada.Font = new Font("Segoe UI", 9F);
            txtMensagemPersonalizada.Location = new Point(10, 51);
            txtMensagemPersonalizada.Multiline = true;
            txtMensagemPersonalizada.Name = "txtMensagemPersonalizada";
            txtMensagemPersonalizada.ScrollBars = ScrollBars.Vertical;
            txtMensagemPersonalizada.Size = new Size(440, 85);
            txtMensagemPersonalizada.TabIndex = 1;
            // 
            // chkUsarMensagemPersonalizada
            // 
            chkUsarMensagemPersonalizada.AutoSize = true;
            chkUsarMensagemPersonalizada.Font = new Font("Segoe UI", 9F);
            chkUsarMensagemPersonalizada.ForeColor = Color.FromArgb(64, 64, 64);
            chkUsarMensagemPersonalizada.Location = new Point(13, 32);
            chkUsarMensagemPersonalizada.Name = "chkUsarMensagemPersonalizada";
            chkUsarMensagemPersonalizada.Size = new Size(156, 19);
            chkUsarMensagemPersonalizada.TabIndex = 0;
            chkUsarMensagemPersonalizada.Text = "Usar mensagem padrão?";
            chkUsarMensagemPersonalizada.UseVisualStyleBackColor = true;
            chkUsarMensagemPersonalizada.CheckedChanged += chkUsarMensagemPersonalizada_CheckedChanged;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.FromArgb(82, 112, 79);
            panelStatus.Controls.Add(lblTitulo);
            panelStatus.Dock = DockStyle.Top;
            panelStatus.Location = new Point(0, 0);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(760, 60);
            panelStatus.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(82, 112, 79);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 473);
            button1.Name = "button1";
            button1.Size = new Size(180, 35);
            button1.TabIndex = 19;
            button1.Text = "SALVAR LOG";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrizonMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(760, 600);
            Controls.Add(panelMensagens);
            Controls.Add(panelLog);
            Controls.Add(panelControles);
            Controls.Add(panelStatus);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(776, 639);
            Name = "FrizonMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frizon WhatsApp Sender";
            panelControles.ResumeLayout(false);
            panelControles.PerformLayout();
            panelLog.ResumeLayout(false);
            panelMensagens.ResumeLayout(false);
            groupBoxMensagens.ResumeLayout(false);
            groupBoxMensagens.PerformLayout();
            panelStatus.ResumeLayout(false);
            panelStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelecionarPlanilha;
        private Button btnIniciar;
        private Button btnParar;
        private TextBox txtCaminhoPlanilha;
        private RichTextBox txtLog;
        private Label lblTotalContatos;
        private Label lblEnviados;
        private Label lblStatus;
        private Button btnPularAutenticacao;
        private Panel panelControles;
        private CheckBox checkBoxEnviarVideo;
        private CheckBox checkBoxEnviarImagem;
        private Panel panelLog;
        private Label lblTitulo;
        private Panel panelMensagens;
        private GroupBox groupBoxMensagens;
        private Button buttonHelpMensagens;
        private TextBox txtMensagemPersonalizada;
        private CheckBox chkUsarMensagemPersonalizada;
        private Button btnMidia;
        private Button btnConfig;
        private Button btnPlanilha;
        private Panel panelStatus;
        private Label lblMediaOptions;
        private ProgressBar progressBar;
        private Button button1;
    }
}