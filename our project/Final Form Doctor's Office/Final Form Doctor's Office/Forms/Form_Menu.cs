using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final_Form_Doctor_s_Office
{
    public partial class Form_Menu : Form
    {
        //Fields
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.
                               //Since the form is resized because it takes into account the size of the title
                               //bar and borders.
        //constructor
        public Form_Menu()
        {
            InitializeComponent();
            collapseMenu();
            this.Padding = new Padding(borderSize);//border size
            this.BackColor = Color.FromArgb(25, 24, 32); //border color            
        }
        //methods to move the forme from the panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_tItle_bar_MouseDown(object sender, MouseEventArgs e)
        {
           ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized://Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal://Restored form (After)
                    if (this.Padding.Top != borderSize)
                    {
                        this.Padding = new Padding(borderSize);
                    }
                    break;

            }
        }
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            collapseMenu();
        }
        private void collapseMenu()
        {
            if (this.PanelMenu.Width > 200)   //collapse menu
            {
                PanelMenu.Width = 100;
                //pictureBox1.Visible = false;
                btn_Menu.Dock = DockStyle.Top;

                foreach (Button menubutton in PanelMenu.Controls.OfType<Button>())
                {
                    menubutton.Text = "";//from property
                    menubutton.ImageAlign = ContentAlignment.MiddleCenter;
                    menubutton.Padding = new Padding(0);
                }
            }
            else
            {//expand menu
                PanelMenu.Width = 230;
                //pictureBox1.Visible = true;
                //pictureBox1.Dock = DockStyle.Left;
                btn_Menu.Dock = DockStyle.Top;
                foreach (Button menubutton in PanelMenu.Controls.OfType<Button>())
                {
                    menubutton.Text ="    "+ menubutton.Tag.ToString();//from property
                    menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                    menubutton.Padding = new Padding(10,0,0,0);
                }
            }
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        private void ActiveButtonsMenu()
        {
            btn_accueil.BackColor = Color.FromArgb(25, 24, 32);
            btn_accueil.BorderColor = Color.FromArgb(25, 24, 32);
            btn_accueil.ForeColor = Color.FromArgb(227, 231, 211);
            btn_accueil.Image = Properties.Resources.home_light;

            btn_patient.BackColor = Color.FromArgb(25, 24, 32);
            btn_patient.BorderColor = Color.FromArgb(25, 24, 32);
            btn_patient.ForeColor = Color.FromArgb(227, 231, 211);
            btn_patient.Image = Properties.Resources.user_light;

            btn_visite.BackColor = Color.FromArgb(25, 24, 32);
            btn_visite.BorderColor = Color.FromArgb(25, 24, 32);
            btn_visite.ForeColor = Color.FromArgb(227, 231, 211);
            btn_visite.Image = Properties.Resources.calendar_light;

            btn_rendezvous.BackColor = Color.FromArgb(25, 24, 32);
            btn_rendezvous.BorderColor = Color.FromArgb(25, 24, 32);
            btn_rendezvous.ForeColor = Color.FromArgb(227, 231, 211);
            btn_rendezvous.Image = Properties.Resources.time_check_light;

            btn_medicament.BackColor = Color.FromArgb(25, 24, 32);
            btn_medicament.BorderColor = Color.FromArgb(25, 24, 32);
            btn_medicament.ForeColor = Color.FromArgb(227, 231, 211);
            btn_medicament.Image = Properties.Resources.doctor_light;
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            Label_text_header.Text = "Accueil";
            UC_Acceuil ua = new UC_Acceuil();
            ua.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(ua);
            ua.BringToFront();
        }
        private void btn_Menu_Click_1(object sender, EventArgs e)
        {
            collapseMenu();
            
        }
        private void btn_Quitter_Click(object sender, EventArgs e) // button exit
        {
            DialogResult res = MessageBox.Show("Voulez-vous vraiment Quitter?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btn_Exit_Form_Click(object sender, EventArgs e) // button quitter
        {
            DialogResult res = MessageBox.Show("Voulez-vous vraiment Quitter?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btn_visite_Click(object sender, EventArgs e)
        {
            Label_text_header.Text = "Visite";
            ActiveButtonsMenu();
            btn_visite.BackColor = Color.FromArgb(227, 231, 211);
            btn_visite.BorderColor = Color.FromArgb(25, 24, 32);
            btn_visite.ForeColor = Color.FromArgb(25, 24, 32);
            btn_visite.Image = Properties.Resources.calendar_dark;
            Forms.UC_Forms.UC_Visite ua = new Forms.UC_Forms.UC_Visite();
            ua.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(ua);
            ua.BringToFront();
        }
        private void btn_accueil_Click(object sender, EventArgs e)
        {
            Label_text_header.Text = "Acceuil";
            ActiveButtonsMenu();
            btn_accueil.BackColor = Color.FromArgb(227, 231, 211);
            btn_accueil.BorderColor = Color.FromArgb(25, 24, 32);
            btn_accueil.ForeColor = Color.FromArgb(25, 24, 32);
            btn_accueil.Image = Properties.Resources.home_dark;
            UC_Acceuil ua = new UC_Acceuil();
            ua.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(ua);
            ua.BringToFront();
        }
        private void btn_patient_Click(object sender, EventArgs e)
        {
            Label_text_header.Text = "Patient";
            ActiveButtonsMenu();
            btn_patient.BackColor = Color.FromArgb(227, 231, 211);
            btn_patient.BorderColor = Color.FromArgb(25, 24, 32);
            btn_patient.ForeColor = Color.FromArgb(25, 24, 32);
            btn_patient.Image = Properties.Resources.user_dark;
            Forms.UC_Forms.UC_Patient ua = new Forms.UC_Forms.UC_Patient();
            ua.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(ua);
            ua.BringToFront();
        }
        private void btn_rendezvous_Click(object sender, EventArgs e)
        {
            Label_text_header.Text = "Rendez-Vous";
            ActiveButtonsMenu();
            btn_rendezvous.BackColor = Color.FromArgb(227, 231, 211);
            btn_rendezvous.BorderColor = Color.FromArgb(25, 24, 32);
            btn_rendezvous.ForeColor = Color.FromArgb(25, 24, 32);
            btn_rendezvous.Image = Properties.Resources.time_check_dark;
            Forms.UC_Forms.UC_RendezVous ua = new Forms.UC_Forms.UC_RendezVous();
            ua.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(ua);
            ua.BringToFront();
        }
        private void btn_medicament_Click(object sender, EventArgs e)
        {
            Label_text_header.Text = "Médicament";
            ActiveButtonsMenu();
            btn_medicament.BackColor = Color.FromArgb(227, 231, 211);
            btn_medicament.BorderColor = Color.FromArgb(25, 24, 32);
            btn_medicament.ForeColor = Color.FromArgb(25, 24, 32);
            btn_medicament.Image = Properties.Resources.doctor_dark;
            Forms.UC_Forms.UC_Medicament ua = new Forms.UC_Forms.UC_Medicament();
            ua.Dock = DockStyle.Fill;
            panel_desktop.Controls.Add(ua);
            ua.BringToFront();
        }
        private void cButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez-vous vraiment Quitter?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
