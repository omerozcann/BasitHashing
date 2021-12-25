using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace basithashing
{
    public partial class basitHashFrm : Form
    {
        List<string> dizi;
        List<int> hashKodlari,modlar;
        String[] indeksdizi;
        public basitHashFrm()
        {
            InitializeComponent();
        }

        private void kelimeyuklebtn_Click(object sender, EventArgs e)
        {
            dizi = new List<string>();
            kelimelerlst.Items.Clear();
            StreamReader sr = new StreamReader("kelimeler.txt");
            while(sr.EndOfStream==false)
            {
                String satir = sr.ReadLine();
                kelimelerlst.Items.Add(satir);
                dizi.Add(satir);
            }
            sr.Close();
        }

        private void hashuretbtn_Click(object sender, EventArgs e)
        {
            hashKodlari = new List<int>();
            hashkodlst.Items.Clear();
            if(dizi!=null)
            {
                for(int i=0;i<dizi.Count;i++)
                {
                    hashkodlst.Items.Add(dizi[i].GetHashCode());
                    hashKodlari.Add(dizi[i].GetHashCode());
                }
            }else
            {
                MessageBox.Show("Veri yok");
            }
        }

        private void modgosterbtn_Click(object sender, EventArgs e)
        {
            if (dizi != null)
            {
                modlar = new List<int>();
                int modDegeri = dizi.Count;
                for (int i = 0; i < dizi.Count; i++)
                {
                    modlst.Items.Add(Math.Abs(hashKodlari[i] % modDegeri));
                    modlar.Add(Math.Abs(hashKodlari[i] % modDegeri));
                }
            }
            else
            {
                MessageBox.Show("Veri yok");
            }
          
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            String aranan = aranantxt.Text;
            int hash = aranan.GetHashCode();
            int mod = Math.Abs(hash % dizi.Count);
            if(aranan==indeksdizi[mod])
            {
                MessageBox.Show(mod+". Sırada Bulundu");
            }else
            {
                MessageBox.Show("Bulunamadı");
            }
        }

        private void indekslebtn_Click(object sender, EventArgs e)
        {
            indeksdizi = new String[dizi.Count];
            for(int i=0;i<dizi.Count;i++)
            {
                indeksdizi[modlar[i]] = dizi[i];
            }

            for (int i = 0; i < indeksdizi.Length; i++)
            {
                if(indeksdizi[i]!=null)
                {
                    indekslst.Items.Add(indeksdizi[i]);
                }else
                {
                    indekslst.Items.Add("-------");
                }               
            }
        }
    }
}
