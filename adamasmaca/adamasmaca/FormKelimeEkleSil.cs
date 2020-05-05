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
    public partial class FormKelimeEkleSil : Form
    {
        public FormKelimeEkleSil()
        {
            InitializeComponent();
        }
        Adam_asma a = new Adam_asma();
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            a.DosyayaKelimeEkle(textBoxKelime.Text);
            listBoxKelime.Items.Add(textBoxKelime.Text);
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            a.DosyadanKelimeSil(listBoxKelime.SelectedItem.ToString());
            listBoxKelime.Items.RemoveAt(listBoxKelime.SelectedIndex);
        }

        private void FormKelimeEkleSil_Load(object sender, EventArgs e)
        {
            a.dizidoldur();
            for(int i=0;i<a.dizi.Length;i++)
            {
                if(a.dizi[i]!=null)
                { 
                listBoxKelime.Items.Add(a.dizi[i]);
                }
            }
        }
    }
}
