
namespace Final_Form_Doctor_s_Office.Forms
{
    partial class Mini_menu_patient
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
            this.panel_title_bar_detailForm = new System.Windows.Forms.Panel();
            this.btn_Exit_Form = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_for_buttons = new System.Windows.Forms.Panel();
            this.bt_ajouterNvVisite = new FontAwesome.Sharp.IconButton();
            this.btn_details_patient = new FontAwesome.Sharp.IconButton();
            this.bt_HistoVisite = new FontAwesome.Sharp.IconButton();
            this.panel_uc = new System.Windows.Forms.Panel();
            this.uC_Patient_Historique1 = new Final_Form_Doctor_s_Office.Forms.UC_Forms.UC_Patient_Historique();
            this.uC_Patient_Nv_Visite1 = new Final_Form_Doctor_s_Office.Forms.UC_Forms.UC_Patient_Nv_Visite();
            this.uC_Patient_details1 = new Final_Form_Doctor_s_Office.Forms.UC_Forms.UC_Patient_details();
            this.panel_title_bar_detailForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_for_buttons.SuspendLayout();
            this.panel_uc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title_bar_detailForm
            // 
            this.panel_title_bar_detailForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_title_bar_detailForm.Controls.Add(this.btn_Exit_Form);
            this.panel_title_bar_detailForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title_bar_detailForm.Location = new System.Drawing.Point(0, 0);
            this.panel_title_bar_detailForm.Margin = new System.Windows.Forms.Padding(4);
            this.panel_title_bar_detailForm.Name = "panel_title_bar_detailForm";
            this.panel_title_bar_detailForm.Size = new System.Drawing.Size(1182, 38);
            this.panel_title_bar_detailForm.TabIndex = 56;
            this.panel_title_bar_detailForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_bar_detailForm_MouseDown);
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
            this.btn_Exit_Form.Location = new System.Drawing.Point(1122, 0);
            this.btn_Exit_Form.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit_Form.Name = "btn_Exit_Form";
            this.btn_Exit_Form.Size = new System.Drawing.Size(60, 38);
            this.btn_Exit_Form.TabIndex = 5;
            this.btn_Exit_Form.Text = "X";
            this.btn_Exit_Form.UseVisualStyleBackColor = false;
            this.btn_Exit_Form.Click += new System.EventHandler(this.btn_Exit_Form_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.panel_uc);
            this.panel1.Controls.Add(this.panel_for_buttons);
            this.panel1.Location = new System.Drawing.Point(16, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 582);
            this.panel1.TabIndex = 57;
            // 
            // panel_for_buttons
            // 
            this.panel_for_buttons.Controls.Add(this.bt_ajouterNvVisite);
            this.panel_for_buttons.Controls.Add(this.btn_details_patient);
            this.panel_for_buttons.Controls.Add(this.bt_HistoVisite);
            this.panel_for_buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_for_buttons.Location = new System.Drawing.Point(0, 0);
            this.panel_for_buttons.Name = "panel_for_buttons";
            this.panel_for_buttons.Size = new System.Drawing.Size(1150, 68);
            this.panel_for_buttons.TabIndex = 8;
            // 
            // bt_ajouterNvVisite
            // 
            this.bt_ajouterNvVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.bt_ajouterNvVisite.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_ajouterNvVisite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.bt_ajouterNvVisite.FlatAppearance.BorderSize = 2;
            this.bt_ajouterNvVisite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            this.bt_ajouterNvVisite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            this.bt_ajouterNvVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ajouterNvVisite.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.bt_ajouterNvVisite.ForeColor = System.Drawing.Color.White;
            this.bt_ajouterNvVisite.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.bt_ajouterNvVisite.IconColor = System.Drawing.Color.White;
            this.bt_ajouterNvVisite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_ajouterNvVisite.IconSize = 30;
            this.bt_ajouterNvVisite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ajouterNvVisite.Location = new System.Drawing.Point(4, 0);
            this.bt_ajouterNvVisite.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ajouterNvVisite.Name = "bt_ajouterNvVisite";
            this.bt_ajouterNvVisite.Size = new System.Drawing.Size(385, 68);
            this.bt_ajouterNvVisite.TabIndex = 5;
            this.bt_ajouterNvVisite.Text = "Ajouter Visite";
            this.bt_ajouterNvVisite.UseVisualStyleBackColor = false;
            this.bt_ajouterNvVisite.Click += new System.EventHandler(this.bt_ajouterNvVisite_Click);
            // 
            // btn_details_patient
            // 
            this.btn_details_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btn_details_patient.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_details_patient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.btn_details_patient.FlatAppearance.BorderSize = 2;
            this.btn_details_patient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            this.btn_details_patient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            this.btn_details_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_details_patient.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_details_patient.ForeColor = System.Drawing.Color.White;
            this.btn_details_patient.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btn_details_patient.IconColor = System.Drawing.Color.White;
            this.btn_details_patient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_details_patient.IconSize = 30;
            this.btn_details_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_details_patient.Location = new System.Drawing.Point(389, 0);
            this.btn_details_patient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_details_patient.Name = "btn_details_patient";
            this.btn_details_patient.Size = new System.Drawing.Size(373, 68);
            this.btn_details_patient.TabIndex = 5;
            this.btn_details_patient.Text = "Details patient ";
            this.btn_details_patient.UseVisualStyleBackColor = false;
            this.btn_details_patient.Click += new System.EventHandler(this.btn_details_patient_Click);
            // 
            // bt_HistoVisite
            // 
            this.bt_HistoVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.bt_HistoVisite.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_HistoVisite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.bt_HistoVisite.FlatAppearance.BorderSize = 2;
            this.bt_HistoVisite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            this.bt_HistoVisite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            this.bt_HistoVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_HistoVisite.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.bt_HistoVisite.ForeColor = System.Drawing.Color.White;
            this.bt_HistoVisite.IconChar = FontAwesome.Sharp.IconChar.History;
            this.bt_HistoVisite.IconColor = System.Drawing.Color.White;
            this.bt_HistoVisite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bt_HistoVisite.IconSize = 30;
            this.bt_HistoVisite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_HistoVisite.Location = new System.Drawing.Point(762, 0);
            this.bt_HistoVisite.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HistoVisite.Name = "bt_HistoVisite";
            this.bt_HistoVisite.Size = new System.Drawing.Size(388, 68);
            this.bt_HistoVisite.TabIndex = 7;
            this.bt_HistoVisite.Text = "Historique des visites ";
            this.bt_HistoVisite.UseVisualStyleBackColor = false;
            this.bt_HistoVisite.Click += new System.EventHandler(this.bt_HistoVisite_Click);
            // 
            // panel_uc
            // 
            this.panel_uc.Controls.Add(this.uC_Patient_details1);
            this.panel_uc.Controls.Add(this.uC_Patient_Nv_Visite1);
            this.panel_uc.Controls.Add(this.uC_Patient_Historique1);
            this.panel_uc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_uc.Location = new System.Drawing.Point(0, 68);
            this.panel_uc.Name = "panel_uc";
            this.panel_uc.Size = new System.Drawing.Size(1150, 514);
            this.panel_uc.TabIndex = 9;
            // 
            // uC_Patient_Historique1
            // 
            this.uC_Patient_Historique1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.uC_Patient_Historique1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Patient_Historique1.Location = new System.Drawing.Point(0, 0);
            this.uC_Patient_Historique1.Name = "uC_Patient_Historique1";
            this.uC_Patient_Historique1.Size = new System.Drawing.Size(1150, 514);
            this.uC_Patient_Historique1.TabIndex = 0;
            // 
            // uC_Patient_Nv_Visite1
            // 
            this.uC_Patient_Nv_Visite1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.uC_Patient_Nv_Visite1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Patient_Nv_Visite1.Location = new System.Drawing.Point(0, 0);
            this.uC_Patient_Nv_Visite1.Name = "uC_Patient_Nv_Visite1";
            this.uC_Patient_Nv_Visite1.Size = new System.Drawing.Size(1150, 514);
            this.uC_Patient_Nv_Visite1.TabIndex = 1;
            // 
            // uC_Patient_details1
            // 
            this.uC_Patient_details1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.uC_Patient_details1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Patient_details1.Location = new System.Drawing.Point(0, 0);
            this.uC_Patient_details1.Name = "uC_Patient_details1";
            this.uC_Patient_details1.Size = new System.Drawing.Size(1150, 514);
            this.uC_Patient_details1.TabIndex = 2;
            // 
            // Mini_menu_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1182, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_title_bar_detailForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mini_menu_patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini_menu_patient";
            this.Load += new System.EventHandler(this.Mini_menu_patient_Load);
            this.panel_title_bar_detailForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_for_buttons.ResumeLayout(false);
            this.panel_uc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title_bar_detailForm;
        private FontAwesome.Sharp.IconButton btn_Exit_Form;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton bt_ajouterNvVisite;
        private FontAwesome.Sharp.IconButton btn_details_patient;
        private FontAwesome.Sharp.IconButton bt_HistoVisite;
        private System.Windows.Forms.Panel panel_for_buttons;
        private System.Windows.Forms.Panel panel_uc;
        private UC_Forms.UC_Patient_details uC_Patient_details1;
        private UC_Forms.UC_Patient_Nv_Visite uC_Patient_Nv_Visite1;
        private UC_Forms.UC_Patient_Historique uC_Patient_Historique1;
    }
}