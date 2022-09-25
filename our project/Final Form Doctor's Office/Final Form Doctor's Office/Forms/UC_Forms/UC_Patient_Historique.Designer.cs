
namespace Final_Form_Doctor_s_Office.Forms.UC_Forms
{
    partial class UC_Patient_Historique
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Patient_Historique));
            this.label8 = new System.Windows.Forms.Label();
            this.Dgv_intitule = new System.Windows.Forms.DataGridView();
            this.Intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_Patient_visite = new System.Windows.Forms.DataGridView();
            this.date_visite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Cin = new System.Windows.Forms.Label();
            this.btn_refresh_p = new Gestion_Commerciale.Classes.CButton();
            this.btn_imprimer_ordonnance = new Gestion_Commerciale.Classes.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_intitule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Patient_visite)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(84, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 13);
            this.label8.TabIndex = 131;
            this.label8.Text = "- double click pour afficher l\'ordonnance de la visite ";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_intitule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_intitule.ColumnHeadersHeight = 45;
            this.Dgv_intitule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intitule});
            this.Dgv_intitule.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(198)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_intitule.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_intitule.EnableHeadersVisualStyles = false;
            this.Dgv_intitule.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_intitule.Location = new System.Drawing.Point(351, 48);
            this.Dgv_intitule.Name = "Dgv_intitule";
            this.Dgv_intitule.ReadOnly = true;
            this.Dgv_intitule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_intitule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_intitule.RowHeadersVisible = false;
            this.Dgv_intitule.RowHeadersWidth = 55;
            this.Dgv_intitule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_intitule.Size = new System.Drawing.Size(407, 307);
            this.Dgv_intitule.TabIndex = 127;
            // 
            // Intitule
            // 
            this.Intitule.HeaderText = "Intitule";
            this.Intitule.MinimumWidth = 6;
            this.Intitule.Name = "Intitule";
            this.Intitule.ReadOnly = true;
            // 
            // Dgv_Patient_visite
            // 
            this.Dgv_Patient_visite.AllowUserToAddRows = false;
            this.Dgv_Patient_visite.AllowUserToDeleteRows = false;
            this.Dgv_Patient_visite.AllowUserToResizeRows = false;
            this.Dgv_Patient_visite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dgv_Patient_visite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Patient_visite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Dgv_Patient_visite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Patient_visite.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.Dgv_Patient_visite.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(54)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Patient_visite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Patient_visite.ColumnHeadersHeight = 45;
            this.Dgv_Patient_visite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date_visite});
            this.Dgv_Patient_visite.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(198)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Patient_visite.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Patient_visite.EnableHeadersVisualStyles = false;
            this.Dgv_Patient_visite.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Patient_visite.Location = new System.Drawing.Point(6, 48);
            this.Dgv_Patient_visite.Name = "Dgv_Patient_visite";
            this.Dgv_Patient_visite.ReadOnly = true;
            this.Dgv_Patient_visite.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Patient_visite.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Patient_visite.RowHeadersVisible = false;
            this.Dgv_Patient_visite.RowHeadersWidth = 55;
            this.Dgv_Patient_visite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Patient_visite.Size = new System.Drawing.Size(339, 351);
            this.Dgv_Patient_visite.TabIndex = 128;
            this.Dgv_Patient_visite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Patient_visite_CellContentClick);
            this.Dgv_Patient_visite.DoubleClick += new System.EventHandler(this.Dgv_Patient_visite_DoubleClick);
            // 
            // date_visite
            // 
            this.date_visite.HeaderText = "Date Visite";
            this.date_visite.MinimumWidth = 6;
            this.date_visite.Name = "date_visite";
            this.date_visite.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 129;
            this.label3.Text = "Visites de patient";
            // 
            // label_Cin
            // 
            this.label_Cin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Cin.AutoSize = true;
            this.label_Cin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.label_Cin.Location = new System.Drawing.Point(352, 9);
            this.label_Cin.Name = "label_Cin";
            this.label_Cin.Size = new System.Drawing.Size(185, 18);
            this.label_Cin.TabIndex = 130;
            this.label_Cin.Text = "Ordonnance de la visite";
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
            this.btn_refresh_p.Location = new System.Drawing.Point(729, 3);
            this.btn_refresh_p.Name = "btn_refresh_p";
            this.btn_refresh_p.Size = new System.Drawing.Size(33, 26);
            this.btn_refresh_p.TabIndex = 132;
            this.btn_refresh_p.TextColor = System.Drawing.Color.White;
            this.btn_refresh_p.UseVisualStyleBackColor = false;
            this.btn_refresh_p.Click += new System.EventHandler(this.btn_refresh_p_Click);
            // 
            // btn_imprimer_ordonnance
            // 
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
            this.btn_imprimer_ordonnance.Location = new System.Drawing.Point(460, 361);
            this.btn_imprimer_ordonnance.Name = "btn_imprimer_ordonnance";
            this.btn_imprimer_ordonnance.Size = new System.Drawing.Size(238, 38);
            this.btn_imprimer_ordonnance.TabIndex = 133;
            this.btn_imprimer_ordonnance.Text = "Imprimer l\'Ordonnance";
            this.btn_imprimer_ordonnance.TextColor = System.Drawing.Color.White;
            this.btn_imprimer_ordonnance.UseVisualStyleBackColor = false;
            this.btn_imprimer_ordonnance.Click += new System.EventHandler(this.btn_imprimer_ordonnance_Click);
            // 
            // UC_Patient_Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.btn_imprimer_ordonnance);
            this.Controls.Add(this.btn_refresh_p);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Dgv_intitule);
            this.Controls.Add(this.Dgv_Patient_visite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Cin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Patient_Historique";
            this.Size = new System.Drawing.Size(765, 411);
            this.Load += new System.EventHandler(this.UC_Patient_Historique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_intitule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Patient_visite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Dgv_intitule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intitule;
        private System.Windows.Forms.DataGridView Dgv_Patient_visite;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_visite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Cin;
        private Gestion_Commerciale.Classes.CButton btn_refresh_p;
        private Gestion_Commerciale.Classes.CButton btn_imprimer_ordonnance;
    }
}
