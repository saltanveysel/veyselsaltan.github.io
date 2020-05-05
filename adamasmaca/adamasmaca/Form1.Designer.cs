namespace adamasmaca
{
    partial class FormUzunluk
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
            this.textBoxKelimeUzunluk = new System.Windows.Forms.TextBox();
            this.buttonUzunlukBelirle = new System.Windows.Forms.Button();
            this.radioButtonRastgele = new System.Windows.Forms.RadioButton();
            this.buttonEkleCikar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime Uzunluğu :";
            // 
            // textBoxKelimeUzunluk
            // 
            this.textBoxKelimeUzunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKelimeUzunluk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxKelimeUzunluk.Location = new System.Drawing.Point(241, 91);
            this.textBoxKelimeUzunluk.Name = "textBoxKelimeUzunluk";
            this.textBoxKelimeUzunluk.Size = new System.Drawing.Size(105, 26);
            this.textBoxKelimeUzunluk.TabIndex = 1;
            this.textBoxKelimeUzunluk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKelimeUzunluk_KeyPress);
            // 
            // buttonUzunlukBelirle
            // 
            this.buttonUzunlukBelirle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUzunlukBelirle.Location = new System.Drawing.Point(77, 139);
            this.buttonUzunlukBelirle.Name = "buttonUzunlukBelirle";
            this.buttonUzunlukBelirle.Size = new System.Drawing.Size(269, 59);
            this.buttonUzunlukBelirle.TabIndex = 2;
            this.buttonUzunlukBelirle.Text = "Tamam";
            this.buttonUzunlukBelirle.UseVisualStyleBackColor = true;
            this.buttonUzunlukBelirle.Click += new System.EventHandler(this.buttonUzunlukBelirle_Click);
            // 
            // radioButtonRastgele
            // 
            this.radioButtonRastgele.AutoSize = true;
            this.radioButtonRastgele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonRastgele.Location = new System.Drawing.Point(77, 47);
            this.radioButtonRastgele.Name = "radioButtonRastgele";
            this.radioButtonRastgele.Size = new System.Drawing.Size(176, 24);
            this.radioButtonRastgele.TabIndex = 3;
            this.radioButtonRastgele.Text = "Rastgele Uzunluk";
            this.radioButtonRastgele.UseVisualStyleBackColor = true;
            this.radioButtonRastgele.CheckedChanged += new System.EventHandler(this.radioButtonRastgele_CheckedChanged);
            // 
            // buttonEkleCikar
            // 
            this.buttonEkleCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkleCikar.Location = new System.Drawing.Point(77, 230);
            this.buttonEkleCikar.Name = "buttonEkleCikar";
            this.buttonEkleCikar.Size = new System.Drawing.Size(269, 51);
            this.buttonEkleCikar.TabIndex = 4;
            this.buttonEkleCikar.Text = "Kelime Ekle/Çıkart";
            this.buttonEkleCikar.UseVisualStyleBackColor = true;
            this.buttonEkleCikar.Click += new System.EventHandler(this.buttonEkleCikar_Click);
            // 
            // FormUzunluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 317);
            this.Controls.Add(this.buttonEkleCikar);
            this.Controls.Add(this.buttonUzunlukBelirle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKelimeUzunluk);
            this.Controls.Add(this.radioButtonRastgele);
            this.Name = "FormUzunluk";
            this.Text = "Kelime Uzunluğu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKelimeUzunluk;
        private System.Windows.Forms.Button buttonUzunlukBelirle;
        private System.Windows.Forms.RadioButton radioButtonRastgele;
        private System.Windows.Forms.Button buttonEkleCikar;
    }
}

