namespace FrizonWhatsappSender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
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
            logoPictureBox = new PictureBox();
            menuPrincipal.SuspendLayout();
            cardClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconClientes).BeginInit();
            cardVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconVendas).BeginInit();
            cardConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconConfig).BeginInit();
            footerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 120, 74);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(30, 320);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(140, 45);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "   Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // menuPrincipal
            // 
            menuPrincipal.BackColor = Color.White;
            menuPrincipal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { homeMenuItem, senderMenuItem, emailSenderMenuItem, sobreMenuItem, exitMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(900, 25);
            menuPrincipal.TabIndex = 1;
            menuPrincipal.Text = "menuStrip1";
            // 
            // homeMenuItem
            // 
            homeMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            homeMenuItem.Name = "homeMenuItem";
            homeMenuItem.Size = new Size(55, 21);
            homeMenuItem.Text = "Home";
            // 
            // senderMenuItem
            // 
            senderMenuItem.Font = new Font("Segoe UI", 9.75F);
            senderMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            senderMenuItem.Name = "senderMenuItem";
            senderMenuItem.Size = new Size(125, 21);
            senderMenuItem.Text = "WhatsApp Sender";
            senderMenuItem.Click += senderMenuItem_Click;
            // 
            // emailSenderMenuItem
            // 
            emailSenderMenuItem.Font = new Font("Segoe UI", 9.75F);
            emailSenderMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            emailSenderMenuItem.Name = "emailSenderMenuItem";
            emailSenderMenuItem.Size = new Size(101, 21);
            emailSenderMenuItem.Text = "E-mail Sender";
            // 
            // sobreMenuItem
            // 
            sobreMenuItem.Font = new Font("Segoe UI", 9.75F);
            sobreMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            sobreMenuItem.Name = "sobreMenuItem";
            sobreMenuItem.Size = new Size(55, 21);
            sobreMenuItem.Text = "Sobre";
            sobreMenuItem.Click += sobreMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Font = new Font("Segoe UI", 9.75F);
            exitMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(42, 21);
            exitMenuItem.Text = "Sair";
            // 
            // cardClientes
            // 
            cardClientes.BackColor = Color.White;
            cardClientes.BorderStyle = BorderStyle.FixedSingle;
            cardClientes.Controls.Add(label1);
            cardClientes.Controls.Add(lblClientes);
            cardClientes.Controls.Add(iconClientes);
            cardClientes.Cursor = Cursors.Hand;
            cardClientes.Location = new Point(31, 67);
            cardClientes.Name = "cardClientes";
            cardClientes.Size = new Size(263, 64);
            cardClientes.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(63, 33);
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
            lblClientes.Location = new Point(63, 12);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(121, 19);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "WhatsApp Sender";
            lblClientes.Click += lblClientes_Click;
            // 
            // iconClientes
            // 
            iconClientes.Image = (Image)resources.GetObject("iconClientes.Image");
            iconClientes.Location = new Point(20, 12);
            iconClientes.Name = "iconClientes";
            iconClientes.Size = new Size(40, 40);
            iconClientes.SizeMode = PictureBoxSizeMode.StretchImage;
            iconClientes.TabIndex = 0;
            iconClientes.TabStop = false;
            iconClientes.Click += iconClientes_Click;
            // 
            // cardVendas
            // 
            cardVendas.BackColor = Color.White;
            cardVendas.BorderStyle = BorderStyle.FixedSingle;
            cardVendas.Controls.Add(lblVendas);
            cardVendas.Controls.Add(iconVendas);
            cardVendas.Cursor = Cursors.Hand;
            cardVendas.Location = new Point(323, 67);
            cardVendas.Name = "cardVendas";
            cardVendas.Size = new Size(265, 64);
            cardVendas.TabIndex = 3;
            // 
            // lblVendas
            // 
            lblVendas.AutoSize = true;
            lblVendas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblVendas.ForeColor = Color.FromArgb(64, 64, 64);
            lblVendas.Location = new Point(63, 22);
            lblVendas.Name = "lblVendas";
            lblVendas.Size = new Size(109, 19);
            lblVendas.TabIndex = 1;
            lblVendas.Text = "Materiais/Mídia";
            lblVendas.Click += lblVendas_Click;
            // 
            // iconVendas
            // 
            iconVendas.Image = (Image)resources.GetObject("iconVendas.Image");
            iconVendas.Location = new Point(20, 12);
            iconVendas.Name = "iconVendas";
            iconVendas.Size = new Size(40, 40);
            iconVendas.SizeMode = PictureBoxSizeMode.Zoom;
            iconVendas.TabIndex = 0;
            iconVendas.TabStop = false;
            // 
            // cardConfig
            // 
            cardConfig.BackColor = Color.White;
            cardConfig.BorderStyle = BorderStyle.FixedSingle;
            cardConfig.Controls.Add(lblConfig);
            cardConfig.Controls.Add(iconConfig);
            cardConfig.Cursor = Cursors.Hand;
            cardConfig.Location = new Point(613, 67);
            cardConfig.Name = "cardConfig";
            cardConfig.Size = new Size(253, 64);
            cardConfig.TabIndex = 4;
            // 
            // lblConfig
            // 
            lblConfig.AutoSize = true;
            lblConfig.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblConfig.ForeColor = Color.FromArgb(64, 64, 64);
            lblConfig.Location = new Point(63, 22);
            lblConfig.Name = "lblConfig";
            lblConfig.Size = new Size(99, 19);
            lblConfig.TabIndex = 1;
            lblConfig.Text = "Configurações";
            // 
            // iconConfig
            // 
            iconConfig.Image = (Image)resources.GetObject("iconConfig.Image");
            iconConfig.Location = new Point(20, 12);
            iconConfig.Name = "iconConfig";
            iconConfig.Size = new Size(40, 40);
            iconConfig.SizeMode = PictureBoxSizeMode.Zoom;
            iconConfig.TabIndex = 0;
            iconConfig.TabStop = false;
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.White;
            panelConteudo.BorderStyle = BorderStyle.FixedSingle;
            panelConteudo.Location = new Point(30, 190);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(836, 331);
            panelConteudo.TabIndex = 5;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(0, 120, 74);
            footerPanel.Controls.Add(logoPictureBox);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 560);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(900, 90);
            footerPanel.TabIndex = 6;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(31, 11);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(219, 67);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 240);
            ClientSize = new Size(900, 650);
            Controls.Add(footerPanel);
            Controls.Add(panelConteudo);
            Controls.Add(cardConfig);
            Controls.Add(cardVendas);
            Controls.Add(cardClientes);
            Controls.Add(btnAdd);
            Controls.Add(menuPrincipal);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuPrincipal;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
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
    }
}