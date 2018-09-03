using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace myGasStation
{
    public partial class CustomerIdentification : Form
    {
        string constr = "Data Source=desktop-7npj8lk;Initial Catalog=GasStation;Integrated Security=True";
        public int IDClient;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdar;
       public bool RegCustomer=false;
    
        public CustomerIdentification()
        {
            con = new SqlConnection(constr);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (idTxt.Text == null || idTxt.Text == "") MessageBox.Show("Customer Not Found!");
            else
            {
                try
                {
                  
                    IDClient = Convert.ToInt32(idTxt.Text);
                    cmd = new SqlCommand("SELECT CustomerId FROM tblCustomer", con);
                    con.Open();
                    sdar = cmd.ExecuteReader();                               
                        while (sdar.Read())
                            if (IDClient == Convert.ToInt32(sdar[0].ToString()))
                            {
                                RegCustomer = true;
                                break;
                                
                            }
                       
                        if (RegCustomer == true)
                        {
                            this.Hide();
                            FuelPump cv = new FuelPump();
                            cv.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Customer Not Found!");
                        }
                   sdar.Close();
                    con.Close();
           // this.Close();
           // string a = idTxt.Text;
           
                 }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }

        }
        }

        private void CustomerIdentification_Load(object sender, EventArgs e)
        {

        }
    }
}
