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
    public partial class Card : Form
    {
        public string name;
        public string id;
        public string address;
        public Int32 phoneNum;
        public string Email;
        public Card()
        {
            InitializeComponent();
        }
       
        /*
         *  constructor : take the params from client taht he recieved an insert them to card show
         */
        public Card(Client objectClient)
        {
            //somthing wrong in the name 
            this.showName.Text = objectClient.Name;
            this.showAddress.Text = objectClient.Address;
            this.showEmail.Text = objectClient.Email;
            this.showPhone.Text = Convert.ToString(objectClient.Phone);
            this.showID.Text = Convert.ToString(objectClient.ID);
            
        }

        private void Card_Load(object sender, EventArgs e)
        {
            
        }
    }
}
