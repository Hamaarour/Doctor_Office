
namespace Final_Form_Doctor_s_Office.Forms
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_password = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Exit_Form = new FontAwesome.Sharp.IconButton();
            this.password_icon = new FontAwesome.Sharp.IconPictureBox();
            this.username_icon = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Login = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(7, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(7, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mote de pass :";
            // 
            // checkBox_password
            // 
            this.checkBox_password.AutoSize = true;
            this.checkBox_password.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.checkBox_password.Location = new System.Drawing.Point(252, 347);
            this.checkBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_password.Name = "checkBox_password";
            this.checkBox_password.Size = new System.Drawing.Size(128, 21);
            this.checkBox_password.TabIndex = 2;
            this.checkBox_password.Text = "Show password";
            this.checkBox_password.UseVisualStyleBackColor = false;
            this.checkBox_password.CheckedChanged += new System.EventHandler(this.checkBox_password_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.tb_password);
            this.panel2.Controls.Add(this.tb_username);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_Minimize);
            this.panel2.Controls.Add(this.btn_Exit_Form);
            this.panel2.Controls.Add(this.password_icon);
            this.panel2.Controls.Add(this.username_icon);
            this.panel2.Controls.Add(this.btn_Login);
            this.panel2.Controls.Add(this.checkBox_password);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(595, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 442);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Dubai", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(72, 296);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(308, 44);
            this.tb_password.TabIndex = 1;
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter_1);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave_1);
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Dubai", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(72, 195);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(308, 44);
            this.tb_username.TabIndex = 0;
            this.tb_username.Enter += new System.EventHandler(this.tb_username_Enter_1);
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.logo_NewDev;
            this.pictureBox2.Location = new System.Drawing.Point(17, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(448, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_Minimize.IconColor = System.Drawing.Color.White;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 20;
            this.btn_Minimize.Location = new System.Drawing.Point(385, 4);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(44, 38);
            this.btn_Minimize.TabIndex = 28;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit_Form
            // 
            this.btn_Exit_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit_Form.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit_Form.FlatAppearance.BorderSize = 0;
            this.btn_Exit_Form.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btn_Exit_Form.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Exit_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit_Form.ForeColor = System.Drawing.Color.White;
            this.btn_Exit_Form.IconChar = FontAwesome.Sharp.IconChar.Napster;
            this.btn_Exit_Form.IconColor = System.Drawing.Color.White;
            this.btn_Exit_Form.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit_Form.IconSize = 1;
            this.btn_Exit_Form.Location = new System.Drawing.Point(430, 4);
            this.btn_Exit_Form.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit_Form.Name = "btn_Exit_Form";
            this.btn_Exit_Form.Size = new System.Drawing.Size(44, 38);
            this.btn_Exit_Form.TabIndex = 27;
            this.btn_Exit_Form.Text = "X";
            this.btn_Exit_Form.UseVisualStyleBackColor = false;
            this.btn_Exit_Form.Click += new System.EventHandler(this.btn_Exit_Form_Click);
            // 
            // password_icon
            // 
            this.password_icon.BackColor = System.Drawing.Color.Transparent;
            this.password_icon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.password_icon.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.password_icon.IconColor = System.Drawing.SystemColors.ControlText;
            this.password_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.password_icon.IconSize = 43;
            this.password_icon.Location = new System.Drawing.Point(31, 295);
            this.password_icon.Margin = new System.Windows.Forms.Padding(4);
            this.password_icon.Name = "password_icon";
            this.password_icon.Size = new System.Drawing.Size(43, 47);
            this.password_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.password_icon.TabIndex = 25;
            this.password_icon.TabStop = false;
            // 
            // username_icon
            // 
            this.username_icon.BackColor = System.Drawing.Color.Transparent;
            this.username_icon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.username_icon.IconChar = FontAwesome.Sharp.IconChar.User;
            this.username_icon.IconColor = System.Drawing.SystemColors.ControlText;
            this.username_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.username_icon.IconSize = 43;
            this.username_icon.Location = new System.Drawing.Point(31, 194);
            this.username_icon.Margin = new System.Windows.Forms.Padding(4);
            this.username_icon.Name = "username_icon";
            this.username_icon.Size = new System.Drawing.Size(43, 46);
            this.username_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.username_icon.TabIndex = 24;
            this.username_icon.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Login.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_Login.IconColor = System.Drawing.Color.White;
            this.btn_Login.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_Login.IconSize = 38;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.Location = new System.Drawing.Point(252, 386);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(213, 44);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = " Se Connecter";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.authentication_standing_physician_stylish_icons;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1073, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_password;
        private FontAwesome.Sharp.IconButton btn_Login;
        private FontAwesome.Sharp.IconPictureBox username_icon;
        private FontAwesome.Sharp.IconPictureBox password_icon;
        private FontAwesome.Sharp.IconButton btn_Exit_Form;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
    }
}