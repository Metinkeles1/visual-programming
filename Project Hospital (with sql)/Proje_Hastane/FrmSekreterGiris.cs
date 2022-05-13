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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {            
            SqlCommand komut = new SqlCommand("select * from tbl_sekreter where sekretertc=@p1 and sekretersifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Username.Text);
            komut.Parameters.AddWithValue("@p2", txt_Password.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.TCNumara = txt_Username.Text;
                frs.Show();
                this.Hide();
                                  
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti().Close();
        }
        #region TXT
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
        #endregion

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void FrmSekreterGiris_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = false;
        }
    }
}
