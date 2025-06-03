using System;
using System.Windows.Forms;

namespace FrizonWhatsappSender
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ShowInTaskbar = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            splashTimer.Interval = 11050;
            splashTimer.Tick += SplashTimer_Tick;
            splashTimer.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Stop();
            this.Close();
        }
    }
}
