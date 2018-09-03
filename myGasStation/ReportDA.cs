using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace myGasStation
{
    public partial class ReportDA : Form
    {
       public string strSQL;
        public ReportDA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textStationId.Text == null || textStationId.Text == "" || txtDate.Text == null || txtDate.Text == "" || txtTime.Text == null || txtTime.Text == "") MessageBox.Show("הנתונים לא מלאים");
            else
            {
                try
                {
                    //DateTime date11 = DateTime.ParseExact(txtDate.Text,
                      //               "MM-dd-yyyy");
                    //DateTime instance = DateTime.Parse(txtDate.Text);
                    strSQL = "select tblRefeul.StationId,StandId,[RefeulAmount(L)],date1,time1 from tblRefeul inner join tblShift on tblRefeul.StationId=tblShift.stationId where tblshift.StationId =" + textStationId.Text + " and time1 between tblShift.startTime and tblShift.EndTime and tblShift.startTime= " + "'"+txtTime.Text+"'"+ "and date1=" + "'"+txtDate.Text+"'";
                    ClientDA sqlCmd = new ClientDA(strSQL);
                    dgReport.DataSource = sqlCmd.datatable(); 

                
               }
                catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
                   
               }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage mainPage = new Mainpage();
            mainPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainpage per = new Mainpage();
            per.Show();
        }

        private void ReportDA_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Date format : dd/mm/yy");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Time format : hh:mm:ss");

        }
    }
}
