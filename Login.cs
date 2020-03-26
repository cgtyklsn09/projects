using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Login : Form
    {
               
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            btnLogin.Parent = panel1;
            btnLogin.BackColor = Color.Transparent;
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Costumer costumer = CostumerProcess.GetCostumer(txtUsername.Text, txtPassword.Text);
            if (costumer == null)
            {
                label5.Text = "There is no costumer! Please try again!";
            }
            else
            {
                Questioning questioning = new Questioning();
                questioning.userName = txtUsername.Text;
                questioning.password = txtPassword.Text;
                questioning.Show();
                this.Hide();
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void lLblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BusinessLayer.Admin admin = AdminProcess.GetAdmin(txtUsername.Text, txtPassword.Text);
            if (admin == null)
            {
                lblCheckAdmin.Visible = true;
            }
            else
            {               
                lblCheckAdmin.Visible = false;
                Admin admin1 = new Admin();
                admin1.adminName = txtUsername.Text;
                admin1.adminPassword = txtPassword.Text;
                admin1.Show();
                this.Hide();               
            }
        }
    }
}
