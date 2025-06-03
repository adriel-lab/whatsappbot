namespace FrizonWhatsappSender
{
    partial class about
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            mainPanel = new Panel();
            logoPicture = new PictureBox();
            appTitle = new Label();
            versionLabel = new Label();
            divider = new Panel();
            descriptionLabel = new Label();
            devLabel = new Label();
            okButton = new Button();
            copyrightLabel = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPicture).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(253, 253, 252);
            mainPanel.Controls.Add(logoPicture);
            mainPanel.Controls.Add(appTitle);
            mainPanel.Controls.Add(versionLabel);
            mainPanel.Controls.Add(divider);
            mainPanel.Controls.Add(descriptionLabel);
            mainPanel.Controls.Add(devLabel);
            mainPanel.Controls.Add(okButton);
            mainPanel.Controls.Add(copyrightLabel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.ForeColor = Color.Black;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(700, 519);
            mainPanel.TabIndex = 0;
            // 
            // logoPicture
            // 
            logoPicture.Image = (Image)resources.GetObject("logoPicture.Image");
            logoPicture.Location = new Point(95, 17);
            logoPicture.Margin = new Padding(4, 3, 4, 3);
            logoPicture.Name = "logoPicture";
            logoPicture.Size = new Size(299, 234);
            logoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            logoPicture.TabIndex = 0;
            logoPicture.TabStop = false;
            // 
            // appTitle
            // 
            appTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            appTitle.Location = new Point(372, 166);
            appTitle.Margin = new Padding(4, 0, 4, 0);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(204, 35);
            appTitle.TabIndex = 1;
            appTitle.Text = "Frizon BOT";
            appTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            versionLabel.Font = new Font("Segoe UI", 10F);
            versionLabel.ForeColor = Color.DimGray;
            versionLabel.Location = new Point(333, 195);
            versionLabel.Margin = new Padding(4, 0, 4, 0);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(247, 23);
            versionLabel.TabIndex = 2;
            versionLabel.Text = "Versão: 0.0.2";
            versionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divider
            // 
            divider.Location = new Point(47, 231);
            divider.Margin = new Padding(4, 3, 4, 3);
            divider.Name = "divider";
            divider.Size = new Size(607, 1);
            divider.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Font = new Font("Segoe UI", 10F);
            descriptionLabel.Location = new Point(47, 254);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(607, 115);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // devLabel
            // 
            devLabel.Font = new Font("Segoe UI", 9F);
            devLabel.Location = new Point(47, 381);
            devLabel.Margin = new Padding(4, 0, 4, 0);
            devLabel.Name = "devLabel";
            devLabel.Size = new Size(607, 115);
            devLabel.TabIndex = 5;
            devLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            okButton.FlatAppearance.BorderSize = 0;
            okButton.FlatStyle = FlatStyle.Flat;
            okButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            okButton.ForeColor = Color.White;
            okButton.Location = new Point(292, 508);
            okButton.Margin = new Padding(4, 3, 4, 3);
            okButton.Name = "okButton";
            okButton.Size = new Size(117, 40);
            okButton.TabIndex = 6;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = false;
            // 
            // copyrightLabel
            // 
            copyrightLabel.Font = new Font("Segoe UI", 8F);
            copyrightLabel.ForeColor = Color.Gray;
            copyrightLabel.Location = new Point(0, 473);
            copyrightLabel.Margin = new Padding(4, 0, 4, 0);
            copyrightLabel.Name = "copyrightLabel";
            copyrightLabel.Size = new Size(700, 23);
            copyrightLabel.TabIndex = 7;
            copyrightLabel.Text = "© 2023 Frizon Construtora. Todos os direitos reservados.";
            copyrightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // about
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 519);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "about";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre o Sistema";
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoPicture).EndInit();
            ResumeLayout(false);
        }


        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label devLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label copyrightLabel;
    }
}