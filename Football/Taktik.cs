using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Football.FootballDataSetTableAdapters;
using System.Data.SqlClient;

namespace Football
{
    public partial class Taktik : Form
    {
        public Taktik()
        {
            InitializeComponent();
        }
        public void Oyuncular()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\database\Football.mdf; Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select f.Ad,f.Soyad,f.Yas,f.Mevki,y.Kalecilik,y.Defans as Savunma,y.Ortasaha,y.Forvet as Hücum,fd.FormaNo,fd.Mac,fd.Gol,fd.Asist,fd.Sari,fd.Kirmizi,fd.Maas,fd.Fiyat from Takimlar t inner join Futbolcu f on t.TakimId=f.TakimId inner join Yetenekler y on f.FutbolcuId=y.FutbolcuId inner join FDetaylari fd on f.FutbolcuId=fd.FutbolcuId where t.TakimAdi='" + GirisEkrani.TakimAdi + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewColumn kolon1 = dataGridView1.Columns[4];
            kolon1.Visible = false;
            DataGridViewColumn kolon2 = dataGridView1.Columns[5];
            kolon2.Visible = false;
            DataGridViewColumn kolon3 = dataGridView1.Columns[6];
            kolon3.Visible = false;
            DataGridViewColumn kolon4 = dataGridView1.Columns[7];
            kolon4.Visible = false;
            DataGridViewColumn kolon5 = dataGridView1.Columns[8];
            kolon5.Visible = false;
            DataGridViewColumn kolon6 = dataGridView1.Columns[9];
            kolon6.Visible = false;
            DataGridViewColumn kolon7 = dataGridView1.Columns[10];
            kolon7.Visible = false;
            DataGridViewColumn kolon8 = dataGridView1.Columns[11];
            kolon8.Visible = false;
            DataGridViewColumn kolon9 = dataGridView1.Columns[12];
            kolon9.Visible = false;
            DataGridViewColumn kolon10 = dataGridView1.Columns[13];
            kolon10.Visible = false;
            DataGridViewColumn kolon11 = dataGridView1.Columns[14];
            kolon11.Visible = false;
            DataGridViewColumn kolon12 = dataGridView1.Columns[15];
            kolon12.Visible = false;

            Kadro[0] = button0;
            Kadro[1] = button1;
            Kadro[2] = button2;
            Kadro[3] = button3;
            Kadro[4] = button4;
            Kadro[5] = button5;
            Kadro[6] = button6;
            Kadro[7] = button7;
            Kadro[8] = button8;
            Kadro[9] = button9;
            Kadro[10] = button10;
            Kadro[11] = button11;
            Kadro[12] = button12;
            Kadro[13] = button13;
            Kadro[14] = button14;
            Kadro[15] = button15;
            Kadro[16] = button16;
            Kadro[17] = button17;
        }
        public void Bilgiler(DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Kaleci")
            {
                FormaResmi.ImageLocation = Application.StartupPath + @"\icon\K-Forma.png";
                FormaNo.ForeColor = Color.White;
                if (FormaNo.Text.Length > 1)
                {
                    FormaNo.Location = new Point(19, 24);
                }
                else
                {
                    FormaNo.Location = new Point(25, 24);
                }
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() != "Kaleci")
            {
                FormaResmi.ImageLocation = Application.StartupPath + @"\icon\F-Forma.png";
                FormaNo.ForeColor = Color.Black;
                if (FormaNo.Text.Length > 1)
                {
                    FormaNo.Location = new Point(19, 24);
                }
                else
                {
                    FormaNo.Location = new Point(25, 24);
                }
            }


            FutbolcuAd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            FutbolcuSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            FutbolcuMevki.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            FutbolcuYas.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            FormaNo.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            label1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            label2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            label3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            label4.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            OynananMac.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            Gol.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            Asist.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            Sari.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            Kirmizi.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
        }
        private void Taktik_Load(object sender, EventArgs e)
        {
            Oyuncular();
            FormaNo.Parent = FormaResmi;

            button0.Text = Properties.Kadro.Default.Oyuncu1;
            button1.Text = Properties.Kadro.Default.Oyuncu2;
            button2.Text = Properties.Kadro.Default.Oyuncu3;
            button3.Text = Properties.Kadro.Default.Oyuncu4;
            button4.Text = Properties.Kadro.Default.Oyuncu5;
            button5.Text = Properties.Kadro.Default.Oyuncu6;
            button6.Text = Properties.Kadro.Default.Oyuncu7;
            button7.Text = Properties.Kadro.Default.Oyuncu8;
            button8.Text = Properties.Kadro.Default.Oyuncu9;
            button9.Text = Properties.Kadro.Default.Oyuncu10;
            button10.Text = Properties.Kadro.Default.Oyuncu11;
            button11.Text = Properties.Kadro.Default.Oyuncu12;
            button12.Text = Properties.Kadro.Default.Oyuncu13;
            button13.Text = Properties.Kadro.Default.Oyuncu14;
            button14.Text = Properties.Kadro.Default.Oyuncu15;
            button15.Text = Properties.Kadro.Default.Oyuncu16;
            button16.Text = Properties.Kadro.Default.Oyuncu17;
            button17.Text = Properties.Kadro.Default.Oyuncu18;
        }
        public static int SourceRow;
        public static Button[] Kadro = new Button[18];

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            SourceRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            dataGridView1.DoDragDrop(SourceRow, DragDropEffects.Copy);
        }
        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                Bilgiler(e);
            }
        }
        private void Kapatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[12] = button12;
            Kadro[12].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button12_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button13_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[13] = button13;
            Kadro[13].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button13_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button14_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[14] = button14;
            Kadro[14].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button14_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button15_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[15] = button15;
            Kadro[15].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button15_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button16_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[16] = button16;
            Kadro[16].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button16_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button17_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[17] = button17;
            Kadro[17].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button17_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button11_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[11] = button11;
            Kadro[11].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button11_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button10_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[10] = button10;
            Kadro[10].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button10_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button9_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[9] = button9;
            Kadro[9].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button9_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button8_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[8] = button8;
            Kadro[8].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button8_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button7_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[7] = button7;
            Kadro[7].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button7_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button6_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[6] = button6;
            Kadro[6].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button6_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button5_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[5] = button5;
            Kadro[5].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button5_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button4_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[4] = button4;
            Kadro[4].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button4_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button3_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[3] = button3;
            Kadro[3].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button3_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button2_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[2] = button2;
            Kadro[2].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[1] = button1;
            Kadro[1].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }

        private void button1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void button0_DragDrop(object sender, DragEventArgs e)
        {
            Kadro[0] = button0;
            Kadro[0].Text = dataGridView1.Rows[SourceRow].Cells[0].Value.ToString() + " " + dataGridView1.Rows[SourceRow].Cells[1].Value.ToString();
        }
        private void button0_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {

        }
        private void button21_Click(object sender, EventArgs e)
        {
            Properties.Kadro.Default.Oyuncu1 = button0.Text;
            Properties.Kadro.Default.Oyuncu2 = button1.Text;
            Properties.Kadro.Default.Oyuncu3 = button2.Text;
            Properties.Kadro.Default.Oyuncu4 = button3.Text;
            Properties.Kadro.Default.Oyuncu5 = button4.Text;
            Properties.Kadro.Default.Oyuncu6 = button5.Text;
            Properties.Kadro.Default.Oyuncu7 = button6.Text;
            Properties.Kadro.Default.Oyuncu8 = button7.Text;
            Properties.Kadro.Default.Oyuncu9 = button8.Text;
            Properties.Kadro.Default.Oyuncu10 = button9.Text;
            Properties.Kadro.Default.Oyuncu11 = button10.Text;
            Properties.Kadro.Default.Oyuncu12 = button11.Text;
            Properties.Kadro.Default.Oyuncu13 = button12.Text;
            Properties.Kadro.Default.Oyuncu14 = button13.Text;
            Properties.Kadro.Default.Oyuncu15 = button14.Text;
            Properties.Kadro.Default.Oyuncu16 = button15.Text;
            Properties.Kadro.Default.Oyuncu17 = button16.Text;
            Properties.Kadro.Default.Oyuncu18 = button17.Text;

            int sayac = 0;
            for (int i = 0; i < 16; i++)
            {
                for (int x = 0; x < 16; x++)
                {
                    if (Kadro[i].Text == Kadro[x].Text)
                    {
                        sayac++;
                        if (sayac == 2)
                        {
                            if (Kadro[i].Text=="")
                            {
                                MessageBox.Show("Kadroda boş mevkiler var!","Boş mevki",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                goto Gel;
                            }
                            MessageBox.Show(Kadro[i].Text + " birden fazla mevkide seçilmiş. Bir oyuncu birden çok mevkide oynayamaz!", "Birden Fazla Mevkide Oynatma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Gel;
                        }
                    }
                }
                sayac = 0;
            }
            MessageBox.Show("Kayıt Başarılı", "Kadro", MessageBoxButtons.OK);
            Gel:;

        }

        private void Taktik_SizeChanged(object sender, EventArgs e)
        {
            //flowLayoutPanel1.MaximumSize = new Size(154, 305);

            panel2.Width = (int)((Size.Width) * 0.15);
            panel2.MinimumSize = new Size(800, 600);
            tableLayoutPanel2.Height = (int)((this.Size.Width) * 0.45);
            tableLayoutPanel2.Width = (int)((this.Size.Width) * 0.3);
            flowLayoutPanel1.Height = tableLayoutPanel2.Height;

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
        //bir mevkide tek oyuncu yapılacka ama bununla değil
    }

}
