using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boyutlar
{
    public class Boyutlar
    {

        public long boyut = 0;
        //Klasör bilgileri
        // public List<String> KlasorOlusturma = new List<string>();
        public List<String> KlasorAdi = new List<string>();
        public string KlasorBoyut;

        //Dosya bilgileri

        public List<String> DosyaAdi = new List<string>();
        

        public void DizinIceriginiListeyeEkle(string dizin)
        {
            string[] dizindekiKlasorler = Directory.GetDirectories(dizin);
            string[] dizindekiDosyalar = Directory.GetFiles(dizin);

            foreach (string klasor in dizindekiKlasorler)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(klasor);
                string klasorAdi = dirInfo.Name;
                DateTime olsTarihi = dirInfo.CreationTime;

                KlasorAdi.Add(klasorAdi+"|Klasör|"+olsTarihi.ToString("dd.MM.yyyy HH:mm"));
                                 

                 
            }

            foreach (string dosya in dizindekiDosyalar)
            {
                FileInfo fileInfo = new FileInfo(dosya);

                string dosyaAdi = fileInfo.Name;
                long byteBoyut = fileInfo.Length;
                DateTime olsTarihi = fileInfo.CreationTime;
                if (boyut > 1073741824)
                {
                    DosyaAdi.Add(dosyaAdi + "|Dosya|" + byteBoyut.ToString() + " GB|" + olsTarihi.ToString("dd.MM.yyyy HH:mm"));
                }
                if (boyut > 1048576)
                {
                    DosyaAdi.Add(dosyaAdi + "|Dosya|" + byteBoyut.ToString() + " MB|" + olsTarihi.ToString("dd.MM.yyyy HH:mm"));
                }
                if (boyut > 1024)
                {
                    DosyaAdi.Add(dosyaAdi + "|Dosya|" + byteBoyut.ToString() + " KB|" + olsTarihi.ToString("dd.MM.yyyy HH:mm"));
                }

                else
                {
                    DosyaAdi.Add(dosyaAdi + "|Dosya|" + byteBoyut.ToString() + " Byte|" + olsTarihi.ToString("dd.MM.yyyy HH:mm"));
                }

               // DosyaAdi.Add(dosyaAdi+"|Dosya|"+byteBoyut.ToString()+"|"+olsTarihi.ToString("dd.MM.yyyy HH:mm"));
            }


        }

        public void temizle()
        {

            DosyaAdi.Clear();
            KlasorAdi.Clear();
           boyut = 0;
            KlasorBoyut = "";


        }

        public void klasorBoyutu(string dizin)
        {
            string[] dizindekiKlasorler = Directory.GetDirectories(dizin);
            string[] dizindekiDosyalar = Directory.GetFiles(dizin);
           
            foreach (string dosya in dizindekiDosyalar)
            {
                FileInfo fileInfo = new FileInfo(dosya);

                
                long byteBoyut = fileInfo.Length;
                boyut = boyut + byteBoyut;
                
            }
            
            if(dizindekiKlasorler != null)
            {
                foreach (string klasor in dizindekiKlasorler)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(klasor);
                    string klasorAdi = dirInfo.Name;
                    string d = dizin + "\\" + klasorAdi;
                    klasorBoyutu(d);
                }
            }

            if(boyut > 1073741824)
            {
                KlasorBoyut = (boyut / 1073741824).ToString()+" GB";
            }
            if (boyut > 1048576)
            {
                KlasorBoyut = (boyut / 1048576).ToString()+" MB";
            }
            if (boyut > 1024)
            {
                KlasorBoyut = (boyut / 1024).ToString()+" KB";
            }
            else
            {
                KlasorBoyut = (boyut / 1024).ToString() + " Byte";
            }
           
            //KlasorBoyut = boyut.ToString();
        }

    }
}
