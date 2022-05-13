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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VQIFM1S;Initial Catalog=Login_Panel;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 90;
        }
        private void label1_MouseHover(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }                      

        #region TXT
        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Username")
                txt_Username.Text = "";            
        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
                txt_Username.Text = "Username";            
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.isPassword = true;
            }
            
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Password";
                txt_Password.isPassword = false;
            }            
        }

        #endregion

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        New_User a = new New_User();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            a.ShowDialog();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = false;

            if(move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici_listesi where kullanici_Adi=@p1 and kullanici_sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_Username.Text);
            komut.Parameters.AddWithValue("@p2", txt_Password.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Anasayfa frm = new Anasayfa();
                frm.Show();
                this.Hide();
            }
            else if (txt_Username.Text == "Username" || txt_Username.Text == "")
            {
                errorProvider1.SetError(txt_Username, "Lütfen Kullanıcı Adını Giriniz.");
            }
            else if (txt_Password.Text == "Password" || txt_Password.Text == "")
            {
                errorProvider2.SetError(txt_Password, "Lütfen Şifrenizi Giriniz.");
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
            }
            baglanti.Close();
                      
        }
    }
}
