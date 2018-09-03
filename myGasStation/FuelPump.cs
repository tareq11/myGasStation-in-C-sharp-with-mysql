using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGasStation
{
    public partial class FuelPump : Form
    {
        //customer id needed to save the ammount of fuel to the same customer
        public FuelPump(string id)
        {
            InitializeComponent();
            //ID.Visible = true;
            //ID.Text = id;
        }

        public FuelPump()
        {
            InitializeComponent();
        }

        private void gasRadio_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = Visible;
            groupBox3.Visible = false; 
        }

        private void fuelRadio_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = Visible;
            groupBox1.Visible = false;
        }

        private void FuelPump_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Credit Card");
            comboBox1.Items.Add("Cash ");
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage per = new Mainpage();
            per.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Credit Card")
                MessageBox.Show("Please Pass the Card and Wait for Confirm");
            if (comboBox1.Text== "Cash")
                MessageBox.Show("Please Put the Money in coins slot");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Put the Pump in the Container");

        }

        private void FuelPump_Load_1(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToLongDateString();
        }

        
    }
}
