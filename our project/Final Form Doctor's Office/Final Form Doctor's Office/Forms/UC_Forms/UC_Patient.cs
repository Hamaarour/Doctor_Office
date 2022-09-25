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
    public partial class UC_Patient : UserControl
    {
        public UC_Patient()
        {
            InitializeComponent();
        }
        //
        // -----------  Code mise en page  ---------------------- 
        //
        private void UC_Patient_ClientSizeChanged(object sender, EventArgs e)
        {
            panel_ajouter_patient.Top = (panel_Full_Form_Patient.Height - panel_ajouter_patient.Height) / 3;
            panel_ajouter_patient.Left = (panel_Full_Form_Patient.Width - panel_ajouter_patient.Width) / 2;
        }
        //
        // -----------  Code programming  ---------------------- 
        //
        private void chargerdata() // Remplir DataGridView 
        {
            Dgv_Patient.Rows.Clear();
            int i = 0;
            foreach (DataRow dr in Classes.GG.ds.Patient.Rows)
            {
                Dgv_Patient.AllowUserToAddRows = true;
                DataGridViewRow row = (DataGridViewRow)Dgv_Patient.Rows[i].Clone();
                row.Cells[1].Value = dr[0].ToString();
                row.Cells[2].Value = dr[1].ToString();
                row.Cells[3].Value = dr[2].ToString();
                row.Cells[4].Value = dr[3].ToString();
                row.Cells[5].Value = dr[4].ToString();
                Dgv_Patient.Rows.Add(row);
                i++;
            }
            Dgv_Patient.AllowUserToAddRows = false;
        }
        private void UC_Patient_Load(object sender, EventArgs e)
        {
            Classes.GG.charge(); // Remplir DataSet 
            // Code de design 
            panel_ajouter_patient.Visible = false;
            panel2.Dock = DockStyle.Fill;
            // Remplir ComboBox du villes 
            foreach (DataRow dr in Classes.GG.ds.Villes.Rows)
            {
                cb_ville.Items.Add(dr[1]);
            }
            chargerdata(); // Remplir DataGridView 
            toolTipAjouterPa.SetToolTip(btn_to_ajouter_patient, "Ajouter nouveau patient.");
            toolTipMineur.SetToolTip(checkBox_enfant, "Si le patient mineur.");
            toolTipTbRecherche.SetToolTip(tb_recherche, "Recherche par CIN, nom ou prenom .");
            toolTip_refesh.SetToolTip(bt_refresh, "Actualiser la page ");
            toolTip_refesh.SetToolTip(btn_refresh_p, "Actualiser la page ");



        }
        private void tb_recherche_TextChanged(object sender, EventArgs e)
        {
            Dgv_Patient.Rows.Clear();
            int i = 0;
            foreach (DataRow dr in Classes.GG.ds.Patient.Select("CIN_patient like'" + tb_recherche.Text + "%' or Nom like'" + tb_recherche.Text + "%' or Prenom like'" + tb_recherche.Text + "%'"))
            {
                Dgv_Patient.AllowUserToAddRows = true;
                DataGridViewRow row = (DataGridViewRow)Dgv_Patient.Rows[i].Clone();
                row.Cells[1].Value = dr[0].ToString();
                row.Cells[2].Value = dr[1].ToString();
                row.Cells[3].Value = dr[2].ToString();
                row.Cells[4].Value = dr[3].ToString();
                row.Cells[5].Value = dr[4].ToString();
                Dgv_Patient.Rows.Add(row);
                i++;
                Dgv_Patient.AllowUserToAddRows = false;
            }
        }
        private void SuppPatient(string ele) // Methode pour supprimer un patient
        {
            DialogResult dre = MessageBox.Show("Voulez-vous vraiment supprimer ce patient ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dre == DialogResult.Yes)
            {
                foreach (DataRow dr in Classes.GG.ds.Patient.Select("CIN_Patient='" + ele + "'"))
                {
                    dr.Delete();
                    Classes.GG.d_patient.Update(Classes.GG.ds.Patient);
                }
                MessageBox.Show("Félicitation patient est supprimé avec succès", "Opération effectuée avec succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Dgv_Patient_CellContentClick(object sender, DataGridViewCellEventArgs e)  // cell content click sur DGV
        {
            int j = Dgv_Patient.CurrentCell.RowIndex;
            Classes.GG.Patientid = Dgv_Patient.Rows[j].Cells[1].Value.ToString();
            if (Dgv_Patient.Columns[e.ColumnIndex].Name == "Supprimer") // button sur DGV pour supprimer un patient
            {
                SuppPatient(Classes.GG.Patientid);
                chargerdata();
            }
            if (Dgv_Patient.Columns[e.ColumnIndex].Name == "AjouterRDV") // button sur DGV pour ajouter un Rendez-Vous
            {
                Forms.Form_Ajouter_Rendez_Vous aRDV = new Form_Ajouter_Rendez_Vous();
                aRDV.Show();
            }
            if (Dgv_Patient.Columns[e.ColumnIndex].Name == "details")
            {
                Forms.Mini_menu_patient fd = new Mini_menu_patient();
                fd.Show();
            }
        }
        private void Dgv_Patient_CellClick(object sender, DataGridViewCellEventArgs e) // cell click sur DGV
        {
            int j = Dgv_Patient.CurrentCell.RowIndex;
            Classes.GG.Patientid = Dgv_Patient.Rows[j].Cells[1].Value.ToString();
        }
        private void bt_refresh_Click(object sender, EventArgs e)// Button Refresh
        {
            tb_recherche.Text = null;
            chargerdata();
        }
        private void bt_info_Click(object sender, EventArgs e) // Button des infos de la page 
        {
            Forms.Form_info_patient inf = new Form_info_patient();
            inf.ShowDialog();
        }
        private void btn_to_ajouter_patient_Click(object sender, EventArgs e)// Button pour afficher la page pour ajouter un nouveau patient
        {
            panel2.Visible = false;
            panel_ajouter_patient.Visible = true;
        }
        private void Btn_retour_Click(object sender, EventArgs e)// button retour
        {
            panel_ajouter_patient.Visible = false;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;
        }
        void patient(DataRow ligne) // Methode d'ajouter patient
        {
            ligne[0] = tb_CIN.Text;
            ligne[1] = tb_nom.Text.ToUpper();
            ligne[2] = tb_prenom.Text.ToUpper();
            ligne[3] = cb_ville.Text;
            ligne[4] = tb_adresse.Text;
            ligne[5] = tb_telephone.Text;
            ligne[6] = dtp_naissance.Value;
            if (checkBox_enfant.Checked)
            {
                ligne[7] = true;
                ligne[8] = tb_nomResponsable.Text;
                ligne[9] = tb_prenomResponsable.Text;
            }
            else
            {
                ligne[7] = false;
                ligne[8] = null;
                ligne[9] = null;
            }
        }
        void vider() // Methode de vider les champs 
        {
            tb_CIN.Text = null;
            tb_nom.Text = null;
            tb_prenom.Text = null;
            tb_telephone.Text = null;
            cb_ville.Text = null;
            tb_adresse.Text = null;
            tb_telephone.Text = null;
            dtp_naissance.Value = DateTime.Now;
            tb_nomResponsable.Text = null;
            tb_prenomResponsable.Text = null;
        }

        private void Btn_Ajouter_Patient_Click(object sender, EventArgs e) // Button Ajouter Nouveau patient
        {
            if (tb_CIN.Text == "")
            {
                MessageBox.Show("Merci de remplir le champs obligatoir", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                label8.Visible = true;
            }
            else
            {
                try
                {
                    DataRow ligne = Classes.GG.ds.Patient.NewRow();
                    patient(ligne);
                    Classes.GG.ds.Patient.Rows.Add(ligne);
                    Classes.GG.d_patient.Update(Classes.GG.ds.Patient);
                    MessageBox.Show("Félicitation patient est ajouté avec succès", "Opération effectuée avec succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    vider();
                    chargerdata();
                }
                catch (Exception)
                {
                    MessageBox.Show("Patient existe deja", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void checkBox_enfant_CheckedChanged(object sender, EventArgs e) // checkBox pour savoir si le patient mineur ou adulte
        {
            if (checkBox_enfant.Checked)
            {
                groupBox1.Visible = true;
                label_Cin.Text = "CIN de Responsable *";
                label_Telephone.Text = "Telephone de Responsatble";
                label7.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                label_Cin.Text = "CIN ";
                label_Telephone.Text = "Telephone ";
                label7.Location = new Point(139, 43);
                label7.Visible = true;
            }
        }
        private void btn_refresh_p_Click(object sender, EventArgs e)// Button Refresh
        {
            vider();
        }
        private void btn_info_p_Click(object sender, EventArgs e)// Button des infos de la page
        {
            Forms.Forms_dialog.Form_info_ajouter_patient ajp = new Forms_dialog.Form_info_ajouter_patient();
            ajp.ShowDialog();
        }
        private void tb_nom_KeyPress(object sender, KeyPressEventArgs e) // only alphabetic
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-' && (e.KeyChar != ' ')))
            {
                e.Handled = true;
            }
        }
        private void tb_prenom_KeyPress(object sender, KeyPressEventArgs e) // only alphabetic
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-' && (e.KeyChar != ' ')))
            {
                e.Handled = true;
            }
        }
        private void tb_nomResponsable_KeyPress(object sender, KeyPressEventArgs e)// only alphabetic
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-' && (e.KeyChar != ' ')))
            {
                e.Handled = true;
            }
        }
        private void tb_prenomResponsable_KeyPress(object sender, KeyPressEventArgs e)// only alphabetic
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-' && (e.KeyChar != ' ')))
            {
                e.Handled = true;
            }
        }
        private void Dgv_Patient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == this.Dgv_Patient.Columns["details"].Index) && e.Value != null)
            {
                DataGridViewCell cell = this.Dgv_Patient.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Details du patient choisie depuis la liste.\nHistorique des visites patient choisie depuis la liste.\n Ajouter visite au patient choisie depuis la liste.\n";
            }
            else if ((e.ColumnIndex == this.Dgv_Patient.Columns["AjouterRDV"].Index) && e.Value != null)
            {
                DataGridViewCell cell = this.Dgv_Patient.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Ajouter Rendez-vous au patient choisie depuis la liste.";
            }
            else if((e.ColumnIndex == this.Dgv_Patient.Columns["supprimer"].Index) && e.Value != null)
            {
                DataGridViewCell cell = this.Dgv_Patient.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Suppprimer patient choisie depuis la liste.";
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
