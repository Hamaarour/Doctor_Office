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
    public partial class UC_Medicament : UserControl
    {
        public UC_Medicament()
        {
            InitializeComponent();
        }

        private void UC_Medicament_Load(object sender, EventArgs e)
        {
            Classes.GG.charge();
            foreach (DataRow dr in Classes.GG.ds.Medicaments.Rows) // remplissage de la liste
                Dgv_medicament.Rows.Add(dr[0], dr[1], dr[2].ToString());
            foreach (string s in Classes.TypeMedicaments.liste_type) // remplissage de type de medicaments
                cb_typeMedicaments.Items.Add(s);
            toolTip_refreche.SetToolTip(btn_refresh_p, "Actualiser la page ");
        }
        private void btn_refresh_p_Click(object sender, EventArgs e) // button refresh
        {
            tb_intitule.Text = null;
            cb_typeMedicaments.Text = null;
        }
        private void btn_ajouter_medicament_Click(object sender, EventArgs e) // button ajouter medicament
        {
            DataRow ligne = Classes.GG.ds.Medicaments.NewRow();
            ligne[1] = tb_intitule.Text;
            ligne[2] = cb_typeMedicaments.Text;
            Classes.GG.ds.Medicaments.Rows.Add(ligne);
            Classes.GG.d_medicament.Update(Classes.GG.ds.Medicaments);
            MessageBox.Show("Félicitation Medicament est ajouté avec succès", "Opération effectuée avec succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel_full_form_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
