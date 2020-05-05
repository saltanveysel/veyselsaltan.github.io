using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev5
{
    public partial class DosyaBul : Form
    {
        public DosyaBul()
        {
            InitializeComponent();
            comboBoxKriter.SelectedIndex = 0;
        }
        public void BirinciKriter()
        {
            textBoxNumara.Visible = false;
            textBoxAd.Visible = true;
            textBoxSoyad.Visible = true;
            checkBoxAnd.Visible = true;
        }
        public void Ikincikriter()
        {
            textBoxAd.Visible = false;
            textBoxSoyad.Visible = false;
            checkBoxAnd.Visible = false;
            textBoxNumara.Visible = true;
        }
        public void Temizle()
        {
            textBoxNumara.Text = "";
            textBoxAd.Text = "";
            textBoxSoyad.Text = ""; 
            checkBoxAnd.Checked = true;
            dataGridViewSonuc.Columns.Clear();
        }
        private void comboBoxKriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxKriter.SelectedIndex==0)
            {
                BirinciKriter();
                Temizle();
            }
            else
            {
                Ikincikriter();
                Temizle(); 
            }
        }

        private void buttonBul_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            cnn.Open();
            SqlDataAdapter da=null;
            if(comboBoxKriter.SelectedIndex==0)
            {
                if(checkBoxAnd.Checked)
                {
                    da = new SqlDataAdapter("select * from hasta where ad='" + textBoxAd.Text.Trim() + "' and soyad='"+textBoxSoyad.Text.Trim() + "'", cnn);
                }
                else
                {
                    da = new SqlDataAdapter("select * from hasta where ad='" + textBoxAd.Text.Trim()+"'", cnn);
                } 
            }
            else if (comboBoxKriter.SelectedIndex == 1)
            {
                da = new SqlDataAdapter("select * from hasta where tckimlikno='" + textBoxNumara.Text.Trim() + "'", cnn);
            }
            else if (comboBoxKriter.SelectedIndex == 2)
            {
                da = new SqlDataAdapter("select * from hasta where kurumsicilno='" + textBoxNumara.Text.Trim() + "'", cnn);
            }
            else if(comboBoxKriter.SelectedIndex == 3)
            {
                da = new SqlDataAdapter("select * from hasta where dosyano='" + textBoxNumara.Text.Trim() + "'", cnn);
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewSonuc.DataSource = ds.Tables[0];
        }
    }
}
