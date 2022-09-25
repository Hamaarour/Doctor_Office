using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Windows.Forms;

namespace Final_Form_Doctor_s_Office
{
    public partial class Form_Imprimer : Form
    {
        public Form_Imprimer()
        {
            InitializeComponent();
        }

        private void Form_Imprimer_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cnx = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\My Projet\C# projet\Gestion cabinet\Gestion Cabinet v1.9\our project\base de donee\Database_cabinet.accdb");
                OleDbDataAdapter d_m = new OleDbDataAdapter("select * from Medicament_Patient where ID_ordonnance ="+Classes.GG.Ordonnanceid+"", cnx);
                OleDbDataAdapter d_pa = new OleDbDataAdapter("select * from Patient where CIN_Patient ='" + Classes.GG.Patientid + "'", cnx);
                Data.Dataset_report dss = new Data.Dataset_report();
                d_m.Fill(dss.Medicament_Patient);
                d_pa.Fill(dss.Patient);
                Impimer_ordonnance.Ordonnance or = new Impimer_ordonnance.Ordonnance();
                or.SetDataSource(dss);
                crystalReportViewer1.ReportSource = or;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("error "+ ex.Message);
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
