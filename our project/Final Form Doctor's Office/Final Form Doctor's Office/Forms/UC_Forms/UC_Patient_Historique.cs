using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Form_Doctor_s_Office.Forms.UC_Forms
{
    public partial class UC_Patient_Historique : UserControl
    {
        public UC_Patient_Historique()
        {
            InitializeComponent();
        }
        public int j;
        public DateTime d;
        private void Dgv_Patient_visite_CellContentClick(object sender, DataGridViewCellEventArgs e) // content click
        {
            j = Dgv_Patient_visite.CurrentCell.RowIndex;
            d = Convert.ToDateTime(Dgv_Patient_visite.Rows[j].Cells[0].Value.ToString());
            foreach (DataRow dr in Classes.GG.ds.Visite.Rows)
            {
                if (dr[2].ToString() == d.ToString())
                {
                    Classes.GG.Visiteid = int.Parse(dr[0].ToString());
                }
            }
            Dgv_intitule.Rows.Clear();
            foreach (DataRow dr in Classes.GG.ds.Ordonnance.Select("ID_visite='" + Classes.GG.Visiteid + "'"))
            {
                foreach (DataRow dr2 in Classes.GG.ds.Medicament_Patient.Select("ID_ordonnance='" + dr[0] + "'"))
                {
                    Classes.GG.Ordonnanceid = int.Parse(dr2[0].ToString());
                    foreach (DataRow dr3 in Classes.GG.ds.Medicaments.Select("ID_medicament='" + dr2[1] + "'"))
                    {
                        Dgv_intitule.Rows.Add(dr3[1].ToString());
                    }
                }

            }
        }
        private void Dgv_Patient_visite_DoubleClick(object sender, EventArgs e)
        {
            j = Dgv_Patient_visite.CurrentCell.RowIndex;
            d = Convert.ToDateTime(Dgv_Patient_visite.Rows[j].Cells[0].Value.ToString());
            
        }

        private void UC_Patient_Historique_Load(object sender, EventArgs e)
        {
            Classes.GG.charge();
            foreach (DataRow dr in Classes.GG.ds.Visite.Select("Cin_patient='" + Classes.GG.Patientid + "'")) // remplissage de la liste des visites
                Dgv_Patient_visite.Rows.Add(dr[2]);
        }

        private void btn_refresh_p_Click(object sender, EventArgs e)
        {
            Classes.GG.charge();
            foreach (DataRow dr in Classes.GG.ds.Visite.Select("Cin_patient='" + Classes.GG.Patientid + "'")) // remplissage de la liste des visites
                Dgv_Patient_visite.Rows.Add(dr[2]);
        }

        private void btn_imprimer_ordonnance_Click(object sender, EventArgs e)
        {
            Form_Imprimer fi = new Form_Imprimer();
            fi.Show();
        }
    }
}
