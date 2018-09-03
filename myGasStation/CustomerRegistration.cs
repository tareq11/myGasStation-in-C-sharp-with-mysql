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
    public partial class CustomerRegistration : Form
    {

        public string strSQL;

        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text == "" || idTxtBox.Text == "" || addressTxtBox.Text == "" || phoneTxtBox.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else
            {
               try
                {
               // strSQL = " INSERT INTO tblCustomer (CustomerId, FullName, Address, PhoneNum, Email) VALUES ("+Int32.Parse(idTxtBox.Text)+","+"'"+nameTxtBox.Text+"'"+","+"'"+ addressTxtBox.Text+"'"+"," +Int32.Parse(phoneTxtBox.Text)+"," +"'"+emailTxtBox.Text+"'"+")";
                //ClientDA sqlCmd = new ClientDA(strSQL);
  
               Client objectClient = new Client(idTxtBox.Text,
                        nameTxtBox.Text, addressTxtBox.Text,
                        Int32.Parse(phoneTxtBox.Text), emailTxtBox.Text);
                    ClientDA.insertEntity(objectClient);
                    MessageBox.Show("Registration is successfull");
                    this.Hide();
                    Card card = new Card(objectClient);
                    card.ShowDialog();
                    Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("Please make sure you entered an appropirate values");
                }
            }

        }
        void Clear() {
            idTxtBox.Text = nameTxtBox.Text = addressTxtBox.Text = phoneTxtBox.Text = "";

        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainpage f1 = new Mainpage();

            f1.Show();

            this.Close();
        }
    }
}
