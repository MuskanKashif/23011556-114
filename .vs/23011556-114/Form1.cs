using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = txtUsername.Text.Trim();
            var pass = txtPassword.Text;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var menu = new MainMenuForm(user);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.WindowState = FormWindowState.Maximized;
            menu.Show();
            this.Hide();
            menu.FormClosed += (s, ev) => this.Show();
        }
    }
}
