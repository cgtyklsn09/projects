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
    public partial class Questioning : Form
    {
        AddVehicle addVehicle = new AddVehicle();
        string plate;
        public Questioning()
        {
            InitializeComponent();
            textBox1.GotFocus += new EventHandler(textBox1_GotFocus);
        }
        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        public string userName { get; set; }
        public string password { get; set; }
        private void Questioning_Load(object sender, EventArgs e)
        {
            Costumer costumer = CostumerProcess.GetCostumer(userName, password);
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Text = costumer.Name + " " + costumer.Surname;
            pictureBox1.Parent = panel1;
            pictureBox1.BackColor = Color.Transparent;
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.Transparent;
            panel3.Parent = pictureBox1;
            panel3.BackColor = Color.Transparent;
            linkLabel1.Parent = panel3;
            linkLabel1.BackColor = Color.Transparent;
        }

        private void btnQuestioning_Click(object sender, EventArgs e)
        {
            lblPlateError.Visible = false;
            Costumer costumer = CostumerProcess.GetCostumer(userName, password);                     
            plate = textBox1.Text;
            Vehicle vehicle = VehicleProcess.GetVehicle(plate);
            if(vehicle != null)
            {
                if(costumer.ID == vehicle.CID)
                {
                    lblLabel.Text = Convert.ToString(vehicle.LID);
                    lblPlate.Text = vehicle.Plate;
                    lblClass.Text = Convert.ToString(vehicle.Grade) + ". Class";
                    lblBalance.Text = Convert.ToString(vehicle.Balance);
                    linkLabel2.Visible = true;
                }
                else
                {
                    lblPlateError.Text = "This vehicle is not your's!";
                    lblPlateError.Visible = true;
                }
            }
            else
            {
                lblPlateError.Text = "There is no vehicle!";
                lblPlateError.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addVehicle.userName = userName;
            addVehicle.password = password;
            addVehicle.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Loading loading = new Loading();
            loading.userName = userName;
            loading.password = password;
            loading.plate = plate;
            loading.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
