using System.Diagnostics;

namespace hyst
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            Program.CTA.license(keyt.Text);
            if (Program.CTA.response.success)
            {
                Home loading = new Home();
                loading.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(Program.CTA.response.message);
            }
        }

        private void d_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeB_CheckedChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}