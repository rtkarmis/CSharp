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
using Entity;
using ORM;

namespace NorthWindUI
{
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }
        UrunlerORM urunler = new UrunlerORM();
        KategorilerORM kategoriler = new KategorilerORM();
        TedarikcilerORM tedarikciler = new TedarikcilerORM();
        private Hashtable parameters;
        private bool result;
        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = urunler.Listele();
            dataGridView1.Columns[0].Visible = false;
            cbxTedarikci.DataSource = tedarikciler.Listele();
            cbxKategori.DataSource = kategoriler.Listele();
            cbxKategori.SelectedIndex = 0;
            cbxTedarikci.SelectedIndex = 0;
            cbxTedarikci.DisplayMember = "SirketAdi";
            cbxTedarikci.ValueMember = "TedarikciID";
            cbxKategori.DisplayMember = "KategoriAdi";
            cbxKategori.ValueMember = "KategoriID";

        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {

            Urun urun = new Urun
            {
                UrunAdi = tbxUrun.Text,
                KategoriID = (int)cbxKategori.SelectedValue,
                TedarikciID = (int)cbxTedarikci.SelectedValue,
                Fiyat = nudFiyat.Value,
                Stok = Convert.ToInt16(nudStok.Value),
                BirimdekiMiktar = ""
            };
            parameters = urunler.ORMParameters(urun);
            result = urunler.Ekle(urun, parameters);
            if (result)
            {
                MessageBox.Show("Ürün başarılı bir şekilde eklendi");
            }
            else
            {
                MessageBox.Show("Ürün eklenemedi");
            }

            dataGridView1.DataSource = urunler.Listele();

            Clear();
        }

        private void Clear()
        {
            tbxUrun.Text = String.Empty;
            cbxKategori.SelectedIndex = 0;
            cbxTedarikci.SelectedIndex = 0;
            nudFiyat.Value = 0;
            nudStok.Value = 0;
        }


        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunID"].Value.ToString());
            Hashtable parameter = urunler.ORMOneParameter(id);
            result = urunler.Sil(parameter);
            if (result)
            {
                MessageBox.Show("Ürün başarılı bir şekilde silinmiştir");
            }
            else
            {
                MessageBox.Show("Ürün silinirken hata oluştu");
            }

            dataGridView1.DataSource = urunler.Listele();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUrun.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            cbxTedarikci.SelectedValue = dataGridView1.CurrentRow.Cells["TedarikciID"].Value.ToString();
            cbxKategori.SelectedValue = dataGridView1.CurrentRow.Cells["KategoriID"].Value.ToString();
            nudFiyat.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Fiyat"].Value);
            nudStok.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Stok"].Value);
        }
    }
}
