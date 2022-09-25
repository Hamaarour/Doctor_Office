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

namespace Final_Form_Doctor_s_Office.Forms.UC_Forms
{
    public partial class UC_RendezVous : UserControl
    {
        public UC_RendezVous()
        {
            InitializeComponent();
        }
        void remplirDGV() // remplissage de la liste
        {
            Dgv_rendezVous.Rows.Clear();
            foreach (DataRow dr in Classes.GG.ds.Visite.Rows)
            {
                if ((bool)dr[4] == true)
                {
                    if (Convert.ToDateTime(dr[2]).Date == DateTime.Now.Date)
                    {
                        foreach (DataRow dr2 in Classes.GG.ds.Patient.Select("CIN_Patient='" + dr[1] + "'"))
                        {

                            Dgv_rendezVous.Rows.Add(dr[0], dr2[1], dr2[2], (DateTime.Now.Year - Convert.ToDateTime(dr2[6]).Year), Convert.ToDateTime(dr[5]).ToShortTimeString(),dr2[0]);
                        }
                    }
                }

            }
        }
        private void UC_RendezVous_Load(object sender, EventArgs e)
        {
            Classes.GG.charge();
            remplirDGV();
            toolTip_refreche.SetToolTip(btn_refresh_p, "Actualiser la page ");
        }
        private void tb_prix_KeyPress(object sender, KeyPressEventArgs e) // nombre seulement
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        void ajouterOrdonnance(int idVisite) // methode d'ajouter ordonnance 
        {
            Classes.GG.charge();
            DataRow ligne = Classes.GG.ds.Ordonnance.NewRow();
            ligne[1] = idVisite;
            Classes.GG.ds.Ordonnance.Rows.Add(ligne);
            Classes.GG.d_ordonnance.Update(Classes.GG.ds.Ordonnance);
        }
        private void btn_refresh_p_Click(object sender, EventArgs e) // button refresh
        {
            dtp_rendezVous.Value = DateTime.Now;
            remplirDGV();
        }
        private void Dgv_rendezVous_DoubleClick(object sender, EventArgs e)
        {
        }
        private void dtp_rendezVous_ValueChanged(object sender, EventArgs e)
        {
            Dgv_rendezVous.Rows.Clear();
            foreach (DataRow dr in Classes.GG.ds.Visite.Rows)
            {
                if ((bool)dr[4] == true)
                {
                    if (Convert.ToDateTime(dr[2]).Date == dtp_rendezVous.Value.Date)
                    {
                        foreach (DataRow dr2 in Classes.GG.ds.Patient.Select("CIN_Patient='" + dr[1] + "'"))
                        {
                            Dgv_rendezVous.Rows.Add(dr[0], dr2[1], dr2[2], (DateTime.Now.Year - Convert.ToDateTime(dr2[6]).Year), Convert.ToDateTime(dr[5]).ToShortTimeString());
                        }
                    }
                }
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (tb_prix.Text == "")
            {
                MessageBox.Show("Merci de donnee le prix !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Classes.GG.charge();
                foreach (DataRow dr in Classes.GG.ds.Visite.Select("ID_visite='" + Classes.GG.Visiteid + "'"))
                {
                    dr[3] = double.Parse(tb_prix.Text);
                    dr[4] = false;
                    Classes.GG.d_visite.Update(Classes.GG.ds.Visite);
                }
                MessageBox.Show("Félicitation visite est ajouté avec succès", "Opération effectuée avec succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Classes.GG.charge();
                ajouterOrdonnance(Classes.GG.Visiteid);
                Classes.GG.charge();
                OleDbDataAdapter d_ordonnance = new OleDbDataAdapter("select top 1 ID_ordonnance from Ordonnance ORDER BY ID_ordonnance desc", Classes.GG.cnx);
                d_ordonnance.Fill(Classes.GG.ds, "id_ordonnance");
                DataRow d = Classes.GG.ds.Tables["id_ordonnance"].Rows[0];
                Classes.GG.Ordonnanceid = int.Parse(d[0].ToString());
                Forms.Form_Ajouter_Ordonnance ao = new Form_Ajouter_Ordonnance();
                ao.Show();
                remplirDGV();
                tb_prix.Text = null;
            }
        }
        private void btn_refresh_p_Click_1(object sender, EventArgs e)
        {
            
            dtp_rendezVous.Value = DateTime.Now;
            remplirDGV();
        }
        private void Dgv_rendezVous_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int j = Dgv_rendezVous.CurrentCell.RowIndex;
            Classes.GG.Patientid = Dgv_rendezVous.Rows[j].Cells[5].Value.ToString();
            if (Dgv_rendezVous.Columns[e.ColumnIndex].Name == "Ajouter_visite") // button sur DGV pour supprimer un patient
            {
                panel_visite.Visible = true;
                Classes.GG.Visiteid = int.Parse(Dgv_rendezVous.Rows[j].Cells[0].Value.ToString());
            }
        }

        private void Dgv_rendezVous_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == this.Dgv_rendezVous.Columns["Ajouter_visite"].Index) && e.Value != null)
            {
                DataGridViewCell cell = this.Dgv_rendezVous.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Ajouter viste au patient choisie depuis la liste .";
            }
        }

        private void tb_recherche_TextChanged(object sender, EventArgs e)
        {
            Dgv_rendezVous.Rows.Clear();

            foreach (DataRow dr2 in Classes.GG.ds.Patient.Select("CIN_patient like'" + tb_recherche.Text + "%' or Nom like'" + tb_recherche.Text + "%' or Prenom like'" + tb_recherche.Text + "%'"))
            {
                foreach (DataRow dr in Classes.GG.ds.Visite.Select("CIN_patient='" + dr2[0] + "'"))
                {
                    if ((bool)dr[4] == true && Convert.ToDateTime(dr[2]).Date == dtp_rendezVous.Value.Date)
                    {
                        Dgv_rendezVous.Rows.Add(dr[0], dr2[1], dr2[2], (DateTime.Now.Year - Convert.ToDateTime(dr2[6]).Year), Convert.ToDateTime(dr[5]).ToShortTimeString(), dr2[0]);
                    }
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_cinn_Click(object sender, EventArgs e)
        {

        }
    }
}
