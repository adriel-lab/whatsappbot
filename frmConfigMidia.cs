using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;


namespace FrizonWhatsappSender
{
    public partial class frmConfigMidia : Form
    {

        private LibVLC _libVLC;
        private LibVLCSharp.Shared.MediaPlayer _mediaPlayer;
        private VideoView _videoView;
        private readonly string caminhoImagemPadrao = Path.Combine(Application.StartupPath, "Media", "imagem_padrao.jpg");
        private readonly string caminhoVideoPadrao = Path.Combine(Application.StartupPath, "Media", "video_padrao.mp4");


        public frmConfigMidia()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Media"));
            CarregarMidias();
            carregarVideo();
        }


        private void carregarVideo()
        {
            Core.Initialize(); // Inicializa o LibVLCSharp

            _libVLC = new LibVLC();
            _mediaPlayer = new LibVLCSharp.Shared.MediaPlayer(_libVLC);

            _videoView = new VideoView
            {
                MediaPlayer = _mediaPlayer,
                Dock = DockStyle.Fill
            };

            panelVideo.Controls.Add(_videoView);

            string videoFile = caminhoVideoPadrao;

            if (File.Exists(videoFile))
            {
                var media = new Media(_libVLC, videoFile, FromType.FromPath);
                _mediaPlayer.Media = media;
                // Não chama Play() -> vídeo pronto, mas só toca quando quiser
            }
            else
            {
                MessageBox.Show("Vídeo não encontrado!");
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer == null || _mediaPlayer.Media == null)
            {
                MessageBox.Show("Nenhum vídeo carregado!");
                return;
            }

            if (_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.Pause();
                btnPlayPause.Text = "▶ Play";
            }
            else
            {
                _mediaPlayer.Play();
                btnPlayPause.Text = "⏸ Pause";
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer == null || _mediaPlayer.Media == null)
            {
                MessageBox.Show("Nenhum vídeo carregado!");
                return;
            }

            // Reinicia o vídeo
            _mediaPlayer.Stop();
            _mediaPlayer.Play();
            btnPlayPause.Text = "⏸ Pause";
        }

        private void CarregarMidias()
        {
            // Remove a criação automática de arquivos vazios
            // Apenas verifica se existem e carrega se forem válidos

            // Para a imagem
            if (File.Exists(caminhoImagemPadrao))
            {
                try
                {
                    // Libera a imagem anterior se existir
                    if (picImagemPreview.Image != null)
                    {
                        picImagemPreview.Image.Dispose();
                        picImagemPreview.Image = null;
                    }

                    // Carrega a nova imagem com tratamento de erros
                    using (var img = Image.FromFile(caminhoImagemPadrao))
                    {
                        picImagemPreview.Image = new Bitmap(img); // Cria uma cópia
                    }
                }
                catch (Exception ex) when (ex is OutOfMemoryException || ex is ArgumentException)
                {
                    // Arquivo corrompido ou não é imagem válida
                    File.Delete(caminhoImagemPadrao);
                    picImagemPreview.Image = null;
                }
            }
            else
            {
                picImagemPreview.Image = null;
            }

            lblImagem.Text = File.Exists(caminhoImagemPadrao)
                ? $"Imagem: {Path.GetFileName(caminhoImagemPadrao)}"
                : "Nenhuma imagem configurada";

            lblVideo.Text = File.Exists(caminhoVideoPadrao)
                ? $"Vídeo: {Path.GetFileName(caminhoVideoPadrao)}"
                : "Nenhum vídeo configurado";
        }



        private void btnSubstituirImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Imagens|*.jpg;*.png;*.jpeg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Substitui o arquivo existente
                        File.Copy(dialog.FileName, caminhoImagemPadrao, overwrite: true);
                        CarregarMidias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao substituir imagem: {ex.Message}", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSubstituirVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Vídeos|*.mp4;*.mov;*.avi";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Substitui o arquivo existente
                        File.Copy(dialog.FileName, caminhoVideoPadrao, overwrite: true);
                        CarregarMidias();
                        RecarregarVideo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao substituir vídeo: {ex.Message}", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RecarregarVideo()
        {
            if (_mediaPlayer != null)
            {
                _mediaPlayer.Stop();

                var media = new Media(_libVLC, caminhoVideoPadrao, FromType.FromPath);
                _mediaPlayer.Media = media;

                btnPlayPause.Text = "Play"; // Reseta o botão
            }
        }



        private void btnRemoverImagem_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminhoImagemPadrao))
            {
                try
                {
                    File.Delete(caminhoImagemPadrao);
                    if (picImagemPreview.Image != null)
                    {
                        picImagemPreview.Image.Dispose();
                        picImagemPreview.Image = null;
                    }
                    lblImagem.Text = "Nenhuma imagem configurada";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover imagem: {ex.Message}", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoverVideo_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminhoVideoPadrao))
            {
                try
                {
                    File.Delete(caminhoVideoPadrao);
                    lblVideo.Text = "Nenhum vídeo configurado";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover vídeo: {ex.Message}", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmConfigMidia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_mediaPlayer != null)
            {
                _mediaPlayer.Stop();
                _mediaPlayer.Dispose();
            }

            if (_libVLC != null)
            {
                _libVLC.Dispose();
            }
        }
    }
}