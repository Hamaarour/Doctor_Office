
namespace Final_Form_Doctor_s_Office.Forms.UC_Forms
{
    partial class UC_RendezVous
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_RendezVous));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_full_form = new System.Windows.Forms.Panel();
            this.btn_refresh_p = new Gestion_Commerciale.Classes.CButton();
            this.panel_visite = new System.Windows.Forms.Panel();
            this.panel_cin = new System.Windows.Forms.Panel();
            this.tb_prix = new System.Windows.Forms.TextBox();
            this.btn_enregistrer = new Gestion_Commerciale.Classes.CButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gp_visite_aujourdhui = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_recherche = new System.Windows.Forms.TextBox();
            this.label_cinn = new System.Windows.Forms.Label();
            this.dtp_rendezVous = new System.Windows.Forms.DateTimePicker();
            this.Dgv_rendezVous = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ajouter_visite = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip_info = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_refreche = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_full_form.SuspendLayout();
            this.panel_visite.SuspendLayout();
            this.gp_visite_aujourdhui.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rendezVous)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_full_form
            // 
            this.panel_full_form.Controls.Add(this.btn_refresh_p);
            this.panel_full_form.Controls.Add(this.panel_visite);
            this.panel_full_form.Controls.Add(this.gp_visite_aujourdhui);
            this.panel_full_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_full_form.Location = new System.Drawing.Point(0, 0);
            this.panel_full_form.Margin = new System.Windows.Forms.Padding(4);
            this.panel_full_form.Name = "panel_full_form";
            this.panel_full_form.Size = new System.Drawing.Size(1000, 588);
            this.panel_full_form.TabIndex = 0;
            // 
            // btn_refresh_p
            // 
            this.btn_refresh_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh_p.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh_p.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_refresh_p.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btn_refresh_p.BorderRadius = 20;
            this.btn_refresh_p.BorderSize = 0;
            this.btn_refresh_p.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh_p.FlatAppearance.BorderSize = 0;
            this.btn_refresh_p.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_refresh_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh_p.ForeColor = System.Drawing.Color.White;
            this.btn_refresh_p.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh_p.Image")));
            this.btn_refresh_p.Location = new System.Drawing.Point(948, 4);
            this.btn_refresh_p.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh_p.Name = "btn_refresh_p";
            this.btn_refresh_p.Size = new System.Drawing.Size(44, 32);
            this.btn_refresh_p.TabIndex = 120;
            this.btn_refresh_p.TextColor = System.Drawing.Color.White;
            this.btn_refresh_p.UseVisualStyleBackColor = false;
            this.btn_refresh_p.Click += new System.EventHandler(this.btn_refresh_p_Click_1);
            // 
            // panel_visite
            // 
            this.panel_visite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_visite.Controls.Add(this.panel_cin);
            this.panel_visite.Controls.Add(this.tb_prix);
            this.panel_visite.Controls.Add(this.btn_enregistrer);
            this.panel_visite.Controls.Add(this.label2);
            this.panel_visite.Location = new System.Drawing.Point(11, 526);
            this.panel_visite.Margin = new System.Windows.Forms.Padding(4);
            this.panel_visite.Name = "panel_visite";
            this.panel_visite.Size = new System.Drawing.Size(972, 55);
            this.panel_visite.TabIndex = 119;
            this.panel_visite.Visible = false;
            // 
            // panel_cin
            // 
            this.panel_cin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_cin.Location = new System.Drawing.Point(167, 44);
            this.panel_cin.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cin.Name = "panel_cin";
            this.panel_cin.Size = new System.Drawing.Size(245, 2);
            this.panel_cin.TabIndex = 104;
            // 
            // tb_prix
            // 
            this.tb_prix.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_prix.Location = new System.Drawing.Point(167, 12);
            this.tb_prix.Margin = new System.Windows.Forms.Padding(4);
            this.tb_prix.Multiline = true;
            this.tb_prix.Name = "tb_prix";
            this.tb_prix.Size = new System.Drawing.Size(247, 35);
            this.tb_prix.TabIndex = 103;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.BackColor = System.Drawing.Color.Green;
            this.btn_enregistrer.BackgroundColor = System.Drawing.Color.Green;
            this.btn_enregistrer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_enregistrer.BorderRadius = 17;
            this.btn_enregistrer.BorderSize = 0;
            this.btn_enregistrer.FlatAppearance.BorderSize = 0;
            this.btn_enregistrer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btn_enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enregistrer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.ForeColor = System.Drawing.Color.White;
            this.btn_enregistrer.Location = new System.Drawing.Point(451, 7);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(261, 46);
            this.btn_enregistrer.TabIndex = 93;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.TextColor = System.Drawing.Color.White;
            this.btn_enregistrer.UseVisualStyleBackColor = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(71, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 90;
            this.label2.Text = "Prix :";
            // 
            // gp_visite_aujourdhui
            // 
            this.gp_visite_aujourdhui.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_visite_aujourdhui.Controls.Add(this.panel1);
            this.gp_visite_aujourdhui.Controls.Add(this.tb_recherche);
            this.gp_visite_aujourdhui.Controls.Add(this.label_cinn);
            this.gp_visite_aujourdhui.Controls.Add(this.dtp_rendezVous);
            this.gp_visite_aujourdhui.Controls.Add(this.Dgv_rendezVous);
            this.gp_visite_aujourdhui.Controls.Add(this.label1);
            this.gp_visite_aujourdhui.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_visite_aujourdhui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.gp_visite_aujourdhui.Location = new System.Drawing.Point(0, 40);
            this.gp_visite_aujourdhui.Margin = new System.Windows.Forms.Padding(4);
            this.gp_visite_aujourdhui.Name = "gp_visite_aujourdhui";
            this.gp_visite_aujourdhui.Padding = new System.Windows.Forms.Padding(4);
            this.gp_visite_aujourdhui.Size = new System.Drawing.Size(1000, 478);
            this.gp_visite_aujourdhui.TabIndex = 118;
            this.gp_visite_aujourdhui.TabStop = false;
            this.gp_visite_aujourdhui.Text = "Rendez-Vous";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel1.Location = new System.Drawing.Point(728, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 2);
            this.panel1.TabIndex = 106;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tb_recherche
            // 
            this.tb_recherche.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_recherche.Location = new System.Drawing.Point(727, 23);
            this.tb_recherche.Margin = new System.Windows.Forms.Padding(4);
            this.tb_recherche.Multiline = true;
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(256, 35);
            this.tb_recherche.TabIndex = 105;
            this.tb_recherche.TextChanged += new System.EventHandler(this.tb_recherche_TextChanged);
            // 
            // label_cinn
            // 
            this.label_cinn.AutoSize = true;
            this.label_cinn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_cinn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_cinn.Location = new System.Drawing.Point(527, 31);
            this.label_cinn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cinn.Name = "label_cinn";
            this.label_cinn.Size = new System.Drawing.Size(196, 23);
            this.label_cinn.TabIndex = 104;
            this.label_cinn.Text = "CIN / Nom / Prenom";
            this.label_cinn.Click += new System.EventHandler(this.label_cinn_Click);
            // 
            // dtp_rendezVous
            // 
            this.dtp_rendezVous.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.dtp_rendezVous.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtp_rendezVous.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_rendezVous.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_rendezVous.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtp_rendezVous.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_rendezVous.Location = new System.Drawing.Point(292, 26);
            this.dtp_rendezVous.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_rendezVous.Name = "dtp_rendezVous";
            this.dtp_rendezVous.Size = new System.Drawing.Size(174, 32);
            this.dtp_rendezVous.TabIndex = 67;
            this.dtp_rendezVous.ValueChanged += new System.EventHandler(this.dtp_rendezVous_ValueChanged);
            // 
            // Dgv_rendezVous
            // 
            this.Dgv_rendezVous.AllowUserToAddRows = false;
            this.Dgv_rendezVous.AllowUserToDeleteRows = false;
            this.Dgv_rendezVous.AllowUserToResizeRows = false;
            this.Dgv_rendezVous.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_rendezVous.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_rendezVous.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Dgv_rendezVous.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_rendezVous.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgv_rendezVous.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_rendezVous.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_rendezVous.ColumnHeadersHeight = 45;
            this.Dgv_rendezVous.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nom,
            this.Prenom,
            this.Age,
            this.Temps,
            this.id_patient,
            this.Ajouter_visite});
            this.Dgv_rendezVous.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(198)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_rendezVous.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_rendezVous.EnableHeadersVisualStyles = false;
            this.Dgv_rendezVous.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_rendezVous.Location = new System.Drawing.Point(8, 84);
            this.Dgv_rendezVous.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_rendezVous.Name = "Dgv_rendezVous";
            this.Dgv_rendezVous.ReadOnly = true;
            this.Dgv_rendezVous.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_rendezVous.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_rendezVous.RowHeadersVisible = false;
            this.Dgv_rendezVous.RowHeadersWidth = 55;
            this.Dgv_rendezVous.RowTemplate.Height = 40;
            this.Dgv_rendezVous.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_rendezVous.Size = new System.Drawing.Size(984, 378);
            this.Dgv_rendezVous.TabIndex = 0;
            this.Dgv_rendezVous.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_rendezVous_CellContentClick);
            this.Dgv_rendezVous.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv_rendezVous_CellFormatting);
            // 
            // id
            // 
            this.id.HeaderText = "id_visite";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Temps
            // 
            this.Temps.HeaderText = "Temps";
            this.Temps.MinimumWidth = 6;
            this.Temps.Name = "Temps";
            this.Temps.ReadOnly = true;
            // 
            // id_patient
            // 
            this.id_patient.HeaderText = "id_patient";
            this.id_patient.MinimumWidth = 6;
            this.id_patient.Name = "id_patient";
            this.id_patient.ReadOnly = true;
            this.id_patient.Visible = false;
            // 
            // Ajouter_visite
            // 
            this.Ajouter_visite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ajouter_visite.HeaderText = "";
            this.Ajouter_visite.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.plus;
            this.Ajouter_visite.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Ajouter_visite.MinimumWidth = 6;
            this.Ajouter_visite.Name = "Ajouter_visite";
            this.Ajouter_visite.ReadOnly = true;
            this.Ajouter_visite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ajouter_visite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ajouter_visite.Width = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Les dates de Rendez-vous";
            // 
            // toolTip_info
            // 
            this.toolTip_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip_refreche
            // 
            this.toolTip_refreche.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.plus;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // UC_RendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.panel_full_form);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_RendezVous";
            this.Size = new System.Drawing.Size(1000, 588);
            this.Load += new System.EventHandler(this.UC_RendezVous_Load);
            this.panel_full_form.ResumeLayout(false);
            this.panel_visite.ResumeLayout(false);
            this.panel_visite.PerformLayout();
            this.gp_visite_aujourdhui.ResumeLayout(false);
            this.gp_visite_aujourdhui.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_rendezVous)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_full_form;
        private Gestion_Commerciale.Classes.CButton btn_refresh_p;
        private System.Windows.Forms.Panel panel_visite;
        private System.Windows.Forms.Panel panel_cin;
        private System.Windows.Forms.TextBox tb_prix;
        private Gestion_Commerciale.Classes.CButton btn_enregistrer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gp_visite_aujourdhui;
        private System.Windows.Forms.DateTimePicker dtp_rendezVous;
        private System.Windows.Forms.DataGridView Dgv_rendezVous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip_info;
        private System.Windows.Forms.ToolTip toolTip_refreche;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_patient;
        private System.Windows.Forms.DataGridViewImageColumn Ajouter_visite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_recherche;
        private System.Windows.Forms.Label label_cinn;
    }
}
