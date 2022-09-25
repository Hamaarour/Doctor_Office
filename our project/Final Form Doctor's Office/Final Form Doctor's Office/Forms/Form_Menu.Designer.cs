
namespace Final_Form_Doctor_s_Office
{
    partial class Form_Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Code généré par le Concepteur Windows Form
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.cButton1 = new Gestion_Commerciale.Classes.CButton();
            this.btn_medicament = new Gestion_Commerciale.Classes.CButton();
            this.btn_rendezvous = new Gestion_Commerciale.Classes.CButton();
            this.btn_visite = new Gestion_Commerciale.Classes.CButton();
            this.btn_patient = new Gestion_Commerciale.Classes.CButton();
            this.btn_accueil = new Gestion_Commerciale.Classes.CButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Menu = new FontAwesome.Sharp.IconButton();
            this.panel_title_bar = new System.Windows.Forms.Panel();
            this.Label_text_header = new System.Windows.Forms.Label();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.btn_Exit_Form = new FontAwesome.Sharp.IconButton();
            this.panel_desktop = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_title_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.PanelMenu.Controls.Add(this.cButton1);
            this.PanelMenu.Controls.Add(this.btn_medicament);
            this.PanelMenu.Controls.Add(this.btn_rendezvous);
            this.PanelMenu.Controls.Add(this.btn_visite);
            this.PanelMenu.Controls.Add(this.btn_patient);
            this.PanelMenu.Controls.Add(this.btn_accueil);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(277, 642);
            this.PanelMenu.TabIndex = 0;
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.cButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.cButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.cButton1.BorderRadius = 20;
            this.cButton1.BorderSize = 3;
            this.cButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.cButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.cButton1.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.sign_out_light;
            this.cButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cButton1.Location = new System.Drawing.Point(0, 572);
            this.cButton1.Margin = new System.Windows.Forms.Padding(5);
            this.cButton1.Name = "cButton1";
            this.cButton1.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.cButton1.Size = new System.Drawing.Size(277, 70);
            this.cButton1.TabIndex = 108;
            this.cButton1.Tag = "Quitter";
            this.cButton1.Text = "Quitter";
            this.cButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // btn_medicament
            // 
            this.btn_medicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_medicament.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_medicament.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_medicament.BorderRadius = 20;
            this.btn_medicament.BorderSize = 3;
            this.btn_medicament.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_medicament.FlatAppearance.BorderSize = 0;
            this.btn_medicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medicament.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_medicament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_medicament.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.doctor_light;
            this.btn_medicament.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_medicament.Location = new System.Drawing.Point(0, 425);
            this.btn_medicament.Margin = new System.Windows.Forms.Padding(5);
            this.btn_medicament.Name = "btn_medicament";
            this.btn_medicament.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btn_medicament.Size = new System.Drawing.Size(277, 70);
            this.btn_medicament.TabIndex = 107;
            this.btn_medicament.Tag = "Médicament";
            this.btn_medicament.Text = "Médicament";
            this.btn_medicament.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_medicament.UseVisualStyleBackColor = false;
            this.btn_medicament.Click += new System.EventHandler(this.btn_medicament_Click);
            // 
            // btn_rendezvous
            // 
            this.btn_rendezvous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_rendezvous.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_rendezvous.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_rendezvous.BorderRadius = 20;
            this.btn_rendezvous.BorderSize = 3;
            this.btn_rendezvous.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_rendezvous.FlatAppearance.BorderSize = 0;
            this.btn_rendezvous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rendezvous.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_rendezvous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_rendezvous.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.time_check_light;
            this.btn_rendezvous.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rendezvous.Location = new System.Drawing.Point(0, 355);
            this.btn_rendezvous.Margin = new System.Windows.Forms.Padding(5);
            this.btn_rendezvous.Name = "btn_rendezvous";
            this.btn_rendezvous.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btn_rendezvous.Size = new System.Drawing.Size(277, 70);
            this.btn_rendezvous.TabIndex = 106;
            this.btn_rendezvous.Tag = "Rendez-vous";
            this.btn_rendezvous.Text = "   Rendez-vous";
            this.btn_rendezvous.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_rendezvous.UseVisualStyleBackColor = false;
            this.btn_rendezvous.Click += new System.EventHandler(this.btn_rendezvous_Click);
            // 
            // btn_visite
            // 
            this.btn_visite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_visite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_visite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_visite.BorderRadius = 20;
            this.btn_visite.BorderSize = 3;
            this.btn_visite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_visite.FlatAppearance.BorderSize = 0;
            this.btn_visite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visite.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_visite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_visite.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.calendar_light;
            this.btn_visite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_visite.Location = new System.Drawing.Point(0, 285);
            this.btn_visite.Margin = new System.Windows.Forms.Padding(5);
            this.btn_visite.Name = "btn_visite";
            this.btn_visite.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btn_visite.Size = new System.Drawing.Size(277, 70);
            this.btn_visite.TabIndex = 105;
            this.btn_visite.Tag = "Visite";
            this.btn_visite.Text = "Visite";
            this.btn_visite.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_visite.UseVisualStyleBackColor = false;
            this.btn_visite.Click += new System.EventHandler(this.btn_visite_Click);
            // 
            // btn_patient
            // 
            this.btn_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_patient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_patient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_patient.BorderRadius = 20;
            this.btn_patient.BorderSize = 3;
            this.btn_patient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_patient.FlatAppearance.BorderSize = 0;
            this.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patient.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_patient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_patient.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.user_light;
            this.btn_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_patient.Location = new System.Drawing.Point(0, 215);
            this.btn_patient.Margin = new System.Windows.Forms.Padding(5);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btn_patient.Size = new System.Drawing.Size(277, 70);
            this.btn_patient.TabIndex = 104;
            this.btn_patient.Tag = "Patient";
            this.btn_patient.Text = "Patient";
            this.btn_patient.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_patient.UseVisualStyleBackColor = false;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // btn_accueil
            // 
            this.btn_accueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_accueil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_accueil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_accueil.BorderRadius = 20;
            this.btn_accueil.BorderSize = 3;
            this.btn_accueil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_accueil.FlatAppearance.BorderSize = 0;
            this.btn_accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accueil.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_accueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_accueil.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.home_dark;
            this.btn_accueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_accueil.Location = new System.Drawing.Point(0, 145);
            this.btn_accueil.Margin = new System.Windows.Forms.Padding(5);
            this.btn_accueil.Name = "btn_accueil";
            this.btn_accueil.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btn_accueil.Size = new System.Drawing.Size(277, 70);
            this.btn_accueil.TabIndex = 103;
            this.btn_accueil.Tag = "Accueil";
            this.btn_accueil.Text = "Accueil";
            this.btn_accueil.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_accueil.UseVisualStyleBackColor = false;
            this.btn_accueil.Click += new System.EventHandler(this.btn_accueil_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 145);
            this.panel1.TabIndex = 0;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btn_Menu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(203)))));
            this.btn_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Menu.IconSize = 30;
            this.btn_Menu.Location = new System.Drawing.Point(197, 0);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(80, 100);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click_1);
            // 
            // panel_title_bar
            // 
            this.panel_title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel_title_bar.Controls.Add(this.Label_text_header);
            this.panel_title_bar.Controls.Add(this.btn_Minimize);
            this.panel_title_bar.Controls.Add(this.btn_Maximize);
            this.panel_title_bar.Controls.Add(this.btn_Exit_Form);
            this.panel_title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title_bar.Location = new System.Drawing.Point(277, 0);
            this.panel_title_bar.Margin = new System.Windows.Forms.Padding(4);
            this.panel_title_bar.Name = "panel_title_bar";
            this.panel_title_bar.Size = new System.Drawing.Size(1000, 54);
            this.panel_title_bar.TabIndex = 1;
            this.panel_title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_tItle_bar_MouseDown);
            // 
            // Label_text_header
            // 
            this.Label_text_header.AutoSize = true;
            this.Label_text_header.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.Label_text_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Label_text_header.Location = new System.Drawing.Point(84, 13);
            this.Label_text_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_text_header.Name = "Label_text_header";
            this.Label_text_header.Size = new System.Drawing.Size(101, 28);
            this.Label_text_header.TabIndex = 20;
            this.Label_text_header.Text = "Accueil";
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
            this.btn_Minimize.Location = new System.Drawing.Point(816, 4);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(60, 44);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.btn_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btn_Maximize.IconColor = System.Drawing.Color.White;
            this.btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximize.IconSize = 20;
            this.btn_Maximize.Location = new System.Drawing.Point(876, 4);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(60, 44);
            this.btn_Maximize.TabIndex = 3;
            this.btn_Maximize.UseVisualStyleBackColor = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Exit_Form
            // 
            this.btn_Exit_Form.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit_Form.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit_Form.FlatAppearance.BorderSize = 0;
            this.btn_Exit_Form.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btn_Exit_Form.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Exit_Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit_Form.ForeColor = System.Drawing.Color.White;
            this.btn_Exit_Form.IconChar = FontAwesome.Sharp.IconChar.Napster;
            this.btn_Exit_Form.IconColor = System.Drawing.Color.White;
            this.btn_Exit_Form.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit_Form.IconSize = 1;
            this.btn_Exit_Form.Location = new System.Drawing.Point(936, 4);
            this.btn_Exit_Form.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit_Form.Name = "btn_Exit_Form";
            this.btn_Exit_Form.Size = new System.Drawing.Size(60, 44);
            this.btn_Exit_Form.TabIndex = 2;
            this.btn_Exit_Form.Text = "X";
            this.btn_Exit_Form.UseVisualStyleBackColor = false;
            this.btn_Exit_Form.Click += new System.EventHandler(this.btn_Exit_Form_Click);
            // 
            // panel_desktop
            // 
            this.panel_desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_desktop.Location = new System.Drawing.Point(277, 54);
            this.panel_desktop.Margin = new System.Windows.Forms.Padding(4);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(1000, 588);
            this.panel_desktop.TabIndex = 2;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1277, 642);
            this.Controls.Add(this.panel_desktop);
            this.Controls.Add(this.panel_title_bar);
            this.Controls.Add(this.PanelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1167, 680);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Menu";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.PanelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_title_bar.ResumeLayout(false);
            this.panel_title_bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_title_bar;
        private FontAwesome.Sharp.IconButton btn_Menu;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private FontAwesome.Sharp.IconButton btn_Exit_Form;
        private System.Windows.Forms.Label Label_text_header;
        private Gestion_Commerciale.Classes.CButton btn_rendezvous;
        private Gestion_Commerciale.Classes.CButton btn_visite;
        private Gestion_Commerciale.Classes.CButton btn_patient;
        private Gestion_Commerciale.Classes.CButton btn_accueil;
        private Gestion_Commerciale.Classes.CButton cButton1;
        private Gestion_Commerciale.Classes.CButton btn_medicament;
        public System.Windows.Forms.Panel panel_desktop;
    }
}

