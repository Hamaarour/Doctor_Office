using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Form_Doctor_s_Office.Forms
{
    public partial class Form_Ajouter_Ordonnance : Form
    {
        public Form_Ajouter_Ordonnance()
        {
            InitializeComponent();
        }
        //
        // -----------  Code mise en page  ---------------------- 
        //
        //methods to move the forme from the panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel_title_bar_detailForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //
        // -----------  Code programming  ---------------------- 
        //
        private void Form_Ajouter_Ordonnance_Load(object sender, EventArgs e)
        {
            foreach (string s in Classes.TypeMedicaments.liste_type) //remplissage de type de medicaments 
                cb_typeMedicaments.Items.Add(s);
            Classes.GG.charge();
            remplir_DGV();
        }
        
        public int id_intitule; 
        public int j;
        private void Dgv_intitule_CellContentClick(object sender, DataGridViewCellEventArgs e) // content click
        {
            j = Dgv_intitule.CurrentCell.RowIndex; // l'indice de row selectione 
            id_intitule = int.Parse(Dgv_intitule.Rows[j].Cells[0].Value.ToString()); // element selectione
            if (Dgv_intitule.Columns[e.ColumnIndex].Name == "Supprimer") // button supprimer
            {
                DialogResult dre = MessageBox.Show("Voulez-vous vraiment supprimer ce patient ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dre == DialogResult.Yes)
                {
                    foreach (DataRow dr in Classes.GG.ds.Medicament_Patient.Select("ID_medicament ='" + id_intitule + "'"))
                    {
                        if (dr[0].ToString() == Classes.GG.Ordonnanceid.ToString())
                        {
                            dr.Delete();
                            Classes.GG.d_MO.Update(Classes.GG.ds.Medicament_Patient);
                        }
                    }
                    remplir_DGV();
                    MessageBox.Show("Félicitation medicament est supprimé avec succès", "Opération effectuée avec succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void Ajouter_medicamenet_ordonnance() // methode d'ajouter ordonnance 
        {
            try
            {
                DataRow ligne = Classes.GG.ds.Medicament_Patient.NewRow();
                ligne[0] = Classes.GG.Ordonnanceid;
                foreach (DataRow dr in Classes.GG.ds.Medicaments.Select("Intitulé ='" + cb_medicament.Text + "'"))
                {
                    ligne[1] = dr[0];
                    
                }
                ligne[2] = tb_posologie.Text;
                ligne[3] = cb_medicament.Text;
                Classes.GG.ds.Medicament_Patient.Rows.Add(ligne);
                Classes.GG.d_MO.Update(Classes.GG.ds.Medicament_Patient);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !" + ex.Message,"Erreur", MessageBoxButtons.OK, MessageBoxIcon.None) ;
            }
        }
        private void btn_ajouter_medicament_Click(object sender, EventArgs e) // button ajouter medicament et posologie dans la liste
        {
            if (cb_typeMedicaments.Text == "" || cb_medicament.Text == "" || tb_posologie.Text == "")
                MessageBox.Show("Merci de remplir tout les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                Ajouter_medicamenet_ordonnance();
                Classes.GG.charge();
                remplir_DGV();
            }
        }
        void remplir_DGV()
        {
            Dgv_intitule.Rows.Clear();

            foreach (DataRow dr in Classes.GG.ds.Medicament_Patient.Select("ID_ordonnance='" + Classes.GG.Ordonnanceid + "'"))
            {
                foreach (DataRow dr2 in Classes.GG.ds.Medicaments.Select("ID_medicament='" + dr[1] + "'"))
                {
                    Dgv_intitule.Rows.Add(dr2[0], dr2[1], dr[2]);
                }
            }           
        }
        private void btn_imprimer_ordonnance_Click(object sender, EventArgs e) // button imprimer 
        {
            Form_Imprimer fi = new Form_Imprimer();
            fi.Show();
        }
        private void btn_refresh_p_Click(object sender, EventArgs e) // button refresh
        {
            cb_medicament.Text = null;
            tb_posologie.Text = null;
        }
        private void cb_typeMedicaments_SelectedIndexChanged_1(object sender, EventArgs e) // comboBox selected 
        {
            cb_medicament.Items.Clear();
            foreach (DataRow dr in Classes.GG.ds.Medicaments.Rows) // remplissage du medicaments
            {
                if (dr[2].ToString() == cb_typeMedicaments.Text)
                    cb_medicament.Items.Add(dr[1]);
            }
        }
        private void btn_info_p_Click(object sender, EventArgs e) // button infos 
        {
            Forms.Forms_dialog.Form_info_ajouter_ordonnance ajouter_Ordonnance = new Forms_dialog.Form_info_ajouter_ordonnance();
            ajouter_Ordonnance.ShowDialog();
        }
        private void btn_Exit_Form_Click(object sender, EventArgs e) // buttom exite 
        {
            this.Hide();
        }
        private void Btn_retour_Click_1(object sender, EventArgs e) // button retour
        {
            this.Hide();
        }
    }
}
