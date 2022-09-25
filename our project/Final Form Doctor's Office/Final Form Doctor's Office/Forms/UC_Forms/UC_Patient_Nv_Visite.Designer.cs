
namespace Final_Form_Doctor_s_Office.Forms.UC_Forms
{
    partial class UC_Patient_Nv_Visite
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_prix = new System.Windows.Forms.TextBox();
            this.dtp_visite = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajouter = new Gestion_Commerciale.Classes.CButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(82)))), ((int)(((byte)(163)))));
            this.panel4.Location = new System.Drawing.Point(213, 158);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 2);
            this.panel4.TabIndex = 109;
            // 
            // tb_prix
            // 
            this.tb_prix.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_prix.Location = new System.Drawing.Point(213, 126);
            this.tb_prix.Margin = new System.Windows.Forms.Padding(4);
            this.tb_prix.Multiline = true;
            this.tb_prix.Name = "tb_prix";
            this.tb_prix.Size = new System.Drawing.Size(247, 35);
            this.tb_prix.TabIndex = 108;
            this.tb_prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_prix_KeyPress);
            // 
            // dtp_visite
            // 
            this.dtp_visite.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.dtp_visite.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtp_visite.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_visite.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtp_visite.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtp_visite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtp_visite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_visite.Location = new System.Drawing.Point(513, 126);
            this.dtp_visite.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_visite.Name = "dtp_visite";
            this.dtp_visite.Size = new System.Drawing.Size(383, 30);
            this.dtp_visite.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(509, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 106;
            this.label1.Text = "Date Visite";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.Green;
            this.btn_ajouter.BackgroundColor = System.Drawing.Color.Green;
            this.btn_ajouter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ajouter.BorderRadius = 17;
            this.btn_ajouter.BorderSize = 0;
            this.btn_ajouter.FlatAppearance.BorderSize = 0;
            this.btn_ajouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(258, 193);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(273, 49);
            this.btn_ajouter.TabIndex = 105;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.TextColor = System.Drawing.Color.White;
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(209, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 104;
            this.label2.Text = "Prix :";
            // 
            // UC_Patient_Nv_Visite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tb_prix);
            this.Controls.Add(this.dtp_visite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Patient_Nv_Visite";
            this.Size = new System.Drawing.Size(1020, 506);
            this.Load += new System.EventHandler(this.UC_Patient_Nv_Visite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_prix;
        private System.Windows.Forms.DateTimePicker dtp_visite;
        private System.Windows.Forms.Label label1;
        private Gestion_Commerciale.Classes.CButton btn_ajouter;
        private System.Windows.Forms.Label label2;
    }
}
