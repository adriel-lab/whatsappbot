using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
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
        private bool _videoCarregado = false;

        public frmConfigMidia()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Media"));

            // Garante que o formulário está completamente carregado antes de iniciar operações assíncronas
            this.Load += async (sender, e) =>
            {
                await CarregarImagemAsync();
                await ConfigurarPlayerVideoAsync();
            };
        }

        private async Task CarregarImagemAsync()
        {
            if (!File.Exists(caminhoImagemPadrao))
            {
                SafeUpdateUI(() =>
                {
                    picImagemPreview.Image = null;
                    lblImagem.Text = "Nenhuma imagem configurada";
                });
                return;
            }

            try
            {
                using (var img = await Task.Run(() => Image.FromFile(caminhoImagemPadrao)))
                {
                    SafeUpdateUI(() =>
                    {
                        if (picImagemPreview.Image != null)
                        {
                            picImagemPreview.Image.Dispose();
                        }
                        picImagemPreview.Image = new Bitmap(img);
                        lblImagem.Text = $"Imagem: {Path.GetFileName(caminhoImagemPadrao)}";
                    });
                }
            }
            catch (Exception ex) when (ex is OutOfMemoryException || ex is ArgumentException)
            {
                File.Delete(caminhoImagemPadrao);
                SafeUpdateUI(() =>
                {
                    picImagemPreview.Image = null;
                    lblImagem.Text = "Imagem inválida - removida";
                });
            }
            catch (Exception ex)
            {
                SafeUpdateUI(() =>
                {
                    MessageBox.Show($"Erro ao carregar imagem: {ex.Message}", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
            }
        }

        private async Task ConfigurarPlayerVideoAsync()
        {
            Label loadingLabel = null;

            SafeUpdateUI(() =>
            {
                loadingLabel = new Label
                {
                    Text = "Preparando player de vídeo...",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10, FontStyle.Italic)
                };
                panelVideo.Controls.Add(loadingLabel);
                lblVideo.Text = "Carregando...";
            });

            try
            {
                if (!File.Exists(caminhoVideoPadrao))
                {
                    SafeUpdateUI(() =>
                    {
                        panelVideo.Controls.Remove(loadingLabel);
                        var noVideoLabel = new Label
                        {
                            Text = "Nenhum vídeo configurado",
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        panelVideo.Controls.Add(noVideoLabel);
                        lblVideo.Text = "Nenhum vídeo configurado";
                    });
                    return;
                }

                await Task.Run(() => Core.Initialize());

                SafeUpdateUI(() =>
                {
                    _libVLC = new LibVLC(enableDebugLogs: false);
                    _mediaPlayer = new LibVLCSharp.Shared.MediaPlayer(_libVLC)
                    {
                        EnableHardwareDecoding = true
                    };

                    _videoView = new VideoView
                    {
                        MediaPlayer = _mediaPlayer,
                        Dock = DockStyle.Fill
                    };

                    panelVideo.Controls.Remove(loadingLabel);
                    panelVideo.Controls.Add(_videoView);

                    var media = new Media(_libVLC, caminhoVideoPadrao, FromType.FromPath);
                    _mediaPlayer.Media = media;
                    _videoCarregado = true;
                    lblVideo.Text = $"Vídeo: {Path.GetFileName(caminhoVideoPadrao)}";

                    btnPlayPause.Enabled = true;
                    btnRestart.Enabled = true;
                });
            }
            catch (Exception ex)
            {
                SafeUpdateUI(() =>
                {
                    panelVideo.Controls.Remove(loadingLabel);
                    MessageBox.Show($"Erro ao carregar player de vídeo: {ex.Message}", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
            }
        }

        private void SafeUpdateUI(Action action)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                // Verifica se o controle ainda está válido
                if (!this.IsDisposed && this.IsHandleCreated)
                {
                    action();
                }
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (!_videoCarregado || _mediaPlayer == null)
            {
                MessageBox.Show("Nenhum vídeo carregado ou player não está pronto!");
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
            if (!_videoCarregado || _mediaPlayer == null)
            {
                MessageBox.Show("Nenhum vídeo carregado ou player não está pronto!");
                return;
            }

            _mediaPlayer.Stop();
            _mediaPlayer.Play();
            btnPlayPause.Text = "⏸ Pause";
        }

        private async void btnSubstituirImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Imagens|*.jpg;*.png;*.jpeg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        await Task.Run(() => File.Copy(dialog.FileName, caminhoImagemPadrao, true));
                        await CarregarImagemAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao substituir imagem: {ex.Message}", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnSubstituirVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Vídeos|*.mp4;*.mov;*.avi";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        await Task.Run(() => File.Copy(dialog.FileName, caminhoVideoPadrao, true));

                        if (_videoCarregado)
                        {
                            SafeUpdateUI(() =>
                            {
                                lblVideo.Text = $"Vídeo: {Path.GetFileName(caminhoVideoPadrao)}";
                                RecarregarVideo();
                            });
                        }
                        else
                        {
                            await ConfigurarPlayerVideoAsync();
                        }
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
            if (!_videoCarregado) return;

            _mediaPlayer.Stop();
            var media = new Media(_libVLC, caminhoVideoPadrao, FromType.FromPath);
            _mediaPlayer.Media = media;
            btnPlayPause.Text = "▶ Play";
        }

        private void btnRemoverImagem_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminhoImagemPadrao))
            {
                try
                {
                    File.Delete(caminhoImagemPadrao);
                    SafeUpdateUI(() =>
                    {
                        picImagemPreview.Image = null;
                        lblImagem.Text = "Nenhuma imagem configurada";
                    });
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

                    SafeUpdateUI(() =>
                    {
                        lblVideo.Text = "Nenhum vídeo configurado";

                        if (_videoCarregado)
                        {
                            _mediaPlayer.Stop();
                            panelVideo.Controls.Remove(_videoView);
                            _videoView.Dispose();
                            _videoView = null;
                            _videoCarregado = false;

                            var noVideoLabel = new Label
                            {
                                Text = "Nenhum vídeo configurado",
                                Dock = DockStyle.Fill,
                                TextAlign = ContentAlignment.MiddleCenter
                            };
                            panelVideo.Controls.Add(noVideoLabel);

                            btnPlayPause.Enabled = false;
                            btnRestart.Enabled = false;
                        }
                    });
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
            if (_videoCarregado)
            {
                _mediaPlayer?.Stop();
                _mediaPlayer?.Dispose();
                _videoView?.Dispose();
                _libVLC?.Dispose();
            }

            if (picImagemPreview.Image != null)
            {
                picImagemPreview.Image.Dispose();
                picImagemPreview.Image = null;
            }
        }
    }
}