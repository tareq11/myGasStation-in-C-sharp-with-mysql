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
    public partial class PaymentApproving : Form
    {
        string kind, paymentType;
        float amount;
        public PaymentApproving(float amount, string kind, string paymentType, float cost)
        {
            InitializeComponent();
            this.amount = amount;
            this.kind = kind;
            this.paymentType = paymentType;
            if (kind == "fue")
            {
                label1.Text = "for the requested price of fuel "+ cost.ToString() + " NIS the fuel amount is: " + amount.ToString() + "\n payment method is: "+ paymentType;

            }
            else
            {
                label1.Text = "for the requested price of gas " + cost.ToString() + " NIS the fuel amount is: " + amount.ToString() + "\n payment method is: " + paymentType ; 

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainpage mp =new Mainpage();
            mp.Show();
            this.Close();
        }
    }
}
