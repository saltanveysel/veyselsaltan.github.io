namespace adamasmaca
{
    partial class FormKelimeyiBul
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
            this.labelHak = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelYanlisHarfler = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHarfTahmin = new System.Windows.Forms.TextBox();
            this.buttonDene = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSkor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(498, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hak :";
            // 
            // labelHak
            // 
            this.labelHak.AutoSize = true;
            this.labelHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHak.ForeColor = System.Drawing.Color.Red;
            this.labelHak.Location = new System.Drawing.Point(580, 40);
            this.labelHak.Name = "labelHak";
            this.labelHak.Size = new System.Drawing.Size(0, 25);
            this.labelHak.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yanlış Tahmin Edilen Harfler :";
            // 
            // labelYanlisHarfler
            // 
            this.labelYanlisHarfler.AutoSize = true;
            this.labelYanlisHarfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYanlisHarfler.Location = new System.Drawing.Point(302, 246);
            this.labelYanlisHarfler.Name = "labelYanlisHarfler";
            this.labelYanlisHarfler.Size = new System.Drawing.Size(0, 22);
            this.labelYanlisHarfler.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harf Tahmin :";
            // 
            // textBoxHarfTahmin
            // 
            this.textBoxHarfTahmin.Location = new System.Drawing.Point(150, 189);
            this.textBoxHarfTahmin.MaxLength = 1;
            this.textBoxHarfTahmin.Name = "textBoxHarfTahmin";
            this.textBoxHarfTahmin.Size = new System.Drawing.Size(56, 26);
            this.textBoxHarfTahmin.TabIndex = 1;
            this.textBoxHarfTahmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHarfTahmin_KeyPress);
            // 
            // buttonDene
            // 
            this.buttonDene.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDene.Location = new System.Drawing.Point(217, 185);
            this.buttonDene.Name = "buttonDene";
            this.buttonDene.Size = new System.Drawing.Size(86, 34);
            this.buttonDene.TabIndex = 6;
            this.buttonDene.Text = "Dene";
            this.buttonDene.UseVisualStyleBackColor = true;
            this.buttonDene.Click += new System.EventHandler(this.buttonDene_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(490, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Skor :";
            // 
            // labelSkor
            // 
            this.labelSkor.AutoSize = true;
            this.labelSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSkor.ForeColor = System.Drawing.Color.Lime;
            this.labelSkor.Location = new System.Drawing.Point(580, 9);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(0, 25);
            this.labelSkor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kelime :";
            // 
            // FormKelimeyiBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDene);
            this.Controls.Add(this.textBoxHarfTahmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelYanlisHarfler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSkor);
            this.Controls.Add(this.labelHak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FormKelimeyiBul";
            this.Text = "Adam Asmaca";
            this.Load += new System.EventHandler(this.FormKelimeyiBul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelYanlisHarfler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHarfTahmin;
        private System.Windows.Forms.Button buttonDene;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSkor;
        private System.Windows.Forms.Label label4;
    }
}