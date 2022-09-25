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
    public partial class UC_Patient_details : UserControl
    {
        public UC_Patient_details()
        {
            InitializeComponent();
        }

        private void Btn_modifier_Click(object sender, EventArgs e)
        {
            bt_enregistrer_mofication.Visible = true;
            tb_adresse.Enabled = true;
            tb_CIN.Enabled = true;
            tb_nom.Enabled = true;
            tb_prenom.Enabled = true;
            tb_telephone.Enabled = true;
            dtp_naissance.Enabled = true;
            cb_ville.Enabled = true;
            tb_nomResponsable.Enabled = true;
            tb_prenomResponsable.Enabled = true;
            label7.Visible = false;
        }
        void patient(DataRow ligne) // methode pour modifier patient
        {
            ligne[0] = tb_CIN.Text;
            ligne[1] = tb_nom.Text;
            ligne[2] = tb_prenom.Text;
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
        private void bt_enregistrer_mofication_Click(object sender, EventArgs e)
        {
            DialogResult dre = MessageBox.Show("Voulez-vous vraiment modifié ce patient ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dre == DialogResult.Yes)
            {
                if (tb_CIN.Text == "")
                {
                    MessageBox.Show("Le CIN ne doit pas etre null!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    foreach (DataRow dr in Classes.GG.ds.Patient.Select("Cin_patient='" + tb_CIN.Text + "'"))
                    {
                        patient(dr);
                    }
                    Classes.GG.d_patient.Update(Classes.GG.ds.Patient);
                    MessageBox.Show("Félicitation patient est modifié avec succès", "Opération effectuée avec succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            bt_enregistrer_mofication.Visible = false;
            tb_adresse.Enabled = false;
            tb_CIN.Enabled = false;
            tb_nom.Enabled = false;
            tb_prenom.Enabled = false;
            tb_telephone.Enabled = false;
            dtp_naissance.Enabled = false;
            cb_ville.Enabled = false;
            tb_nomResponsable.Enabled = false;
            tb_prenomResponsable.Enabled = false;
            label7.Visible = true;
        }
        private void tb_nom_KeyPress(object sender, KeyPressEventArgs e) // alphabetique seulement
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-' && (e.KeyChar != ' ')))
            {
                e.Handled = true;
            }
        }
        private void tb_prenom_KeyPress(object sender, KeyPressEventArgs e)// alphabetique seulement
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-' && (e.KeyChar != ' ')))
            {
                e.Handled = true;
            }
        }
        private void tb_nomResponsable_KeyPress(object sender, KeyPressEventArgs e)// alphabetique seulement
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-' && (e.KeyChar != ' ')))
            {
                e.Handled = true;
            }
        }
        private void tb_prenomResponsable_KeyPress(object sender, KeyPressEventArgs e)// alphabetique seulement
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-' && (e.KeyChar != ' ')))
            {
                e.Handled = true;
            }
        }
        void details() // methode du detail
        {
            foreach (DataRow dr in Classes.GG.ds.Patient.Select("CIN_patient='" + Classes.GG.Patientid + "'"))
            {
                if ((bool)dr[7] == true)
                {
                    groupBox1.Visible = true;
                    checkBox_enfant.Checked = true;
                }
                else
                {
                    groupBox1.Visible = false;
                    checkBox_enfant.Checked = false;
                }
            }
        }
        private void UC_Patient_details_Load(object sender, EventArgs e)
        {
            details();
            Classes.GG.charge();
            foreach (DataRow dr in Classes.GG.ds.Patient.Select("Cin_patient='" + Classes.GG.Patientid + "'")) // information du patient selectione
            {
                tb_CIN.Text = dr[0].ToString();
                tb_nom.Text = dr[1].ToString();
                tb_prenom.Text = dr[2].ToString();
                cb_ville.Text = dr[3].ToString();
                tb_adresse.Text = dr[4].ToString();
                tb_telephone.Text = dr[5].ToString();
                dtp_naissance.Value = Convert.ToDateTime(dr[6]);
                tb_nomResponsable.Text = dr[8].ToString();
                tb_prenomResponsable.Text = dr[9].ToString();
                if ((bool)dr[7] == true)
                    checkBox_enfant.Checked = true;
                else
                    checkBox_enfant.Checked = false;
            }
            foreach (DataRow dr2 in Classes.GG.ds.Villes.Rows)
                cb_ville.Items.Add(dr2[1]);
        }
    }
}
