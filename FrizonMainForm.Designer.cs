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
            components = new System.ComponentModel.Container();
            btnSelecionarPlanilha = new Button();
            btnIniciar = new Button();
            btnParar = new Button();
            txtCaminhoPlanilha = new TextBox();
            txtLog = new RichTextBox();
            lblTotalContatos = new Label();
            lblEnviados = new Label();
            lblStatus = new Label();
            picQRCodeInfo = new PictureBox();
            btnPularAutenticacao = new Button();
            panelControles = new Panel();
            panelLog = new Panel();
            lblTitulo = new Label();
            panelMensagens = new Panel();
            groupBoxMensagens = new GroupBox();
            buttonHelpMensagens = new Button();
            txtMensagemPersonalizada = new TextBox();
            chkUsarMensagemPersonalizada = new CheckBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picQRCodeInfo).BeginInit();
            panelControles.SuspendLayout();
            panelLog.SuspendLayout();
            panelMensagens.SuspendLayout();
            groupBoxMensagens.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelecionarPlanilha
            // 
            btnSelecionarPlanilha.BackColor = Color.FromArgb(82, 112, 79);
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
            txtCaminhoPlanilha.BorderStyle = BorderStyle.FixedSingle;
            txtCaminhoPlanilha.Location = new Point(20, 50);
            txtCaminhoPlanilha.Name = "txtCaminhoPlanilha";
            txtCaminhoPlanilha.ReadOnly = true;
            txtCaminhoPlanilha.Size = new Size(180, 23);
            txtCaminhoPlanilha.TabIndex = 3;
            // 
            // txtLog
            // 
            txtLog.BackColor = Color.FromArgb(240, 240, 240);
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
            lblTotalContatos.Location = new Point(20, 230);
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
            // picQRCodeInfo
            // 
            picQRCodeInfo.BackColor = Color.White;
            picQRCodeInfo.BorderStyle = BorderStyle.FixedSingle;
            picQRCodeInfo.Location = new Point(20, 288);
            picQRCodeInfo.Name = "picQRCodeInfo";
            picQRCodeInfo.Size = new Size(180, 195);
            picQRCodeInfo.TabIndex = 13;
            picQRCodeInfo.TabStop = false;
            picQRCodeInfo.Visible = false;
            // 
            // btnPularAutenticacao
            // 
            btnPularAutenticacao.BackColor = Color.FromArgb(82, 112, 79);
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
            panelControles.Controls.Add(txtCaminhoPlanilha);
            panelControles.Controls.Add(btnSelecionarPlanilha);
            panelControles.Controls.Add(btnIniciar);
            panelControles.Controls.Add(btnPularAutenticacao);
            panelControles.Controls.Add(btnParar);
            panelControles.Controls.Add(lblTotalContatos);
            panelControles.Controls.Add(lblStatus);
            panelControles.Controls.Add(lblEnviados);
            panelControles.Controls.Add(picQRCodeInfo);
            panelControles.Location = new Point(20, 70);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(220, 500);
            panelControles.TabIndex = 15;
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
            lblTitulo.ForeColor = Color.FromArgb(82, 112, 79);
            lblTitulo.Location = new Point(20, 0);
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
            panelMensagens.Size = new Size(480, 144);
            panelMensagens.TabIndex = 18;
            // 
            // groupBoxMensagens
            // 
            groupBoxMensagens.BackColor = Color.WhiteSmoke;
            groupBoxMensagens.Controls.Add(buttonHelpMensagens);
            groupBoxMensagens.Controls.Add(txtMensagemPersonalizada);
            groupBoxMensagens.Controls.Add(chkUsarMensagemPersonalizada);
            groupBoxMensagens.Location = new Point(10, 3);
            groupBoxMensagens.Name = "groupBoxMensagens";
            groupBoxMensagens.Size = new Size(460, 124);
            groupBoxMensagens.TabIndex = 0;
            groupBoxMensagens.TabStop = false;
            groupBoxMensagens.Text = "Mensagens";
            // 
            // buttonHelpMensagens
            // 
            buttonHelpMensagens.Location = new Point(423, 14);
            buttonHelpMensagens.Name = "buttonHelpMensagens";
            buttonHelpMensagens.Size = new Size(27, 23);
            buttonHelpMensagens.TabIndex = 2;
            buttonHelpMensagens.Text = "?";
            buttonHelpMensagens.UseVisualStyleBackColor = true;
            buttonHelpMensagens.Click += buttonHelpMensagens_Click;
            // 
            // txtMensagemPersonalizada
            // 
            txtMensagemPersonalizada.Location = new Point(10, 43);
            txtMensagemPersonalizada.Multiline = true;
            txtMensagemPersonalizada.Name = "txtMensagemPersonalizada";
            txtMensagemPersonalizada.Size = new Size(440, 70);
            txtMensagemPersonalizada.TabIndex = 1;
            // 
            // chkUsarMensagemPersonalizada
            // 
            chkUsarMensagemPersonalizada.AutoSize = true;
            chkUsarMensagemPersonalizada.Location = new Point(13, 22);
            chkUsarMensagemPersonalizada.Name = "chkUsarMensagemPersonalizada";
            chkUsarMensagemPersonalizada.Size = new Size(156, 19);
            chkUsarMensagemPersonalizada.TabIndex = 0;
            chkUsarMensagemPersonalizada.Text = "Usar mensagem padrão?";
            chkUsarMensagemPersonalizada.UseVisualStyleBackColor = true;
            chkUsarMensagemPersonalizada.CheckedChanged += chkUsarMensagemPersonalizada_CheckedChanged;
            // 
            // FrizonMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(760, 600);
            Controls.Add(panelMensagens);
            Controls.Add(lblTitulo);
            Controls.Add(panelLog);
            Controls.Add(panelControles);
            MinimumSize = new Size(776, 639);
            Name = "FrizonMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frizon WhatsApp Sender";
            ((System.ComponentModel.ISupportInitialize)picQRCodeInfo).EndInit();
            panelControles.ResumeLayout(false);
            panelControles.PerformLayout();
            panelLog.ResumeLayout(false);
            panelMensagens.ResumeLayout(false);
            groupBoxMensagens.ResumeLayout(false);
            groupBoxMensagens.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox picQRCodeInfo;
        private Button btnPularAutenticacao;
        private Panel panelControles;
        private Panel panelLog;
        private Label lblTitulo;
        private Panel panelMensagens;
        private GroupBox groupBoxMensagens;
        private TextBox txtMensagemPersonalizada;
        private CheckBox chkUsarMensagemPersonalizada;
        private ToolTip toolTip1;
        private Button buttonHelpMensagens;
    }
}