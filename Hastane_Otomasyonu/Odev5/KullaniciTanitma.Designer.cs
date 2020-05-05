namespace Odev5
{
    partial class KullaniciTanitma
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
            this.comboBoxKullanicilar = new System.Windows.Forms.ComboBox();
            this.buttonKullaniciEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-3, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "SOHATS - Kullanıcı Tanıtma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // comboBoxKullanicilar
            // 
            this.comboBoxKullanicilar.FormattingEnabled = true;
            this.comboBoxKullanicilar.Location = new System.Drawing.Point(134, 79);
            this.comboBoxKullanicilar.Name = "comboBoxKullanicilar";
            this.comboBoxKullanicilar.Size = new System.Drawing.Size(149, 28);
            this.comboBoxKullanicilar.TabIndex = 3;
            this.comboBoxKullanicilar.SelectedIndexChanged += new System.EventHandler(this.comboBoxKullanicilar_SelectedIndexChanged);
            // 
            // buttonKullaniciEkle
            // 
            this.buttonKullaniciEkle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonKullaniciEkle.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonKullaniciEkle.FlatAppearance.BorderSize = 2;
            this.buttonKullaniciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKullaniciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKullaniciEkle.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonKullaniciEkle.Location = new System.Drawing.Point(66, 130);
            this.buttonKullaniciEkle.Name = "buttonKullaniciEkle";
            this.buttonKullaniciEkle.Size = new System.Drawing.Size(217, 43);
            this.buttonKullaniciEkle.TabIndex = 8;
            this.buttonKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.buttonKullaniciEkle.UseVisualStyleBackColor = false;
            this.buttonKullaniciEkle.Click += new System.EventHandler(this.buttonKullaniciEkle_Click);
            // 
            // KullaniciTanitma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 210);
            this.Controls.Add(this.buttonKullaniciEkle);
            this.Controls.Add(this.comboBoxKullanicilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciTanitma";
            this.Text = "KullaniciTanitma";
            this.Load += new System.EventHandler(this.KullaniciTanitma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKullanicilar;
        private System.Windows.Forms.Button buttonKullaniciEkle;
    }
}