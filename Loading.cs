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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        public string plate { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        private void Loading_Load(object sender, EventArgs e)
        {
            pictureBox1.Parent = panel1;
            pictureBox1.BackColor = Color.Transparent;
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.Transparent;
            panel3.Parent = pictureBox1;
            panel3.BackColor = Color.Transparent;
            panel4.Parent = pictureBox1;
            panel4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label12.Parent = pictureBox1;
            label12.BackColor = Color.Transparent;
            label13.Parent = pictureBox1;
            label13.BackColor = Color.Transparent;
            llblTurn.Parent = pictureBox1;
            llblTurn.BackColor = Color.Transparent;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" &&
                comboBox1.Text != "" && comboBox2.Text != "" || textBox7.Text != "")
                if (txtAmount.Text != "")
                {
                    Vehicle vehicle = VehicleProcess.GetVehicle(plate);
                    decimal newbalance = Convert.ToDecimal(vehicle.Balance) + Convert.ToDecimal(txtAmount.Text);
                    VehicleProcess.UpdateBalance(newbalance,plate);
                    txtAmount.Text = "";
                    pictureBox2.Visible = true;
                    button2.Visible = true;
                    if (label10.Visible == true)
                        label10.Visible = false;
                    if (label11.Visible == true)
                        label11.Visible = false;
                }
                else
                {
                    label10.Visible = true;
                    if (label11.Visible == true)
                        label11.Visible = false;
                }                                
            else
                label11.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Questioning questioning = new Questioning();
            questioning.userName = userName;
            questioning.password = password;
            questioning.Show();
            this.Hide();
        }

        private void llblTurn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Questioning questioning = new Questioning();
            questioning.userName = userName;
            questioning.password = password;
            questioning.Show();
            this.Hide();
        }
    }
}
