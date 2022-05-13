using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmDoktorGiriş : Form
    {
        public FrmDoktorGiriş()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_doktorlar where doktortc=@p1 and doktorsifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Username.Text);
            komut.Parameters.AddWithValue("@p2", txt_Password.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.TC = txt_Username.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }
            bgl.baglanti().Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if (txt_Username.Text == "TC Kimlik No")
                txt_Username.Text = "";
        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
                txt_Username.Text = "TC Kimlik No";
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Şifre")
            {
                txt_Password.Text = "";
                txt_Password.isPassword = true;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Şifre";
                txt_Password.isPassword = false;
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            PanelBaslıkÇizgi.Visible = true;
        }

        private void FrmDoktorGiriş_MouseMove(object sender, MouseEventArgs e)
        {
            PanelBaslıkÇizgi.Visible = false;
        }

        private void FrmDoktorGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
