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
    public class FeesProcess
    {
        public static Fees GetFees(string grade)
        {
            DataSet tempFees = DBClass.SelectCommand("select * from Fees where Class = '" + grade + "'");

            if (tempFees.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                DataRow dataRow = tempFees.Tables[0].Rows[0];
                return new Fees
                {
                    Osmangazi = Convert.ToDouble(dataRow[1]),
                    Yss = Convert.ToDouble(dataRow[2]),
                    Fsm = Convert.ToDouble(dataRow[3]),
                    Anadolu = Convert.ToDouble(dataRow[4]),
                    Izmir_aydin = Convert.ToDouble(dataRow[5]),
                    Cukurova = Convert.ToDouble(dataRow[6]),
                    Nmanatolian = Convert.ToDouble(dataRow[7]),
                    Nmeuropean = Convert.ToDouble(dataRow[8]),
                    Gebze_orhangazi_izmir = Convert.ToDouble(dataRow[9])
                };
            }
        }
    }
}
