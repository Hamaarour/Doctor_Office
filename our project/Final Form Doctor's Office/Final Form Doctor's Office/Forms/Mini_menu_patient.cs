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
    public partial class Mini_menu_patient : Form
    {
        public Mini_menu_patient()
        {
            InitializeComponent();
        }
       
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
        private void ActiveButtonsMenu(FontAwesome.Sharp.IconButton current)
        {
            btn_details_patient.BackColor = Color.FromArgb(55, 82, 163);
            btn_details_patient.IconColor = Color.White;
            btn_details_patient.ForeColor = Color.White;

            bt_ajouterNvVisite.BackColor = Color.FromArgb(55, 82, 163);
            bt_ajouterNvVisite.IconColor = Color.White;
            bt_ajouterNvVisite.ForeColor = Color.White;


            bt_HistoVisite.BackColor = Color.FromArgb(55, 82, 163);
            bt_HistoVisite.IconColor = Color.White;
            bt_HistoVisite.ForeColor = Color.White;

            current.BackColor = Color.FromArgb(227, 231, 211);
            current.IconColor = Color.FromArgb(55, 82, 163);
            current.ForeColor = Color.FromArgb(55, 82, 163);
            current.FlatAppearance.BorderColor= Color.FromArgb(55, 82, 163);
            current.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 229, 229);
        }
        private void Mini_menu_patient_Load(object sender, EventArgs e)
        {
            ActiveButtonsMenu(btn_details_patient);
            Classes.GG.charge();
        }
        private void btn_Exit_Form_Click(object sender, EventArgs e) // button exit
        {
            this.Hide();
        }
        private void bt_ajouterNvVisite_Click(object sender, EventArgs e) // button nv Visite
        {
            uC_Patient_Nv_Visite1.BringToFront();
            ActiveButtonsMenu(bt_ajouterNvVisite);
        }
        private void btn_details_patient_Click(object sender, EventArgs e) // button details patient
        {
            uC_Patient_details1.BringToFront();
            ActiveButtonsMenu(btn_details_patient);
        }
        private void bt_HistoVisite_Click(object sender, EventArgs e) // button historique visites du patient
        {
            uC_Patient_Historique1.BringToFront();
            ActiveButtonsMenu(bt_HistoVisite);
        }
    }
}
