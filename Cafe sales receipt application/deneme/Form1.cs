using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }               

        int satilanurunadedi, satilanurunadedi1, kasatoplam, aratoplam, çayToplam, suToplam, çeşitçayToplam, nescafeToplam, kolaToplam, fantaToplam, sodaToplam, enerjiicecegiToplam;        

    private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        void fis()
        {
            int adisyontoplam = 0;
            Label[] labellerim = {label3, label4, label5, label6, label7, label8, label9, label12};
            int labelArtis = 0;

            //global değişkenlerin tutulduğu dizi
            int[] arr = new int[20];
            arr[0] = satilanurunadedi;
            arr[1] = satilanurunadedi1;
            arr[2] = kasatoplam;
            arr[3] = aratoplam;
            arr[4] = çayToplam;
            arr[5] = suToplam;
            arr[6] = çeşitçayToplam;
            arr[7] = nescafeToplam;
            arr[8] = kolaToplam;
            arr[9] = fantaToplam;
            arr[10] = sodaToplam;
            arr[11] = enerjiicecegiToplam;

            //toplamların tutulduğu dizi
            int[] toplam = new int[8];
            toplam[0] = çayToplam * 1;
            toplam[1] = suToplam * 1;
            toplam[2] = çeşitçayToplam * 2;
            toplam[3] = nescafeToplam * 2;
            toplam[4] = kolaToplam * 3;
            toplam[5] = fantaToplam * 3;
            toplam[6] = sodaToplam * 2;
            toplam[7] = enerjiicecegiToplam * 5;


            for (int i=0; i<toplam.Length; i++)
            {
                if(arr[i+4] != 0)
                {
                    listBox1.Items.Add(labellerim[i].Text + " " + toplam[i] + "₺");
                    labelArtis++;                    
                }                
            }
          
            for (int i=0; i<toplam.Length; i++)
            {
                adisyontoplam += toplam[i];
            }
            listBox1.Items.Add("Toplam Tutar: " + adisyontoplam + "₺");           
        }

        private void ÖdemeAl_Click(object sender, EventArgs e)
        {
            satilanurunadedi = çayToplam + suToplam + çeşitçayToplam + nescafeToplam + kolaToplam + fantaToplam + sodaToplam + enerjiicecegiToplam;
            SatılanÜrünAdediLabel.Text = satilanurunadedi.ToString();
            fis();
            Label[] labellerim = { ÇayLabel, SuLabel, ÇeşitÇayLabel,NescafeLabel,KolaLabel,FantaLabel,SodaLabel,EnerjiİçecegiLabel };

            int[] arr = new int[20];     
            çayToplam = arr[4];
            suToplam = arr[5];
            çeşitçayToplam = arr[6];
            nescafeToplam = arr[7];
            kolaToplam = arr[8];
            fantaToplam = arr[9];
            sodaToplam = arr[10];
            enerjiicecegiToplam = arr[11];

            for (int i = 0; i < labellerim.Length; i++)
            {
                arr[i] = 0;
                labellerim[i].Text = "0";
            }

            kasatoplam += aratoplam;
            KasaToplamLabel.Text = kasatoplam.ToString() + "₺";
            AraToplamLabel.Text = "0";
            aratoplam = 0;

            satilanurunadedi1 += satilanurunadedi;
            SatılanÜrünAdediLabel.Text = satilanurunadedi1.ToString();
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            aratoplam = çayToplam + suToplam + (çeşitçayToplam * 2) + (nescafeToplam * 2) + (kolaToplam * 3) + (fantaToplam * 3) + (sodaToplam * 2) + (enerjiicecegiToplam * 5);
            AraToplamLabel.Text = aratoplam.ToString() + "₺";
            
        }

        void textboxdegerlerisifiryapma()
        {
            TextBox[] tb = { ÇayTB, SuTB, ÇeşitÇayTB, NescafeTB, KolaTB, FantaTB, SodaTB, EnerjiİcecegiTB };

            for (int i = 0; i < tb.Count(); i++)
            {
                tb[i].Clear();
                tb[i].Text = "0";
            }
        }

        private void ÜrünEkle_Click(object sender, EventArgs e)
        {
            TextBox[] tb = { ÇayTB, SuTB, ÇeşitÇayTB, NescafeTB, KolaTB, FantaTB, SodaTB, EnerjiİcecegiTB };
            
            for(int i=0; i<tb.Count(); i++)
            {
                if(tb[i].Text == "" || Convert.ToInt32(tb[i].Text) < 0)
                {
                    MessageBox.Show("Hatalı veya Eksik Değer Girdiniz.");
                    tb[i].Text = "0";
                }
            }

            çayToplam += Convert.ToInt32(ÇayTB.Text);
            suToplam += Convert.ToInt32(SuTB.Text);
            çeşitçayToplam += Convert.ToInt32(ÇeşitÇayTB.Text);
            nescafeToplam += Convert.ToInt32(NescafeTB.Text);
            kolaToplam += Convert.ToInt32(KolaTB.Text);
            fantaToplam += Convert.ToInt32(FantaTB.Text);
            sodaToplam += Convert.ToInt32(SodaTB.Text);
            enerjiicecegiToplam += Convert.ToInt32(EnerjiİcecegiTB.Text);

            ÇayLabel.Text = çayToplam.ToString();
            SuLabel.Text = suToplam.ToString();
            ÇeşitÇayLabel.Text = çeşitçayToplam.ToString();
            NescafeLabel.Text = nescafeToplam.ToString();
            KolaLabel.Text = kolaToplam.ToString();
            FantaLabel.Text = fantaToplam.ToString();
            SodaLabel.Text = sodaToplam.ToString();
            EnerjiİçecegiLabel.Text = enerjiicecegiToplam.ToString();

            textboxdegerlerisifiryapma();
        }
    }
}
