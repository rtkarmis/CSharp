using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtikKutusuUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int puan = 0;
        private int sayi = 60;
        private void Form1_Load(object sender, EventArgs e)
        {

            lblPuan.Text = puan.ToString();
            lblSure.Text = sayi.ToString();


        }

        private static List<Atik> AtikList()
        {
            Atik domates = new Atik
            {
                Hacim = 150,
                Image = Image.FromFile(@"domates.jpg"),
                Tur = Tur.Organik,
                Ad = "Domates"
            };
            Atik salcaKutusu = new Atik
            {
                Hacim = 550,
                Image = Image.FromFile(@"salca.jpg"),
                Tur = Tur.Metal,
                Ad = "Salça Kutusu"
            };
            Atik kolaKutusu = new Atik
            {
                Hacim = 350,
                Image = Image.FromFile(@"kola.jpg"),
                Tur = Tur.Metal,
                Ad = "Kola Kutusu"

            };
            Atik salatalik = new Atik
            {
                Hacim = 120,
                Image = Image.FromFile(@"salatalik.jpg"),
                Tur = Tur.Organik,
                Ad = "Salatalık"
            };
            Atik gazete = new Atik
            {
                Hacim = 250,
                Image = Image.FromFile(@"gazete.jpg"),
                Tur = Tur.Kagit,
                Ad = "Gazete"
            };

            Atik dergi = new Atik
            {
                Hacim = 200,
                Image = Image.FromFile(@"dergi.jpg"),
                Tur = Tur.Kagit,
                Ad = "Dergi"
            };
            Atik bardak = new Atik
            {
                Hacim = 250,
                Image = Image.FromFile(@"bardak.jpg"),
                Tur = Tur.Cam,
                Ad = "Bardak"
            };

            Atik camSise = new Atik
            {
                Hacim = 600,
                Image = Image.FromFile(@"cam-sise.jpg"),
                Tur = Tur.Cam,
                Ad = "Cam Şişe"

            };

            List<Atik> atiklar = new List<Atik>();

            atiklar.Add(domates);
            atiklar.Add(dergi);
            atiklar.Add(gazete);
            atiklar.Add(salatalik);
            atiklar.Add(salcaKutusu);
            atiklar.Add(kolaKutusu);
            atiklar.Add(camSise);
            atiklar.Add(bardak);
            return atiklar;
        }

        static Random random = new Random();
        static List<Atik> atiklar = AtikList();
        private static int selected;
        
        private void btnYeni_Click(object sender, EventArgs e)
        {
            NewImage();
            Reset();
            ButtonEnabled(true);
        }

        private void Reset()
        {
            sayi = 60;
            lblSure.Text = sayi.ToString();
            puan = 0;
            lblPuan.Text = puan.ToString();
            timer1.Enabled = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            pbrCam.Value = 0;
            pbrOrganik.Value = 0;
            pbrMetal.Value = 0;
            pbrKagit.Value = 0;
        }

        private void NewImage()
        {
            int sayi = random.Next(0, atiklar.Count);
            pictureBox1.Image = atiklar[sayi].Image;
            selected = sayi;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        static List<AtikKutusu> atikKutusuVar = AtikKutusuList();
        
        private void btnOrganik_Click(object sender, EventArgs e)
        {
            AddItem(atiklar,atikKutusuVar[0],Tur.Organik,listBox1, pbrOrganik);
        }

        private void AddItem(List<Atik> atiklar,AtikKutusu atikKutusu,Tur tur, ListBox listbox,ProgressBar pbrBar)
        {
            if (atiklar[selected].Tur == tur && atikKutusu.Ekle(atiklar[selected]))
            {
                listbox.Items.Add(string.Format("{0}-{1}", atiklar[selected].Ad, atiklar[selected].Hacim));
                puan += (int)atiklar[selected].Hacim;
                lblPuan.Text = puan.ToString();
                pbrBar.Maximum = (int)atikKutusu.Kapasite;
                pbrBar.Value = (int)atikKutusu.DoluHacim;
                NewImage();
            }

            else if (pbrBar.Maximum < pbrBar.Value +(int)atiklar[selected].Hacim)
            {
                MessageBox.Show("Ürünü eklemek için öncelikle atık kutusunu boşaltmalısın");
            }
        }

        private void btnOrBosalt_Click(object sender, EventArgs e)
        {
            RemoveItem(atikKutusuVar[0],listBox1,pbrOrganik);
        }

        private void RemoveItem(AtikKutusu atikKutusu,ListBox listbox, ProgressBar pbrBar)
        {
            if (atikKutusu.Bosalt())
            {
                listbox.Items.Clear();
                puan += atikKutusu.BosaltmaPuani;
                lblPuan.Text = puan.ToString();
                pbrBar.Maximum = (int)atikKutusu.Kapasite;
                pbrBar.Value = (int)atikKutusu.DoluHacim;
                sayi += 3;
                lblSure.Text = sayi.ToString();
            }
        }

        private static List<AtikKutusu> AtikKutusuList()
        {
            
            AtikKutusu organik = new AtikKutusu
            {
                Kapasite = 700,
                BosaltmaPuani = 0,
                DoluHacim = 0
            };
            AtikKutusu kagit = new AtikKutusu
            {
                Kapasite = 1200,
                BosaltmaPuani = 1000,
                DoluHacim = 0
            };
            AtikKutusu cam = new AtikKutusu
            {
                Kapasite = 2200,
                BosaltmaPuani = 600,
                DoluHacim = 0
            };
            AtikKutusu metal = new AtikKutusu
            {
                Kapasite = 2300,
                BosaltmaPuani = 800,
                DoluHacim = 0
            };

            List<AtikKutusu> atikKutusuList = new List<AtikKutusu>();
            atikKutusuList.Add(organik);
            atikKutusuList.Add(kagit);
            atikKutusuList.Add(cam);
            atikKutusuList.Add(metal);
            
            return atikKutusuList;
        }

        private void btnKagit_Click(object sender, EventArgs e)
        {
            AddItem(atiklar, atikKutusuVar[1], Tur.Kagit, listBox2, pbrKagit);
        }

        private void btnKaBosalt_Click(object sender, EventArgs e)
        {
            RemoveItem(atikKutusuVar[1],listBox2,pbrKagit);
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            AddItem(atiklar,atikKutusuVar[2],Tur.Cam,listBox3,pbrCam);
        }

        private void btnCaBosalt_Click(object sender, EventArgs e)
        {
            RemoveItem(atikKutusuVar[2],listBox3,pbrCam);
        }

        private void btnMetal_Click(object sender, EventArgs e)
        {
            AddItem(atiklar, atikKutusuVar[3], Tur.Metal, listBox4,pbrMetal);
        }

        private void btnMeBosalt_Click(object sender, EventArgs e)
        {
            RemoveItem(atikKutusuVar[3], listBox4,pbrMetal);
            
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi > 0)
            {
                timer1.Interval = 1000;
                timer1.Enabled = true;
                sayi--;
                lblSure.Text = sayi.ToString();
            }

            if (sayi == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show(string.Format("Oyun bitti !!!\nPuanınız : {0}", lblPuan.Text));
                ButtonEnabled(false);
            }
        }

        private void ButtonEnabled(bool state)
        {
            btnCam.Enabled = state;
            btnKagit.Enabled = state;
            btnMetal.Enabled = state;
            btnOrganik.Enabled = state;
            btnOrBosalt.Enabled = state;
            btnKaBosalt.Enabled = state;
            btnMeBosalt.Enabled = state;
            btnCaBosalt.Enabled = state;
        }
    }
}
