
namespace deneme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Masa = new System.Windows.Forms.GroupBox();
            this.ÖdemeAl = new System.Windows.Forms.Button();
            this.Hesapla = new System.Windows.Forms.Button();
            this.AraToplamLabel = new System.Windows.Forms.Label();
            this.ÜrünEkle = new System.Windows.Forms.Button();
            this.EnerjiİçecegiLabel = new System.Windows.Forms.Label();
            this.SodaLabel = new System.Windows.Forms.Label();
            this.FantaLabel = new System.Windows.Forms.Label();
            this.KolaLabel = new System.Windows.Forms.Label();
            this.NescafeLabel = new System.Windows.Forms.Label();
            this.ÇeşitÇayLabel = new System.Windows.Forms.Label();
            this.SuLabel = new System.Windows.Forms.Label();
            this.ÇayLabel = new System.Windows.Forms.Label();
            this.EnerjiİcecegiTB = new System.Windows.Forms.TextBox();
            this.SodaTB = new System.Windows.Forms.TextBox();
            this.FantaTB = new System.Windows.Forms.TextBox();
            this.KolaTB = new System.Windows.Forms.TextBox();
            this.NescafeTB = new System.Windows.Forms.TextBox();
            this.ÇeşitÇayTB = new System.Windows.Forms.TextBox();
            this.SuTB = new System.Windows.Forms.TextBox();
            this.ÇayTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KasaToplamLabel = new System.Windows.Forms.Label();
            this.SatılanÜrünAdediLabel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Masa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Location = new System.Drawing.Point(-1, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(737, 109);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salaz\'s Cafe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Masa
            // 
            this.Masa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Masa.Controls.Add(this.ÖdemeAl);
            this.Masa.Controls.Add(this.Hesapla);
            this.Masa.Controls.Add(this.AraToplamLabel);
            this.Masa.Controls.Add(this.ÜrünEkle);
            this.Masa.Controls.Add(this.EnerjiİçecegiLabel);
            this.Masa.Controls.Add(this.SodaLabel);
            this.Masa.Controls.Add(this.FantaLabel);
            this.Masa.Controls.Add(this.KolaLabel);
            this.Masa.Controls.Add(this.NescafeLabel);
            this.Masa.Controls.Add(this.ÇeşitÇayLabel);
            this.Masa.Controls.Add(this.SuLabel);
            this.Masa.Controls.Add(this.ÇayLabel);
            this.Masa.Controls.Add(this.EnerjiİcecegiTB);
            this.Masa.Controls.Add(this.SodaTB);
            this.Masa.Controls.Add(this.FantaTB);
            this.Masa.Controls.Add(this.KolaTB);
            this.Masa.Controls.Add(this.NescafeTB);
            this.Masa.Controls.Add(this.ÇeşitÇayTB);
            this.Masa.Controls.Add(this.SuTB);
            this.Masa.Controls.Add(this.ÇayTB);
            this.Masa.Controls.Add(this.label13);
            this.Masa.Controls.Add(this.label12);
            this.Masa.Controls.Add(this.label11);
            this.Masa.Controls.Add(this.label10);
            this.Masa.Controls.Add(this.label9);
            this.Masa.Controls.Add(this.label8);
            this.Masa.Controls.Add(this.label7);
            this.Masa.Controls.Add(this.label6);
            this.Masa.Controls.Add(this.label5);
            this.Masa.Controls.Add(this.label4);
            this.Masa.Controls.Add(this.label3);
            this.Masa.Controls.Add(this.label2);
            this.Masa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Masa.Location = new System.Drawing.Point(12, 115);
            this.Masa.Name = "Masa";
            this.Masa.Size = new System.Drawing.Size(405, 490);
            this.Masa.TabIndex = 3;
            this.Masa.TabStop = false;
            this.Masa.Text = "Masa-1 Adisyon";
            // 
            // ÖdemeAl
            // 
            this.ÖdemeAl.Location = new System.Drawing.Point(291, 418);
            this.ÖdemeAl.Name = "ÖdemeAl";
            this.ÖdemeAl.Size = new System.Drawing.Size(96, 30);
            this.ÖdemeAl.TabIndex = 31;
            this.ÖdemeAl.Text = "Ödeme Al";
            this.ÖdemeAl.UseVisualStyleBackColor = true;
            this.ÖdemeAl.Click += new System.EventHandler(this.ÖdemeAl_Click);
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(291, 382);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(96, 30);
            this.Hesapla.TabIndex = 30;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // AraToplamLabel
            // 
            this.AraToplamLabel.AutoSize = true;
            this.AraToplamLabel.Location = new System.Drawing.Point(141, 405);
            this.AraToplamLabel.Name = "AraToplamLabel";
            this.AraToplamLabel.Size = new System.Drawing.Size(28, 18);
            this.AraToplamLabel.TabIndex = 29;
            this.AraToplamLabel.Text = "0₺";
            // 
            // ÜrünEkle
            // 
            this.ÜrünEkle.Location = new System.Drawing.Point(203, 382);
            this.ÜrünEkle.Name = "ÜrünEkle";
            this.ÜrünEkle.Size = new System.Drawing.Size(68, 66);
            this.ÜrünEkle.TabIndex = 28;
            this.ÜrünEkle.Text = "Ürün Ekle";
            this.ÜrünEkle.UseVisualStyleBackColor = true;
            this.ÜrünEkle.Click += new System.EventHandler(this.ÜrünEkle_Click);
            // 
            // EnerjiİçecegiLabel
            // 
            this.EnerjiİçecegiLabel.AutoSize = true;
            this.EnerjiİçecegiLabel.Location = new System.Drawing.Point(337, 334);
            this.EnerjiİçecegiLabel.Name = "EnerjiİçecegiLabel";
            this.EnerjiİçecegiLabel.Size = new System.Drawing.Size(18, 18);
            this.EnerjiİçecegiLabel.TabIndex = 27;
            this.EnerjiİçecegiLabel.Text = "0";
            // 
            // SodaLabel
            // 
            this.SodaLabel.AutoSize = true;
            this.SodaLabel.Location = new System.Drawing.Point(337, 298);
            this.SodaLabel.Name = "SodaLabel";
            this.SodaLabel.Size = new System.Drawing.Size(18, 18);
            this.SodaLabel.TabIndex = 26;
            this.SodaLabel.Text = "0";
            // 
            // FantaLabel
            // 
            this.FantaLabel.AutoSize = true;
            this.FantaLabel.Location = new System.Drawing.Point(337, 262);
            this.FantaLabel.Name = "FantaLabel";
            this.FantaLabel.Size = new System.Drawing.Size(18, 18);
            this.FantaLabel.TabIndex = 25;
            this.FantaLabel.Text = "0";
            // 
            // KolaLabel
            // 
            this.KolaLabel.AutoSize = true;
            this.KolaLabel.Location = new System.Drawing.Point(337, 226);
            this.KolaLabel.Name = "KolaLabel";
            this.KolaLabel.Size = new System.Drawing.Size(18, 18);
            this.KolaLabel.TabIndex = 24;
            this.KolaLabel.Text = "0";
            // 
            // NescafeLabel
            // 
            this.NescafeLabel.AutoSize = true;
            this.NescafeLabel.Location = new System.Drawing.Point(337, 190);
            this.NescafeLabel.Name = "NescafeLabel";
            this.NescafeLabel.Size = new System.Drawing.Size(18, 18);
            this.NescafeLabel.TabIndex = 23;
            this.NescafeLabel.Text = "0";
            // 
            // ÇeşitÇayLabel
            // 
            this.ÇeşitÇayLabel.AutoSize = true;
            this.ÇeşitÇayLabel.Location = new System.Drawing.Point(337, 154);
            this.ÇeşitÇayLabel.Name = "ÇeşitÇayLabel";
            this.ÇeşitÇayLabel.Size = new System.Drawing.Size(18, 18);
            this.ÇeşitÇayLabel.TabIndex = 22;
            this.ÇeşitÇayLabel.Text = "0";
            // 
            // SuLabel
            // 
            this.SuLabel.AutoSize = true;
            this.SuLabel.Location = new System.Drawing.Point(337, 118);
            this.SuLabel.Name = "SuLabel";
            this.SuLabel.Size = new System.Drawing.Size(18, 18);
            this.SuLabel.TabIndex = 21;
            this.SuLabel.Text = "0";
            // 
            // ÇayLabel
            // 
            this.ÇayLabel.AutoSize = true;
            this.ÇayLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ÇayLabel.Location = new System.Drawing.Point(337, 82);
            this.ÇayLabel.Name = "ÇayLabel";
            this.ÇayLabel.Size = new System.Drawing.Size(18, 18);
            this.ÇayLabel.TabIndex = 20;
            this.ÇayLabel.Text = "0";
            // 
            // EnerjiİcecegiTB
            // 
            this.EnerjiİcecegiTB.Location = new System.Drawing.Point(204, 327);
            this.EnerjiİcecegiTB.Name = "EnerjiİcecegiTB";
            this.EnerjiİcecegiTB.Size = new System.Drawing.Size(67, 26);
            this.EnerjiİcecegiTB.TabIndex = 19;
            this.EnerjiİcecegiTB.Text = "0";
            this.EnerjiİcecegiTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SodaTB
            // 
            this.SodaTB.Location = new System.Drawing.Point(204, 292);
            this.SodaTB.Name = "SodaTB";
            this.SodaTB.Size = new System.Drawing.Size(67, 26);
            this.SodaTB.TabIndex = 18;
            this.SodaTB.Text = "0";
            this.SodaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FantaTB
            // 
            this.FantaTB.Location = new System.Drawing.Point(204, 257);
            this.FantaTB.Name = "FantaTB";
            this.FantaTB.Size = new System.Drawing.Size(67, 26);
            this.FantaTB.TabIndex = 17;
            this.FantaTB.Text = "0";
            this.FantaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KolaTB
            // 
            this.KolaTB.Location = new System.Drawing.Point(204, 222);
            this.KolaTB.Name = "KolaTB";
            this.KolaTB.Size = new System.Drawing.Size(67, 26);
            this.KolaTB.TabIndex = 16;
            this.KolaTB.Text = "0";
            this.KolaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NescafeTB
            // 
            this.NescafeTB.Location = new System.Drawing.Point(204, 187);
            this.NescafeTB.Name = "NescafeTB";
            this.NescafeTB.Size = new System.Drawing.Size(67, 26);
            this.NescafeTB.TabIndex = 15;
            this.NescafeTB.Text = "0";
            this.NescafeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ÇeşitÇayTB
            // 
            this.ÇeşitÇayTB.Location = new System.Drawing.Point(204, 152);
            this.ÇeşitÇayTB.Name = "ÇeşitÇayTB";
            this.ÇeşitÇayTB.Size = new System.Drawing.Size(67, 26);
            this.ÇeşitÇayTB.TabIndex = 14;
            this.ÇeşitÇayTB.Text = "0";
            this.ÇeşitÇayTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SuTB
            // 
            this.SuTB.Location = new System.Drawing.Point(204, 117);
            this.SuTB.Name = "SuTB";
            this.SuTB.Size = new System.Drawing.Size(67, 26);
            this.SuTB.TabIndex = 13;
            this.SuTB.Text = "0";
            this.SuTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ÇayTB
            // 
            this.ÇayTB.Location = new System.Drawing.Point(204, 82);
            this.ÇayTB.Name = "ÇayTB";
            this.ÇayTB.Size = new System.Drawing.Size(67, 26);
            this.ÇayTB.TabIndex = 12;
            this.ÇayTB.Text = "0";
            this.ÇayTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "Ara Toplam: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Enerji İçeceği(5₺):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Güncel Alım";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Alım Adeti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Soda(2₺):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fanta(3₺):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kola(3₺):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nescafe(2₺):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Çeşit Çay(2₺):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Su(1₺):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Çay(1₺):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı(Fiyat)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Controls.Add(this.KasaToplamLabel);
            this.groupBox2.Controls.Add(this.SatılanÜrünAdediLabel);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Location = new System.Drawing.Point(423, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 166);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kasa bilgisi";
            // 
            // KasaToplamLabel
            // 
            this.KasaToplamLabel.AutoSize = true;
            this.KasaToplamLabel.Location = new System.Drawing.Point(224, 107);
            this.KasaToplamLabel.Name = "KasaToplamLabel";
            this.KasaToplamLabel.Size = new System.Drawing.Size(18, 20);
            this.KasaToplamLabel.TabIndex = 3;
            this.KasaToplamLabel.Text = "0";
            // 
            // SatılanÜrünAdediLabel
            // 
            this.SatılanÜrünAdediLabel.AutoSize = true;
            this.SatılanÜrünAdediLabel.Location = new System.Drawing.Point(74, 107);
            this.SatılanÜrünAdediLabel.Name = "SatılanÜrünAdediLabel";
            this.SatılanÜrünAdediLabel.Size = new System.Drawing.Size(18, 20);
            this.SatılanÜrünAdediLabel.TabIndex = 2;
            this.SatılanÜrünAdediLabel.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(185, 50);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 20);
            this.label24.TabIndex = 1;
            this.label24.Text = "Kasa Toplam";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 20);
            this.label23.TabIndex = 0;
            this.label23.Text = "Satılan Ürün Adedi";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(423, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 318);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgilendirme Fişi";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(19, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 244);
            this.listBox1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(190, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(742, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Masa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Masa.ResumeLayout(false);
            this.Masa.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Masa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ÖdemeAl;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.Label AraToplamLabel;
        private System.Windows.Forms.Button ÜrünEkle;
        private System.Windows.Forms.Label EnerjiİçecegiLabel;
        private System.Windows.Forms.Label SodaLabel;
        private System.Windows.Forms.Label FantaLabel;
        private System.Windows.Forms.Label KolaLabel;
        private System.Windows.Forms.Label NescafeLabel;
        private System.Windows.Forms.Label ÇeşitÇayLabel;
        private System.Windows.Forms.Label SuLabel;
        private System.Windows.Forms.Label ÇayLabel;
        private System.Windows.Forms.TextBox EnerjiİcecegiTB;
        private System.Windows.Forms.TextBox SodaTB;
        private System.Windows.Forms.TextBox FantaTB;
        private System.Windows.Forms.TextBox KolaTB;
        private System.Windows.Forms.TextBox NescafeTB;
        private System.Windows.Forms.TextBox ÇeşitÇayTB;
        private System.Windows.Forms.TextBox SuTB;
        private System.Windows.Forms.TextBox ÇayTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KasaToplamLabel;
        private System.Windows.Forms.Label SatılanÜrünAdediLabel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

