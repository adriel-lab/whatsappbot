namespace FrizonWhatsappSender
{
    partial class planilhaModelo
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
            panelMain = new Panel();
            btnClose = new Button();
            labelMensagemDesc = new Label();
            labelTelefoneDesc = new Label();
            labelNomeDesc = new Label();
            labelColumnsTitle = new Label();
            btnDownload = new Button();
            dataGridViewExample = new DataGridView();
            labelDescription = new Label();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExample).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(btnClose);
            panelMain.Controls.Add(labelMensagemDesc);
            panelMain.Controls.Add(labelTelefoneDesc);
            panelMain.Controls.Add(labelNomeDesc);
            panelMain.Controls.Add(labelColumnsTitle);
            panelMain.Controls.Add(btnDownload);
            panelMain.Controls.Add(dataGridViewExample);
            panelMain.Controls.Add(labelDescription);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 700);
            panelMain.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(82, 112, 79);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 85, 58);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 130, 92);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(543, 630);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(233, 46);
            btnClose.TabIndex = 8;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // labelMensagemDesc
            // 
            labelMensagemDesc.AutoSize = true;
            labelMensagemDesc.Font = new Font("Segoe UI", 10F);
            labelMensagemDesc.Location = new Point(40, 480);
            labelMensagemDesc.Margin = new Padding(4, 0, 4, 0);
            labelMensagemDesc.MaximumSize = new Size(720, 0);
            labelMensagemDesc.Name = "labelMensagemDesc";
            labelMensagemDesc.Size = new Size(686, 38);
            labelMensagemDesc.TabIndex = 7;
            labelMensagemDesc.Text = "• Mensagem: Texto que será enviado para o contato. Pode conter quebras de linha (use \\n para nova linha). Se quiser personalizar por contato, inclua a coluna na planilha.";
            // 
            // labelTelefoneDesc
            // 
            labelTelefoneDesc.AutoSize = true;
            labelTelefoneDesc.Font = new Font("Segoe UI", 10F);
            labelTelefoneDesc.Location = new Point(40, 430);
            labelTelefoneDesc.Margin = new Padding(4, 0, 4, 0);
            labelTelefoneDesc.MaximumSize = new Size(720, 0);
            labelTelefoneDesc.Name = "labelTelefoneDesc";
            labelTelefoneDesc.Size = new Size(643, 19);
            labelTelefoneDesc.TabIndex = 6;
            labelTelefoneDesc.Text = "• Telefone: Número de telefone com DDD (formato: 11987654321) - sem espaços, traços ou parênteses";
            // 
            // labelNomeDesc
            // 
            labelNomeDesc.AutoSize = true;
            labelNomeDesc.Font = new Font("Segoe UI", 10F);
            labelNomeDesc.Location = new Point(40, 400);
            labelNomeDesc.Margin = new Padding(4, 0, 4, 0);
            labelNomeDesc.MaximumSize = new Size(720, 0);
            labelNomeDesc.Name = "labelNomeDesc";
            labelNomeDesc.Size = new Size(535, 19);
            labelNomeDesc.TabIndex = 5;
            labelNomeDesc.Text = "• Nome: Nome do destinatário (opcional, usado apenas para identificação no relatório)";
            // 
            // labelColumnsTitle
            // 
            labelColumnsTitle.AutoSize = true;
            labelColumnsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelColumnsTitle.ForeColor = Color.FromArgb(82, 112, 79);
            labelColumnsTitle.Location = new Point(38, 370);
            labelColumnsTitle.Margin = new Padding(4, 0, 4, 0);
            labelColumnsTitle.Name = "labelColumnsTitle";
            labelColumnsTitle.Size = new Size(179, 21);
            labelColumnsTitle.TabIndex = 4;
            labelColumnsTitle.Text = "Descrição das Colunas";
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDownload.BackColor = Color.FromArgb(82, 112, 79);
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 85, 58);
            btnDownload.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 130, 92);
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDownload.ForeColor = Color.White;
            btnDownload.Location = new Point(40, 630);
            btnDownload.Margin = new Padding(4, 3, 4, 3);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(233, 46);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Baixar Modelo CSV";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click_1;
            // 
            // dataGridViewExample
            // 
            dataGridViewExample.AllowUserToAddRows = false;
            dataGridViewExample.AllowUserToDeleteRows = false;
            dataGridViewExample.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewExample.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExample.BackgroundColor = Color.White;
            dataGridViewExample.BorderStyle = BorderStyle.None;
            dataGridViewExample.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewExample.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewExample.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExample.GridColor = Color.FromArgb(240, 240, 240);
            dataGridViewExample.Location = new Point(40, 150);
            dataGridViewExample.Margin = new Padding(4, 3, 4, 3);
            dataGridViewExample.Name = "dataGridViewExample";
            dataGridViewExample.ReadOnly = true;
            dataGridViewExample.RowHeadersVisible = false;
            dataGridViewExample.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewExample.RowTemplate.Height = 30;
            dataGridViewExample.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExample.Size = new Size(720, 200);
            dataGridViewExample.TabIndex = 2;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 10F);
            labelDescription.Location = new Point(40, 100);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.MaximumSize = new Size(720, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(712, 38);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Para enviar mensagens em massa, você precisa preparar uma planilha CSV com os dados dos destinatários. Abaixo está o modelo que deve ser seguido:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(82, 112, 79);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20);
            panelHeader.Size = new Size(800, 70);
            panelHeader.TabIndex = 9;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(20, 20);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(327, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Modelo de Planilha para Envio";
            // 
            // planilhaModelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 700);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "planilhaModelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modelo de Planilha CSV";
            Load += planilhaModelo_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExample).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.DataGridView dataGridViewExample;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label labelMensagemDesc;
        private System.Windows.Forms.Label labelTelefoneDesc;
        private System.Windows.Forms.Label labelNomeDesc;
        private System.Windows.Forms.Label labelColumnsTitle;
        private System.Windows.Forms.Button btnClose;
        private Panel panelHeader;
    }
}