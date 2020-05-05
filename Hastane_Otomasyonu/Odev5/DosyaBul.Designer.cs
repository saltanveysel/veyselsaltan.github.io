namespace Odev5
{
    partial class DosyaBul
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
            this.comboBoxKriter = new System.Windows.Forms.ComboBox();
            this.buttonBul = new System.Windows.Forms.Button();
            this.textBoxNumara = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.checkBoxAnd = new System.Windows.Forms.CheckBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.dataGridViewSonuc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Kriteri :";
            // 
            // comboBoxKriter
            // 
            this.comboBoxKriter.FormattingEnabled = true;
            this.comboBoxKriter.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.comboBoxKriter.Location = new System.Drawing.Point(126, 6);
            this.comboBoxKriter.Name = "comboBoxKriter";
            this.comboBoxKriter.Size = new System.Drawing.Size(145, 28);
            this.comboBoxKriter.TabIndex = 1;
            this.comboBoxKriter.SelectedIndexChanged += new System.EventHandler(this.comboBoxKriter_SelectedIndexChanged);
            // 
            // buttonBul
            // 
            this.buttonBul.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonBul.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonBul.FlatAppearance.BorderSize = 2;
            this.buttonBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBul.ForeColor = System.Drawing.Color.Black;
            this.buttonBul.Location = new System.Drawing.Point(715, 2);
            this.buttonBul.Name = "buttonBul";
            this.buttonBul.Size = new System.Drawing.Size(68, 37);
            this.buttonBul.TabIndex = 13;
            this.buttonBul.Text = "Bul";
            this.buttonBul.UseVisualStyleBackColor = false;
            this.buttonBul.Click += new System.EventHandler(this.buttonBul_Click);
            // 
            // textBoxNumara
            // 
            this.textBoxNumara.Location = new System.Drawing.Point(290, 8);
            this.textBoxNumara.Name = "textBoxNumara";
            this.textBoxNumara.Size = new System.Drawing.Size(373, 26);
            this.textBoxNumara.TabIndex = 14;
            this.textBoxNumara.Visible = false;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(290, 8);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(129, 26);
            this.textBoxAd.TabIndex = 15;
            // 
            // checkBoxAnd
            // 
            this.checkBoxAnd.AutoSize = true;
            this.checkBoxAnd.Checked = true;
            this.checkBoxAnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAnd.Location = new System.Drawing.Point(457, 8);
            this.checkBoxAnd.Name = "checkBoxAnd";
            this.checkBoxAnd.Size = new System.Drawing.Size(51, 24);
            this.checkBoxAnd.TabIndex = 16;
            this.checkBoxAnd.Text = "ve";
            this.checkBoxAnd.UseVisualStyleBackColor = true;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(533, 8);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(156, 26);
            this.textBoxSoyad.TabIndex = 17;
            // 
            // dataGridViewSonuc
            // 
            this.dataGridViewSonuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSonuc.Location = new System.Drawing.Point(2, 45);
            this.dataGridViewSonuc.Name = "dataGridViewSonuc";
            this.dataGridViewSonuc.RowTemplate.Height = 28;
            this.dataGridViewSonuc.Size = new System.Drawing.Size(781, 259);
            this.dataGridViewSonuc.TabIndex = 18;
            // 
            // DosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 304);
            this.Controls.Add(this.dataGridViewSonuc);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.checkBoxAnd);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.textBoxNumara);
            this.Controls.Add(this.buttonBul);
            this.Controls.Add(this.comboBoxKriter);
            this.Controls.Add(this.label1);
            this.Name = "DosyaBul";
            this.Text = "DosyaBul";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKriter;
        private System.Windows.Forms.Button buttonBul;
        private System.Windows.Forms.TextBox textBoxNumara;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.CheckBox checkBoxAnd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.DataGridView dataGridViewSonuc;
    }
}