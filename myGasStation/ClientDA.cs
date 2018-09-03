using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

using System.Threading.Tasks;

namespace myGasStation
{
    class ClientDA
    {
        static SqlCommand cmd;
        static SqlConnection con;
        static SqlDataAdapter da;
        public DataTable dt;
        public SqlConnection sqlconnection;


        public string sqlStr;

        static string connectionString = "Data Source=desktop-7npj8lk;Initial Catalog=GasStation;Integrated Security=True";
        
        public ClientDA(string sqlStr)
        {
            dt = new DataTable();
             this.sqlStr = sqlStr;
             sqlconnection = new SqlConnection(connectionString);  
        }
        /*
         * recieve a Client object and enter it in the DB=> clients table
         */
        public static int insertEntity(Client c)         {
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("INSERT INTO tblCustomer (CustomerId, FullName, Address, PhoneNum, Email) VALUES (@id,@name, @address, @phone, @email ) ", con);
            cmd.Parameters.AddWithValue("@id", c.ID);
            cmd.Parameters.AddWithValue("@name", c.Name);
            cmd.Parameters.AddWithValue("@address", c.Address);
            cmd.Parameters.AddWithValue("@phone", c.Phone);
            cmd.Parameters.AddWithValue("@email", c.Email);

           cmd.ExecuteNonQuery();
            con.Close();
            return 0;
        }

        public DataTable datatable()
        {
            cmd = new SqlCommand(sqlStr, sqlconnection);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }
        /*
        public static Boolean (int id)
        {

            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand(" if Exist (SELECT * FROM Clients WHERE ID = id )", con);

        }*/
    }
}
