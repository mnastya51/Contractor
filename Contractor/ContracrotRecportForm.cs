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
using CrystalDecisions.CrystalReports.Engine;

namespace Contractor
{
    public partial class ContracrotRecportForm : Form
    {
        public string connectionstring;
        public ContracrotRecportForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            connectionstring = @"Data Source=.\SQLEXPRESS; Initial Catalog = D:\НАСТЯ\ДИПЛОМ\ACCOUNT_GRAIN.MDF; Integrated Security = True";
            SqlConnection connect = new SqlConnection(connectionstring);
            connect.Open(); 
            string s = string.Format("Select * From Сontractor"); 
            SqlDataAdapter da = new SqlDataAdapter(s, connect); 
            Account_grainDataSet ds = new Account_grainDataSet();
            da.Fill(ds, "Сontractor");
            ReportDocument doc = new ReportDocument(); 
            doc.Load("ReportContractor.rpt"); 
            doc.SetDataSource(ds); 
            crystalReportViewer1.ReportSource = doc;
        }
    }
}
