namespace FrizonWhatsappSender
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuPrincipal = new MenuStrip();
            homeMenuItem = new ToolStripMenuItem();
            senderMenuItem = new ToolStripMenuItem();
            emailSenderMenuItem = new ToolStripMenuItem();
            sobreMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            cardClientes = new Panel();
            label1 = new Label();
            lblClientes = new Label();
            iconClientes = new PictureBox();
            cardVendas = new Panel();
            lblVendas = new Label();
            iconVendas = new PictureBox();
            cardConfig = new Panel();
            lblConfig = new Label();
            iconConfig = new PictureBox();
            panelConteudo = new Panel();
            footerPanel = new Panel();
            lblFooterText = new Label();
            logoPictureBox = new PictureBox();
            panelHeader = new Panel();
            lblTitulo = new Label();
            menuPrincipal.SuspendLayout();
            cardClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconClientes).BeginInit();
            cardVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconVendas).BeginInit();
            cardConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconConfig).BeginInit();
            footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.BackColor = Color.White;
            menuPrincipal.Font = new Font("Segoe UI", 10F);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { homeMenuItem, senderMenuItem, emailSenderMenuItem, sobreMenuItem, exitMenuItem });
            menuPrincipal.Location = new Point(0, 60);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(900, 25);
            menuPrincipal.TabIndex = 1;
            menuPrincipal.Text = "menuStrip1";
            // 
            // homeMenuItem
            // 
            homeMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            homeMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            homeMenuItem.Name = "homeMenuItem";
            homeMenuItem.Padding = new Padding(10, 0, 10, 0);
            homeMenuItem.Size = new Size(69, 21);
            homeMenuItem.Text = "Home";
            // 
            // senderMenuItem
            // 
            senderMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            senderMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            senderMenuItem.Name = "senderMenuItem";
            senderMenuItem.Padding = new Padding(10, 0, 10, 0);
            senderMenuItem.Size = new Size(142, 21);
            senderMenuItem.Text = "WhatsApp Sender";
            senderMenuItem.Click += senderMenuItem_Click;
            // 
            // emailSenderMenuItem
            // 
            emailSenderMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            emailSenderMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            emailSenderMenuItem.Name = "emailSenderMenuItem";
            emailSenderMenuItem.Padding = new Padding(10, 0, 10, 0);
            emailSenderMenuItem.Size = new Size(115, 21);
            emailSenderMenuItem.Text = "E-mail Sender";
            // 
            // sobreMenuItem
            // 
            sobreMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            sobreMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            sobreMenuItem.Name = "sobreMenuItem";
            sobreMenuItem.Padding = new Padding(10, 0, 10, 0);
            sobreMenuItem.Size = new Size(67, 21);
            sobreMenuItem.Text = "Sobre";
            sobreMenuItem.Click += sobreMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            exitMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Padding = new Padding(10, 0, 10, 0);
            exitMenuItem.Size = new Size(54, 21);
            exitMenuItem.Text = "Sair";
            // 
            // cardClientes
            // 
            cardClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardClientes.BackColor = Color.White;
            cardClientes.BorderStyle = BorderStyle.FixedSingle;
            cardClientes.Controls.Add(label1);
            cardClientes.Controls.Add(lblClientes);
            cardClientes.Controls.Add(iconClientes);
            cardClientes.Cursor = Cursors.Hand;
            cardClientes.Location = new Point(30, 120);
            cardClientes.Name = "cardClientes";
            cardClientes.Size = new Size(269, 80);
            cardClientes.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(60, 45);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 2;
            label1.Text = "Email Sender";
            label1.Click += label1_Click;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblClientes.ForeColor = Color.FromArgb(64, 64, 64);
            lblClientes.Location = new Point(60, 20);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(121, 19);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "WhatsApp Sender";
            lblClientes.Click += lblClientes_Click;
            // 
            // iconClientes
            // 
            iconClientes.Image = (Image)resources.GetObject("iconClientes.Image");
            iconClientes.Location = new Point(15, 20);
            iconClientes.Name = "iconClientes";
            iconClientes.Size = new Size(40, 40);
            iconClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            iconClientes.TabIndex = 0;
            iconClientes.TabStop = false;
            iconClientes.Click += iconClientes_Click;
            // 
            // cardVendas
            // 
            cardVendas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardVendas.BackColor = Color.White;
            cardVendas.BorderStyle = BorderStyle.FixedSingle;
            cardVendas.Controls.Add(lblVendas);
            cardVendas.Controls.Add(iconVendas);
            cardVendas.Cursor = Cursors.Hand;
            cardVendas.Location = new Point(314, 120);
            cardVendas.Name = "cardVendas";
            cardVendas.Size = new Size(269, 80);
            cardVendas.TabIndex = 3;
            // 
            // lblVendas
            // 
            lblVendas.AutoSize = true;
            lblVendas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblVendas.ForeColor = Color.FromArgb(64, 64, 64);
            lblVendas.Location = new Point(60, 30);
            lblVendas.Name = "lblVendas";
            lblVendas.Size = new Size(109, 19);
            lblVendas.TabIndex = 1;
            lblVendas.Text = "Materiais/Mídia";
            lblVendas.Click += lblVendas_Click;
            // 
            // iconVendas
            // 
            iconVendas.Image = (Image)resources.GetObject("iconVendas.Image");
            iconVendas.Location = new Point(15, 20);
            iconVendas.Name = "iconVendas";
            iconVendas.Size = new Size(40, 40);
            iconVendas.SizeMode = PictureBoxSizeMode.Zoom;
            iconVendas.TabIndex = 0;
            iconVendas.TabStop = false;
            // 
            // cardConfig
            // 
            cardConfig.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cardConfig.BackColor = Color.White;
            cardConfig.BorderStyle = BorderStyle.FixedSingle;
            cardConfig.Controls.Add(lblConfig);
            cardConfig.Controls.Add(iconConfig);
            cardConfig.Cursor = Cursors.Hand;
            cardConfig.Location = new Point(597, 120);
            cardConfig.Name = "cardConfig";
            cardConfig.Size = new Size(269, 80);
            cardConfig.TabIndex = 4;
            // 
            // lblConfig
            // 
            lblConfig.AutoSize = true;
            lblConfig.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblConfig.ForeColor = Color.FromArgb(64, 64, 64);
            lblConfig.Location = new Point(60, 30);
            lblConfig.Name = "lblConfig";
            lblConfig.Size = new Size(99, 19);
            lblConfig.TabIndex = 1;
            lblConfig.Text = "Configurações";
            lblConfig.Click += lblConfig_Click;
            // 
            // iconConfig
            // 
            iconConfig.Image = (Image)resources.GetObject("iconConfig.Image");
            iconConfig.Location = new Point(15, 20);
            iconConfig.Name = "iconConfig";
            iconConfig.Size = new Size(40, 40);
            iconConfig.SizeMode = PictureBoxSizeMode.Zoom;
            iconConfig.TabIndex = 0;
            iconConfig.TabStop = false;
            // 
            // panelConteudo
            // 
            panelConteudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelConteudo.BackColor = Color.White;
            panelConteudo.BorderStyle = BorderStyle.FixedSingle;
            panelConteudo.Location = new Point(30, 220);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(836, 300);
            panelConteudo.TabIndex = 5;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(0, 120, 74);
            footerPanel.Controls.Add(lblFooterText);
            footerPanel.Controls.Add(logoPictureBox);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 540);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(900, 60);
            footerPanel.TabIndex = 6;
            // 
            // lblFooterText
            // 
            lblFooterText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFooterText.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooterText.ForeColor = Color.White;
            lblFooterText.Location = new Point(500, 20);
            lblFooterText.Name = "lblFooterText";
            lblFooterText.Size = new Size(380, 30);
            lblFooterText.TabIndex = 1;
            lblFooterText.Text = "© 2025 Frizon Construtora - Todos os direitos reservados";
            lblFooterText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(30, 10);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(150, 40);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 120, 74);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 60);
            panelHeader.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(306, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Frizon Construtora - Comunicação";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(900, 600);
            Controls.Add(panelConteudo);
            Controls.Add(cardConfig);
            Controls.Add(cardVendas);
            Controls.Add(cardClientes);
            Controls.Add(menuPrincipal);
            Controls.Add(panelHeader);
            Controls.Add(footerPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuPrincipal;
            MinimumSize = new Size(916, 639);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frizon Construtora - Sistema de Comunicação";
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            cardClientes.ResumeLayout(false);
            cardClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconClientes).EndInit();
            cardVendas.ResumeLayout(false);
            cardVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconVendas).EndInit();
            cardConfig.ResumeLayout(false);
            cardConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconConfig).EndInit();
            footerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuPrincipal;
        private ToolStripMenuItem homeMenuItem;
        private ToolStripMenuItem senderMenuItem;
        private ToolStripMenuItem emailSenderMenuItem;
        private ToolStripMenuItem sobreMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private Panel cardClientes;
        private Label lblClientes;
        private PictureBox iconClientes;
        private Panel cardVendas;
        private Label lblVendas;
        private PictureBox iconVendas;
        private Panel cardConfig;
        private Label lblConfig;
        private PictureBox iconConfig;
        private Panel panelConteudo;
        private Panel footerPanel;
        private PictureBox logoPictureBox;
        private Label label1;
        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblFooterText;
    }
}