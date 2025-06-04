using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrizonWhatsappSender
{
    public partial class SettingsForm : Form
    {
        private readonly AppSettings settings;

        public SettingsForm(AppSettings settings)
        {
            InitializeComponent();
            this.settings = settings;
            LoadSettings();
        }

        private void LoadSettings()
        {
            numMinDelayBetweenContacts.Value = settings.MinDelayBetweenContacts;
            numMaxDelayBetweenContacts.Value = settings.MaxDelayBetweenContacts;
            numDelayAfterSend.Value = settings.DelayAfterSend;
            numMaxRetryAttempts.Value = settings.MaxRetryAttempts;
            numRetryDelayMultiplier.Value = settings.RetryDelayMultiplier;
            numErrorDelay.Value = settings.ErrorDelay;
            numInitialLoadDelay.Value = settings.InitialLoadDelay;
            numMinSendDelay.Value = settings.MinSendDelay;
            numMaxSendDelay.Value = settings.MaxSendDelay;
            numDelayFoto.Value = settings.delayFoto;
            numDelayVideo.Value = settings.delayVideo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settings.MinDelayBetweenContacts = (int)numMinDelayBetweenContacts.Value;
            settings.MaxDelayBetweenContacts = (int)numMaxDelayBetweenContacts.Value;
            settings.DelayAfterSend = (int)numDelayAfterSend.Value;
            settings.MaxRetryAttempts = (int)numMaxRetryAttempts.Value;
            settings.RetryDelayMultiplier = (int)numRetryDelayMultiplier.Value;
            settings.ErrorDelay = (int)numErrorDelay.Value;
            settings.InitialLoadDelay = (int)numInitialLoadDelay.Value;
            settings.MinSendDelay = (int)numMinSendDelay.Value;
            settings.MaxSendDelay = (int)numMaxSendDelay.Value;
            settings.delayFoto = (int)numDelayFoto.Value;
            settings.delayVideo = (int)numDelayVideo.Value;

            settings.Save();
            MessageBox.Show("Configurações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnResetDefaults_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja restaurar todas as configurações para os valores padrão?",
                                       "Restaurar Padrões",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                settings.ResetToDefaults();
                LoadSettings(); // Recarrega os controles com os novos valores
                MessageBox.Show("Configurações restauradas para os valores padrão.",
                               "Sucesso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}