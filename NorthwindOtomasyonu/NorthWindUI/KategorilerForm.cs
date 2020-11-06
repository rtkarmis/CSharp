using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM;

namespace NorthWindUI
{
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }

        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            KategorilerORM kategoriler = new KategorilerORM();
            dataGridView1.DataSource = kategoriler.Listele();
            dataGridView1.Columns[0].Visible = false;

        }
    }
}
