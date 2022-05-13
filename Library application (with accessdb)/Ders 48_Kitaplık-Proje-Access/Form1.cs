using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ders_48_Kitaplık_Proje_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\metin\Desktop\Mersin ÜNİ\C# Dersleri\Ders 48_Kitaplık-Proje-Access\Kitaplık.mdb");
        BaglantiSinif bgl = new BaglantiSinif();
        
        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from kitaplar", bgl.Adres);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle()
        {
            TxtKitapID.Clear();
            TxtKitapAd.Clear();
            TxtYazar.Clear();
            TxtSayfa.Clear();
            CmbTür.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
        string durum = "";
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(bgl.Adres);
            conn.Open();
            OleDbCommand komut1 = new OleDbCommand("insert into kitaplar (KitapAd,Yazar,Tur,Sayfa,Durum) values (@p1,@p2,@p3,@p4,@p5)", conn);
            komut1.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut1.Parameters.AddWithValue("@p2", TxtYazar.Text);
            komut1.Parameters.AddWithValue("@p3", CmbTür.Text);
            komut1.Parameters.AddWithValue("@p4", TxtSayfa.Text);
            komut1.Parameters.AddWithValue("@p5", durum);
            komut1.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kitap Sİsteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtKitapID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbTür.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(bgl.Adres);
            conn.Open();
            OleDbCommand komut = new OleDbCommand("Delete from kitaplar where kitapıd=@p1", conn);
            komut.Parameters.AddWithValue("@p1", TxtKitapID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kitap Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(bgl.Adres);
            conn.Open();
            OleDbCommand komut2 = new OleDbCommand("update kitaplar set kitapad=@p1, yazar=@p2,tur=@p3,sayfa=@p4,durum=@p5 where kitapID=@p6", conn);
            komut2.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtYazar.Text);
            komut2.Parameters.AddWithValue("@p3", CmbTür.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSayfa.Text);
            if (radioButton1.Checked == true)
            {
                komut2.Parameters.AddWithValue("@p5", durum);
            }
            if (radioButton2.Checked == true)
            {
                komut2.Parameters.AddWithValue("@p5", durum);
            }
            komut2.Parameters.AddWithValue("@p6", TxtKitapID.Text);
            komut2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(bgl.Adres);
            OleDbCommand komut = new OleDbCommand("select * from kitaplar where kitapad=@p1", conn);
            komut.Parameters.AddWithValue("@p1", TxtKitapBul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(bgl.Adres);
            OleDbCommand komut = new OleDbCommand("select * from kitaplar where kitapad like '%"+ TxtKitapBul.Text + "%'", conn);            
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void TxtKitapBul_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(bgl.Adres);
            conn.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar where KitapAd like'%" + TxtKitapBul.Text + "%'", conn);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
