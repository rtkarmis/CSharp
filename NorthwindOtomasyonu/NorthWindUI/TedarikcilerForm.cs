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
    public partial class frmTedarikciler : Form
    {
        public frmTedarikciler()
        {
            InitializeComponent();
        }

        private void frmTedarikciler_Load(object sender, EventArgs e)
        {
            TedarikcilerORM tedarikciler = new TedarikcilerORM();
            dataGridView1.DataSource = tedarikciler.Listele();
            dataGridView1.Columns[0].Visible = false;

        }
    }
}
