using SMD_PROJECT.model;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMD_PROJECT.view
{
    public partial class MusicForm : Form
    {
        private String savePath = "";
        public MusicForm()
        {
            InitializeComponent();
        }

        private void donwload_btn_Click(object sender, EventArgs e)
        {
            if(search_input.Text != "")
            {
                Task.Factory.StartNew(() => downloadSongByName(search_input.Text));

            }
            else
            {
                MessageBox.Show("Por favor, digite o nome da música");

            }
        }

        private void downloadSongByName(String songName)
        {
            if (savePath == "") {  getFolder(); }
            setLog($"Buscando por: {songName}");
            YoutubeApiModel yt = new YoutubeApiModel();
            var result = yt.search(songName + "lyrics");
            setLog($"Baixando: {songName}");
            var path = yt.videoDownloader(result, savePath);
            setLog($"Finalizando operação");
            var file = yt.convertToMp3(path);
            setLog($"Música baixada e salva em: {file}");

            DialogResult dialogResult = MessageBox.Show(
                "Deseja executar a música?", "Música baixada", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start(file);
            }

        }
        private  void getFolder()
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

            if (path.Substring((path.Length - 11), 11) == "SMD_MUSICAS")
            {
                savePath = path + @"\";
                return;
            }

            path = path + @"\SMD_MUSICAS\";

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
                setLog($"Pasta SMD_MUSICAS criada em: {path}");
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
