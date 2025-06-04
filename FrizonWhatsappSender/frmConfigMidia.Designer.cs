namespace FrizonWhatsappSender
{
    partial class frmConfigMidia
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
            picImagemPreview = new PictureBox();
            lblImagem = new Label();
            lblVideo = new Label();
            panelContainer = new Panel();
            grpPreview = new GroupBox();
            grpAcoes = new GroupBox();
            btnRestart = new Button();
            btnPlayPause = new Button();
            panelVideo = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            lblTitulo = new Label();
            btnSubstituirVideo = new Button();
            btnSubstituirImagem = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagemPreview).BeginInit();
            panelContainer.SuspendLayout();
            grpPreview.SuspendLayout();
            grpAcoes.SuspendLayout();
            SuspendLayout();
            // 
            // picImagemPreview
            // 
            picImagemPreview.BackColor = Color.WhiteSmoke;
            picImagemPreview.BorderStyle = BorderStyle.FixedSingle;
            picImagemPreview.Location = new Point(15, 22);
            picImagemPreview.Name = "picImagemPreview";
            picImagemPreview.Size = new Size(300, 300);
            picImagemPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picImagemPreview.TabIndex = 0;
            picImagemPreview.TabStop = false;
            // 
            // lblImagem
            // 
            lblImagem.AutoSize = true;
            lblImagem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImagem.ForeColor = Color.DimGray;
            lblImagem.Location = new Point(15, 340);
            lblImagem.Name = "lblImagem";
            lblImagem.Size = new Size(164, 13);
            lblImagem.TabIndex = 3;
            lblImagem.Text = "Nenhuma imagem selecionada";
            // 
            // lblVideo
            // 
            lblVideo.AutoSize = true;
            lblVideo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVideo.ForeColor = Color.DimGray;
            lblVideo.Location = new Point(53, 331);
            lblVideo.Name = "lblVideo";
            lblVideo.Size = new Size(147, 13);
            lblVideo.TabIndex = 4;
            lblVideo.Text = "Nenhum vídeo selecionado";
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(grpPreview);
            panelContainer.Controls.Add(grpAcoes);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 50);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(20);
            panelContainer.Size = new Size(800, 489);
            panelContainer.TabIndex = 5;
            // 
            // grpPreview
            // 
            grpPreview.Controls.Add(picImagemPreview);
            grpPreview.Controls.Add(lblImagem);
            grpPreview.Dock = DockStyle.Left;
            grpPreview.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPreview.Location = new Point(20, 20);
            grpPreview.Name = "grpPreview";
            grpPreview.Size = new Size(350, 449);
            grpPreview.TabIndex = 5;
            grpPreview.TabStop = false;
            grpPreview.Text = "Pré-visualização imagem";
            // 
            // grpAcoes
            // 
            grpAcoes.Controls.Add(btnRestart);
            grpAcoes.Controls.Add(btnPlayPause);
            grpAcoes.Controls.Add(panelVideo);
            grpAcoes.Controls.Add(lblVideo);
            grpAcoes.Dock = DockStyle.Right;
            grpAcoes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAcoes.Location = new Point(400, 20);
            grpAcoes.Name = "grpAcoes";
            grpAcoes.Size = new Size(380, 449);
            grpAcoes.TabIndex = 6;
            grpAcoes.TabStop = false;
            grpAcoes.Text = "Pré-visualização video";
            // 
            // btnRestart
            // 
            btnRestart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestart.BackColor = Color.White;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = SystemColors.ControlText;
            btnRestart.Location = new Point(71, 359);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(118, 30);
            btnRestart.TabIndex = 12;
            btnRestart.Text = "🔄 Reiniciar";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnPlayPause
            // 
            btnPlayPause.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPlayPause.BackColor = Color.White;
            btnPlayPause.FlatStyle = FlatStyle.Flat;
            btnPlayPause.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlayPause.ForeColor = SystemColors.ControlText;
            btnPlayPause.Location = new Point(199, 359);
            btnPlayPause.Name = "btnPlayPause";
            btnPlayPause.Size = new Size(87, 30);
            btnPlayPause.TabIndex = 11;
            btnPlayPause.Text = "▶ Play";
            btnPlayPause.UseVisualStyleBackColor = false;
            btnPlayPause.Click += btnPlayPause_Click;
            // 
            // panelVideo
            // 
            panelVideo.Location = new Point(25, 24);
            panelVideo.Name = "panelVideo";
            panelVideo.Size = new Size(327, 298);
            panelVideo.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(680, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(570, 10);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(20, 0, 0, 0);
            lblTitulo.Size = new Size(800, 50);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Configuração de Mídia";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSubstituirVideo
            // 
            btnSubstituirVideo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubstituirVideo.BackColor = Color.White;
            btnSubstituirVideo.FlatStyle = FlatStyle.Flat;
            btnSubstituirVideo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubstituirVideo.ForeColor = SystemColors.ControlText;
            btnSubstituirVideo.Location = new Point(550, 10);
            btnSubstituirVideo.Name = "btnSubstituirVideo";
            btnSubstituirVideo.Size = new Size(124, 30);
            btnSubstituirVideo.TabIndex = 9;
            btnSubstituirVideo.Text = "Substituir Video";
            btnSubstituirVideo.UseVisualStyleBackColor = false;
            btnSubstituirVideo.Click += btnSubstituirVideo_Click;
            // 
            // btnSubstituirImagem
            // 
            btnSubstituirImagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubstituirImagem.BackColor = Color.White;
            btnSubstituirImagem.FlatStyle = FlatStyle.Flat;
            btnSubstituirImagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubstituirImagem.ForeColor = SystemColors.ControlText;
            btnSubstituirImagem.Location = new Point(391, 10);
            btnSubstituirImagem.Name = "btnSubstituirImagem";
            btnSubstituirImagem.Size = new Size(153, 30);
            btnSubstituirImagem.TabIndex = 10;
            btnSubstituirImagem.Text = "Substituir Imagem";
            btnSubstituirImagem.UseVisualStyleBackColor = false;
            btnSubstituirImagem.Click += btnSubstituirImagem_Click;
            // 
            // frmConfigMidia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 539);
            Controls.Add(btnSubstituirImagem);
            Controls.Add(btnSubstituirVideo);
            Controls.Add(panelContainer);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(816, 489);
            Name = "frmConfigMidia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frizon Construtora - Configuração de Mídia";
            FormClosing += frmConfigMidia_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picImagemPreview).EndInit();
            panelContainer.ResumeLayout(false);
            grpPreview.ResumeLayout(false);
            grpPreview.PerformLayout();
            grpAcoes.ResumeLayout(false);
            grpAcoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picImagemPreview;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.GroupBox grpAcoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTitulo;
        private Button btnSubstituirVideo;
        private Button btnSubstituirImagem;
        private Panel panelVideo;
        private Button btnPlayPause;
        private Button btnRestart;
    }
}