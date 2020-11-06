using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class FrmYeniOyun : Form
    {
        public FrmYeniOyun()
        {
            InitializeComponent();
        }

        private void btnKolay_Click(object sender, EventArgs e)
        {
            AlanOlustur(0.1);

        }
        Random random = new Random();
        void AlanOlustur( double oran)
        {
            ButtonEnabled(false);
            flowLayoutPanel1.Controls.Clear();
            int satir = 10;
            int alan = (int) Math.Pow(satir, 2);
            int mayin = (int)(Math.Pow(satir, 2) * oran);
            List<int> mayinlar = new List<int>();
            for (int i = 0; i < mayin; i++)
            {
                int ran = random.Next(0, alan);
                if (mayinlar.Contains(ran))
                {
                    i--;
                }
                else
                {
                    mayinlar.Add(ran);
                }
            }

            for (int i = 0; i < alan; i++)
            {
                Button btn = new Button();
                btn.Width = btn.Height = 35;
                btn.BackColor = Color.Green;

                btn.Margin = new Padding(5,5,0,0);
                if (mayinlar.Contains(i))
                {
                    btn.Tag = true;
                }
                else
                {
                    btn.Tag = false;
                }
                btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }

            flowLayoutPanel1.Width = satir * 40;
            flowLayoutPanel1.Height = satir * 40;
            puan = 0;
            lblPuan.Text = puan.ToString();
        }

        void ButtonEnabled(bool state)
        {
            btnKolay.Enabled = state;
            btnOrta.Enabled = state;
            btnZor.Enabled = state;
        }
        private int puan = 0;
        private void btn_Click(object sender, EventArgs e)
        {
            Button clicked = (Button) sender;
            if ((bool) clicked.Tag)
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    Button btn = (Button) control;
                    if ((bool) btn.Tag )
                    {
                        btn.BackColor = Color.Red;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackgroundImage = Image.FromFile("mayin.jpg");
                        
                        
                    }
                    else
                    {
                        btn.BackColor = Color.Green;
                    }
                    ButtonEnabled(true);
                    btn.Enabled = false;
                }


                MessageBox.Show(string.Format("Mayına bastın !!!\n Puan : {0}", puan));
            }
            else
            {
                clicked.BackColor = Color.Gray;
                puan += 5;
                lblPuan.Text = puan.ToString();
            }
        }

        private void btnOrta_Click(object sender, EventArgs e)
        {
            AlanOlustur(0.25);
        }

        private void btnZor_Click(object sender, EventArgs e)
        {
            AlanOlustur(0.40);
        }

        
    }
}
