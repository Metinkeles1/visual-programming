
namespace Proje_Hastane
{
    partial class FrmBranş
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranş));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnGüncelle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnSil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtBranş = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtİd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton4);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(500, 167);
            this.bunifuGradientPanel1.TabIndex = 83;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(190, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ActiveBorderThickness = 1;
            this.BtnGüncelle.ActiveCornerRadius = 20;
            this.BtnGüncelle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnGüncelle.ActiveForecolor = System.Drawing.Color.White;
            this.BtnGüncelle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtnGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.BackgroundImage")));
            this.BtnGüncelle.ButtonText = "Güncelle";
            this.BtnGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGüncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGüncelle.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnGüncelle.IdleBorderThickness = 1;
            this.BtnGüncelle.IdleCornerRadius = 20;
            this.BtnGüncelle.IdleFillColor = System.Drawing.Color.White;
            this.BtnGüncelle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnGüncelle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnGüncelle.Location = new System.Drawing.Point(342, 250);
            this.BtnGüncelle.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(96, 41);
            this.BtnGüncelle.TabIndex = 97;
            this.BtnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ActiveBorderThickness = 1;
            this.BtnSil.ActiveCornerRadius = 20;
            this.BtnSil.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnSil.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSil.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSil.BackgroundImage")));
            this.BtnSil.ButtonText = "Sil";
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSil.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSil.IdleBorderThickness = 1;
            this.BtnSil.IdleCornerRadius = 20;
            this.BtnSil.IdleFillColor = System.Drawing.Color.White;
            this.BtnSil.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnSil.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnSil.Location = new System.Drawing.Point(392, 200);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(93, 41);
            this.BtnSil.TabIndex = 96;
            this.BtnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ActiveBorderThickness = 1;
            this.BtnEkle.ActiveCornerRadius = 20;
            this.BtnEkle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.BtnEkle.ActiveForecolor = System.Drawing.Color.White;
            this.BtnEkle.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.BtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEkle.BackgroundImage")));
            this.BtnEkle.ButtonText = "Ekle";
            this.BtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnEkle.IdleBorderThickness = 1;
            this.BtnEkle.IdleCornerRadius = 20;
            this.BtnEkle.IdleFillColor = System.Drawing.Color.White;
            this.BtnEkle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnEkle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnEkle.Location = new System.Drawing.Point(289, 200);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(93, 41);
            this.BtnEkle.TabIndex = 95;
            this.BtnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 317);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(473, 241);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtBranş
            // 
            this.TxtBranş.BackColor = System.Drawing.Color.White;
            this.TxtBranş.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TxtBranş.BorderColorIdle = System.Drawing.Color.White;
            this.TxtBranş.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TxtBranş.BorderThickness = 3;
            this.TxtBranş.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBranş.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBranş.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBranş.ForeColor = System.Drawing.Color.Black;
            this.TxtBranş.isPassword = false;
            this.TxtBranş.Location = new System.Drawing.Point(119, 250);
            this.TxtBranş.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBranş.MaxLength = 32767;
            this.TxtBranş.Name = "TxtBranş";
            this.TxtBranş.Size = new System.Drawing.Size(139, 30);
            this.TxtBranş.TabIndex = 89;
            this.TxtBranş.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 88;
            this.label1.Text = "Branş Ad:";
            // 
            // Txtİd
            // 
            this.Txtİd.BackColor = System.Drawing.Color.White;
            this.Txtİd.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Txtİd.BorderColorIdle = System.Drawing.Color.White;
            this.Txtİd.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Txtİd.BorderThickness = 3;
            this.Txtİd.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Txtİd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtİd.Font = new System.Drawing.Font("Century Gothic", 11.75F);
            this.Txtİd.ForeColor = System.Drawing.Color.Black;
            this.Txtİd.isPassword = false;
            this.Txtİd.Location = new System.Drawing.Point(119, 200);
            this.Txtİd.Margin = new System.Windows.Forms.Padding(4);
            this.Txtİd.MaxLength = 32767;
            this.Txtİd.Name = "Txtİd";
            this.Txtİd.Size = new System.Drawing.Size(139, 30);
            this.Txtİd.TabIndex = 86;
            this.Txtİd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 22);
            this.label9.TabIndex = 85;
            this.label9.Text = "Branş İd:";
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(463, 3);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(34, 33);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton4.TabIndex = 98;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmBranş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(500, 576);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBranş);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtİd);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmBranş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.FrmBranş_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnGüncelle;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnSil;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtBranş;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtİd;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}