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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        //methods to move the forme from the panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void checkBox_password_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_password.PasswordChar == (char)0)
            {
                tb_password.PasswordChar = '•';
            }
            else
            {
                tb_password.PasswordChar = (char)0;
            }
        }

        private void btn_Exit_Form_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            Classes.GG.charge();
            this.ActiveControl = tb_username;
        }
        private void btn_Login_Click(object sender, EventArgs e) // Button LOGIN
        {
            int j = 0;
            foreach (DataRow dr in Classes.GG.ds.LOGIN.Select("Username='" + tb_username.Text + "'"))
            {
                j++;
                if (dr[1].ToString() == tb_password.Text)
                {
                    Form_Menu menu = new Form_Menu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Mots de pass incorrect","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
            }
            if (j == 0)
            {
                MessageBox.Show("Username incorrect","Erreur",MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_username_Enter_1(object sender, EventArgs e)
        {
            username_icon.IconColor = Color.FromArgb(96, 147, 166);
        }

        private void tb_username_Leave_1(object sender, EventArgs e)
        {
            username_icon.IconColor = Color.Black;
        }

        private void tb_password_Leave_1(object sender, EventArgs e)
        {
            password_icon.IconColor = Color.Black;
        }

        private void tb_password_Enter_1(object sender, EventArgs e)
        {
            password_icon.IconColor = Color.FromArgb(96, 147, 166);
        }
    }
}
