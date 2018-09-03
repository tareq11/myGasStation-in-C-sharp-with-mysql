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
    public partial class Mainpage : Form
    {


        public Mainpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerRegistration subWindow = new CustomerRegistration();
            subWindow.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerIdentification ci = new CustomerIdentification();
            ci.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIPCustomer cv = new VIPCustomer();
            cv.ShowDialog();
        }

      

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportDA cv = new ReportDA();
            cv.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CustomerRegistration subWindow = new CustomerRegistration();
            subWindow.Show();
            this.Hide();
        }

        

        
    }
}
