using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev5
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxKullaniciAd.Clear();
            textBoxSifre.Clear();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Kontrol k = new Kontrol();

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            bool bos = k.TrimKontrol(textBoxKullaniciAd.Text, textBoxSifre.Text);
            if (!bos)
            {
                return;
            }
            try
            {
                SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
                SqlCommand cmd = new SqlCommand("select * from kullanici where username = @KAdi and sifre = @KParola", cnn);
                cmd.Parameters.AddWithValue("@KAdi", textBoxKullaniciAd.Text);
                cmd.Parameters.AddWithValue("@KParola", textBoxSifre.Text);
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows) 
                {
                    var parent = (FormAna)MdiParent;
                    parent.AktifEt();
                    this.Close();
                }
                else 
                {
                    rd.Close();
                    MessageBox.Show("Yanlış kullanıcı adı ve/veya şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch 
            {
                MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBoxSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonGiris_Click(sender,e);
            }
        }
    }
}

