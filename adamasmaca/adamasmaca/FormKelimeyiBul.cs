using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace adamasmaca
{
    public partial class FormKelimeyiBul : Form
    {
        public FormKelimeyiBul()
        {
            InitializeComponent();
        }
        string kelime;
        public static int skor = 0;
        public static string IsimGirisi;
        int hak;
        string tahminedilenHarfler = "";
        Adam_asma a = new Adam_asma();
        public void bittimi()
        {
            bool bitti = true;
            for (int i = 0; i < kelime.Length; i++)
            {
                TextBox t = (TextBox)this.Controls["textbox" + (i + 1)];
                if(t.Text=="")
                {
                    bitti = false;
                }             
            }
            if(bitti)
            { 
            MessageBox.Show("Tebrikler Bildiniz.Skorunuz: " + skor);
            isimGir();
            }
        }
        public void TextBoxOlustur()
        {
            kelime = a.KelimeSec();
            for (int i = 0, k = 0; i < kelime.Length; i++)
            {
                TextBox t = new TextBox();
                t.Top = 50;
                t.Left = 30 + k;
                t.Width = 20;
                t.Text = "";
                t.MaxLength = 1;
                t.Name = "textBox" + (i + 1);
                t.ReadOnly = true;
                t.BackColor = this.BackColor;
                t.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(t);
                k += 40;
            }
        }
        private void FormKelimeyiBul_Load(object sender, EventArgs e)
        {
            a.dizidoldur();
            TextBoxOlustur();
            hak = kelime.Length + 2;
            labelHak.Text = hak.ToString();
            labelSkor.Text = skor.ToString();
        }
        private void textBoxHarfTahmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        private void isimGir()
        {
            IsimGirisi = Interaction.InputBox("Bilgi Girişi :", "Adınızı Soyadınızı Giriniz", "", 110, 110);
            SkorListesi fs = new SkorListesi();
            fs.Show();
            this.Hide();
        }
        public void Kontrol()
        {
            bool yanlismi = true;
            if (textBoxHarfTahmin.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Bir Harf Giriniz");
                return;
            }
            if (tahminedilenHarfler.IndexOf(textBoxHarfTahmin.Text) != -1)
            {
                return;
            }
            for (int i = 0; i < kelime.Length; i++)
            {

                if (kelime[i] == char.Parse(textBoxHarfTahmin.Text))
                {
                    TextBox t = (TextBox)this.Controls["textbox" + (i + 1)];
                    t.Text = kelime[i].ToString();
                    skor += 10;
                    labelSkor.Text = skor.ToString();
                    yanlismi = false;
                }
            }
            bittimi();
            if (yanlismi)
            {
                hak--;
                labelHak.Text = hak.ToString();
                if (skor >= 2)
                    skor -= 2;
                labelSkor.Text = skor.ToString();
                if (hak == 0)
                {
                    MessageBox.Show("Üzgünüz.Bilemediniz.Kelime : " + kelime + " Skorunuz: " + skor);
                    isimGir();
                }
                labelYanlisHarfler.Text += textBoxHarfTahmin.Text + "  ";
            }
            tahminedilenHarfler += char.Parse(textBoxHarfTahmin.Text);
        }

        private void buttonDene_Click(object sender, EventArgs e)
        {
            Kontrol();

        }
    }
}
