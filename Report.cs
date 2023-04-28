using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using COVID_19_DIAGNOSTIC_SYSTEM.connection;
using System.Data.SqlClient;

namespace COVID_19_DIAGNOSTIC_SYSTEM
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string Unique_ID = login.getEmail;
           
                System.Drawing.Printing.PageSettings pg = new PageSettings();
                pg.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
                pg.PaperSize = new PaperSize("A4", 827, 1169);
                pg.PaperSize.RawKind = (int)PaperKind.A4;
                //Refreshing Report
                this.reportViewer1.SetPageSettings(pg);

                this.reportViewer1.RefreshReport();

                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            // load up report

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD9VL65;Initial Catalog=covid19_db;Integrated Security=True");
            con.Open();
            string mySQL1 = string.Empty;
            string mySQL2 = string.Empty;
            string mySQL3 = string.Empty;
            mySQL1 = "SELECT * FROM patient_tab WHERE email_id = '"+ Unique_ID +"'";
            mySQL2 = "SELECT * FROM symptom_diagnosis WHERE email_id = '" + Unique_ID + "'";
            mySQL3 = "SELECT * FROM absent_symptoms WHERE email_id = '" + Unique_ID + "'";

            SqlCommand cmd = new SqlCommand(mySQL1, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            SqlCommand cmd2 = new SqlCommand(mySQL2, con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            SqlCommand cmd3 = new SqlCommand(mySQL3, con);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportDataSource rds2 = new ReportDataSource("DataSet2", dt2);
            ReportDataSource rds3 = new ReportDataSource("DataSet3", dt3);

            reportViewer1.LocalReport.ReportPath = @"C:\Users\Dell\Documents\Visual Studio 2015\Projects\COVID 19 DIAGNOSTIC SYSTEM\COVID 19 DIAGNOSTIC SYSTEM\Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds2);
            reportViewer1.LocalReport.DataSources.Add(rds3);
            reportViewer1.RefreshReport();

                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

         
        }
    }
}
