using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                OleDbConnection cnx = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Hicham Amaarour\Desktop\our project (1)\our project\Final Form Doctor's Office\Final Form Doctor's Office\Database_cabinet.accdb"); 
                OleDbDataAdapter d_m = new OleDbDataAdapter("select * from Medicament_Patient where ID_ordonnance ="+Classes.GG.Ordonnanceid+"", cnx);
                OleDbDataAdapter d_pa = new OleDbDataAdapter("select * from Patient where CIN_Patient ='" + Classes.GG.Patientid + "'", cnx);
                Data.Dataset_report dss = new Data.Dataset_report();
                d_m.Fill(dss.Medicament_Patient);
                d_pa.Fill(dss.Patient);
                foreach (DataRow dr in dss.Patient.Rows)
                    MessageBox.Show(dr[1].ToString() + dr[2].ToString());
                Impression.Ordonnance or = new Impression.Ordonnance();
                or.SetDataSource(dss);
                crystalReportViewer1.ReportSource = or;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("error "+ ex.Message);
            }
           
        }
    }
}
