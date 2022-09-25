
namespace Final_Form_Doctor_s_Office.Forms.UC_Forms
{
    partial class UC_Medicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Medicament));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_full_form = new System.Windows.Forms.Panel();
            this.btn_refresh_p = new Gestion_Commerciale.Classes.CButton();
            this.gp_dgv_medicaments = new System.Windows.Forms.GroupBox();
            this.Dgv_medicament = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gp_nouveau_medicament = new System.Windows.Forms.GroupBox();
            this.cb_typeMedicaments = new System.Windows.Forms.ComboBox();
            this.panel_cin = new System.Windows.Forms.Panel();
            this.tb_intitule = new System.Windows.Forms.TextBox();
            this.btn_ajouter_medicament = new Gestion_Commerciale.Classes.CButton();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Intitule = new System.Windows.Forms.Label();
            this.toolTipinfo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_refreche = new System.Windows.Forms.ToolTip(this.components);
            this.panel_full_form.SuspendLayout();
            this.gp_dgv_medicaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_medicament)).BeginInit();
            this.gp_nouveau_medicament.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_full_form
            // 
            this.panel_full_form.Controls.Add(this.btn_refresh_p);
            this.panel_full_form.Controls.Add(this.gp_dgv_medicaments);
            this.panel_full_form.Controls.Add(this.gp_nouveau_medicament);
            this.panel_full_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_full_form.Location = new System.Drawing.Point(0, 0);
            this.panel_full_form.Margin = new System.Windows.Forms.Padding(4);
            this.panel_full_form.Name = "panel_full_form";
            this.panel_full_form.Size = new System.Drawing.Size(1000, 588);
            this.panel_full_form.TabIndex = 0;
            this.panel_full_form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_full_form_Paint);
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
            this.btn_refresh_p.Location = new System.Drawing.Point(940, 4);
            this.btn_refresh_p.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh_p.Name = "btn_refresh_p";
            this.btn_refresh_p.Size = new System.Drawing.Size(44, 32);
            this.btn_refresh_p.TabIndex = 113;
            this.btn_refresh_p.TextColor = System.Drawing.Color.White;
            this.btn_refresh_p.UseVisualStyleBackColor = false;
            this.btn_refresh_p.Click += new System.EventHandler(this.btn_refresh_p_Click);
            // 
            // gp_dgv_medicaments
            // 
            this.gp_dgv_medicaments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_dgv_medicaments.Controls.Add(this.Dgv_medicament);
            this.gp_dgv_medicaments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_dgv_medicaments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.gp_dgv_medicaments.Location = new System.Drawing.Point(17, 271);
            this.gp_dgv_medicaments.Margin = new System.Windows.Forms.Padding(4);
            this.gp_dgv_medicaments.Name = "gp_dgv_medicaments";
            this.gp_dgv_medicaments.Padding = new System.Windows.Forms.Padding(4);
            this.gp_dgv_medicaments.Size = new System.Drawing.Size(967, 310);
            this.gp_dgv_medicaments.TabIndex = 112;
            this.gp_dgv_medicaments.TabStop = false;
            this.gp_dgv_medicaments.Text = "Liste des medicaments ";
            // 
            // Dgv_medicament
            // 
            this.Dgv_medicament.AllowUserToAddRows = false;
            this.Dgv_medicament.AllowUserToDeleteRows = false;
            this.Dgv_medicament.AllowUserToResizeRows = false;
            this.Dgv_medicament.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_medicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_medicament.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Dgv_medicament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_medicament.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgv_medicament.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_medicament.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_medicament.ColumnHeadersHeight = 45;
            this.Dgv_medicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Intitule,
            this.Description});
            this.Dgv_medicament.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(198)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_medicament.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_medicament.EnableHeadersVisualStyles = false;
            this.Dgv_medicament.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_medicament.Location = new System.Drawing.Point(8, 44);
            this.Dgv_medicament.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_medicament.Name = "Dgv_medicament";
            this.Dgv_medicament.ReadOnly = true;
            this.Dgv_medicament.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_medicament.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_medicament.RowHeadersVisible = false;
            this.Dgv_medicament.RowHeadersWidth = 55;
            this.Dgv_medicament.RowTemplate.Height = 40;
            this.Dgv_medicament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_medicament.Size = new System.Drawing.Size(951, 255);
            this.Dgv_medicament.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Intitule
            // 
            this.Intitule.HeaderText = "Intitule";
            this.Intitule.MinimumWidth = 6;
            this.Intitule.Name = "Intitule";
            this.Intitule.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // gp_nouveau_medicament
            // 
            this.gp_nouveau_medicament.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_nouveau_medicament.Controls.Add(this.cb_typeMedicaments);
            this.gp_nouveau_medicament.Controls.Add(this.panel_cin);
            this.gp_nouveau_medicament.Controls.Add(this.tb_intitule);
            this.gp_nouveau_medicament.Controls.Add(this.btn_ajouter_medicament);
            this.gp_nouveau_medicament.Controls.Add(this.label_Description);
            this.gp_nouveau_medicament.Controls.Add(this.label_Intitule);
            this.gp_nouveau_medicament.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_nouveau_medicament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.gp_nouveau_medicament.Location = new System.Drawing.Point(17, 48);
            this.gp_nouveau_medicament.Margin = new System.Windows.Forms.Padding(4);
            this.gp_nouveau_medicament.Name = "gp_nouveau_medicament";
            this.gp_nouveau_medicament.Padding = new System.Windows.Forms.Padding(4);
            this.gp_nouveau_medicament.Size = new System.Drawing.Size(967, 215);
            this.gp_nouveau_medicament.TabIndex = 111;
            this.gp_nouveau_medicament.TabStop = false;
            this.gp_nouveau_medicament.Text = "Ajouter medicament";
            // 
            // cb_typeMedicaments
            // 
            this.cb_typeMedicaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typeMedicaments.FormattingEnabled = true;
            this.cb_typeMedicaments.Location = new System.Drawing.Point(323, 102);
            this.cb_typeMedicaments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_typeMedicaments.Name = "cb_typeMedicaments";
            this.cb_typeMedicaments.Size = new System.Drawing.Size(508, 31);
            this.cb_typeMedicaments.TabIndex = 103;
            // 
            // panel_cin
            // 
            this.panel_cin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel_cin.Location = new System.Drawing.Point(323, 78);
            this.panel_cin.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cin.Name = "panel_cin";
            this.panel_cin.Size = new System.Drawing.Size(508, 2);
            this.panel_cin.TabIndex = 102;
            // 
            // tb_intitule
            // 
            this.tb_intitule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_intitule.Location = new System.Drawing.Point(323, 46);
            this.tb_intitule.Margin = new System.Windows.Forms.Padding(4);
            this.tb_intitule.Multiline = true;
            this.tb_intitule.Name = "tb_intitule";
            this.tb_intitule.Size = new System.Drawing.Size(508, 35);
            this.tb_intitule.TabIndex = 101;
            // 
            // btn_ajouter_medicament
            // 
            this.btn_ajouter_medicament.BackColor = System.Drawing.Color.Green;
            this.btn_ajouter_medicament.BackgroundColor = System.Drawing.Color.Green;
            this.btn_ajouter_medicament.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ajouter_medicament.BorderRadius = 20;
            this.btn_ajouter_medicament.BorderSize = 0;
            this.btn_ajouter_medicament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajouter_medicament.FlatAppearance.BorderSize = 0;
            this.btn_ajouter_medicament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btn_ajouter_medicament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.btn_ajouter_medicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter_medicament.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_medicament.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter_medicament.Location = new System.Drawing.Point(557, 149);
            this.btn_ajouter_medicament.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter_medicament.Name = "btn_ajouter_medicament";
            this.btn_ajouter_medicament.Size = new System.Drawing.Size(273, 49);
            this.btn_ajouter_medicament.TabIndex = 4;
            this.btn_ajouter_medicament.Text = "Ajouter";
            this.btn_ajouter_medicament.TextColor = System.Drawing.Color.White;
            this.btn_ajouter_medicament.UseVisualStyleBackColor = false;
            this.btn_ajouter_medicament.Click += new System.EventHandler(this.btn_ajouter_medicament_Click);
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_Description.Location = new System.Drawing.Point(80, 102);
            this.label_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(119, 23);
            this.label_Description.TabIndex = 3;
            this.label_Description.Text = "Description";
            // 
            // label_Intitule
            // 
            this.label_Intitule.AutoSize = true;
            this.label_Intitule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label_Intitule.Location = new System.Drawing.Point(80, 46);
            this.label_Intitule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Intitule.Name = "label_Intitule";
            this.label_Intitule.Size = new System.Drawing.Size(75, 23);
            this.label_Intitule.TabIndex = 3;
            this.label_Intitule.Text = "Intitule";
            // 
            // UC_Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.panel_full_form);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Medicament";
            this.Size = new System.Drawing.Size(1000, 588);
            this.Load += new System.EventHandler(this.UC_Medicament_Load);
            this.panel_full_form.ResumeLayout(false);
            this.gp_dgv_medicaments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_medicament)).EndInit();
            this.gp_nouveau_medicament.ResumeLayout(false);
            this.gp_nouveau_medicament.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_full_form;
        private Gestion_Commerciale.Classes.CButton btn_refresh_p;
        private System.Windows.Forms.GroupBox gp_dgv_medicaments;
        private System.Windows.Forms.DataGridView Dgv_medicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intitule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.GroupBox gp_nouveau_medicament;
        private System.Windows.Forms.ComboBox cb_typeMedicaments;
        private System.Windows.Forms.Panel panel_cin;
        private System.Windows.Forms.TextBox tb_intitule;
        private Gestion_Commerciale.Classes.CButton btn_ajouter_medicament;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Intitule;
        private System.Windows.Forms.ToolTip toolTipinfo;
        private System.Windows.Forms.ToolTip toolTip_refreche;
    }
}
