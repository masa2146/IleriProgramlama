using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boyutlar;
using System.Threading;

namespace Proje
{
    public partial class Form1 : Form
    {
        Boyutlar.Boyutlar b = new Boyutlar.Boyutlar();

        public static string secilenDizin;
        public Form1()
        {
            InitializeComponent();
        }

        private void gozatButton_Click(object sender, EventArgs e)
        {
            dizinIcerigiListView.Items.Clear();
            FolderBrowserDialog fBrowser = new FolderBrowserDialog();
            fBrowser.ShowDialog();
            secilenDizin = fBrowser.SelectedPath;
            secilenDizinTextBox.Text = secilenDizin;

            Thread thread1 = new Thread(new ThreadStart(fonk1));
           thread1.Start();

           // Thread thread2 = new Thread(new ThreadStart(fonk2));
           //thread2.Start();

         //  fonk1();
        }


        public void fonk1()
        {



            string KlasorBoyut;
            b.DizinIceriginiListeyeEkle(secilenDizin);
            foreach (string dosya in b.KlasorAdi)
            {



                string[] dizi = dosya.Split('|');
                string dizin = secilenDizin + "\\" + dizi[0];

                b.klasorBoyutu(dizin);

                 ThreadStart start = delegate { b.klasorBoyutu(dizin); };
                 new Thread(start).Start();
                ListViewItem item = new ListViewItem(dizi[0]);


                item.SubItems.Add(dizi[1]);

                item.SubItems.Add(b.KlasorBoyut);
                item.SubItems.Add(dizi[2]);

                AddListBoxItem(item);

               // dizinIcerigiListView.Items.Add(item);
            }


            foreach (string dosya in b.DosyaAdi)
            {
                string[] dizi = dosya.Split('|');
                ListViewItem item = new ListViewItem(dizi[0]);
                item.SubItems.Add(dizi[1]);
                item.SubItems.Add(dizi[2]);
                item.SubItems.Add(dizi[3]);

                AddListBoxItem(item);
                 //dizinIcerigiListView.Items.Add(item);
            }

            b.temizle();

        }

        private delegate void AddListBoxItemDelegate(ListViewItem item);

        private void AddListBoxItem(ListViewItem item)
        {
            if (dizinIcerigiListView.InvokeRequired)
            {
                dizinIcerigiListView.Invoke(new AddListBoxItemDelegate(this.AddListBoxItem), item);
            }
            else
            {
                this.dizinIcerigiListView.Items.Add(item);
            }
        }

    }
}
