
namespace Final_Form_Doctor_s_Office.Forms.UC_Forms
{
    partial class UC_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Patient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Full_Form_Patient = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_recherche = new System.Windows.Forms.TextBox();
            this.bt_refresh = new Gestion_Commerciale.Classes.CButton();
            this.btn_to_ajouter_patient = new FontAwesome.Sharp.IconButton();
            this.Dgv_Patient = new System.Windows.Forms.DataGridView();
            this.details = new System.Windows.Forms.DataGridViewImageColumn();
            this.cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AjouterRDV = new System.Windows.Forms.DataGridViewImageColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.label_cinn = new System.Windows.Forms.Label();
            this.panel_ajouter_patient = new System.Windows.Forms.Panel();
            this.btn_refresh_p = new Gestion_Commerciale.Classes.CButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_naissance = new System.Windows.Forms.DateTimePicker();
            this.panel_adresse = new System.Windows.Forms.Panel();
            this.panel_tele = new System.Windows.Forms.Panel();
            this.panel_prenom = new System.Windows.Forms.Panel();
            this.panel_nom = new System.Windows.Forms.Panel();
            this.panel_cin = new System.Windows.Forms.Panel();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.tb_telephone = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_CIN = new System.Windows.Forms.TextBox();
            this.label_date_naissance = new System.Windows.Forms.Label();
            this.label_Telephone = new System.Windows.Forms.Label();
            this.checkBox_enfant = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_prenomResp = new System.Windows.Forms.Panel();
            this.tb_prenomResponsable = new System.Windows.Forms.TextBox();
            this.panel_nomResp = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_nomResponsable = new System.Windows.Forms.TextBox();
            this.cb_ville = new System.Windows.Forms.ComboBox();
            this.Btn_retour = new Gestion_Commerciale.Classes.CButton();
            this.label_adresse = new System.Windows.Forms.Label();
            this.Btn_Ajouter_Patient = new Gestion_Commerciale.Classes.CButton();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_ville = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_Cin = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolTipAjouterPa = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMineur = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTbRecherche = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_refesh = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipinfo = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Full_Form_Patient.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Patient)).BeginInit();
            this.panel_ajouter_patient.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Full_Form_Patient
            // 
            this.panel_Full_Form_Patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.panel_Full_Form_Patient.Controls.Add(this.panel2);
            this.panel_Full_Form_Patient.Controls.Add(this.panel_ajouter_patient);
            this.panel_Full_Form_Patient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Full_Form_Patient.Location = new System.Drawing.Point(0, 0);
            this.panel_Full_Form_Patient.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Full_Form_Patient.Name = "panel_Full_Form_Patient";
            this.panel_Full_Form_Patient.Size = new System.Drawing.Size(1100, 638);
            this.panel_Full_Form_Patient.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.tb_recherche);
            this.panel2.Controls.Add(this.bt_refresh);
            this.panel2.Controls.Add(this.btn_to_ajouter_patient);
            this.panel2.Controls.Add(this.Dgv_Patient);
            this.panel2.Controls.Add(this.label_cinn);
            this.panel2.Location = new System.Drawing.Point(16, 459);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 175);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel1.Location = new System.Drawing.Point(292, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 2);
            this.panel1.TabIndex = 103;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tb_recherche
            // 
            this.tb_recherche.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_recherche.Location = new System.Drawing.Point(292, 21);
            this.tb_recherche.Margin = new System.Windows.Forms.Padding(4);
            this.tb_recherche.Multiline = true;
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(256, 35);
            this.tb_recherche.TabIndex = 102;
            this.tb_recherche.TextChanged += new System.EventHandler(this.tb_recherche_TextChanged);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_refresh.BackColor = System.Drawing.Color.Transparent;
            this.bt_refresh.BackgroundColor = System.Drawing.Color.Transparent;
            this.bt_refresh.BorderColor = System.Drawing.Color.DarkMagenta;
            this.bt_refresh.BorderRadius = 20;
            this.bt_refresh.BorderSize = 0;
            this.bt_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_refresh.FlatAppearance.BorderSize = 0;
            this.bt_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.bt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_refresh.ForeColor = System.Drawing.Color.White;
            this.bt_refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_refresh.Image")));
            this.bt_refresh.Location = new System.Drawing.Point(1020, 12);
            this.bt_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(44, 32);
            this.bt_refresh.TabIndex = 61;
            this.bt_refresh.TextColor = System.Drawing.Color.White;
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // btn_to_ajouter_patient
            // 
            this.btn_to_ajouter_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_to_ajouter_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btn_to_ajouter_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_to_ajouter_patient.FlatAppearance.BorderSize = 0;
            this.btn_to_ajouter_patient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            this.btn_to_ajouter_patient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(71)))), ((int)(((byte)(125)))));
            this.btn_to_ajouter_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_to_ajouter_patient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_to_ajouter_patient.ForeColor = System.Drawing.Color.White;
            this.btn_to_ajouter_patient.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_to_ajouter_patient.IconColor = System.Drawing.Color.White;
            this.btn_to_ajouter_patient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_to_ajouter_patient.IconSize = 30;
            this.btn_to_ajouter_patient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_to_ajouter_patient.Location = new System.Drawing.Point(647, 12);
            this.btn_to_ajouter_patient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_to_ajouter_patient.Name = "btn_to_ajouter_patient";
            this.btn_to_ajouter_patient.Size = new System.Drawing.Size(300, 46);
            this.btn_to_ajouter_patient.TabIndex = 4;
            this.btn_to_ajouter_patient.Text = "Ajouter Patient";
            this.btn_to_ajouter_patient.UseVisualStyleBackColor = false;
            this.btn_to_ajouter_patient.Click += new System.EventHandler(this.btn_to_ajouter_patient_Click);
            // 
            // Dgv_Patient
            // 
            this.Dgv_Patient.AllowUserToAddRows = false;
            this.Dgv_Patient.AllowUserToDeleteRows = false;
            this.Dgv_Patient.AllowUserToResizeRows = false;
            this.Dgv_Patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Patient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Dgv_Patient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Patient.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgv_Patient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Patient.ColumnHeadersHeight = 45;
            this.Dgv_Patient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.details,
            this.cin,
            this.nom,
            this.prenom,
            this.ville,
            this.Age,
            this.AjouterRDV,
            this.Supprimer});
            this.Dgv_Patient.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(198)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Patient.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Patient.EnableHeadersVisualStyles = false;
            this.Dgv_Patient.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Patient.Location = new System.Drawing.Point(4, 66);
            this.Dgv_Patient.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Patient.Name = "Dgv_Patient";
            this.Dgv_Patient.ReadOnly = true;
            this.Dgv_Patient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Patient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Patient.RowHeadersVisible = false;
            this.Dgv_Patient.RowHeadersWidth = 55;
            this.Dgv_Patient.RowTemplate.Height = 30;
            this.Dgv_Patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Patient.Size = new System.Drawing.Size(1060, 105);
            this.Dgv_Patient.TabIndex = 0;
            this.Dgv_Patient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Patient_CellClick);
            this.Dgv_Patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Patient_CellContentClick);
            this.Dgv_Patient.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv_Patient_CellFormatting);
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.details.HeaderText = "";
            this.details.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.details;
            this.details.MinimumWidth = 6;
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.details.Width = 28;
            // 
            // cin
            // 
            this.cin.FillWeight = 60F;
            this.cin.HeaderText = "CIN";
            this.cin.MinimumWidth = 6;
            this.cin.Name = "cin";
            this.cin.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prenom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // ville
            // 
            this.ville.FillWeight = 70F;
            this.ville.HeaderText = "Ville";
            this.ville.MinimumWidth = 6;
            this.ville.Name = "ville";
            this.ville.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // AjouterRDV
            // 
            this.AjouterRDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AjouterRDV.HeaderText = "";
            this.AjouterRDV.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.plus;
            this.AjouterRDV.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.AjouterRDV.MinimumWidth = 6;
            this.AjouterRDV.Name = "AjouterRDV";
            this.AjouterRDV.ReadOnly = true;
            this.AjouterRDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AjouterRDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AjouterRDV.Width = 28;
            // 
            // Supprimer
            // 
            this.Supprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Supprimer.HeaderText = "";
            this.Supprimer.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.delete1;
            this.Supprimer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Supprimer.MinimumWidth = 6;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Supprimer.ToolTipText = "Suppprimer patient choisie depuis la liste.";
            this.Supprimer.Width = 28;
            // 
            // label_cinn
            // 
            this.label_cinn.AutoSize = true;
            this.label_cinn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_cinn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_cinn.Location = new System.Drawing.Point(23, 25);
            this.label_cinn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cinn.Name = "label_cinn";
            this.label_cinn.Size = new System.Drawing.Size(196, 23);
            this.label_cinn.TabIndex = 3;
            this.label_cinn.Text = "CIN / Nom / Prenom";
            this.label_cinn.Click += new System.EventHandler(this.label_cinn_Click);
            // 
            // panel_ajouter_patient
            // 
            this.panel_ajouter_patient.Controls.Add(this.btn_refresh_p);
            this.panel_ajouter_patient.Controls.Add(this.label8);
            this.panel_ajouter_patient.Controls.Add(this.label7);
            this.panel_ajouter_patient.Controls.Add(this.dtp_naissance);
            this.panel_ajouter_patient.Controls.Add(this.panel_adresse);
            this.panel_ajouter_patient.Controls.Add(this.panel_tele);
            this.panel_ajouter_patient.Controls.Add(this.panel_prenom);
            this.panel_ajouter_patient.Controls.Add(this.panel_nom);
            this.panel_ajouter_patient.Controls.Add(this.panel_cin);
            this.panel_ajouter_patient.Controls.Add(this.tb_adresse);
            this.panel_ajouter_patient.Controls.Add(this.tb_telephone);
            this.panel_ajouter_patient.Controls.Add(this.tb_prenom);
            this.panel_ajouter_patient.Controls.Add(this.tb_nom);
            this.panel_ajouter_patient.Controls.Add(this.tb_CIN);
            this.panel_ajouter_patient.Controls.Add(this.label_date_naissance);
            this.panel_ajouter_patient.Controls.Add(this.label_Telephone);
            this.panel_ajouter_patient.Controls.Add(this.checkBox_enfant);
            this.panel_ajouter_patient.Controls.Add(this.groupBox1);
            this.panel_ajouter_patient.Controls.Add(this.cb_ville);
            this.panel_ajouter_patient.Controls.Add(this.Btn_retour);
            this.panel_ajouter_patient.Controls.Add(this.label_adresse);
            this.panel_ajouter_patient.Controls.Add(this.Btn_Ajouter_Patient);
            this.panel_ajouter_patient.Controls.Add(this.label_prenom);
            this.panel_ajouter_patient.Controls.Add(this.label_ville);
            this.panel_ajouter_patient.Controls.Add(this.label_nom);
            this.panel_ajouter_patient.Controls.Add(this.label_Cin);
            this.panel_ajouter_patient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_ajouter_patient.Location = new System.Drawing.Point(16, 4);
            this.panel_ajouter_patient.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ajouter_patient.Name = "panel_ajouter_patient";
            this.panel_ajouter_patient.Size = new System.Drawing.Size(1068, 450);
            this.panel_ajouter_patient.TabIndex = 17;
            this.panel_ajouter_patient.Visible = false;
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
            this.btn_refresh_p.Location = new System.Drawing.Point(1020, 5);
            this.btn_refresh_p.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh_p.Name = "btn_refresh_p";
            this.btn_refresh_p.Size = new System.Drawing.Size(44, 32);
            this.btn_refresh_p.TabIndex = 103;
            this.btn_refresh_p.TextColor = System.Drawing.Color.White;
            this.btn_refresh_p.UseVisualStyleBackColor = false;
            this.btn_refresh_p.Click += new System.EventHandler(this.btn_refresh_p_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(106, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 102;
            this.label8.Text = "* Champs obligatoir";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(139, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 83;
            this.label7.Text = "* ";
            // 
            // dtp_naissance
            // 
            this.dtp_naissance.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.dtp_naissance.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtp_naissance.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_naissance.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_naissance.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtp_naissance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dtp_naissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_naissance.Location = new System.Drawing.Point(105, 165);
            this.dtp_naissance.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_naissance.Name = "dtp_naissance";
            this.dtp_naissance.Size = new System.Drawing.Size(247, 32);
            this.dtp_naissance.TabIndex = 3;
            // 
            // panel_adresse
            // 
            this.panel_adresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_adresse.Location = new System.Drawing.Point(103, 274);
            this.panel_adresse.Margin = new System.Windows.Forms.Padding(4);
            this.panel_adresse.Name = "panel_adresse";
            this.panel_adresse.Size = new System.Drawing.Size(883, 2);
            this.panel_adresse.TabIndex = 100;
            // 
            // panel_tele
            // 
            this.panel_tele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_tele.Location = new System.Drawing.Point(405, 194);
            this.panel_tele.Margin = new System.Windows.Forms.Padding(4);
            this.panel_tele.Name = "panel_tele";
            this.panel_tele.Size = new System.Drawing.Size(247, 2);
            this.panel_tele.TabIndex = 100;
            // 
            // panel_prenom
            // 
            this.panel_prenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_prenom.Location = new System.Drawing.Point(696, 111);
            this.panel_prenom.Margin = new System.Windows.Forms.Padding(4);
            this.panel_prenom.Name = "panel_prenom";
            this.panel_prenom.Size = new System.Drawing.Size(291, 2);
            this.panel_prenom.TabIndex = 100;
            // 
            // panel_nom
            // 
            this.panel_nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_nom.Location = new System.Drawing.Point(405, 111);
            this.panel_nom.Margin = new System.Windows.Forms.Padding(4);
            this.panel_nom.Name = "panel_nom";
            this.panel_nom.Size = new System.Drawing.Size(247, 2);
            this.panel_nom.TabIndex = 100;
            // 
            // panel_cin
            // 
            this.panel_cin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_cin.Location = new System.Drawing.Point(105, 111);
            this.panel_cin.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cin.Name = "panel_cin";
            this.panel_cin.Size = new System.Drawing.Size(247, 2);
            this.panel_cin.TabIndex = 100;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_adresse.Location = new System.Drawing.Point(103, 242);
            this.tb_adresse.Margin = new System.Windows.Forms.Padding(4);
            this.tb_adresse.Multiline = true;
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(881, 35);
            this.tb_adresse.TabIndex = 6;
            // 
            // tb_telephone
            // 
            this.tb_telephone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_telephone.Location = new System.Drawing.Point(405, 162);
            this.tb_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.tb_telephone.Multiline = true;
            this.tb_telephone.Name = "tb_telephone";
            this.tb_telephone.Size = new System.Drawing.Size(247, 35);
            this.tb_telephone.TabIndex = 4;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_prenom.Location = new System.Drawing.Point(696, 79);
            this.tb_prenom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_prenom.Multiline = true;
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(291, 35);
            this.tb_prenom.TabIndex = 2;
            this.tb_prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_prenom_KeyPress);
            // 
            // tb_nom
            // 
            this.tb_nom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_nom.Location = new System.Drawing.Point(405, 79);
            this.tb_nom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nom.Multiline = true;
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(247, 35);
            this.tb_nom.TabIndex = 1;
            this.tb_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nom_KeyPress);
            // 
            // tb_CIN
            // 
            this.tb_CIN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_CIN.Location = new System.Drawing.Point(105, 79);
            this.tb_CIN.Margin = new System.Windows.Forms.Padding(4);
            this.tb_CIN.Multiline = true;
            this.tb_CIN.Name = "tb_CIN";
            this.tb_CIN.Size = new System.Drawing.Size(247, 35);
            this.tb_CIN.TabIndex = 0;
            // 
            // label_date_naissance
            // 
            this.label_date_naissance.AutoSize = true;
            this.label_date_naissance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_naissance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_date_naissance.Location = new System.Drawing.Point(101, 135);
            this.label_date_naissance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date_naissance.Name = "label_date_naissance";
            this.label_date_naissance.Size = new System.Drawing.Size(155, 23);
            this.label_date_naissance.TabIndex = 43;
            this.label_date_naissance.Text = "Date Naissance";
            // 
            // label_Telephone
            // 
            this.label_Telephone.AutoSize = true;
            this.label_Telephone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Telephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_Telephone.Location = new System.Drawing.Point(404, 135);
            this.label_Telephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Telephone.Name = "label_Telephone";
            this.label_Telephone.Size = new System.Drawing.Size(106, 23);
            this.label_Telephone.TabIndex = 45;
            this.label_Telephone.Text = "Telephone";
            // 
            // checkBox_enfant
            // 
            this.checkBox_enfant.AutoSize = true;
            this.checkBox_enfant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.checkBox_enfant.Location = new System.Drawing.Point(103, 9);
            this.checkBox_enfant.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_enfant.Name = "checkBox_enfant";
            this.checkBox_enfant.Size = new System.Drawing.Size(88, 27);
            this.checkBox_enfant.TabIndex = 81;
            this.checkBox_enfant.Text = "Enfant";
            this.checkBox_enfant.UseVisualStyleBackColor = true;
            this.checkBox_enfant.CheckedChanged += new System.EventHandler(this.checkBox_enfant_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_prenomResp);
            this.groupBox1.Controls.Add(this.tb_prenomResponsable);
            this.groupBox1.Controls.Add(this.panel_nomResp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_nomResponsable);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.groupBox1.Location = new System.Drawing.Point(105, 286);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(883, 105);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Responsable";
            this.groupBox1.Visible = false;
            // 
            // panel_prenomResp
            // 
            this.panel_prenomResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_prenomResp.Location = new System.Drawing.Point(485, 97);
            this.panel_prenomResp.Margin = new System.Windows.Forms.Padding(4);
            this.panel_prenomResp.Name = "panel_prenomResp";
            this.panel_prenomResp.Size = new System.Drawing.Size(247, 2);
            this.panel_prenomResp.TabIndex = 103;
            // 
            // tb_prenomResponsable
            // 
            this.tb_prenomResponsable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_prenomResponsable.Location = new System.Drawing.Point(485, 65);
            this.tb_prenomResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.tb_prenomResponsable.Multiline = true;
            this.tb_prenomResponsable.Name = "tb_prenomResponsable";
            this.tb_prenomResponsable.Size = new System.Drawing.Size(247, 35);
            this.tb_prenomResponsable.TabIndex = 1;
            this.tb_prenomResponsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_prenomResponsable_KeyPress);
            // 
            // panel_nomResp
            // 
            this.panel_nomResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_nomResp.Location = new System.Drawing.Point(109, 97);
            this.panel_nomResp.Margin = new System.Windows.Forms.Padding(4);
            this.panel_nomResp.Name = "panel_nomResp";
            this.panel_nomResp.Size = new System.Drawing.Size(247, 2);
            this.panel_nomResp.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label4.Location = new System.Drawing.Point(481, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = "Prenom Responsable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label6.Location = new System.Drawing.Point(105, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Nom Responsable";
            // 
            // tb_nomResponsable
            // 
            this.tb_nomResponsable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_nomResponsable.Location = new System.Drawing.Point(109, 65);
            this.tb_nomResponsable.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nomResponsable.Multiline = true;
            this.tb_nomResponsable.Name = "tb_nomResponsable";
            this.tb_nomResponsable.Size = new System.Drawing.Size(247, 35);
            this.tb_nomResponsable.TabIndex = 0;
            this.tb_nomResponsable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nomResponsable_KeyPress);
            // 
            // cb_ville
            // 
            this.cb_ville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ville.DropDownWidth = 106;
            this.cb_ville.FormattingEnabled = true;
            this.cb_ville.ItemHeight = 23;
            this.cb_ville.Location = new System.Drawing.Point(696, 166);
            this.cb_ville.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ville.Name = "cb_ville";
            this.cb_ville.Size = new System.Drawing.Size(291, 31);
            this.cb_ville.TabIndex = 27;
            // 
            // Btn_retour
            // 
            this.Btn_retour.BackColor = System.Drawing.Color.Red;
            this.Btn_retour.BackgroundColor = System.Drawing.Color.Red;
            this.Btn_retour.BorderColor = System.Drawing.Color.DarkMagenta;
            this.Btn_retour.BorderRadius = 20;
            this.Btn_retour.BorderSize = 0;
            this.Btn_retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_retour.FlatAppearance.BorderSize = 0;
            this.Btn_retour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Btn_retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retour.ForeColor = System.Drawing.Color.White;
            this.Btn_retour.Image = ((System.Drawing.Image)(resources.GetObject("Btn_retour.Image")));
            this.Btn_retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_retour.Location = new System.Drawing.Point(16, 398);
            this.Btn_retour.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_retour.Name = "Btn_retour";
            this.Btn_retour.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_retour.Size = new System.Drawing.Size(207, 44);
            this.Btn_retour.TabIndex = 53;
            this.Btn_retour.Text = "     Retour";
            this.Btn_retour.TextColor = System.Drawing.Color.White;
            this.Btn_retour.UseVisualStyleBackColor = false;
            this.Btn_retour.Click += new System.EventHandler(this.Btn_retour_Click);
            // 
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_adresse.Location = new System.Drawing.Point(99, 215);
            this.label_adresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(83, 23);
            this.label_adresse.TabIndex = 44;
            this.label_adresse.Text = "Adresse";
            // 
            // Btn_Ajouter_Patient
            // 
            this.Btn_Ajouter_Patient.BackColor = System.Drawing.Color.Green;
            this.Btn_Ajouter_Patient.BackgroundColor = System.Drawing.Color.Green;
            this.Btn_Ajouter_Patient.BorderColor = System.Drawing.Color.DarkMagenta;
            this.Btn_Ajouter_Patient.BorderRadius = 20;
            this.Btn_Ajouter_Patient.BorderSize = 0;
            this.Btn_Ajouter_Patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ajouter_Patient.FlatAppearance.BorderSize = 0;
            this.Btn_Ajouter_Patient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.Btn_Ajouter_Patient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.Btn_Ajouter_Patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ajouter_Patient.ForeColor = System.Drawing.Color.White;
            this.Btn_Ajouter_Patient.Location = new System.Drawing.Point(379, 398);
            this.Btn_Ajouter_Patient.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ajouter_Patient.Name = "Btn_Ajouter_Patient";
            this.Btn_Ajouter_Patient.Size = new System.Drawing.Size(348, 44);
            this.Btn_Ajouter_Patient.TabIndex = 7;
            this.Btn_Ajouter_Patient.Text = "Ajouter le patient";
            this.Btn_Ajouter_Patient.TextColor = System.Drawing.Color.White;
            this.Btn_Ajouter_Patient.UseVisualStyleBackColor = false;
            this.Btn_Ajouter_Patient.Click += new System.EventHandler(this.Btn_Ajouter_Patient_Click);
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_prenom.Location = new System.Drawing.Point(692, 43);
            this.label_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(80, 23);
            this.label_prenom.TabIndex = 46;
            this.label_prenom.Text = "Prenom";
            // 
            // label_ville
            // 
            this.label_ville.AutoSize = true;
            this.label_ville.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ville.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_ville.Location = new System.Drawing.Point(688, 140);
            this.label_ville.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ville.Name = "label_ville";
            this.label_ville.Size = new System.Drawing.Size(50, 23);
            this.label_ville.TabIndex = 47;
            this.label_ville.Text = "Ville";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_nom.Location = new System.Drawing.Point(403, 43);
            this.label_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(54, 23);
            this.label_nom.TabIndex = 48;
            this.label_nom.Text = "Nom";
            // 
            // label_Cin
            // 
            this.label_Cin.AutoSize = true;
            this.label_Cin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_Cin.Location = new System.Drawing.Point(101, 43);
            this.label_Cin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Cin.Name = "label_Cin";
            this.label_Cin.Size = new System.Drawing.Size(46, 23);
            this.label_Cin.TabIndex = 49;
            this.label_Cin.Text = "Cin ";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.plus;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Visible = false;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.delete1;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Visible = false;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Final_Form_Doctor_s_Office.Properties.Resources.delete1;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // toolTipAjouterPa
            // 
            this.toolTipAjouterPa.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipMineur
            // 
            this.toolTipMineur.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipTbRecherche
            // 
            this.toolTipTbRecherche.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip_refesh
            // 
            this.toolTip_refesh.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipinfo
            // 
            this.toolTipinfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // UC_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.panel_Full_Form_Patient);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Patient";
            this.Size = new System.Drawing.Size(1100, 638);
            this.Load += new System.EventHandler(this.UC_Patient_Load);
            this.ClientSizeChanged += new System.EventHandler(this.UC_Patient_ClientSizeChanged);
            this.panel_Full_Form_Patient.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Patient)).EndInit();
            this.panel_ajouter_patient.ResumeLayout(false);
            this.panel_ajouter_patient.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Full_Form_Patient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_recherche;
        private Gestion_Commerciale.Classes.CButton bt_refresh;
        private FontAwesome.Sharp.IconButton btn_to_ajouter_patient;
        private System.Windows.Forms.DataGridView Dgv_Patient;
        private System.Windows.Forms.Label label_cinn;
        private System.Windows.Forms.Panel panel_ajouter_patient;
        private Gestion_Commerciale.Classes.CButton btn_refresh_p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_naissance;
        private System.Windows.Forms.Panel panel_adresse;
        private System.Windows.Forms.Panel panel_tele;
        private System.Windows.Forms.Panel panel_prenom;
        private System.Windows.Forms.Panel panel_nom;
        private System.Windows.Forms.Panel panel_cin;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.TextBox tb_telephone;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_CIN;
        private System.Windows.Forms.Label label_date_naissance;
        private System.Windows.Forms.Label label_Telephone;
        private System.Windows.Forms.CheckBox checkBox_enfant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_prenomResp;
        private System.Windows.Forms.TextBox tb_prenomResponsable;
        private System.Windows.Forms.Panel panel_nomResp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_nomResponsable;
        private System.Windows.Forms.ComboBox cb_ville;
        private Gestion_Commerciale.Classes.CButton Btn_retour;
        private System.Windows.Forms.Label label_adresse;
        private Gestion_Commerciale.Classes.CButton Btn_Ajouter_Patient;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_ville;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_Cin;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.ToolTip toolTipAjouterPa;
        private System.Windows.Forms.ToolTip toolTipMineur;
        private System.Windows.Forms.ToolTip toolTipTbRecherche;
        private System.Windows.Forms.ToolTip toolTip_refesh;
        private System.Windows.Forms.DataGridViewImageColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewImageColumn AjouterRDV;
        private System.Windows.Forms.DataGridViewImageColumn Supprimer;
        private System.Windows.Forms.ToolTip toolTipinfo;
    }
}
