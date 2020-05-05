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
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
            buttonEkle_Guncelle.Text = "Ekle";
        }
        public Kullanici(string k_ad)
        {
            InitializeComponent();
            buttonEkle_Guncelle.Text = "Güncelle";
            textBoxKullaniciAd.Text = k_ad;
        }
        public void ComboboxDoldur(SqlDataReader dr, ComboBox c, string sutun)
        {
            for (int i = -1; i < c.Items.Count; i++)
            {
                c.SelectedIndex = i;
                if (dr[sutun].ToString() == c.Text)
                {
                    break;
                }
            }
        }
        public void Temizle()
        {
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            textBoxKullaniciKodu.Text = "";
            textBoxKullaniciAd.Text = "";
            textBoxSifre.Text = "";
            textBoxMaas.Text = "";
            textBoxGSM.Text = "";
            textBoxAnne.Text = "";
            textBoxBaba.Text = "";
            textBoxAdres.Text = "";
            textBoxDogumYeri.Text = "";
            textBoxTcKimlik.Text = "";
            textBoxUnvan.Text = "";
            textBoxTel.Text = "";
            dateTimePickerIseBaslama.Value = DateTime.Now;
            dateTimePickerDogum.Value = DateTime.Parse("01.01.1990");
            checkBoxYetki.Checked = false;
            comboBoxCinsiyet.SelectedIndex = -1;
            comboBoxKanGrubu.SelectedIndex = -1;
            comboBoxMedeniHal.SelectedIndex = -1;
        }
        private void Kullanici_Load(object sender, EventArgs e)
        {
            if (buttonEkle_Guncelle.Text != "Ekle")
            {
                SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
                SqlCommand cmd = new SqlCommand("select * from kullanici where username=@username", cnn);
                cmd.Parameters.AddWithValue("@username", textBoxKullaniciAd.Text);
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                textBoxAd.Text = dr["ad"].ToString();
                textBoxSoyad.Text = dr["soyad"].ToString();
                textBoxKullaniciKodu.Text = dr["kodu"].ToString();
                textBoxSifre.Text = dr["sifre"].ToString();
                textBoxMaas.Text = dr["maas"].ToString();
                textBoxGSM.Text = dr["ceptel"].ToString();
                textBoxAnne.Text = dr["annead"].ToString();
                textBoxBaba.Text = dr["babaad"].ToString();
                textBoxAdres.Text = dr["adres"].ToString();
                textBoxDogumYeri.Text = dr["dogumyeri"].ToString();
                textBoxTcKimlik.Text = dr["tckimlikno"].ToString();
                textBoxUnvan.Text = dr["unvan"].ToString();
                textBoxTel.Text = dr["evtel"].ToString();
                dateTimePickerIseBaslama.Value = DateTime.Parse(dr["isebaslama"].ToString());
                dateTimePickerDogum.Value = DateTime.Parse(dr["dogumtarihi"].ToString());
                ComboboxDoldur(dr, comboBoxCinsiyet, "cinsiyet");
                ComboboxDoldur(dr, comboBoxKanGrubu, "kangrubu");
                ComboboxDoldur(dr, comboBoxMedeniHal, "medenihal");
                checkBoxYetki.Checked = dr["yetki"].ToString() == "True" ? true : false;
                dr.Close();
                cnn.Close();
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }



        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("delete_kullanici", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@kodu", SqlDbType.NVarChar).Value = textBoxKullaniciKodu.Text.Trim();
            cnn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarılı Bir Şekilde Silindi");
            }
            catch
            {
                MessageBox.Show("Silme İşlemi Yapılamadı");
            }
            finally
            {
                cnn.Close();
            }


        }

        private void buttonEkle_Guncelle_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            SqlCommand cmd;
            cnn.Open();
            cmd = new SqlCommand("select kodu from kullanici", cnn);
            SqlDataReader sd = cmd.ExecuteReader();
            while (sd.Read())
            {
                if(sd["kodu"].ToString()==textBoxKullaniciKodu.Text.Trim())
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Kodu Zaten Var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sd.Close();
                    return;
                }
            }
            sd.Close();
            if (buttonEkle_Guncelle.Text == "Ekle")
            {
                cmd = new SqlCommand("insert_kullanici", cnn);
            }
            else
            {
                cmd = new SqlCommand("update_kullanici", cnn);
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@kodu", SqlDbType.NVarChar).Value = textBoxKullaniciKodu.Text.Trim();
            cmd.Parameters.Add("@ad", SqlDbType.NVarChar).Value = textBoxAd.Text.Trim();
            cmd.Parameters.Add("@soyad", SqlDbType.NVarChar).Value = textBoxSoyad.Text.Trim();
            cmd.Parameters.Add("@sifre", SqlDbType.NVarChar).Value = textBoxSifre.Text.Trim();
            cmd.Parameters.Add("@yetki", SqlDbType.NVarChar).Value = checkBoxYetki.Checked ? "True" : "False";
            cmd.Parameters.Add("@evtel", SqlDbType.NVarChar).Value = textBoxTel.Text.Trim();
            cmd.Parameters.Add("@ceptel", SqlDbType.NVarChar).Value = textBoxGSM.Text.Trim();
            cmd.Parameters.Add("@adres", SqlDbType.NVarChar).Value = textBoxAdres.Text.Trim();
            cmd.Parameters.Add("@unvan", SqlDbType.NVarChar).Value = textBoxUnvan.Text.Trim();
            cmd.Parameters.Add("@isebaslama", SqlDbType.DateTime).Value = dateTimePickerIseBaslama.Value;
            cmd.Parameters.Add("@maas", SqlDbType.NVarChar).Value = textBoxMaas.Text.Trim();
            cmd.Parameters.Add("@dogumyeri", SqlDbType.NVarChar).Value = textBoxDogumYeri.Text.Trim();
            cmd.Parameters.Add("@annead", SqlDbType.NVarChar).Value = textBoxAnne.Text.Trim();
            cmd.Parameters.Add("@babaad", SqlDbType.NVarChar).Value = textBoxBaba.Text.Trim();
            cmd.Parameters.Add("@cinsiyet", SqlDbType.NVarChar).Value = comboBoxCinsiyet.Text;
            cmd.Parameters.Add("@kangrubu", SqlDbType.NVarChar).Value = comboBoxKanGrubu.Text;
            cmd.Parameters.Add("@medenihal", SqlDbType.NVarChar).Value = comboBoxMedeniHal.Text;
            cmd.Parameters.Add("@dogumtarihi", SqlDbType.DateTime).Value = dateTimePickerDogum.Value;
            cmd.Parameters.Add("@tckimlikno", SqlDbType.NVarChar).Value = textBoxTcKimlik.Text.Trim();
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = textBoxKullaniciAd.Text.Trim();
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleşti");
            }
            catch
            {
                MessageBox.Show("İşlem Yapılamadı");
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
