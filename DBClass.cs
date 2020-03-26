using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class DBClass
    {
        public static string connectionString = "Data Source=CAGATAYKALSAN;Initial Catalog=HGS;Integrated Security=True";
        static readonly SqlConnection connection = new SqlConnection(connectionString);
        static SqlDataAdapter sqlDataAdapter;
        static SqlCommand sqlCommand;

        public static void InsertCommand(string query)
        {
            sqlCommand = new SqlCommand(query, connection);

            if (connection.State == ConnectionState.Closed)
            {          
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                connection.Close();
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
         }

        public static DataSet SelectCommand(string query)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            DataSet temp = new DataSet();
            sqlDataAdapter = new SqlDataAdapter(query, connection);
            sqlDataAdapter.Fill(temp);
            connection.Close();
            return temp;
        }

        public static void UpdateCommand(string query)
        {
            sqlCommand = new SqlCommand(query, connection);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();               
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                connection.Close();
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public static void DeleteCommand(string query)
        {
            //
        }
    }
}

