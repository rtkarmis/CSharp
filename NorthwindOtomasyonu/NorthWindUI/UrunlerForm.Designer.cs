namespace NorthWindUI
{
    partial class frmUrunler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUrun = new System.Windows.Forms.Label();
            this.tbxUrun = new System.Windows.Forms.TextBox();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.cbxTedarikci = new System.Windows.Forms.ComboBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.lblStok = new System.Windows.Forms.Label();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(32, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 416);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.düzenleToolStripMenuItem.Text = "Sil";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(55, 14);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(63, 17);
            this.lblUrun.TabIndex = 1;
            this.lblUrun.Text = "Ürün Adı";
            // 
            // tbxUrun
            // 
            this.tbxUrun.Location = new System.Drawing.Point(32, 34);
            this.tbxUrun.Name = "tbxUrun";
            this.tbxUrun.Size = new System.Drawing.Size(110, 22);
            this.tbxUrun.TabIndex = 2;
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.AutoSize = true;
            this.lblTedarikci.Location = new System.Drawing.Point(202, 12);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(66, 17);
            this.lblTedarikci.TabIndex = 3;
            this.lblTedarikci.Text = "Tedarikçi";
            // 
            // cbxTedarikci
            // 
            this.cbxTedarikci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTedarikci.FormattingEnabled = true;
            this.cbxTedarikci.Location = new System.Drawing.Point(175, 32);
            this.cbxTedarikci.Name = "cbxTedarikci";
            this.cbxTedarikci.Size = new System.Drawing.Size(121, 24);
            this.cbxTedarikci.TabIndex = 4;
            // 
            // cbxKategori
            // 
            this.cbxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(340, 32);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(121, 24);
            this.cbxKategori.TabIndex = 6;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(366, 14);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(61, 17);
            this.lblKategori.TabIndex = 5;
            this.lblKategori.Text = "Kategori";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(530, 14);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 17);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyat";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(500, 32);
            this.nudFiyat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 22);
            this.nudFiyat.TabIndex = 8;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(677, 12);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(36, 17);
            this.lblStok.TabIndex = 7;
            this.lblStok.Text = "Stok";
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(650, 35);
            this.nudStok.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(120, 22);
            this.nudStok.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(819, 32);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 25);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1013, 510);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudStok);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cbxTedarikci);
            this.Controls.Add(this.lblTedarikci);
            this.Controls.Add(this.tbxUrun);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.UrunlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.TextBox tbxUrun;
        private System.Windows.Forms.Label lblTedarikci;
        private System.Windows.Forms.ComboBox cbxTedarikci;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
    }
}