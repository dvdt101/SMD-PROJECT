using SMD_PROJECT.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMD_PROJECT.view
{
    public partial class YouTubeForm : Form
    {
        private String savePath = "";
        public YouTubeForm()
        {
            InitializeComponent();
        }

        private void donwload_btn_Click(object sender, EventArgs e)
        {
            if (search_input.Text != "")
            {
                Task.Factory.StartNew(() => downloadYoutubeVideo(search_input.Text));
            }
            else
            {
                MessageBox.Show("Por favor, digite o link do video");

            }
        }

        private void downloadYoutubeVideo(String link)
        {
            if (savePath == "") { getFolder(); }
            setLog($"Buscando por:{link}");
            YoutubeApiModel yt = new YoutubeApiModel();
            setLog($"Baixando:{link}");
            var path = yt.videoDownloader(link, savePath);
            if (path != null)
            {
                setLog($"Video salvo em: {path}");
                DialogResult dialogResult = MessageBox.Show(
                "Deseja executar o video?", "Video baixado", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes) {Process.Start(path); }

            }
            else
            {
                setLog("Operação cancelada");
            }


        }

        private void getFolder()
        {

            var path = "";

            FolderBrowserDialog dialog = new FolderBrowserDialog();

            Thread t = new Thread((ThreadStart)(() => {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;

                }
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

            setLog($"Local selecionado: {path}");

            if (path.Substring((path.Length - 11), 11) == "SMD_VIDEOS")
            {
                savePath = path + @"\";
                return;
            }

            path = path + @"\SMD_VIDEOS\";

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
                setLog($"Pasta SMD_VIDEOS criada em: {path}");
            }

            savePath = path;
        }

        private void setLog(String logText)
        {
            if (logs_box.InvokeRequired)
                logs_box.BeginInvoke((MethodInvoker)delegate {
                    logs_box.Text += $"\n {logText}";
                });
        }

    }
}
