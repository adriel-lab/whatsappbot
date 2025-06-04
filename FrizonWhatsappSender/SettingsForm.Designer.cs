namespace FrizonWhatsappSender
{
    partial class SettingsForm
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
            panelHeader = new Panel();
            lblTitle = new Label();
            panelMain = new Panel();
            panelMediaSettings = new Panel();
            groupBox1 = new GroupBox();
            lblDelayFoto = new Label();
            numDelayFoto = new NumericUpDown();
            numDelayVideo = new NumericUpDown();
            lblDelayVideo = new Label();
            panelTimingSettings = new Panel();
            groupBox2 = new GroupBox();
            lblMinDelayBetweenContacts = new Label();
            numMinDelayBetweenContacts = new NumericUpDown();
            lblMaxSendDelay = new Label();
            numMaxDelayBetweenContacts = new NumericUpDown();
            lblMinSendDelay = new Label();
            numMaxSendDelay = new NumericUpDown();
            numDelayAfterSend = new NumericUpDown();
            numMinSendDelay = new NumericUpDown();
            lblMaxDelayBetweenContacts = new Label();
            lblDelayAfterSend = new Label();
            panelRetrySettings = new Panel();
            groupBox4 = new GroupBox();
            lblErrorDelay = new Label();
            lblInitialLoadDelay = new Label();
            numMaxRetryAttempts = new NumericUpDown();
            numInitialLoadDelay = new NumericUpDown();
            lblMaxRetryAttempts = new Label();
            numErrorDelay = new NumericUpDown();
            numRetryDelayMultiplier = new NumericUpDown();
            lblRetryDelayMultiplier = new Label();
            btnResetDefaults = new Button();
            btnSave = new Button();
            toolTip = new ToolTip(components);
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelMediaSettings.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDelayFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDelayVideo).BeginInit();
            panelTimingSettings.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinDelayBetweenContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxDelayBetweenContacts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxSendDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDelayAfterSend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinSendDelay).BeginInit();
            panelRetrySettings.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxRetryAttempts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInitialLoadDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numErrorDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRetryDelayMultiplier).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(82, 112, 79);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(607, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(243, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Configurações do Sistema";
            toolTip.SetToolTip(lblTitle, "Tela de configurações do sistema de envio de mensagens");
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.AutoScrollMinSize = new Size(0, 850);
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panelMediaSettings);
            panelMain.Controls.Add(panelTimingSettings);
            panelMain.Controls.Add(panelRetrySettings);
            panelMain.Controls.Add(btnResetDefaults);
            panelMain.Controls.Add(btnSave);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 60);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(607, 423);
            panelMain.TabIndex = 1;
            // 
            // panelMediaSettings
            // 
            panelMediaSettings.BackColor = Color.White;
            panelMediaSettings.Controls.Add(groupBox1);
            panelMediaSettings.Location = new Point(20, 20);
            panelMediaSettings.Name = "panelMediaSettings";
            panelMediaSettings.Size = new Size(560, 130);
            panelMediaSettings.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDelayFoto);
            groupBox1.Controls.Add(numDelayFoto);
            groupBox1.Controls.Add(numDelayVideo);
            groupBox1.Controls.Add(lblDelayVideo);
            groupBox1.ForeColor = Color.FromArgb(82, 112, 79);
            groupBox1.Location = new Point(10, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurações de Mídia";
            toolTip.SetToolTip(groupBox1, "Configurações relacionadas ao envio de mídias (fotos e vídeos)");
            // 
            // lblDelayFoto
            // 
            lblDelayFoto.AutoSize = true;
            lblDelayFoto.Location = new Point(32, 29);
            lblDelayFoto.Name = "lblDelayFoto";
            lblDelayFoto.Size = new Size(129, 15);
            lblDelayFoto.TabIndex = 3;
            lblDelayFoto.Text = "Atraso para fotos (seg):";
            toolTip.SetToolTip(lblDelayFoto, "Tempo de espera após selecionar uma foto antes de enviar");
            // 
            // numDelayFoto
            // 
            numDelayFoto.BackColor = Color.WhiteSmoke;
            numDelayFoto.BorderStyle = BorderStyle.FixedSingle;
            numDelayFoto.Font = new Font("Segoe UI", 9.75F);
            numDelayFoto.Location = new Point(270, 27);
            numDelayFoto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDelayFoto.Name = "numDelayFoto";
            numDelayFoto.Size = new Size(80, 25);
            numDelayFoto.TabIndex = 1;
            toolTip.SetToolTip(numDelayFoto, "Tempo de espera (em segundos) após selecionar uma foto antes de enviar");
            numDelayFoto.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numDelayVideo
            // 
            numDelayVideo.BackColor = Color.WhiteSmoke;
            numDelayVideo.BorderStyle = BorderStyle.FixedSingle;
            numDelayVideo.Font = new Font("Segoe UI", 9.75F);
            numDelayVideo.Location = new Point(270, 67);
            numDelayVideo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDelayVideo.Name = "numDelayVideo";
            numDelayVideo.Size = new Size(80, 25);
            numDelayVideo.TabIndex = 2;
            toolTip.SetToolTip(numDelayVideo, "Tempo de espera (em segundos) após selecionar um vídeo antes de enviar");
            numDelayVideo.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // lblDelayVideo
            // 
            lblDelayVideo.AutoSize = true;
            lblDelayVideo.Location = new Point(32, 69);
            lblDelayVideo.Name = "lblDelayVideo";
            lblDelayVideo.Size = new Size(136, 15);
            lblDelayVideo.TabIndex = 2;
            lblDelayVideo.Text = "Atraso para vídeos (seg):";
            toolTip.SetToolTip(lblDelayVideo, "Tempo de espera após selecionar um vídeo antes de enviar");
            // 
            // panelTimingSettings
            // 
            panelTimingSettings.BackColor = Color.White;
            panelTimingSettings.Controls.Add(groupBox2);
            panelTimingSettings.Location = new Point(20, 160);
            panelTimingSettings.Name = "panelTimingSettings";
            panelTimingSettings.Size = new Size(560, 243);
            panelTimingSettings.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMinDelayBetweenContacts);
            groupBox2.Controls.Add(numMinDelayBetweenContacts);
            groupBox2.Controls.Add(lblMaxSendDelay);
            groupBox2.Controls.Add(numMaxDelayBetweenContacts);
            groupBox2.Controls.Add(lblMinSendDelay);
            groupBox2.Controls.Add(numMaxSendDelay);
            groupBox2.Controls.Add(numDelayAfterSend);
            groupBox2.Controls.Add(numMinSendDelay);
            groupBox2.Controls.Add(lblMaxDelayBetweenContacts);
            groupBox2.Controls.Add(lblDelayAfterSend);
            groupBox2.ForeColor = Color.FromArgb(82, 112, 79);
            groupBox2.Location = new Point(10, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 225);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Configurações de Tempo";
            toolTip.SetToolTip(groupBox2, "Configurações de temporização para envio de mensagens");
            // 
            // lblMinDelayBetweenContacts
            // 
            lblMinDelayBetweenContacts.AutoSize = true;
            lblMinDelayBetweenContacts.Location = new Point(32, 37);
            lblMinDelayBetweenContacts.Name = "lblMinDelayBetweenContacts";
            lblMinDelayBetweenContacts.Size = new Size(151, 15);
            lblMinDelayBetweenContacts.TabIndex = 3;
            lblMinDelayBetweenContacts.Text = "Atraso mínimo (segundos):";
            toolTip.SetToolTip(lblMinDelayBetweenContacts, "Tempo mínimo de espera entre o envio para diferentes contatos");
            // 
            // numMinDelayBetweenContacts
            // 
            numMinDelayBetweenContacts.BackColor = Color.WhiteSmoke;
            numMinDelayBetweenContacts.BorderStyle = BorderStyle.FixedSingle;
            numMinDelayBetweenContacts.Font = new Font("Segoe UI", 9.75F);
            numMinDelayBetweenContacts.Location = new Point(270, 33);
            numMinDelayBetweenContacts.Minimum = new decimal(new int[] { 60, 0, 0, 0 });
            numMinDelayBetweenContacts.Name = "numMinDelayBetweenContacts";
            numMinDelayBetweenContacts.Size = new Size(80, 25);
            numMinDelayBetweenContacts.TabIndex = 1;
            toolTip.SetToolTip(numMinDelayBetweenContacts, "Tempo mínimo (em segundos) entre envios para diferentes contatos");
            numMinDelayBetweenContacts.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // lblMaxSendDelay
            // 
            lblMaxSendDelay.AutoSize = true;
            lblMaxSendDelay.Location = new Point(32, 195);
            lblMaxSendDelay.Name = "lblMaxSendDelay";
            lblMaxSendDelay.Size = new Size(153, 15);
            lblMaxSendDelay.TabIndex = 8;
            lblMaxSendDelay.Text = "Atraso máximo (segundos):";
            toolTip.SetToolTip(lblMaxSendDelay, "Tempo máximo de espera entre o envio de mensagens para o mesmo contato");
            // 
            // numMaxDelayBetweenContacts
            // 
            numMaxDelayBetweenContacts.BackColor = Color.WhiteSmoke;
            numMaxDelayBetweenContacts.BorderStyle = BorderStyle.FixedSingle;
            numMaxDelayBetweenContacts.Font = new Font("Segoe UI", 9.75F);
            numMaxDelayBetweenContacts.Location = new Point(270, 73);
            numMaxDelayBetweenContacts.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numMaxDelayBetweenContacts.Minimum = new decimal(new int[] { 120, 0, 0, 0 });
            numMaxDelayBetweenContacts.Name = "numMaxDelayBetweenContacts";
            numMaxDelayBetweenContacts.Size = new Size(80, 25);
            numMaxDelayBetweenContacts.TabIndex = 2;
            toolTip.SetToolTip(numMaxDelayBetweenContacts, "Tempo máximo (em segundos) entre envios para diferentes contatos");
            numMaxDelayBetweenContacts.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // lblMinSendDelay
            // 
            lblMinSendDelay.AutoSize = true;
            lblMinSendDelay.Location = new Point(32, 155);
            lblMinSendDelay.Name = "lblMinSendDelay";
            lblMinSendDelay.Size = new Size(151, 15);
            lblMinSendDelay.TabIndex = 7;
            lblMinSendDelay.Text = "Atraso mínimo (segundos):";
            toolTip.SetToolTip(lblMinSendDelay, "Tempo mínimo de espera entre o envio de mensagens para o mesmo contato");
            // 
            // numMaxSendDelay
            // 
            numMaxSendDelay.BackColor = Color.WhiteSmoke;
            numMaxSendDelay.BorderStyle = BorderStyle.FixedSingle;
            numMaxSendDelay.Font = new Font("Segoe UI", 9.75F);
            numMaxSendDelay.Location = new Point(270, 191);
            numMaxSendDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMaxSendDelay.Name = "numMaxSendDelay";
            numMaxSendDelay.Size = new Size(80, 25);
            numMaxSendDelay.TabIndex = 6;
            toolTip.SetToolTip(numMaxSendDelay, "Tempo máximo (em segundos) entre envios para o mesmo contato");
            numMaxSendDelay.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // numDelayAfterSend
            // 
            numDelayAfterSend.BackColor = Color.WhiteSmoke;
            numDelayAfterSend.BorderStyle = BorderStyle.FixedSingle;
            numDelayAfterSend.Font = new Font("Segoe UI", 9.75F);
            numDelayAfterSend.Location = new Point(270, 113);
            numDelayAfterSend.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numDelayAfterSend.Name = "numDelayAfterSend";
            numDelayAfterSend.Size = new Size(80, 25);
            numDelayAfterSend.TabIndex = 3;
            toolTip.SetToolTip(numDelayAfterSend, "Tempo de espera (em milissegundos) após o envio de uma mensagem");
            numDelayAfterSend.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numMinSendDelay
            // 
            numMinSendDelay.BackColor = Color.WhiteSmoke;
            numMinSendDelay.BorderStyle = BorderStyle.FixedSingle;
            numMinSendDelay.Font = new Font("Segoe UI", 9.75F);
            numMinSendDelay.Location = new Point(270, 151);
            numMinSendDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMinSendDelay.Name = "numMinSendDelay";
            numMinSendDelay.Size = new Size(80, 25);
            numMinSendDelay.TabIndex = 5;
            toolTip.SetToolTip(numMinSendDelay, "Tempo mínimo (em segundos) entre envios para o mesmo contato");
            numMinSendDelay.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblMaxDelayBetweenContacts
            // 
            lblMaxDelayBetweenContacts.AutoSize = true;
            lblMaxDelayBetweenContacts.Location = new Point(32, 77);
            lblMaxDelayBetweenContacts.Name = "lblMaxDelayBetweenContacts";
            lblMaxDelayBetweenContacts.Size = new Size(153, 15);
            lblMaxDelayBetweenContacts.TabIndex = 4;
            lblMaxDelayBetweenContacts.Text = "Atraso máximo (segundos):";
            toolTip.SetToolTip(lblMaxDelayBetweenContacts, "Tempo máximo de espera entre o envio para diferentes contatos");
            // 
            // lblDelayAfterSend
            // 
            lblDelayAfterSend.AutoSize = true;
            lblDelayAfterSend.Location = new Point(32, 117);
            lblDelayAfterSend.Name = "lblDelayAfterSend";
            lblDelayAfterSend.Size = new Size(153, 15);
            lblDelayAfterSend.TabIndex = 5;
            lblDelayAfterSend.Text = "Atraso após envio (miliseg):";
            toolTip.SetToolTip(lblDelayAfterSend, "Tempo de espera após o envio de uma mensagem");
            // 
            // panelRetrySettings
            // 
            panelRetrySettings.BackColor = Color.White;
            panelRetrySettings.Controls.Add(groupBox4);
            panelRetrySettings.Location = new Point(20, 417);
            panelRetrySettings.Name = "panelRetrySettings";
            panelRetrySettings.Size = new Size(560, 210);
            panelRetrySettings.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblErrorDelay);
            groupBox4.Controls.Add(lblInitialLoadDelay);
            groupBox4.Controls.Add(numMaxRetryAttempts);
            groupBox4.Controls.Add(numInitialLoadDelay);
            groupBox4.Controls.Add(lblMaxRetryAttempts);
            groupBox4.Controls.Add(numErrorDelay);
            groupBox4.Controls.Add(numRetryDelayMultiplier);
            groupBox4.Controls.Add(lblRetryDelayMultiplier);
            groupBox4.ForeColor = Color.FromArgb(82, 112, 79);
            groupBox4.Location = new Point(10, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(540, 197);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Configurações de Retentativa";
            toolTip.SetToolTip(groupBox4, "Configurações para tratamento de erros e tentativas de reenvio");
            // 
            // lblErrorDelay
            // 
            lblErrorDelay.AutoSize = true;
            lblErrorDelay.Location = new Point(13, 115);
            lblErrorDelay.Name = "lblErrorDelay";
            lblErrorDelay.Size = new Size(125, 15);
            lblErrorDelay.TabIndex = 4;
            lblErrorDelay.Text = "Atraso após erro (seg):";
            toolTip.SetToolTip(lblErrorDelay, "Tempo de espera após ocorrer um erro no envio");
            // 
            // lblInitialLoadDelay
            // 
            lblInitialLoadDelay.AutoSize = true;
            lblInitialLoadDelay.Location = new Point(13, 155);
            lblInitialLoadDelay.Name = "lblInitialLoadDelay";
            lblInitialLoadDelay.Size = new Size(155, 15);
            lblInitialLoadDelay.TabIndex = 5;
            lblInitialLoadDelay.Text = "Atraso inicial de carga (seg):";
            toolTip.SetToolTip(lblInitialLoadDelay, "Tempo de espera inicial para carregar a página do WhatsApp");
            // 
            // numMaxRetryAttempts
            // 
            numMaxRetryAttempts.BackColor = Color.WhiteSmoke;
            numMaxRetryAttempts.BorderStyle = BorderStyle.FixedSingle;
            numMaxRetryAttempts.Font = new Font("Segoe UI", 9.75F);
            numMaxRetryAttempts.Location = new Point(255, 22);
            numMaxRetryAttempts.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMaxRetryAttempts.Name = "numMaxRetryAttempts";
            numMaxRetryAttempts.Size = new Size(80, 25);
            numMaxRetryAttempts.TabIndex = 1;
            toolTip.SetToolTip(numMaxRetryAttempts, "Número máximo de tentativas de reenvio em caso de falha");
            numMaxRetryAttempts.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numInitialLoadDelay
            // 
            numInitialLoadDelay.BackColor = Color.WhiteSmoke;
            numInitialLoadDelay.BorderStyle = BorderStyle.FixedSingle;
            numInitialLoadDelay.Font = new Font("Segoe UI", 9.75F);
            numInitialLoadDelay.Location = new Point(255, 142);
            numInitialLoadDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numInitialLoadDelay.Name = "numInitialLoadDelay";
            numInitialLoadDelay.Size = new Size(80, 25);
            numInitialLoadDelay.TabIndex = 4;
            toolTip.SetToolTip(numInitialLoadDelay, "Tempo de espera (em segundos) para carregar a página do WhatsApp");
            numInitialLoadDelay.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblMaxRetryAttempts
            // 
            lblMaxRetryAttempts.AutoSize = true;
            lblMaxRetryAttempts.Location = new Point(13, 35);
            lblMaxRetryAttempts.Name = "lblMaxRetryAttempts";
            lblMaxRetryAttempts.Size = new Size(143, 15);
            lblMaxRetryAttempts.TabIndex = 2;
            lblMaxRetryAttempts.Text = "Tentativas de reenvio (nº):";
            toolTip.SetToolTip(lblMaxRetryAttempts, "Número máximo de tentativas em caso de falha no envio");
            // 
            // numErrorDelay
            // 
            numErrorDelay.BackColor = Color.WhiteSmoke;
            numErrorDelay.BorderStyle = BorderStyle.FixedSingle;
            numErrorDelay.Font = new Font("Segoe UI", 9.75F);
            numErrorDelay.Location = new Point(255, 102);
            numErrorDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numErrorDelay.Name = "numErrorDelay";
            numErrorDelay.Size = new Size(80, 25);
            numErrorDelay.TabIndex = 3;
            toolTip.SetToolTip(numErrorDelay, "Tempo de espera (em segundos) após ocorrer um erro no envio");
            numErrorDelay.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // numRetryDelayMultiplier
            // 
            numRetryDelayMultiplier.BackColor = Color.WhiteSmoke;
            numRetryDelayMultiplier.BorderStyle = BorderStyle.FixedSingle;
            numRetryDelayMultiplier.Font = new Font("Segoe UI", 9.75F);
            numRetryDelayMultiplier.Location = new Point(255, 62);
            numRetryDelayMultiplier.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRetryDelayMultiplier.Name = "numRetryDelayMultiplier";
            numRetryDelayMultiplier.Size = new Size(80, 25);
            numRetryDelayMultiplier.TabIndex = 2;
            toolTip.SetToolTip(numRetryDelayMultiplier, "Multiplicador aplicado ao tempo de espera entre tentativas de reenvio");
            numRetryDelayMultiplier.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblRetryDelayMultiplier
            // 
            lblRetryDelayMultiplier.AutoSize = true;
            lblRetryDelayMultiplier.Location = new Point(13, 75);
            lblRetryDelayMultiplier.Name = "lblRetryDelayMultiplier";
            lblRetryDelayMultiplier.Size = new Size(132, 15);
            lblRetryDelayMultiplier.TabIndex = 3;
            lblRetryDelayMultiplier.Text = "Multiplicador de atraso:";
            toolTip.SetToolTip(lblRetryDelayMultiplier, "Fator que multiplica o tempo de espera a cada tentativa de reenvio");
            // 
            // btnResetDefaults
            // 
            btnResetDefaults.BackColor = Color.FromArgb(204, 85, 67);
            btnResetDefaults.FlatAppearance.BorderSize = 0;
            btnResetDefaults.FlatStyle = FlatStyle.Flat;
            btnResetDefaults.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnResetDefaults.ForeColor = Color.White;
            btnResetDefaults.Location = new Point(300, 639);
            btnResetDefaults.Name = "btnResetDefaults";
            btnResetDefaults.Size = new Size(147, 35);
            btnResetDefaults.TabIndex = 6;
            btnResetDefaults.Text = "VALORES PADRÕES";
            toolTip.SetToolTip(btnResetDefaults, "Cancelar alterações e fechar a janela");
            btnResetDefaults.UseVisualStyleBackColor = false;
            btnResetDefaults.Click += btnResetDefaults_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(82, 112, 79);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(457, 639);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 35);
            btnSave.TabIndex = 5;
            btnSave.Text = "SALVAR";
            toolTip.SetToolTip(btnSave, "Salvar todas as configurações alteradas");
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(607, 483);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações do Sistema";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMediaSettings.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDelayFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDelayVideo).EndInit();
            panelTimingSettings.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMinDelayBetweenContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxDelayBetweenContacts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxSendDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDelayAfterSend).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinSendDelay).EndInit();
            panelRetrySettings.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxRetryAttempts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInitialLoadDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numErrorDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRetryDelayMultiplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // TODOS OS 11 CAMPOS DECLARADOS
        private NumericUpDown numMinDelayBetweenContacts;
        private NumericUpDown numMaxDelayBetweenContacts;
        private NumericUpDown numDelayAfterSend;
        private NumericUpDown numMaxRetryAttempts;
        private NumericUpDown numRetryDelayMultiplier;
        private NumericUpDown numErrorDelay;
        private NumericUpDown numInitialLoadDelay;
        private NumericUpDown numMinSendDelay;
        private NumericUpDown numMaxSendDelay;
        private NumericUpDown numDelayFoto;
        private NumericUpDown numDelayVideo;

        private Button btnSave;
        private Button btnResetDefaults;

        private Label lblMinDelayBetweenContacts;
        private Label lblMaxDelayBetweenContacts;
        private Label lblDelayAfterSend;
        private Label lblMaxRetryAttempts;
        private Label lblRetryDelayMultiplier;
        private Label lblErrorDelay;
        private Label lblInitialLoadDelay;
        private Label lblMinSendDelay;
        private Label lblMaxSendDelay;
        private Label lblDelayFoto;
        private Label lblDelayVideo;

        private Panel panelHeader;
        private Label lblTitle;
        private ToolTip toolTip;
        private Panel panelMain;
        private Panel panelMediaSettings;
        private Panel panelTimingSettings;
        private Panel panelRetrySettings;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
    }
}