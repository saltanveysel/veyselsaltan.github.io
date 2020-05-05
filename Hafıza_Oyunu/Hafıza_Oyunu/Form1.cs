using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafıza_Oyunu
{
    public partial class Hafiza_Oyunu : Form
    {
        public Hafiza_Oyunu()
        {
            InitializeComponent();
        }
        string onceki = "";
        string[] image = new string[40];
        string[] image2 = new string[40];
        Random rn = new Random();
        int[] rastgele = new int[40];
        int kirmizi = 0, mavi = 0,sure=5;
        public void listedoldur()
        {
          int  say = image.Length;
          for (int i = 0; i <20; i++)
           {

                image[i]= "img"+(i+1);
           }
           for (int i = 20, j = 0; i < 40; i++,j++)
           {
                image[i] = "img" + (j + 1);
           }
           while(say>1)
            {
                int random = rn.Next(say);
                say--;
                string a = image[say];
                image[say] = image[random];
                image[random] = a;

            }
           
        }
        public void yedeklistedoldur()
        {
            for (int i = 0; i < 40; i++)
            {
                image2[i]="img0.png";
            }
        }
        public void resimlerikapat()
        {
            for (int i = 0; i < 40; i++)
            {
                PictureBox p = (PictureBox)this.Controls["pictureBox" + (i + 1)];
                p.ImageLocation = image2[i];
            
            }
        }
        public void TumunuGoster()
        {
            PictureBox[] picBox = new PictureBox[40];
            for (int i = 0; i < 40; i++)
            {
                PictureBox p = (PictureBox)this.Controls["pictureBox" + (i + 1)];
                p.ImageLocation = image[i]+".png";
                
            }
            timer1.Start();
        }
        private void Hafiza_Oyunu_Load(object sender, EventArgs e)
        {
            listedoldur();
            yedeklistedoldur();
            TumunuGoster();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            resimlerikapat();
            onceki = "";
            timer1.Stop();
        }

        private void pictureBox40_MouseClick(object sender, MouseEventArgs e)
        {

          
        }
        public void pBoxEnableTrue()
        {
            for (int j = 0; j < 40; j++)
            {
                PictureBox p2 = (PictureBox)this.Controls["pictureBox" + (j + 1)];
                if(image2[j]=="img0.png")
                p2.Enabled = true;
            }
        }
        public void pBoxEnableFalse()
        {
            for (int j = 0; j < 40; j++)
            {
                PictureBox p2 = (PictureBox)this.Controls["pictureBox" + (j + 1)];
                p2.Enabled = false ;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            resimlerikapat();
            siraDegis();
            pBoxEnableTrue();
            timer2.Stop();
            
            
            
        }
        public void siraDegis()
        {
            if(labelKirmiziTaraf.BorderStyle==BorderStyle.FixedSingle)
            {
                labelKirmiziTaraf.BorderStyle = BorderStyle.None;
                labelMaviTaraf.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                labelKirmiziTaraf.BorderStyle = BorderStyle.FixedSingle;
                labelMaviTaraf.BorderStyle =  BorderStyle.None;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
            sure--;
            labelSure.Text = sure.ToString();
            if(sure==0 )
            {
                timer3.Stop();
                labelSure.Text = sure.ToString();
                sure = 5;
                siraDegis();
                onceki = "";
                resimlerikapat();
            }
        }

        public void Kontrol2()
        {
            if(labelKirmiziTaraf.BorderStyle == BorderStyle.FixedSingle)
            {
                kirmizi++;
                labelKirmizi.Text = kirmizi.ToString();
            }
            else
            {
                mavi++;
                labelMavi.Text = mavi.ToString();
            }
            if(kirmizi==11)
            {
                MessageBox.Show("Red won.");
                this.Close();
            }
            else if(mavi==11)
            {
                MessageBox.Show("Blue won.");
                this.Close();
            }
            else if(kirmizi==10 && mavi==10)
            {
                MessageBox.Show("Berabere.");
                this.Close();
            }
        }
        public void Kontrol(string location)
        {
            if (onceki == location)
            {
                onceki = "";
                for (int j = 0; j < 40; j++)
                {
                    PictureBox p2 = (PictureBox)this.Controls["pictureBox" + (j + 1)];
                    if(p2.ImageLocation==location)
                    {
                        image2[j] = location;
                    }
                }
                Kontrol2();
                timer3.Stop();
                return;
            }
            else if (onceki != "" && onceki != "img0.png" && location != "img0.png")
            {
                
                pBoxEnableFalse();
                onceki = "";
                timer3.Stop();
                timer2.Start();
                return;
            }
            else if(location != "img0.png" && onceki=="")
            {
                sure = 5;
                labelSure.Text = sure.ToString();
                timer3.Start();
            }
            onceki = location;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int i = int.Parse(p.Name.Substring(10));
            p.ImageLocation = image[i - 1] + ".png";
            p.Enabled = false;
            Kontrol(p.ImageLocation);
        }
    }
}
