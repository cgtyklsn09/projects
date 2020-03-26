using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class CostumerProcess
    {
        public static void AddCostumer(Costumer costumer)
        {
            string query = "insert into Costumer(IdNumber,Name,Surname,EMail,Password,UserName,Gender,BDD,BDM,BDY) values(" + costumer.ID + ",'" + costumer.Name + "','" + costumer.Surname + "','" + costumer.Email + "','" + costumer.Password + "','" + costumer.UserName + "', '" + costumer.Gender + "'," + costumer.BDD + ",'" + costumer.BDM + "'," + costumer.BDY + ")";
            DBClass.InsertCommand(query);
        }

        public static Costumer GetCostumer(string username, string pswd)
        {
            DataSet tempCostumer = DBClass.SelectCommand("select * from Costumer where UserName = '"
                + username + "' and Password ='" + pswd + "'");

            if (tempCostumer.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                DataRow dataRow = tempCostumer.Tables[0].Rows[0];
                return new Costumer
                {
                    ID = dataRow[1].ToString(),
                    Name = dataRow[2].ToString(),
                    Surname = dataRow[3].ToString(),
                    Email = dataRow[4].ToString(),
                    Password = dataRow[5].ToString(),
                    UserName = dataRow[6].ToString(),
                    Gender = dataRow[7].ToString(),
                    BDD = Convert.ToInt32(dataRow[8]),
                    BDM = dataRow[9].ToString(),
                    BDY = Convert.ToInt32(dataRow[10])
                };
            }        
        }
    }
}
