using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

            //create 6 buttons
            int x = 33, y = 29;
            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    Button b = new Button();  //Create button
                    b.Location = new Point(x, y);  // Set new location
                    b.Name = "button_" + (i + 1).ToString();  // Set button name
                    b.Text = "Click";
                    b.Size = new Size(110, 42);
                    b.Font = new Font("Minion Pro", 20); // Change Button Font
                    b.Padding = new Padding(0);
                    b.Click += new EventHandler(this.button_click);
                    this.Controls.Add(b);
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        x = x + 170; // create button on right side

                        Button b = new Button();
                        b.Location = new Point(x, y);
                        b.Name = "button_" +(i + 1).ToString();
                        b.Text = "Click";
                        b.Size = new Size(110, 42);
                        b.Font = new Font("Minion Pro", 20);
                        b.Padding = new Padding(0);
                        b.Click += new EventHandler(this.button_click);
                        this.Controls.Add(b);
                    }
                    else
                    {

                        x = x - 170;/* create button on bottom of first */
                        y = y + 83;

                        Button b = new Button();
                        b.Location = new Point(x, y);
                        b.Name = "button_" +(i + 1).ToString();
                        b.Text = "Click";
                        b.Size = new Size(110, 42);
                        b.Font = new Font("Minion Pro", 20);
                        b.Padding = new Padding(0);
                        b.Click += new EventHandler(this.button_click);
                        this.Controls.Add(b);
                    }
                }
            }
        }
        void button_click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            btn.Text = "clicked";            
        }
    }
}
