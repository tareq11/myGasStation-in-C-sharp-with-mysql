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
    public partial class VIPCustomer : Form
    {
      
        public string strSQL;


        public VIPCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done!!");
            this.Hide();
            Mainpage m = new Mainpage();
            m.Show();
        }

        private void VIPCustomer_Load(object sender, EventArgs e)
        {
            strSQL = "select distinct FullName,Address,PhoneNum,Email,MemberId from tblCustomer inner join tblRefeul on tblCustomer.licenseNum=tblRefeul.licenseNum where tblRefeul.date1 >= DATEADD(MONTH, -4, GETDATE()) and tblCustomer.licenseNum in (SELECT licenseNum  FROM tblRefeul GROUP BY  month(tblRefeul.date1),licenseNum HAVING COUNT(licenseNum) > 2);";
            ClientDA sqlCmd = new ClientDA(strSQL);
           dgClient.DataSource = sqlCmd.datatable();   
        }

        private void dgClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
