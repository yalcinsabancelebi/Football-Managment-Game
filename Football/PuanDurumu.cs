using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football
{
    public partial class PuanDurumu : Form
    {

        public PuanDurumu()
        {
            InitializeComponent();
        }
        private void PuanDurumu_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = MacEkrani.Sonuclar.ToList();
            dataGridView2.Columns[0].HeaderText = "Takım";
            dataGridView2.Columns[1].HeaderText = "Puan";
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
