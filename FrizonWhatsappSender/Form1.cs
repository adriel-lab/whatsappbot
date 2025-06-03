namespace FrizonWhatsappSender
{
    public partial class Form1 : Form
    {
        private AppSettings settings = new AppSettings();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrizonMainForm frizonForm = new FrizonMainForm();
            frizonForm.Show(); // ou frizonForm.ShowDialog(); se quiser modal
        }

        private void iconClientes_Click(object sender, EventArgs e)
        {

        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            FrizonMainForm frizonForm = new FrizonMainForm();
            frizonForm.Show(); // ou frizonForm.ShowDialog(); se quiser modal
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void senderMenuItem_Click(object sender, EventArgs e)
        {
            FrizonMainForm frizonForm = new FrizonMainForm();
            frizonForm.Show(); // ou frizonForm.ShowDialog(); se quiser modal
        }

        private void sobreMenuItem_Click(object sender, EventArgs e)
        {
            about aboutForm = new about();
            aboutForm.Show(); // ou frizonForm.ShowDialog(); se quiser modal
        }

        private void lblVendas_Click(object sender, EventArgs e)
        {
            frmConfigMidia frmConfigMidiaForm = new frmConfigMidia();
            frmConfigMidiaForm.Show(); // ou frizonForm.ShowDialog(); se quiser modal
        }

        private void lblConfig_Click(object sender, EventArgs e)
        {
            SettingsForm frmConfigTimes = new SettingsForm(settings);
            frmConfigTimes.Show();
        }
    }
}
