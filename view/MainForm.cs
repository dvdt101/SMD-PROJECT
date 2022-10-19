using SMD_PROJECT.view;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SMD_PROJECT
{
    public partial class MainPanel : Form
    {

        private Form frmAtivo;
        public MainPanel()
        {
            InitializeComponent();
          
            if (!IsConnectedToInternet())
            { 
                MessageBox.Show("Verifique sua conexão" +
                " com a internet para que a aplicação funcione corretamente.", "Sem conexão com internet");
                Application.Exit();
            }
        }

        private void formAtivo(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            main_panel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
           if(frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void music_btn_Click(object sender, EventArgs e)
        {
            resetMenuColors();
            music_btn.BackColor = Color.DarkOrange;
            MusicForm mf = new MusicForm();
            formAtivo(mf);
        }

        private void youtube_btn_Click(object sender, EventArgs e)
        {
            resetMenuColors();
            youtube_btn.BackColor = Color.DarkOrange;
            YouTubeForm yt = new YouTubeForm();
            formAtivo(yt);
        }

        private void resetMenuColors()
        {
            music_btn.BackColor = Color.FromArgb(32, 32, 32);
            youtube_btn.BackColor = Color.FromArgb(32, 32, 32);
            spotify_btn.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void spotify_btn_Click(object sender, EventArgs e)
        {
            resetMenuColors();
            spotify_btn.BackColor = Color.DarkOrange;
            SpotifyForm sf = new SpotifyForm();
            formAtivo(sf);
        }

        public bool IsConnectedToInternet()
        {
            string host = "www.youtube.com";  
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            return result;
        }
    }
}
