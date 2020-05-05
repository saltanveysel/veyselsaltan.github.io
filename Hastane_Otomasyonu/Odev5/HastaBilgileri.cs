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
    public partial class HastaBilgileri : Form
    {
        public HastaBilgileri()
        {
            InitializeComponent();
            buttonKaydet_Guncelle.Text = "Kaydet";
            buttonSil.Visible = false;
        }

        public HastaBilgileri(string dosyano)
        {
            InitializeComponent();
            textBoxDosya.Text = dosyano;
            buttonSil.Visible = true;
            buttonKaydet_Guncelle.Text= "Güncelle";
            textBoxDosya.ReadOnly = true;
            textBoxTcKimlik.ReadOnly = true;
        }
        public void dosyanoAyarla()
        {
            string dosyano = "";
            for (int i = textBoxDosya.TextLength; i < textBoxDosya.MaxLength; i++)
            {
                dosyano += "0";
            }
            textBoxDosya.Text = dosyano + textBoxDosya.Text;
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
        private void HastaBilgileri_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            cnn.Open();
            if (textBoxDosya.Text.Trim()=="")
            {
                SqlCommand cmd = new SqlCommand("select dosyano from hasta", cnn);
                int[] dosyanolar = new int[100];
                int j = 0;
                SqlDataReader sd = cmd.ExecuteReader();
                while (sd.Read())
                {
                    dosyanolar[j] = int.Parse(sd["dosyano"].ToString());
                    j++;
                    //textBoxDosya.Text = sd["dosyano"].ToString();
                }
                Array.Sort(dosyanolar);
                sd.Close();
                textBoxDosya.Text = (((dosyanolar[dosyanolar.Length-1])) + 1).ToString();
                dosyanoAyarla();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from hasta where dosyano=@dosyano", cnn);
                cmd.Parameters.AddWithValue("@dosyano", textBoxDosya.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                textBoxTcKimlik.Text = dr["tckimlikno"].ToString();
                textBoxAd.Text = dr["ad"].ToString();
                textBoxSoyad.Text = dr["soyad"].ToString();
                textBoxDogumYeri.Text = dr["dogumyeri"].ToString();
                dateTimePickerDogum.Value = DateTime.Parse(dr["dogumtarihi"].ToString());
                textBoxAnne.Text = dr["anneadi"].ToString();
                textBoxBaba.Text = dr["babaadi"].ToString();
                textBoxAdres.Text = dr["adres"].ToString();
                textBoxTelefon.Text = dr["tel"].ToString();
                textBoxKurumSicil.Text = dr["kurumsicilno"].ToString();
                textBoxKurumAd.Text = dr["kurumadi"].ToString();
                textBoxYakinTel.Text = dr["yakintel"].ToString();
                textBoxYakinKurumSicil.Text = dr["yakinkurumsicilno"].ToString();
                textBoxYakinKurumAd.Text = dr["yakinkurumadi"].ToString();
                ComboboxDoldur(dr, comboBoxCinsiyet, "cinsiyet");
                ComboboxDoldur(dr, comboBoxKanGrubu, "kangrubu");
                ComboboxDoldur(dr, comboBoxMedeniHal, "medenihal");
                dr.Close();
                cnn.Close();
            }  
            cnn.Close();
        }

        private void buttonKaydet_Guncelle_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            SqlCommand cmd;
            if (buttonKaydet_Guncelle.Text == "Kaydet")
            {
                cmd = new SqlCommand("insert_hasta", cnn);
            }
            else
            {
                cmd = new SqlCommand("update_hasta", cnn);
            }
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tckimlikno", SqlDbType.NVarChar).Value = textBoxTcKimlik.Text.Trim();
            cmd.Parameters.Add("@dosyano", SqlDbType.NVarChar).Value = textBoxDosya.Text.Trim();
            cmd.Parameters.Add("@ad", SqlDbType.NVarChar).Value = textBoxAd.Text.Trim();
            cmd.Parameters.Add("@soyad", SqlDbType.NVarChar).Value = textBoxSoyad.Text.Trim();
            cmd.Parameters.Add("@dogumyeri", SqlDbType.NVarChar).Value = textBoxDogumYeri.Text.Trim(); ;
            cmd.Parameters.Add("@dogumtarihi", SqlDbType.DateTime).Value = dateTimePickerDogum.Value;
            cmd.Parameters.Add("@babaadi", SqlDbType.NVarChar).Value = textBoxBaba.Text.Trim();
            cmd.Parameters.Add("@anneadi", SqlDbType.NVarChar).Value = textBoxAnne.Text.Trim();
            cmd.Parameters.Add("@cinsiyet", SqlDbType.NVarChar).Value = comboBoxCinsiyet.Text;
            cmd.Parameters.Add("@kangrubu", SqlDbType.NVarChar).Value = comboBoxKanGrubu.Text;
            cmd.Parameters.Add("@medenihal", SqlDbType.NVarChar).Value = comboBoxMedeniHal.Text;
            cmd.Parameters.Add("@adres", SqlDbType.NVarChar).Value = textBoxAdres.Text.Trim();
            cmd.Parameters.Add("@tel", SqlDbType.NVarChar).Value = textBoxTelefon.Text.Trim();
            cmd.Parameters.Add("@kurumsicilno", SqlDbType.NVarChar).Value = textBoxKurumSicil.Text.Trim();
            cmd.Parameters.Add("@kurumadi", SqlDbType.NVarChar).Value = textBoxKurumAd.Text.Trim();
            cmd.Parameters.Add("@yakintel", SqlDbType.NVarChar).Value = textBoxYakinTel.Text.Trim();
            cmd.Parameters.Add("@yakinkurumsicilno", SqlDbType.NVarChar).Value = textBoxYakinKurumSicil.Text.Trim();
            cmd.Parameters.Add("@yakinkurumadi", SqlDbType.NVarChar).Value = textBoxYakinKurumAd.Text.Trim();
            cnn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                labelislem.Text = " < İŞLEM TAMAMLANDI >";
            }
            catch 
            {

                labelislem.Text = " < İŞLEM TAMAMLANAMADI ! >";
            }
            finally
            {
                cnn.Close();
            }

            
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("delete_hasta", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tckimlikno", SqlDbType.NVarChar).Value = textBoxTcKimlik.Text.Trim();
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

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            textBoxTcKimlik.Text = "";
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            textBoxDogumYeri.Text = "";
            dateTimePickerDogum.Value = DateTime.Parse("12.12.1980");
            textBoxAnne.Text = "";
            textBoxBaba.Text = "";
            textBoxAdres.Text = "";
            textBoxTelefon.Text = "";
            textBoxKurumSicil.Text = "";
            textBoxKurumAd.Text = "";
            textBoxYakinTel.Text = "";
            textBoxYakinKurumSicil.Text = "";
            textBoxYakinKurumAd.Text = "";
            comboBoxCinsiyet.SelectedIndex = -1;
            comboBoxKanGrubu.SelectedIndex = -1;
            comboBoxMedeniHal.SelectedIndex = -1;
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("select dosyano from hasta", cnn);
            cnn.Open();
            int[] dosyanolar = new int[100];
            int j = 0;
            SqlDataReader sd = cmd.ExecuteReader();
            while (sd.Read())
            {
                dosyanolar[j] = int.Parse(sd["dosyano"].ToString());
                j++;
                //textBoxDosya.Text = sd["dosyano"].ToString();
            }
            Array.Sort(dosyanolar);
            sd.Close();
            textBoxDosya.Text = (((dosyanolar[dosyanolar.Length-1])) + 1).ToString();
            dosyanoAyarla();
            cnn.Close();
        }
    }
}
