
namespace Final_Form_Doctor_s_Office.Forms
{
    partial class Form_Ajouter_Rendez_Vous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajouter_Rendez_Vous));
            this.panel_ajouter_RendezVous = new System.Windows.Forms.Panel();
            this.Btn_retour = new Gestion_Commerciale.Classes.CButton();
            this.btn_enregistrer_rendezVous = new Gestion_Commerciale.Classes.CButton();
            this.dtp_rendezVous = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_title_bar_ajouterRendezVous = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Exit_Form = new FontAwesome.Sharp.IconButton();
            this.panel_ajouter_RendezVous.SuspendLayout();
            this.panel_title_bar_ajouterRendezVous.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ajouter_RendezVous
            // 
            this.panel_ajouter_RendezVous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.panel_ajouter_RendezVous.Controls.Add(this.Btn_retour);
            this.panel_ajouter_RendezVous.Controls.Add(this.btn_enregistrer_rendezVous);
            this.panel_ajouter_RendezVous.Controls.Add(this.dtp_rendezVous);
            this.panel_ajouter_RendezVous.Controls.Add(this.label2);
            this.panel_ajouter_RendezVous.Controls.Add(this.dtp_time);
            this.panel_ajouter_RendezVous.Controls.Add(this.label1);
            this.panel_ajouter_RendezVous.Location = new System.Drawing.Point(16, 38);
            this.panel_ajouter_RendezVous.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ajouter_RendezVous.Name = "panel_ajouter_RendezVous";
            this.panel_ajouter_RendezVous.Size = new System.Drawing.Size(759, 231);
            this.panel_ajouter_RendezVous.TabIndex = 0;
            // 
            // Btn_retour
            // 
            this.Btn_retour.BackColor = System.Drawing.Color.Red;
            this.Btn_retour.BackgroundColor = System.Drawing.Color.Red;
            this.Btn_retour.BorderColor = System.Drawing.Color.DarkMagenta;
            this.Btn_retour.BorderRadius = 20;
            this.Btn_retour.BorderSize = 0;
            this.Btn_retour.FlatAppearance.BorderSize = 0;
            this.Btn_retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Btn_retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_retour.ForeColor = System.Drawing.Color.White;
            this.Btn_retour.Image = ((System.Drawing.Image)(resources.GetObject("Btn_retour.Image")));
            this.Btn_retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_retour.Location = new System.Drawing.Point(80, 146);
            this.Btn_retour.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_retour.Name = "Btn_retour";
            this.Btn_retour.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_retour.Size = new System.Drawing.Size(163, 48);
            this.Btn_retour.TabIndex = 95;
            this.Btn_retour.Text = "     Retour";
            this.Btn_retour.TextColor = System.Drawing.Color.White;
            this.Btn_retour.UseVisualStyleBackColor = false;
            this.Btn_retour.Click += new System.EventHandler(this.Btn_retour_Click);
            // 
            // btn_enregistrer_rendezVous
            // 
            this.btn_enregistrer_rendezVous.BackColor = System.Drawing.Color.Green;
            this.btn_enregistrer_rendezVous.BackgroundColor = System.Drawing.Color.Green;
            this.btn_enregistrer_rendezVous.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_enregistrer_rendezVous.BorderRadius = 17;
            this.btn_enregistrer_rendezVous.BorderSize = 0;
            this.btn_enregistrer_rendezVous.FlatAppearance.BorderSize = 0;
            this.btn_enregistrer_rendezVous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btn_enregistrer_rendezVous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.btn_enregistrer_rendezVous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enregistrer_rendezVous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer_rendezVous.ForeColor = System.Drawing.Color.White;
            this.btn_enregistrer_rendezVous.Location = new System.Drawing.Point(414, 146);
            this.btn_enregistrer_rendezVous.Margin = new System.Windows.Forms.Padding(4);
            this.btn_enregistrer_rendezVous.Name = "btn_enregistrer_rendezVous";
            this.btn_enregistrer_rendezVous.Size = new System.Drawing.Size(273, 48);
            this.btn_enregistrer_rendezVous.TabIndex = 94;
            this.btn_enregistrer_rendezVous.Text = "Enregistrer";
            this.btn_enregistrer_rendezVous.TextColor = System.Drawing.Color.White;
            this.btn_enregistrer_rendezVous.UseVisualStyleBackColor = false;
            this.btn_enregistrer_rendezVous.Click += new System.EventHandler(this.btn_enregistrer_rendezVous_Click);
            // 
            // dtp_rendezVous
            // 
            this.dtp_rendezVous.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.dtp_rendezVous.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtp_rendezVous.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_rendezVous.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_rendezVous.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtp_rendezVous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtp_rendezVous.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_rendezVous.Location = new System.Drawing.Point(366, 28);
            this.dtp_rendezVous.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_rendezVous.Name = "dtp_rendezVous";
            this.dtp_rendezVous.Size = new System.Drawing.Size(321, 32);
            this.dtp_rendezVous.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(65, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "La date de Rendez-vous";
            // 
            // dtp_time
            // 
            this.dtp_time.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.dtp_time.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtp_time.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_time.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_time.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtp_time.CustomFormat = "HH:mm";
            this.dtp_time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_time.Location = new System.Drawing.Point(366, 87);
            this.dtp_time.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.ShowUpDown = true;
            this.dtp_time.Size = new System.Drawing.Size(321, 32);
            this.dtp_time.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "Le temps de Rendez-vous";
            // 
            // panel_title_bar_ajouterRendezVous
            // 
            this.panel_title_bar_ajouterRendezVous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_title_bar_ajouterRendezVous.Controls.Add(this.label3);
            this.panel_title_bar_ajouterRendezVous.Controls.Add(this.btn_Exit_Form);
            this.panel_title_bar_ajouterRendezVous.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title_bar_ajouterRendezVous.Location = new System.Drawing.Point(0, 0);
            this.panel_title_bar_ajouterRendezVous.Margin = new System.Windows.Forms.Padding(4);
            this.panel_title_bar_ajouterRendezVous.Name = "panel_title_bar_ajouterRendezVous";
            this.panel_title_bar_ajouterRendezVous.Size = new System.Drawing.Size(795, 38);
            this.panel_title_bar_ajouterRendezVous.TabIndex = 57;
            this.panel_title_bar_ajouterRendezVous.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_bar_ajouterRendezVous_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remplissage d\'un Rendez-vous";
            // 
            // btn_Exit_Form
            // 
            this.btn_Exit_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit_Form.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit_Form.FlatAppearance.BorderSize = 0;
            this.btn_Exit_Form.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Exit_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit_Form.ForeColor = System.Drawing.Color.White;
            this.btn_Exit_Form.IconChar = FontAwesome.Sharp.IconChar.Napster;
            this.btn_Exit_Form.IconColor = System.Drawing.Color.White;
            this.btn_Exit_Form.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit_Form.IconSize = 1;
            this.btn_Exit_Form.Location = new System.Drawing.Point(735, 0);
            this.btn_Exit_Form.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit_Form.Name = "btn_Exit_Form";
            this.btn_Exit_Form.Size = new System.Drawing.Size(60, 38);
            this.btn_Exit_Form.TabIndex = 5;
            this.btn_Exit_Form.Text = "X";
            this.btn_Exit_Form.UseVisualStyleBackColor = false;
            this.btn_Exit_Form.Click += new System.EventHandler(this.btn_Exit_Form_Click);
            // 
            // Form_Ajouter_Rendez_Vous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(795, 289);
            this.Controls.Add(this.panel_title_bar_ajouterRendezVous);
            this.Controls.Add(this.panel_ajouter_RendezVous);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Ajouter_Rendez_Vous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Ajouter_Rendez_Vous";
            this.Load += new System.EventHandler(this.Form_Ajouter_Rendez_Vous_Load);
            this.panel_ajouter_RendezVous.ResumeLayout(false);
            this.panel_ajouter_RendezVous.PerformLayout();
            this.panel_title_bar_ajouterRendezVous.ResumeLayout(false);
            this.panel_title_bar_ajouterRendezVous.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ajouter_RendezVous;
        private System.Windows.Forms.Panel panel_title_bar_ajouterRendezVous;
        private FontAwesome.Sharp.IconButton btn_Exit_Form;
        private System.Windows.Forms.DateTimePicker dtp_rendezVous;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.Label label1;
        private Gestion_Commerciale.Classes.CButton btn_enregistrer_rendezVous;
        private Gestion_Commerciale.Classes.CButton Btn_retour;
        private System.Windows.Forms.Label label3;
    }
}