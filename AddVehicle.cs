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
    public partial class AddVehicle : Form
    {       
        public AddVehicle()
        {
            InitializeComponent();
        }

        public string userName { get; set; }
        public string password { get; set; }

        private void AddVehicle_Load(object sender, EventArgs e)
        {
            Costumer costumer = CostumerProcess.GetCostumer(userName, password);
            pictureBox1.Parent = panel1;
            pictureBox1.BackColor = Color.Transparent;
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.Transparent;
            panel3.Parent = pictureBox1;
            panel3.BackColor = Color.Transparent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBrand.Text == "" || txtModel.Text == "" || txtPlate.Text == "" || txtClass.Text == "")
            {
                lblBlanks.Text = "Please fill in the blanks";
            }
            else
            {
                int len1, len2;
                string a, b;
                len1 = txtBrand.Text.Length;
                len2 = txtModel.Text.Length;
                a = txtBrand.Text.Substring(0, 1);
                b = txtModel.Text.Substring(0, 1);

                Vehicle vehicle = new Vehicle();
                vehicle.Brand = a.ToUpper() + txtBrand.Text.Substring(1, len1 - 1);
                vehicle.Model = b.ToUpper() + txtModel.Text.Substring(1, len2 - 1);
                vehicle.Plate = txtPlate.Text;
                vehicle.Grade = txtClass.Text;

                Costumer costumer = CostumerProcess.GetCostumer(userName, password);
                vehicle.CID = costumer.ID;

                VehicleProcess.AddVehicle(vehicle);
                Questioning questioning = new Questioning();
                questioning.userName = userName;
                questioning.password = password;
                questioning.Show();
                this.Hide();
            }
        }
    }
}
