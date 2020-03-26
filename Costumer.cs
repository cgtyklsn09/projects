using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Costumer
    {
        private string Id;
        private string name;
        private string surname;
        private string email;
        private string pswd;
        private string username;
        private string gender;
        private int bdd; //birth date day
        private string bdm; //birth date month
        private int bdy; //birth date year

        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return pswd; }
            set { pswd = value; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int BDD
        {
            get { return bdd; }
            set { bdd = value; }
        }

        public string BDM
        {
            get { return bdm; }
            set { bdm = value; }
        }

        public int BDY
        {
            get { return bdy; }
            set { bdy = value; }
        }
    }
}
