using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ileriProgramlama
{
    public partial class Form1 : Form
    {
         


        public Form1()
        {
            InitializeComponent();
            
        }

        private void gozatButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fBrowser = new FolderBrowserDialog();
            fBrowser.ShowDialog();
            string secilenDizin = fBrowser.SelectedPath;
            secilenDizinTextBox.Text = secilenDizin;
            DizinIceriginiListeyeEkle(secilenDizin);

            
           
        }

      

        public void run()
        {

        }

        public void DizinIceriginiListeyeEkle(String dizin)
        {
            Dosya.Class1 d = new Dosya.Class1();
            d.KlasorIceriginiGetir(dizin);
            d.DosyaIceriginiGetir(dizin);
            
           for(int i=0;i<d.getKlasorAdi().Count;i++)
            {

                ListViewItem item = new ListViewItem(d.getKlasorAdi()[i]);
                item.SubItems.Add("Klasör");
                item.SubItems.Add("");
                item.SubItems.Add(d.getKlasorOlusturma()[i]);

                dizinIcerigiListView.Items.Add(item);
            }

         /*   for (int i = 0; i < d.getKlasorAdi().Count; i++)
            {

                ListViewItem item = new ListViewItem(d.getDosyaAdi()[i]);
                item.SubItems.Add("Dosya");
                item.SubItems.Add(d.getDosyaBoyutu()[i].ToString());
                item.SubItems.Add(d.getDosyaOlusturma()[i]);
                dizinIcerigiListView.Items.Add(item);
            }*/

        }
    }
}
