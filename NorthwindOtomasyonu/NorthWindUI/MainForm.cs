using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWindUI
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        frmUrunler uf = new frmUrunler();
        frmKategoriler kf = new frmKategoriler();
        frmTedarikciler tf = new frmTedarikciler();
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uf.IsDisposed)
            {
                uf = new frmUrunler();
            }
            uf.MdiParent = this;
            uf.Show();
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kf.IsDisposed)
            {
                kf = new frmKategoriler();
            }
            kf.MdiParent = this;
            kf.Show();
        }

        private void tedarikçilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tf.IsDisposed)
            {
                tf = new frmTedarikciler();
            }

            tf.MdiParent = this;
            tf.Show();
        }
    }
}
