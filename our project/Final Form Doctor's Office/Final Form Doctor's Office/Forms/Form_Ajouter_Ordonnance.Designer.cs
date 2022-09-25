
namespace Final_Form_Doctor_s_Office.Forms
{
    partial class Form_Ajouter_Ordonnance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajouter_Ordonnance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gp_ordonnance = new System.Windows.Forms.GroupBox();
            this.btn_info_p = new Gestion_Commerciale.Classes.CButton();
            this.btn_refresh_p = new Gestion_Commerciale.Classes.CButton();
            this.panel_posologie = new System.Windows.Forms.Panel();
            this.tb_posologie = new System.Windows.Forms.TextBox();
            this.Btn_retour = new Gestion_Commerciale.Classes.CButton();
            this.cb_typeMedicaments = new System.Windows.Forms.ComboBox();
            this.cb_medicament = new System.Windows.Forms.ComboBox();
            this.Dgv_intitule = new System.Windows.Forms.DataGridView();
            this.ID_odo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posologie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Posologie = new System.Windows.Forms.Label();
            this.label_Medicament = new System.Windows.Forms.Label();
            this.btn_imprimer_ordonnance = new Gestion_Commerciale.Classes.CButton();
            this.btn_ajouter_medicament = new Gestion_Commerciale.Classes.CButton();
            this.panel_title_bar_detailForm = new System.Windows.Forms.Panel();
            this.btn_Exit_Form = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gp_ordonnance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_intitule)).BeginInit();
            this.panel_title_bar_detailForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_ordonnance
            // 
            this.gp_ordonnance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_ordonnance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.gp_ordonnance.Controls.Add(this.btn_info_p);
            this.gp_ordonnance.Controls.Add(this.btn_refresh_p);
            this.gp_ordonnance.Controls.Add(this.panel_posologie);
            this.gp_ordonnance.Controls.Add(this.tb_posologie);
            this.gp_ordonnance.Controls.Add(this.Btn_retour);
            this.gp_ordonnance.Controls.Add(this.cb_typeMedicaments);
            this.gp_ordonnance.Controls.Add(this.cb_medicament);
            this.gp_ordonnance.Controls.Add(this.Dgv_intitule);
            this.gp_ordonnance.Controls.Add(this.label1);
            this.gp_ordonnance.Controls.Add(this.label_Posologie);
            this.gp_ordonnance.Controls.Add(this.label_Medicament);
            this.gp_ordonnance.Controls.Add(this.btn_imprimer_ordonnance);
            this.gp_ordonnance.Controls.Add(this.btn_ajouter_medicament);
            this.gp_ordonnance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_ordonnance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_ordonnance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.gp_ordonnance.Location = new System.Drawing.Point(16, 49);
            this.gp_ordonnance.Margin = new System.Windows.Forms.Padding(4);
            this.gp_ordonnance.Name = "gp_ordonnance";
            this.gp_ordonnance.Padding = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.gp_ordonnance.Size = new System.Drawing.Size(1029, 542);
            this.gp_ordonnance.TabIndex = 5;
            this.gp_ordonnance.TabStop = false;
            this.gp_ordonnance.Text = " ";
            // 
            // btn_info_p
            // 
            this.btn_info_p.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_info_p.BackColor = System.Drawing.Color.Transparent;
            this.btn_info_p.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_info_p.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btn_info_p.BorderRadius = 20;
            this.btn_info_p.BorderSize = 0;
            this.btn_info_p.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info_p.FlatAppearance.BorderSize = 0;
            this.btn_info_p.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(154)))), ((int)(((byte)(140)))));
            this.btn_info_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info_p.ForeColor = System.Drawing.Color.White;
            this.btn_info_p.Image = ((System.Drawing.Image)(resources.GetObject("btn_info_p.Image")));
            this.btn_info_p.Location = new System.Drawing.Point(985, 0);
            this.btn_info_p.Margin = new System.Windows.Forms.Padding(4);
            this.btn_info_p.Name = "btn_info_p";
            this.btn_info_p.Size = new System.Drawing.Size(44, 32);
            this.btn_info_p.TabIndex = 106;
            this.btn_info_p.TextColor = System.Drawing.Color.White;
            this.btn_info_p.UseVisualStyleBackColor = false;
            this.btn_info_p.Click += new System.EventHandler(this.btn_info_p_Click);
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
            this.btn_refresh_p.Location = new System.Drawing.Point(933, 0);
            this.btn_refresh_p.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh_p.Name = "btn_refresh_p";
            this.btn_refresh_p.Size = new System.Drawing.Size(44, 32);
            this.btn_refresh_p.TabIndex = 105;
            this.btn_refresh_p.TextColor = System.Drawing.Color.White;
            this.btn_refresh_p.UseVisualStyleBackColor = false;
            this.btn_refresh_p.Click += new System.EventHandler(this.btn_refresh_p_Click);
            // 
            // panel_posologie
            // 
            this.panel_posologie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_posologie.Location = new System.Drawing.Point(259, 124);
            this.panel_posologie.Margin = new System.Windows.Forms.Padding(4);
            this.panel_posologie.Name = "panel_posologie";
            this.panel_posologie.Size = new System.Drawing.Size(431, 2);
            this.panel_posologie.TabIndex = 98;
            // 
            // tb_posologie
            // 
            this.tb_posologie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_posologie.Location = new System.Drawing.Point(259, 92);
            this.tb_posologie.Margin = new System.Windows.Forms.Padding(4);
            this.tb_posologie.Multiline = true;
            this.tb_posologie.Name = "tb_posologie";
            this.tb_posologie.Size = new System.Drawing.Size(431, 35);
            this.tb_posologie.TabIndex = 97;
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
            this.Btn_retour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_retour.ForeColor = System.Drawing.Color.White;
            this.Btn_retour.Image = ((System.Drawing.Image)(resources.GetObject("Btn_retour.Image")));
            this.Btn_retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_retour.Location = new System.Drawing.Point(8, 481);
            this.Btn_retour.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_retour.Name = "Btn_retour";
            this.Btn_retour.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_retour.Size = new System.Drawing.Size(144, 44);
            this.Btn_retour.TabIndex = 96;
            this.Btn_retour.Text = "     Retour";
            this.Btn_retour.TextColor = System.Drawing.Color.White;
            this.Btn_retour.UseVisualStyleBackColor = false;
            this.Btn_retour.Click += new System.EventHandler(this.Btn_retour_Click_1);
            // 
            // cb_typeMedicaments
            // 
            this.cb_typeMedicaments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_typeMedicaments.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cb_typeMedicaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typeMedicaments.DropDownWidth = 213;
            this.cb_typeMedicaments.FormattingEnabled = true;
            this.cb_typeMedicaments.Location = new System.Drawing.Point(259, 15);
            this.cb_typeMedicaments.Margin = new System.Windows.Forms.Padding(4);
            this.cb_typeMedicaments.Name = "cb_typeMedicaments";
            this.cb_typeMedicaments.Size = new System.Drawing.Size(560, 31);
            this.cb_typeMedicaments.TabIndex = 69;
            this.cb_typeMedicaments.SelectedIndexChanged += new System.EventHandler(this.cb_typeMedicaments_SelectedIndexChanged_1);
            // 
            // cb_medicament
            // 
            this.cb_medicament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_medicament.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_medicament.FormattingEnabled = true;
            this.cb_medicament.Location = new System.Drawing.Point(259, 53);
            this.cb_medicament.Margin = new System.Windows.Forms.Padding(4);
            this.cb_medicament.Name = "cb_medicament";
            this.cb_medicament.Size = new System.Drawing.Size(725, 31);
            this.cb_medicament.TabIndex = 69;
            // 
            // Dgv_intitule
            // 
            this.Dgv_intitule.AllowUserToAddRows = false;
            this.Dgv_intitule.AllowUserToDeleteRows = false;
            this.Dgv_intitule.AllowUserToResizeRows = false;
            this.Dgv_intitule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_intitule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_intitule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Dgv_intitule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_intitule.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgv_intitule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(96)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_intitule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_intitule.ColumnHeadersHeight = 45;
            this.Dgv_intitule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_odo,
            this.dataGridViewTextBoxColumn1,
            this.Posologie,
            this.Supprimer});
            this.Dgv_intitule.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(198)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_intitule.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_intitule.EnableHeadersVisualStyles = false;
            this.Dgv_intitule.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_intitule.Location = new System.Drawing.Point(12, 185);
            this.Dgv_intitule.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_intitule.Name = "Dgv_intitule";
            this.Dgv_intitule.ReadOnly = true;
            this.Dgv_intitule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_intitule.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_intitule.RowHeadersVisible = false;
            this.Dgv_intitule.RowHeadersWidth = 55;
            this.Dgv_intitule.RowTemplate.Height = 30;
            this.Dgv_intitule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_intitule.Size = new System.Drawing.Size(1003, 289);
            this.Dgv_intitule.TabIndex = 0;
            this.Dgv_intitule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_intitule_CellContentClick);
            // 
            // ID_odo
            // 
            this.ID_odo.HeaderText = "ID";
            this.ID_odo.MinimumWidth = 6;
            this.ID_odo.Name = "ID_odo";
            this.ID_odo.ReadOnly = true;
            this.ID_odo.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 194.9239F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Intitule";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Posologie
            // 
            this.Posologie.FillWeight = 5.076141F;
            this.Posologie.HeaderText = "Posologie";
            this.Posologie.MinimumWidth = 200;
            this.Posologie.Name = "Posologie";
            this.Posologie.ReadOnly = true;
            // 
            // Supprimer
            // 
            this.Supprimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Supprimer.HeaderText = "";
            this.Supprimer.Image = ((System.Drawing.Image)(resources.GetObject("Supprimer.Image")));
            this.Supprimer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Supprimer.MinimumWidth = 6;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Supprimer.Width = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type medicaments";
            // 
            // label_Posologie
            // 
            this.label_Posologie.AutoSize = true;
            this.label_Posologie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_Posologie.Location = new System.Drawing.Point(73, 95);
            this.label_Posologie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Posologie.Name = "label_Posologie";
            this.label_Posologie.Size = new System.Drawing.Size(105, 23);
            this.label_Posologie.TabIndex = 5;
            this.label_Posologie.Text = "Posologie";
            // 
            // label_Medicament
            // 
            this.label_Medicament.AutoSize = true;
            this.label_Medicament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_Medicament.Location = new System.Drawing.Point(55, 56);
            this.label_Medicament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Medicament.Name = "label_Medicament";
            this.label_Medicament.Size = new System.Drawing.Size(135, 23);
            this.label_Medicament.TabIndex = 4;
            this.label_Medicament.Text = "Medicament";
            // 
            // btn_imprimer_ordonnance
            // 
            this.btn_imprimer_ordonnance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_imprimer_ordonnance.BackColor = System.Drawing.Color.Green;
            this.btn_imprimer_ordonnance.BackgroundColor = System.Drawing.Color.Green;
            this.btn_imprimer_ordonnance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_imprimer_ordonnance.BorderRadius = 20;
            this.btn_imprimer_ordonnance.BorderSize = 0;
            this.btn_imprimer_ordonnance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimer_ordonnance.FlatAppearance.BorderSize = 0;
            this.btn_imprimer_ordonnance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btn_imprimer_ordonnance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.btn_imprimer_ordonnance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimer_ordonnance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_imprimer_ordonnance.ForeColor = System.Drawing.Color.White;
            this.btn_imprimer_ordonnance.Location = new System.Drawing.Point(365, 481);
            this.btn_imprimer_ordonnance.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imprimer_ordonnance.Name = "btn_imprimer_ordonnance";
            this.btn_imprimer_ordonnance.Size = new System.Drawing.Size(431, 44);
            this.btn_imprimer_ordonnance.TabIndex = 3;
            this.btn_imprimer_ordonnance.Text = "Imprimer l\'Ordonnance";
            this.btn_imprimer_ordonnance.TextColor = System.Drawing.Color.White;
            this.btn_imprimer_ordonnance.UseVisualStyleBackColor = false;
            this.btn_imprimer_ordonnance.Click += new System.EventHandler(this.btn_imprimer_ordonnance_Click);
            // 
            // btn_ajouter_medicament
            // 
            this.btn_ajouter_medicament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ajouter_medicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btn_ajouter_medicament.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.btn_ajouter_medicament.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ajouter_medicament.BorderRadius = 20;
            this.btn_ajouter_medicament.BorderSize = 0;
            this.btn_ajouter_medicament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajouter_medicament.FlatAppearance.BorderSize = 0;
            this.btn_ajouter_medicament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            this.btn_ajouter_medicament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(71)))), ((int)(((byte)(125)))));
            this.btn_ajouter_medicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter_medicament.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter_medicament.Location = new System.Drawing.Point(336, 135);
            this.btn_ajouter_medicament.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter_medicament.Name = "btn_ajouter_medicament";
            this.btn_ajouter_medicament.Size = new System.Drawing.Size(272, 39);
            this.btn_ajouter_medicament.TabIndex = 2;
            this.btn_ajouter_medicament.Text = "Ajouter medicament";
            this.btn_ajouter_medicament.TextColor = System.Drawing.Color.White;
            this.btn_ajouter_medicament.UseVisualStyleBackColor = false;
            this.btn_ajouter_medicament.Click += new System.EventHandler(this.btn_ajouter_medicament_Click);
            // 
            // panel_title_bar_detailForm
            // 
            this.panel_title_bar_detailForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_title_bar_detailForm.Controls.Add(this.btn_Exit_Form);
            this.panel_title_bar_detailForm.Controls.Add(this.label2);
            this.panel_title_bar_detailForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title_bar_detailForm.Location = new System.Drawing.Point(0, 0);
            this.panel_title_bar_detailForm.Margin = new System.Windows.Forms.Padding(4);
            this.panel_title_bar_detailForm.Name = "panel_title_bar_detailForm";
            this.panel_title_bar_detailForm.Size = new System.Drawing.Size(1061, 38);
            this.panel_title_bar_detailForm.TabIndex = 57;
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
            this.btn_Exit_Form.Location = new System.Drawing.Point(997, 4);
            this.btn_Exit_Form.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit_Form.Name = "btn_Exit_Form";
            this.btn_Exit_Form.Size = new System.Drawing.Size(60, 30);
            this.btn_Exit_Form.TabIndex = 5;
            this.btn_Exit_Form.Text = "X";
            this.btn_Exit_Form.UseVisualStyleBackColor = false;
            this.btn_Exit_Form.Click += new System.EventHandler(this.btn_Exit_Form_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remplissage de l\'ordonnance";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // Form_Ajouter_Ordonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1061, 603);
            this.Controls.Add(this.panel_title_bar_detailForm);
            this.Controls.Add(this.gp_ordonnance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Ajouter_Ordonnance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Ajouter_Ordonnance";
            this.Load += new System.EventHandler(this.Form_Ajouter_Ordonnance_Load);
            this.gp_ordonnance.ResumeLayout(false);
            this.gp_ordonnance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_intitule)).EndInit();
            this.panel_title_bar_detailForm.ResumeLayout(false);
            this.panel_title_bar_detailForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_ordonnance;
        private System.Windows.Forms.ComboBox cb_medicament;
        private System.Windows.Forms.DataGridView Dgv_intitule;
        private System.Windows.Forms.Label label_Posologie;
        private System.Windows.Forms.Label label_Medicament;
        private Gestion_Commerciale.Classes.CButton btn_imprimer_ordonnance;
        private Gestion_Commerciale.Classes.CButton btn_ajouter_medicament;
        private System.Windows.Forms.Panel panel_title_bar_detailForm;
        private FontAwesome.Sharp.IconButton btn_Exit_Form;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Gestion_Commerciale.Classes.CButton Btn_retour;
        private System.Windows.Forms.Panel panel_posologie;
        private System.Windows.Forms.TextBox tb_posologie;
        private Gestion_Commerciale.Classes.CButton btn_info_p;
        private Gestion_Commerciale.Classes.CButton btn_refresh_p;
        private System.Windows.Forms.ComboBox cb_typeMedicaments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_odo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posologie;
        private System.Windows.Forms.DataGridViewImageColumn Supprimer;
    }
}