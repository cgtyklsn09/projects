using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Vehicle
    {
        private int labelId;
        private string brand;
        private string model;
        private string plate;
        private string grade;
        private string costumerId;
        private double balance;

        public int LID
        {
            get { return labelId; }
            set { labelId = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Plate
        {
            get { return plate; }
            set { plate = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public string CID
        {
            get { return costumerId; }
            set { costumerId = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
