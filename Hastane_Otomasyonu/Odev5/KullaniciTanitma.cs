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
    public partial class KullaniciTanitma : Form
    {
        public KullaniciTanitma()
        {
            InitializeComponent();
        }

        private void KullaniciTanitma_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("select username from kullanici", cnn);
            cnn.Open();
            SqlDataReader sd = cmd.ExecuteReader();
            while (sd.Read())
            {
                comboBoxKullanicilar.Items.Add(sd["username"]);
            }
            sd.Close();
            cnn.Close();
        }

        private void comboBoxKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici(comboBoxKullanicilar.Text);
            k.MdiParent = this.MdiParent;
            k.StartPosition = FormStartPosition.CenterScreen;
            k.Show();
            this.Close();
        }

        private void buttonKullaniciEkle_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            k.MdiParent = this.MdiParent;
            k.StartPosition = FormStartPosition.CenterScreen;
            k.Show();
            this.Close();
        }
    }
}
