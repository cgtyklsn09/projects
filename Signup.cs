using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Signup : Form
    {

        public Signup()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblHeader.Parent = pictureBox1;
            lblHeader.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;
            label8.Parent = pictureBox1;
            label8.BackColor = Color.Transparent;
            label9.Parent = pictureBox1;
            label9.BackColor = Color.Transparent;
            label10.Parent = pictureBox1;
            label10.BackColor = Color.Transparent;
            lblFill1.Parent = pictureBox1;
            lblFill1.BackColor = Color.Transparent;
            lblFill2.Parent = pictureBox1;
            lblFill2.BackColor = Color.Transparent;
            btnComplete.Parent = pictureBox1;
            btnComplete.BackColor = Color.Transparent;
            txtPassword.PasswordChar = '*';
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            lblIdError.Visible = false;
            if (txtName.Text == "" || txtSurname.Text == "" || txtId.Text == "" || txtEmail.Text == "" || 
                txtUserName.Text == "" || txtPassword.Text == "" || comboBox1.Text == "" ||
                comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
            {
                lblFill1.Text = "Please fill in the blanks";
            }
            else if(checkBox1.Checked == false)
            {
                lblFill2.Text = "Please accept the Membership Agreement and Privacy Policy";
            }
            else if (txtId.Text.Length < 11 || txtId.Text.Length > 11)
            {
                lblIdError.Visible = true;
            }
            else
            {
                int len1, len2;
                string a, b;
                len1 = txtName.Text.Length;
                len2 = txtSurname.Text.Length;
                a = txtName.Text.Substring(0, 1);
                b = txtSurname.Text.Substring(0, 1);

                Costumer costumer = new Costumer();
                costumer.Name = a.ToUpper() + txtName.Text.Substring(1, len1 - 1);
                costumer.Surname = b.ToUpper() + txtSurname.Text.Substring(1, len2 - 1);
                costumer.ID = txtId.Text;
                costumer.Email = txtEmail.Text;
                costumer.UserName = txtUserName.Text;
                costumer.Password = txtPassword.Text;
                costumer.Gender = comboBox1.SelectedItem.ToString();
                costumer.BDD = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                costumer.BDM = comboBox3.SelectedItem.ToString();
                costumer.BDY = Convert.ToInt32(comboBox4.SelectedItem.ToString());
                CostumerProcess.AddCostumer(costumer);
                AddVehicle addVehicle = new AddVehicle();
                addVehicle.userName = costumer.UserName;
                addVehicle.password = costumer.Password;
                addVehicle.Show();
                this.Hide();
            }

        }
    }
}
