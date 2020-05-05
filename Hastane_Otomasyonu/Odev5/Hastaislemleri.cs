using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev5
{
    public partial class Hastaislemleri : Form
    {
        public Hastaislemleri()
        {
            InitializeComponent();
        }

        private void buttonBaski_Click(object sender, EventArgs e)
        {
            
            DialogResult sayfaOnizleme;
            sayfaOnizleme = printDialogYazdir.ShowDialog();
            if (sayfaOnizleme == DialogResult.OK)
            {
                DialogResult dr;
                dr = MessageBox.Show("Raporun sayfayı ortalamasını istiyor musunuz?", "InvoiceManager - Center On Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                }
                else
                {

                }
                printPreviewDialogBaski.Document = printDocumentBaski;
                printPreviewDialogBaski.ShowDialog();

            }



        }
        public void temizle()
        {
            textBoxHastaAd.Text = "";
            textBoxHastaSoyad.Text = "";
            textBoxKurumAd.Text = "";
            comboBoxOncekiislemler.Text = "";
            comboBoxOncekiislemler.Items.Clear();
            dataGridViewSonuc.Rows.Clear();
        }
        public void temizle2()
        {
            comboBoxPoliklinik.SelectedIndex = -1;
            textBoxsirano.Text = "";
            comboBoxYapilanislem.SelectedIndex = -1;
            comboBoxdrKodu.SelectedIndex = -1;
            numericUpDownMiktar.Value = 1;
            textBoxbfiyat.Text = "";

        }
        public void dosyanoAyarla()
        {
            string dosyano = "";
            for (int i = textBoxDosyaNo.TextLength; i < textBoxDosyaNo.MaxLength; i++)
            {
                dosyano += "0";
            }
            textBoxDosyaNo.Text = dosyano + textBoxDosyaNo.Text;
        }
        private void buttonBul_Click(object sender, EventArgs e)
        {
            i = 0;
            temizle();
            if(textBoxDosyaNo.Text.Trim()=="")
            {
                DosyaBul d = new DosyaBul();
                d.MdiParent = this.MdiParent;
                d.StartPosition = FormStartPosition.CenterScreen;
                d.Show();
            }
            else
            {
                dosyanoAyarla();
                SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from sevk where dosyano = @dosyano", cnn);
                cmd.Parameters.AddWithValue("@dosyano", textBoxDosyaNo.Text);
                SqlDataReader sd = cmd.ExecuteReader();
                while(sd.Read())
                {
                    if(comboBoxOncekiislemler.Items.IndexOf(sd["sevktarihi"].ToString())==-1)
                    {
                        comboBoxOncekiislemler.Items.Add(sd["sevktarihi"]);
                    }   
                }
                comboBoxOncekiislemler.SelectedIndex = comboBoxOncekiislemler.Items.Count-1;
                sd.Close();
                SqlCommand cmd2 = new SqlCommand("select * from hasta where dosyano=@dosyano", cnn);
                cmd2.Parameters.AddWithValue("@dosyano", textBoxDosyaNo.Text);
                SqlDataReader dr=null;
                try
                {
                    dr = cmd2.ExecuteReader();
                    dr.Read();
                    textBoxHastaAd.Text = dr["ad"].ToString();
                    textBoxHastaSoyad.Text = dr["soyad"].ToString();
                    textBoxKurumAd.Text = dr["kurumadi"].ToString();
                }
                catch
                {
                    MessageBox.Show("Dosya No'ya Karşılık Hasta Bulunamadı");
                }
                
                dr.Close();
                cnn.Close();
            }
        }

        private void textBoxDosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonBul_Click(sender,e);
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            textBoxDosyaNo.Text = "";
            textBoxHastaAd.Text = "";
            textBoxHastaSoyad.Text = "";
            textBoxKurumAd.Text = "";
            
            comboBoxOncekiislemler.SelectedIndex = -1;

            HastaBilgileri h = new HastaBilgileri();
            h.MdiParent = this.MdiParent;
            h.StartPosition = FormStartPosition.CenterScreen;
            h.Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHastaBilgileri_Click(object sender, EventArgs e)
        {
            HastaBilgileri h = new HastaBilgileri(textBoxDosyaNo.Text);
            h.MdiParent = this.MdiParent;
            h.StartPosition = FormStartPosition.CenterScreen;
            h.Show();
        }
        int i;
        public void DatagridviewEkle(SqlDataReader dr)
        {
            dataGridViewSonuc.Rows.Add();
            dataGridViewSonuc.Rows[i].Cells[0].Value = dr["poliklinik"].ToString();
            dataGridViewSonuc.Rows[i].Cells[1].Value = dr["sira"].ToString();
            dataGridViewSonuc.Rows[i].Cells[2].Value = dr["saat"].ToString();
            dataGridViewSonuc.Rows[i].Cells[3].Value = dr["yapilanislem"].ToString();
            dataGridViewSonuc.Rows[i].Cells[4].Value = dr["drkod"].ToString();
            dataGridViewSonuc.Rows[i].Cells[5].Value = dr["miktar"].ToString();
            dataGridViewSonuc.Rows[i].Cells[6].Value = dr["birimfiyat"].ToString();
        }
        public void DatagridviewEkle()
        {
            dataGridViewSonuc.Rows.Add();
            dataGridViewSonuc.Rows[i].Cells[0].Value =comboBoxPoliklinik.Text;
            dataGridViewSonuc.Rows[i].Cells[1].Value = textBoxsirano.Text.Trim();
            dataGridViewSonuc.Rows[i].Cells[2].Value = DateTime.Now.Hour+":"+DateTime.Now.Minute;
            dataGridViewSonuc.Rows[i].Cells[3].Value = comboBoxYapilanislem.Text;
            dataGridViewSonuc.Rows[i].Cells[4].Value = comboBoxdrKodu.Text;
            dataGridViewSonuc.Rows[i].Cells[5].Value = numericUpDownMiktar.Value;
            dataGridViewSonuc.Rows[i].Cells[6].Value = textBoxbfiyat.Text;
        }


        private void buttonGit_Click(object sender, EventArgs e)
        {
            if(comboBoxOncekiislemler.Text.Trim()=="")
            {
                return;
            }
            i = 0;
            int toplam = 0;
            dataGridViewSonuc.Rows.Clear();
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select * from sevk where dosyano='" + textBoxDosyaNo.Text.Trim() + "' and sevktarihi='" + comboBoxOncekiislemler.Text + "'", cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                toplam += int.Parse(dr["toplamtutar"].ToString());
                DatagridviewEkle(dr);
                i++;
            }
            
            dr.Close();
            dr = cmd.ExecuteReader();
            bool sevk = true;
            
            while (dr.Read())
            {
                if (dr["taburcu"].ToString() != "true")
                {
                    sevk = false;
                    break;
                }
            }
            if(sevk)
            {
                buttonTaburcu.ForeColor = SystemColors.ControlText;
                MessageBox.Show("Hasta Bu Sevkten Taburcu Edilmiş", "Taburcu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
            else
            {
                buttonTaburcu.ForeColor = Color.Yellow;
                MessageBox.Show("Hasta Bu Sevkten Taburcu Edilmemiş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dr.Close();
            labelTutar.Text = toplam+ " TL";
            cnn.Close();
            

        }
        public void comboBoxDoldur(ComboBox c,SqlCommand cmd,string sutun)
        {
            SqlDataReader sd = cmd.ExecuteReader();
            while (sd.Read())
            {
                c.Items.Add(sd[sutun]);
            }
            sd.Close();
        }
        private void Hastaislemleri_Load(object sender, EventArgs e)
        {
            dateTimePickerSevk.Value = DateTime.Now;
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            SqlCommand cmd; 
            cmd= new SqlCommand("select islemAdi from islem", cnn);
            cnn.Open();
            comboBoxYapilanislem.Items.Add("yeniislem..");
            comboBoxDoldur(comboBoxYapilanislem, cmd, "islemAdi");
            cmd = new SqlCommand("select poliklinikadi from poliklinik", cnn);
            comboBoxDoldur(comboBoxPoliklinik, cmd, "poliklinikadi");
            cmd = new SqlCommand("select kodu from kullanici where unvan='Doktor'", cnn);
            comboBoxDoldur(comboBoxdrKodu, cmd, "kodu");
            cnn.Close();
        }

        private void comboBoxPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxsirano.Text = "1";
        }

        private void comboBoxYapilanislem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxYapilanislem.SelectedIndex != 0 && comboBoxYapilanislem.SelectedIndex!=-1)
            { 
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("select birimFiyat from islem where islemAdi='" + comboBoxYapilanislem.Text + "'", cnn);
            cnn.Open();
            SqlDataReader sd = cmd.ExecuteReader();
            sd.Read();
            textBoxbfiyat.Text = sd["birimFiyat"].ToString();
            sd.Close();
            cnn.Close();
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            
            if(textBoxHastaAd.Text.Trim()!="")
            {
                DatagridviewEkle();
                i++;
                SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
                SqlCommand cmd = new SqlCommand("insert_sevk", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sevktarihi", SqlDbType.NVarChar).Value = dateTimePickerSevk.Value;
                cmd.Parameters.Add("@dosyano", SqlDbType.NVarChar).Value = textBoxDosyaNo.Text.Trim();
                cmd.Parameters.Add("@poliklinik", SqlDbType.NVarChar).Value = comboBoxPoliklinik.Text;
                cmd.Parameters.Add("@saat", SqlDbType.NVarChar).Value = DateTime.Now.Hour+":"+DateTime.Now.Minute;
                cmd.Parameters.Add("@yapilanislem", SqlDbType.NVarChar).Value = comboBoxYapilanislem.Text;
                cmd.Parameters.Add("@drkod", SqlDbType.Char).Value = comboBoxdrKodu.Text;
                cmd.Parameters.Add("@miktar", SqlDbType.Char).Value = numericUpDownMiktar.Value;
                cmd.Parameters.Add("@birimfiyat", SqlDbType.NVarChar).Value = textBoxbfiyat.Text.Trim();
                cmd.Parameters.Add("@sira", SqlDbType.NVarChar).Value = textBoxsirano.Text.Trim();
                cmd.Parameters.Add("@toplamtutar", SqlDbType.NVarChar).Value = ((int)(numericUpDownMiktar.Value)*int.Parse(textBoxbfiyat.Text)).ToString();
                cmd.Parameters.Add("@taburcu", SqlDbType.NVarChar).Value = "false";
                buttonTaburcu.ForeColor = Color.Yellow;
                cnn.Open();
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
                int toplam = 0;
                cnn.Open();
                SqlCommand cmd2 = new SqlCommand("select * from sevk where dosyano='" + textBoxDosyaNo.Text.Trim() + "' and sevktarihi='" + comboBoxOncekiislemler.Text + "'", cnn);
                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    toplam += int.Parse(dr["toplamtutar"].ToString());
                    
                }
                dr.Close();
                labelTutar.Text = toplam + " TL";
            }
            temizle2();
        }

        private void buttonTaburcu_Click(object sender, EventArgs e)
        {
            if(buttonTaburcu.ForeColor==Color.Yellow)
            {
                Taburcu t = new Taburcu(textBoxDosyaNo.Text,dateTimePickerSevk.Value,labelTutar.Text);
                t.MdiParent = this.MdiParent;
                t.StartPosition = FormStartPosition.CenterParent;
                t.Show();
            }
        }

        private void buttonSecSil_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("delete_sevk", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sevktarihi", SqlDbType.NVarChar).Value = dateTimePickerSevk.Value;
            cmd.Parameters.Add("@dosyano", SqlDbType.NVarChar).Value = textBoxDosyaNo.Text.Trim();
            cmd.Parameters.Add("@poliklinik", SqlDbType.NVarChar).Value = dataGridViewSonuc.CurrentRow.Cells[0].Value;
            cmd.Parameters.Add("@saat", SqlDbType.NVarChar).Value = dataGridViewSonuc.CurrentRow.Cells[2].Value;
            cmd.Parameters.Add("@yapilanislem", SqlDbType.NVarChar).Value = dataGridViewSonuc.CurrentRow.Cells[3].Value;
            cmd.Parameters.Add("@drkod", SqlDbType.Char).Value = dataGridViewSonuc.CurrentRow.Cells[4].Value;
            cmd.Parameters.Add("@miktar", SqlDbType.Char).Value = dataGridViewSonuc.CurrentRow.Cells[5].Value;
            cmd.Parameters.Add("@birimfiyat", SqlDbType.NVarChar).Value = dataGridViewSonuc.CurrentRow.Cells[6].Value;
            cmd.Parameters.Add("@sira", SqlDbType.NVarChar).Value = dataGridViewSonuc.CurrentRow.Cells[1].Value;
            cnn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                buttonGit_Click(sender,e);
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
        int j = 0;
        private void printDocumentBaski_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Times New Roman", 24,FontStyle.Bold);
            e.Graphics.DrawString("Hasta Sevk İşlemleri :"+textBoxHastaAd.Text+" "+textBoxHastaSoyad.Text, myFont, Brushes.Black,170,70);

            Font baslik = new Font("Arial", 7, FontStyle.Regular);
            Font altbaslik = new Font("Arial", 6, FontStyle.Regular);
            PageSettings p = printDocumentBaski.DefaultPageSettings;
            int x = 135, y = 135, say = dataGridViewSonuc.Rows.Count-1;
            e.Graphics.DrawLine(new Pen(Color.Black, 2), p.Margins.Left, 125, p.Margins.Left + 620, 125);
            e.Graphics.DrawString("POLİKLİNİK", baslik,Brushes.Black, 110, 130);
            e.Graphics.DrawString("SIRA NO", baslik, Brushes.Black, 170, 130);
            e.Graphics.DrawString("SAAT", baslik, Brushes.Black, 250, 130);
            e.Graphics.DrawString("YAPILAN İŞLEM", baslik, Brushes.Black, 310, 130);
            e.Graphics.DrawString("DR.KODU", baslik, Brushes.Black, 450, 130);
            e.Graphics.DrawString("MİKTAR", baslik, Brushes.Black, 550, 130);
            e.Graphics.DrawString("BİRİM FİYATI", baslik, Brushes.Black,630, 130);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), p.Margins.Left, 153, p.Margins.Left + 620, 153);

            while(j<say)
            {
                x += 25;
                e.Graphics.DrawString(dataGridViewSonuc.Rows[j].Cells[0].Value.ToString(), altbaslik, Brushes.Black, 115, x);
                e.Graphics.DrawString(dataGridViewSonuc.Rows[j].Cells[1].Value.ToString(), altbaslik, Brushes.Black, 175, x);
                e.Graphics.DrawString(dataGridViewSonuc.Rows[j].Cells[2].Value.ToString(), altbaslik, Brushes.Black, 255, x);
                e.Graphics.DrawString(dataGridViewSonuc.Rows[j].Cells[3].Value.ToString(), altbaslik, Brushes.Black, 330, x);
                e.Graphics.DrawString(dataGridViewSonuc.Rows[j].Cells[4].Value.ToString(), altbaslik, Brushes.Black, 455, x);
                e.Graphics.DrawString(dataGridViewSonuc.Rows[j].Cells[5].Value.ToString(), altbaslik, Brushes.Black, 555, x);
                e.Graphics.DrawString(dataGridViewSonuc.Rows[j].Cells[6].Value.ToString(), altbaslik, Brushes.Black, 635, x);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), p.Margins.Left, x+20, p.Margins.Left + 620, x+20);
                j++;

                if((x+y+20)>(p.PaperSize.Height+80-p.Margins.Bottom+80))
                {
                    e.HasMorePages = true;
                    break;
                }
            }
            int k = 0;
            while(k<7)
            {
                x += 25;
                e.Graphics.DrawString("", altbaslik, Brushes.Black, 115, x);
                e.Graphics.DrawString("", altbaslik, Brushes.Black, 175, x);
                e.Graphics.DrawString("", altbaslik, Brushes.Black, 255, x);
                e.Graphics.DrawString("", altbaslik, Brushes.Black, 330, x);
                if (k == 1)
                {
                    e.Graphics.DrawString("Toplam:", altbaslik, Brushes.Black, 555, x);
                    e.Graphics.DrawString(labelTutar.Text, altbaslik, Brushes.Black, 635, x);
                }
                else if(k==4)
                {
                    SqlConnection cnn = new SqlConnection("Data Source=VEYSEL-J93HR1I; Initial Catalog=SOHATS;Integrated Security=SSPI");
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("select unvan,ad,soyad from kullanici where kodu = @kodu", cnn);
                    cmd.Parameters.AddWithValue("@kodu", dataGridViewSonuc.Rows[1].Cells[4].Value.ToString());
                    SqlDataReader sd = cmd.ExecuteReader();
                    sd.Read();
                    e.Graphics.DrawString(sd["unvan"]+" "+sd["ad"]+" "+sd["soyad"], altbaslik, Brushes.Black, 455, x);   
                    cnn.Close();
                    
                }
                else if (k == 5)
                {
                    e.Graphics.DrawString(dateTimePickerSevk.Value.ToShortDateString(), altbaslik, Brushes.Black, 455, x);
                }
                else
                {
                    e.Graphics.DrawString("", altbaslik, Brushes.Black, 455, x);
                    e.Graphics.DrawString("", altbaslik, Brushes.Black, 555, x);
                    e.Graphics.DrawString("", altbaslik, Brushes.Black, 635, x);
                }
                
                e.Graphics.DrawLine(new Pen(Color.Black, 1), p.Margins.Left, x + 20, p.Margins.Left + 620, x + 20);
                k++;

                if ((x + y + 20) > (p.PaperSize.Height + 80 - p.Margins.Bottom + 80))
                {
                    e.HasMorePages = true;
                    break;
                }
            }

            e.Graphics.DrawLine(new Pen(Color.Black, 1), p.Margins.Left, 125, p.Margins.Left, x + 20);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), p.Margins.Left + 70, 125, p.Margins.Left + 70, x + 20);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), p.Margins.Left+150, 125, p.Margins.Left+ 150, x + 20);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), p.Margins.Left + 205, 125, p.Margins.Left + 205, x + 20);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), p.Margins.Left + 350, 125, p.Margins.Left + 350, x + 20);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), p.Margins.Left + 440, 125, p.Margins.Left + 440, x + 20);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), p.Margins.Left + 530, 125, p.Margins.Left + 530, x + 20);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), p.Margins.Left + 620, 125, p.Margins.Left + 620, x + 20);


            if (j>=say)
            {
                e.HasMorePages = false;
                j = 0;
            }



        }

        private void buttonYazdir_Click(object sender, EventArgs e)
        {
            printDialogYazdir.Document = printDocumentBaski;
            DialogResult pdr = printDialogYazdir.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocumentBaski.Print();
            }
        }
    }
}
