using System;
using System.Windows.Forms;

namespace FrizonWhatsappSender
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();

            // Configurações adicionais que não podem ser feitas no designer
            this.okButton.Cursor = Cursors.Hand;
            this.okButton.Click += (sender, e) => this.Close();

            // Textos longos são melhores definidos no código
            this.descriptionLabel.Text = "Sistema desenvolvido para envio automatizado de mensagens\n" +
                                      "via WhatsApp para clientes e leads da Frizon Construtora.\n\n" +
                                      "Facilite sua comunicação e aumente sua produtividade!";

            this.devLabel.Text = "Desenvolvido por:\n" +
                              "Equipe de TI Frizon Construtora\n\n" +
                              "Suporte técnico:\n" +
                              "ti@frizonconstrutora.com.br\n" +
                              "(11) 1234-5678";
        }
    }
}