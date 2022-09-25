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
    public partial class UC_Patient_Nv_Visite : UserControl
    {
        public UC_Patient_Nv_Visite()
        {
            InitializeComponent();
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
        void ajout_Visite(string cin, double prix, DateTime d) // methode ajouter visite
        {
            DataRow ligne = Classes.GG.ds.Visite.NewRow();
            ligne[1] = cin;
            ligne[2] = d;
            ligne[3] = prix;
            ligne[4] = false;
            Classes.GG.ds.Visite.Rows.Add(ligne);
            Classes.GG.d_visite.Update(Classes.GG.ds.Visite);
        }
        void ajouterOrdonnance(int idVisite) // methode d'ajouter ordonnance 
        {
            DataRow ligne = Classes.GG.ds.Ordonnance.NewRow();
            ligne[1] = idVisite;
            Classes.GG.ds.Ordonnance.Rows.Add(ligne);
            Classes.GG.d_ordonnance.Update(Classes.GG.ds.Ordonnance);
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (tb_prix.Text == "")
                MessageBox.Show("Merci de donnee le prix !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                ajout_Visite(Classes.GG.Patientid, Convert.ToDouble(tb_prix.Text), dtp_visite.Value);
                MessageBox.Show("Félicitation visite est ajoutée avec succès", "Opération effectuée avec succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Classes.GG.charge();
                tb_prix.Text = null;
                dtp_visite.Value = DateTime.Now;
                OleDbDataAdapter d_visitee = new OleDbDataAdapter("select top 1 ID_visite from Visite ORDER BY ID_visite desc", Classes.GG.cnx);
                OleDbCommandBuilder cmd_visite = new OleDbCommandBuilder(d_visitee);
                d_visitee.Fill(Classes.GG.ds, "id_visite");
                DataRow d = Classes.GG.ds.Tables["id_visite"].Rows[0];
                Classes.GG.Visiteid = int.Parse(d[0].ToString());
                Classes.GG.ds.Tables["id_visite"].Clear();
                ////////////////////////////////////
                ajouterOrdonnance(Classes.GG.Visiteid);
                OleDbDataAdapter d_ordonnance = new OleDbDataAdapter("select top 1 ID_ordonnance from Ordonnance ORDER BY ID_ordonnance desc", Classes.GG.cnx);
                d_ordonnance.Fill(Classes.GG.ds, "id_ordonnance");
                DataRow dd = Classes.GG.ds.Tables["id_ordonnance"].Rows[0];
                Classes.GG.Ordonnanceid = int.Parse(dd[0].ToString());
                Classes.GG.ds.Tables["id_ordonnance"].Clear();
                Form_Ajouter_Ordonnance ao = new Form_Ajouter_Ordonnance();
                ao.Show();
            }
        }
        private void UC_Patient_Nv_Visite_Load(object sender, EventArgs e)
        {
            Classes.GG.charge();
        }
    }
}
