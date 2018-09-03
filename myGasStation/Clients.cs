using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
/*
 * Clients class : for every new customer that register in the station 
 * build a new object of client 
 * all the param have specifie name 
 */        
namespace myGasStation
{
    public class Client
    {
        string CustomerId;
        string name;
        string address;
        int phone;
        string email;

        public Client(string ClientID, string ClinetName, string ClientAddress, int ClientPhone, string ClientEmail)
        {
            this.CustomerId = ClientID;
            this.name = ClinetName;
            this.address = ClientAddress;
            this.phone = ClientPhone;
            this.email = ClientEmail;

        }
        public string ID { get { return CustomerId; }
            private set { } }
        public string Name { get { return name; }
            private set { }
        }
        public string Address
        {
            get { return address; }
            private set { }
        }
        public int Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Email
        {
            get { return email; }
            private set { }
        }



    }
         
}



