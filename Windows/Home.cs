using Injection;
using System.Diagnostics;
using System.IO;
using System.Net;
using static Injection.MonoInjection;
using System.Reflection.Metadata;

namespace hyst
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
        }

        private void MinimizeB_CheckedChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseB_CheckedChanged(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("GAME NAME");
            if (processes.Length > 0)
            {
                Thread.Sleep(10000);
                timer1.Stop();
                string a = "https://cdn.discordapp.com/attachments/1158228877605339196/1160841968205713529/example.dll";
                string b = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                string c = Path.Combine(b, Path.GetRandomFileName());
                Directory.CreateDirectory(b);
                WebClient webClient = new WebClient();
                webClient.DownloadFile(a, c);
                try
                {
                    Injector injector = new Injector("Gorilla Tag");
                    injector.Inject(File.ReadAllBytes(c), "Example", "MyLoader", "Init");
                    Directory.Delete(b, true);
                    MessageBox.Show("injection completed.");
                }
                catch (Exception ex)
                {
                    Directory.Delete(b, true);
                    MessageBox.Show(ex.Message);
                    File.WriteAllText("injection error.txt", ex.Message);
                }
                guna2WinProgressIndicator1.ProgressColor = Color.Transparent;
                label2.Visible = false;
                label3.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}