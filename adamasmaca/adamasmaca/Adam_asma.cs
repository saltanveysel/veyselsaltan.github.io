using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adamasmaca
{
    class Adam_asma
    {
        public static int harfsayisi;
        public string[] dizi=new string[30];
        Random rn = new Random();
        public void dizidoldur()
        { 
            StreamReader oku = new StreamReader("kelimeler.txt");
            string a = oku.ReadLine();
            int i = 0;
            while (a != null)
            {
                dizi[i] = a;
                a = oku.ReadLine();
                i++;
            }
            oku.Close();
        }
        public void DosyayaKelimeEkle(string k)
        {
            StreamWriter ekle = File.AppendText("kelimeler.txt");
            bool varmi = false;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == k)
                {
                    varmi = true;
                    break;
                }
                if (dizi[i] == null)
                {
                    dizi[i] = k;
                    break;
                }
            }
            if (!varmi)
            {
                ekle.WriteLine(k);
            }

            ekle.Close();
        }
        public void DosyadanKelimeSil(string k)
        {
            bool b = false;
            for (int i = 0; i < dizi.Length-1; i++)
            {
                if (dizi[i] == k)
                {
                    b = true;
                }
                if(b)
                {
                    dizi[i] = dizi[i + 1];
                }
            }
            if(b)
            {
                StreamWriter sw = new StreamWriter("kelimeler.txt");
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (dizi[i] != null)
                    {
                        sw.WriteLine(dizi[i]);
                    }



                }
                sw.Close();
            }
            



        }
        public string KelimeSec()
        {
            string kelime="";
            int j = 0;
            string[] k = new string[dizi.Length];
            if (harfsayisi!=0)
            {    
                for(int i=0;i<dizi.Length;i++)
                {
                    if(dizi[i] != null && dizi[i].Length == harfsayisi)
                    {
                        k[j] = dizi[i];
                        j++;
                    }
                }
                do
                {
                    kelime = k[rn.Next(k.Length)];
                } while (kelime == null) ;
            }
            else
            {
                do
                {
                    kelime = dizi[rn.Next(dizi.Length)];
                }while (kelime == null);
            }
            return kelime;
        }

    }
}
