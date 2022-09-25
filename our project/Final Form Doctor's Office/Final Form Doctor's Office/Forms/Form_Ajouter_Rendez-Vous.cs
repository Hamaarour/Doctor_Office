using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Form_Doctor_s_Office.Forms
{
    public partial class Form_Ajouter_Rendez_Vous : Form
    {
        public Form_Ajouter_Rendez_Vous()
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
        private void Form_Ajouter_Rendez_Vous_Load(object sender, EventArgs e)
        {
            Classes.GG.charge();
        }
        private void panel_title_bar_ajouterRendezVous_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //
        // -----------  Code programming  ---------------------- 
        //
       
        void ajout_Visite_RDV(string cin, DateTime d, DateTime t) // methode d'ajouter rendez-vous
        {
            DataRow ligne = Classes.GG.ds.Visite.NewRow();
            ligne[1] = cin;
            ligne[2] = d;
            ligne[4] = true;
            ligne[5] = t;
            Classes.GG.ds.Visite.Rows.Add(ligne);
            Classes.GG.d_visite.Update(Classes.GG.ds.Visite);
        }
        private void btn_enregistrer_rendezVous_Click(object sender, EventArgs e) // button enregister 
        {
            ajout_Visite_RDV(Classes.GG.Patientid, dtp_rendezVous.Value, dtp_time.Value);
            MessageBox.Show("Félicitation visite est ajoutée avec succès", "Opération effectuée avec succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UC_Acceuil c = new UC_Acceuil();
            c.Show();
            this.Hide();

        }
        private void btn_Exit_Form_Click(object sender, EventArgs e) // button exit
        {
            this.Hide();
        } 
        private void Btn_retour_Click(object sender, EventArgs e) // button retour
        {
            this.Hide();
        }


    }
}
