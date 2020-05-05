using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adamasmaca
{
    public partial class FormUzunluk : Form
    {
        public FormUzunluk()
        {
            InitializeComponent();
        }

        

        private void buttonUzunlukBelirle_Click(object sender, EventArgs e)
        {
            if(textBoxKelimeUzunluk.Text.Trim()=="" && !radioButtonRastgele.Checked)
            {
                MessageBox.Show("Lütfen Seçim Yapın");
                return;
            }
           
            if (!radioButtonRastgele.Checked)
            {
                if (int.Parse(textBoxKelimeUzunluk.Text) > 10 )
                {
                    MessageBox.Show("Kelime uzunluğu 10 harfden uzun olamaz");
                    return;
                }
                Adam_asma.harfsayisi = int.Parse(textBoxKelimeUzunluk.Text);
            }
            FormKelimeyiBul fkb = new FormKelimeyiBul();
            fkb.Show();
            this.Hide();

       
    }

        private void radioButtonRastgele_CheckedChanged(object sender, EventArgs e)
        {
            textBoxKelimeUzunluk.Enabled = !(textBoxKelimeUzunluk.Enabled);
        }

        private void textBoxKelimeUzunluk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonEkleCikar_Click(object sender, EventArgs e)
        {
            FormKelimeEkleSil fes = new FormKelimeEkleSil();
            fes.Show();
            this.Hide();
        }
    }
}
