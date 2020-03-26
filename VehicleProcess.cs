using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLayer;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class VehicleProcess
    {
        public static void AddVehicle(Vehicle vehicle)
        {
            string query = "insert into Vehicle (Brand,Model,Plate,Class,CostumerID,Balance) values('" + vehicle.Brand + "','" + vehicle.Model
                + "','" + vehicle.Plate + "','" + vehicle.Grade + "','" + vehicle.CID + "'," + vehicle.Balance + ")";
            DBClass.InsertCommand(query);
        }

        public static Vehicle GetVehicle(string plate)
        {
            DataSet tempVehicle = DBClass.SelectCommand("select * from Vehicle where Plate = '" + plate + "'");

            if (tempVehicle.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                System.Data.DataRow dataRow = tempVehicle.Tables[0].Rows[0];
                return new Vehicle
                {
                    LID = Convert.ToInt32(dataRow[0]),
                    Brand = dataRow[1].ToString(),
                    Model = dataRow[2].ToString(),
                    Plate = dataRow[3].ToString(),
                    Grade = dataRow[4].ToString(),
                    CID = dataRow[5].ToString(),
                    Balance = Convert.ToDouble(dataRow[6])
                };
            }
        }

        public static void UpdateBalance(decimal balance,string plate)
        {
            string query = "update Vehicle set Balance = " + balance + " where Plate = '" + plate + "'";
            query = query.ToString().Replace(',', '.'); //query gönderilirken balance değerinin tamsayıdan sonraki ayracı virgülden noktaya dönüştürülüyor
            DBClass.UpdateCommand(query);
        }
    }
}