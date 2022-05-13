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

namespace WindowsFormsApp1
{
    public partial class New_User : Form
    {
        public New_User()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VQIFM1S;Initial Catalog=Login_Panel;Integrated Security=True");

        private void New_User_Load(object sender, EventArgs e)
        {
            this.Opacity = 90;
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region txt       

        private void txt_NewUser_Enter(object sender, EventArgs e)
        {
            if (txt_NewUser.Text == "New User")
                txt_NewUser.Text = "";
        }

        private void txt_NewUser_Leave(object sender, EventArgs e)
        {
            if (txt_NewUser.Text == "")
                txt_NewUser.Text = "New User";
        }

        private void txt_NewPassword_Enter(object sender, EventArgs e)
        {            
            if (txt_NewPassword.Text == "New Password")
            {
                txt_NewPassword.Text = "";
                txt_NewPassword.isPassword = true;
            }
        }

        private void txt_NewPassword_Leave(object sender, EventArgs e)
        {
            if (txt_NewPassword.Text == "")
            {
                txt_NewPassword.Text = "New Password";
                txt_NewPassword.isPassword = false;
            }
        }
        #endregion

        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1 kullanıcıgiris = new Form1();            
            SqlCommand komut = new SqlCommand("insert into kullanici_listesi (kullanici_adi,kullanici_sifre) values (@p3,@p4)", baglanti);
            SqlCommand komut2 = new SqlCommand("select * from kullanici_listesi where kullanici_Adi=@p1", baglanti);
            baglanti.Open();            
            komut2.Parameters.AddWithValue("@p1", txt_NewUser.Text);                    
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bu Kullanıcı Adı Kullanılmaktadır.");
            }
            else if (txt_NewUser.Text == "New User")
            {
                errorProvider1.SetError(txt_NewUser, "Lütfen Kullanıcı Adını Giriniz.");
            }            
            else if (txt_NewPassword.Text == "New Password")
            {
                errorProvider2.SetError(txt_NewPassword, "Lütfen Şifrenizi Giriniz.");
            }
            else
            {
                baglanti.Close();
                baglanti.Open();
                komut.Parameters.AddWithValue("@p3", txt_NewUser.Text);
                komut.Parameters.AddWithValue("@p4", txt_NewPassword.Text);
                komut.ExecuteNonQuery();
                kullanıcıgiris.Show();
                this.Hide();

            }
            baglanti.Close();                       
        }       
    }
}
