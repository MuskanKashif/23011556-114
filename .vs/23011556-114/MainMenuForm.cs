using System;
using System.Windows.Forms;

namespace Assignment2
{
    public class MainMenuForm : Form
    {
        private Button btnProgram1;
        private Button btnProgram2;
        private Button btnProgram3;
        private Button btnProgram4;
        private string username;

        public MainMenuForm(string user)
        {
            username = user;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnProgram1 = new Button();
            this.btnProgram2 = new Button();
            this.btnProgram3 = new Button();
            this.btnProgram4 = new Button();

            // 
            // btnProgram1
            // 
            this.btnProgram1.Location = new System.Drawing.Point(100, 100);
            this.btnProgram1.Name = "btnProgram1";
            this.btnProgram1.Size = new System.Drawing.Size(150, 50);
            this.btnProgram1.Text = "Program 1";
            this.btnProgram1.Click += BtnProgram1_Click;
            // 
            // btnProgram2
            // 
            this.btnProgram2.Location = new System.Drawing.Point(300, 100);
            this.btnProgram2.Name = "btnProgram2";
            this.btnProgram2.Size = new System.Drawing.Size(150, 50);
            this.btnProgram2.Text = "Program 2";
            this.btnProgram2.Click += BtnProgram2_Click;
            // 
            // btnProgram3
            // 
            this.btnProgram3.Location = new System.Drawing.Point(100, 200);
            this.btnProgram3.Name = "btnProgram3";
            this.btnProgram3.Size = new System.Drawing.Size(150, 50);
            this.btnProgram3.Text = "Program 3";
            this.btnProgram3.Click += BtnProgram3_Click;
            // 
            // btnProgram4
            // 
            this.btnProgram4.Location = new System.Drawing.Point(300, 200);
            this.btnProgram4.Name = "btnProgram4";
            this.btnProgram4.Size = new System.Drawing.Size(150, 50);
            this.btnProgram4.Text = "Program 4";
            this.btnProgram4.Click += BtnProgram4_Click;

            // 
            // MainMenuForm
            // 
            this.Text = "Main Menu";
            this.Controls.Add(this.btnProgram1);
            this.Controls.Add(this.btnProgram2);
            this.Controls.Add(this.btnProgram3);
            this.Controls.Add(this.btnProgram4);
            this.Load += MainMenuForm_Load;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            // no-op
        }

        private void BtnProgram1_Click(object? sender, EventArgs e)
        {
            var f = new Assignment1.Program1.LoginForm();
            f.ShowDialog();
        }

        private void BtnProgram2_Click(object? sender, EventArgs e)
        {
            var f = new Assignment1.Program2.DashboardForm();
            f.ShowDialog();
        }

        private void BtnProgram3_Click(object? sender, EventArgs e)
        {
            var f = new Assignment1.Program3.DashboardForm();
            f.ShowDialog();
        }

        private void BtnProgram4_Click(object? sender, EventArgs e)
        {
            var f = new Assignment1.Program4.LoginForm();
            f.ShowDialog();
        }
    }
}
