using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football
{

    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public void FormBaslat()
        {
            Application.Run(new LoadingEkrani());
        }
        public void YukleVeCagir()
        {
            Thread t = new Thread(new ThreadStart(FormBaslat));
            t.Start();
            Thread.Sleep(1500);
            t.Abort();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Kadro.Default.Oyuncu1 = "";
            Properties.Kadro.Default.Oyuncu2 = "";
            Properties.Kadro.Default.Oyuncu3 = "";
            Properties.Kadro.Default.Oyuncu4 = "";
            Properties.Kadro.Default.Oyuncu5 = "";
            Properties.Kadro.Default.Oyuncu6 = "";
            Properties.Kadro.Default.Oyuncu7 = "";
            Properties.Kadro.Default.Oyuncu8 = "";
            Properties.Kadro.Default.Oyuncu9 = "";
            Properties.Kadro.Default.Oyuncu10 = "";
            Properties.Kadro.Default.Oyuncu11 = "";
            Properties.Kadro.Default.Oyuncu12 = "";
            Properties.Kadro.Default.Oyuncu13 = "";
            Properties.Kadro.Default.Oyuncu14 = "";
            Properties.Kadro.Default.Oyuncu15 = "";
            Properties.Kadro.Default.Oyuncu16 = "";
            Properties.Kadro.Default.Oyuncu17 = "";
            Properties.Kadro.Default.Oyuncu18 = "";
            Properties.Kadro.Default.Save();
            Application.Exit();
        }

        public Deneme dene = new Deneme();
        public static string rakip;
        public void Rakip()
        {
            dene.Show();

            if (label1.Text == TakimListesi.takimdizisi[1].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[2].ToString();
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[2].ToString();
                rakip = TakimListesi.takimdizisi[2].ToString();

            }
            if (label1.Text == TakimListesi.takimdizisi[2].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[1].ToString() + " (D)";
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[1].ToString();
                rakip = TakimListesi.takimdizisi[1].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[3].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[4].ToString();
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[4].ToString();
                rakip = TakimListesi.takimdizisi[4].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[4].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[3].ToString() + " (D)";
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[3].ToString();
                rakip = TakimListesi.takimdizisi[3].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[5].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[6].ToString();
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[6].ToString();
                rakip = TakimListesi.takimdizisi[6].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[6].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[5].ToString() + " (D)";
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[5].ToString();
                rakip = TakimListesi.takimdizisi[5].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[7].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[8].ToString();
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[8].ToString();
                rakip = TakimListesi.takimdizisi[8].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[8].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[7].ToString() + " (D)";
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[7].ToString();
                rakip = TakimListesi.takimdizisi[7].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[9].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[10].ToString();
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[10].ToString();
                rakip = TakimListesi.takimdizisi[10].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[10].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[9].ToString() + " (D)";
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[9].ToString();
                rakip = TakimListesi.takimdizisi[9].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[11].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[12].ToString();
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[12].ToString();
                rakip = TakimListesi.takimdizisi[12].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[12].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[11].ToString() + " (D)";
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[11].ToString();
                rakip = TakimListesi.takimdizisi[11].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[13].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[14].ToString();
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[14].ToString();
                rakip = TakimListesi.takimdizisi[14].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[14].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[13].ToString() + " (D)";
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[13].ToString();
                rakip = TakimListesi.takimdizisi[13].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[15].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[16].ToString();
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[16].ToString();
                rakip = TakimListesi.takimdizisi[16].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[16].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[15].ToString() + " (D)";
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[15].ToString();
                rakip = TakimListesi.takimdizisi[15].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[17].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[18].ToString();
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[18].ToString();
                rakip = TakimListesi.takimdizisi[18].ToString();
            }
            if (label1.Text == TakimListesi.takimdizisi[18].ToString())
            {
                gelecekmacbtn.Text = "Rakip:\n" + TakimListesi.takimdizisi[17].ToString() + " (D)";
                rakiplogo.ImageLocation = TakimListesi.takimlogolari[17].ToString();
                rakip = TakimListesi.takimdizisi[17].ToString();
            }
            dene.Close();
        }

        public void MacaGit()
        {
            ilkonbir[0] = fw2.Text;
            ilkonbir[1] = fw1.Text;
            ilkonbir[2] = os4.Text;
            ilkonbir[3] = os3.Text;
            ilkonbir[4] = os2.Text;
            ilkonbir[5] = os1.Text;
            ilkonbir[6] = def4.Text;
            ilkonbir[7] = def3.Text;
            ilkonbir[8] = def2.Text;
            ilkonbir[9] = def1.Text;
            ilkonbir[10] = gk.Text;

            MacEkrani macEkrani = new MacEkrani();
            if (fw1.Visible == false || fw2.Visible == false || os1.Visible == false || os2.Visible == false || os3.Visible == false || os4.Visible == false || def1.Visible == false || def2.Visible == false || def3.Visible == false || def4.Visible == false || gk.Visible == false)
            {
                MessageBox.Show("Lütfen kadronuzu kontrol ediniz. Kadronuzda eksikler var!");
            }
            else
            {


                int sayac = 0;
                for (int i = 0; i < 11; i++)
                {
                    for (int x = 0; x < 11; x++)
                    {
                        if (ilkonbir[i] == ilkonbir[x])
                        {
                            sayac++;
                            if (sayac == 2)
                            {
                                MessageBox.Show(ilkonbir[i] + " birden fazla mevkide seçilmiş. Bir oyuncu birden çok mevkide oynayamaz!", "Birden Fazla Mevkide Oynatma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto Gel;
                            }
                        }
                    }
                    sayac = 0;
                }



                if (bir.ImageLocation == uyari || iki.ImageLocation == uyari || uc.ImageLocation == uyari || dort.ImageLocation == uyari || bes.ImageLocation == uyari || alti.ImageLocation == uyari || yedi.ImageLocation == uyari || sekiz.ImageLocation == uyari || dokuz.ImageLocation == uyari || on.ImageLocation == uyari || onbir.ImageLocation == uyari)
                {
                    for (int i = 0; i <= 9; i++)
                    {
                        songenelrate += topyetenek[i];
                    }
                    if (MessageBox.Show("Kadroda mevkisi dışında oynayan oyuncular tespit edildi.\nYine de maça başlamak istiyor musunuz?\n(Mevkisi dışında oynayan oyuncuların performansı takımı olumsuz etkiler)", "Maça Git", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Hide();
                        YukleVeCagir();
                        macEkrani.Show();
                    }
                }
                else
                {
                    for (int i = 0; i <= 9; i++)
                    {
                        songenelrate += topyetenek[i];
                    }
                    Hide();
                    YukleVeCagir();
                    macEkrani.Show();
                }
                Gel:
                ;
            }
        }
        public void Anasayfa_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;

            onbir.AllowDrop = true;
            on.AllowDrop = true;
            dokuz.AllowDrop = true;
            sekiz.AllowDrop = true;
            yedi.AllowDrop = true;
            alti.AllowDrop = true;
            bes.AllowDrop = true;
            dort.AllowDrop = true;
            uc.AllowDrop = true;
            iki.AllowDrop = true;
            bir.AllowDrop = true;

            tabControl1.Controls.Remove(tabPage2);
            pictureBox1.ImageLocation = GirisEkrani.logo;
            pictureBox5.ImageLocation = GirisEkrani.logo;
            label1.Text = GirisEkrani.TakimAdi;
            label11.Text = GirisEkrani.TakimAdi;
            label2.Text = GirisEkrani.Kurulus;
            label4.Text = GirisEkrani.Butce;
            label6.Text = GirisEkrani.TeknikDirektor + "\n" + GirisEkrani.Yas + " Yaşında";
            label8.Text = GirisEkrani.Stadyum;
            label15.Text = GirisEkrani.Defans;
            label16.Text = GirisEkrani.Ortasaha;
            label17.Text = GirisEkrani.Forvet;


            SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\database\Football.mdf; Integrated Security=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select f.Ad,f.Soyad,f.Yas,f.Mevki,y.Kalecilik,y.Defans as Savunma,y.Ortasaha,y.Forvet as Hücum,fd.FormaNo,fd.Mac,fd.Gol,fd.Asist,fd.Sari,fd.Kirmizi,fd.Maas,fd.Fiyat from Takimlar t inner join Futbolcu f on t.TakimId=f.TakimId inner join Yetenekler y on f.FutbolcuId=y.FutbolcuId inner join FDetaylari fd on f.FutbolcuId=fd.FutbolcuId where t.TakimAdi='" + GirisEkrani.TakimAdi + "'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

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

            comboBox1.SelectedIndex = 0;
            void dizilim()
            {
                bir.Parent = pictureBox12;
                iki.Parent = pictureBox12;
                uc.Parent = pictureBox12;
                dort.Parent = pictureBox12;
                bes.Parent = pictureBox12;
                alti.Parent = pictureBox12;
                yedi.Parent = pictureBox12;
                sekiz.Parent = pictureBox12;
                dokuz.Parent = pictureBox12;
                on.Parent = pictureBox12;
                onbir.Parent = pictureBox12;
                bir.BackColor = Color.Transparent;
                iki.BackColor = Color.Transparent;
                uc.BackColor = Color.Transparent;
                dort.BackColor = Color.Transparent;
                bes.BackColor = Color.Transparent;
                alti.BackColor = Color.Transparent;
                yedi.BackColor = Color.Transparent;
                sekiz.BackColor = Color.Transparent;
                dokuz.BackColor = Color.Transparent;
                on.BackColor = Color.Transparent;
                onbir.BackColor = Color.Transparent;
            }
            dizilim();
            this.AllowDrop = true;
            Rakip();
            rakiptakim = gelecekmacbtn.Text;
            evlogo = pictureBox1.ImageLocation.ToString();
            deplogo = rakiplogo.ImageLocation.ToString();
            DeplasmanMı = gelecekmacbtn.Text;
        }

        public static string kaleci = "Kaleci";
        public static string defans = "Defans";
        public static string ortasaha = "Orta Saha";
        public static string forvet = "Forvet";

        public static string secilitakim = GirisEkrani.TakimAdi;
        public static string rakiptakim;
        public static string DeplasmanMı;

        public static string evlogo;
        public static string deplogo;

        public static string secili = Application.StartupPath + @"\icon\secili-forma.png";
        public static string secilebilir = Application.StartupPath + @"\icon\secilebilir-forma.png";
        public static string uyari = Application.StartupPath + @"\icon\uyari-forma.gif";

        void futbolcubilgileri()
        {
            if (tabControl1.TabCount == 1)
            {
                tabControl1.Controls.Add(tabPage2);
            }

            label21.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label22.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label23.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label25.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label28.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            label31.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            label29.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            label33.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label43.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            label40.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            label38.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            label39.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            label37.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            label42.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();

            label46.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString() + " €";
            label47.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString() + " €";

            if (label43.Text.Length > 1)
            {
                label43.Location = new Point(40, 68);
            }
            else
            {
                label43.Location = new Point(47, 68);
            }


            ////////////////////////////////////////////////////savunma
            if (Convert.ToInt32(label28.Text) >= 60)
            {
                label28.ForeColor = Color.Green;
            }
            else if (Convert.ToInt32(label28.Text) >= 40 && Convert.ToInt32(label28.Text) <= 59)
            {
                label28.ForeColor = Color.DarkOrange;
            }
            else
            {
                label28.ForeColor = Color.Maroon;
            }
            ////////////////////////////////////////////////////ortasaha
            if (Convert.ToInt32(label31.Text) >= 60)
            {
                label31.ForeColor = Color.Green;
            }
            else if (Convert.ToInt32(label31.Text) >= 40 && Convert.ToInt32(label31.Text) <= 59)
            {
                label31.ForeColor = Color.DarkOrange;
            }
            else
            {
                label31.ForeColor = Color.Maroon;
            }
            /////////////////////////////////////////////////forvet
            if (Convert.ToInt32(label29.Text) >= 60)
            {
                label29.ForeColor = Color.Green;
            }
            else if (Convert.ToInt32(label29.Text) >= 40 && Convert.ToInt32(label29.Text) <= 59)
            {
                label29.ForeColor = Color.DarkOrange;
            }
            else
            {
                label29.ForeColor = Color.Maroon;
            }


            if (label23.Text == "Kaleci")
            {
                pictureBox9.Image = null;
                pictureBox9.ImageLocation = Application.StartupPath + @"\icon\K-Forma.png";
            }
            else
            {
                pictureBox9.Image = null;
                pictureBox9.ImageLocation = Application.StartupPath + @"\icon\F-Forma.png";
            }


            int genelrate = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value) + Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value) + Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value) + Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);
            songenelrate = genelrate;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            futbolcubilgileri();
            tabControl1.SelectedTab = tabPage2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                alti.Location = new Point(66, 264);
                yedi.Location = new Point(147, 284);
                sekiz.Location = new Point(228, 284);
                dokuz.Location = new Point(308, 264);
                on.Location = new Point(228, 90);
                onbir.Location = new Point(147, 90);
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                alti.Location = new Point(66, 173);
                yedi.Location = new Point(147, 310);
                sekiz.Location = new Point(228, 310);
                dokuz.Location = new Point(308, 173);
                on.Location = new Point(187, 190);
                onbir.Location = new Point(187, 84);
            }
            fw2.Location = new Point(onbir.Location.X, onbir.Location.Y + 60);
            fw1.Location = new Point(on.Location.X, on.Location.Y + 60);

            os1.Location = new Point(dokuz.Location.X, dokuz.Location.Y + 60);
            os2.Location = new Point(sekiz.Location.X, sekiz.Location.Y + 60);
            os3.Location = new Point(yedi.Location.X, yedi.Location.Y + 60);
            os4.Location = new Point(alti.Location.X, alti.Location.Y + 60);

            def1.Location = new Point(bes.Location.X, bes.Location.Y + 60);
            def2.Location = new Point(dort.Location.X, dort.Location.Y + 60);
            def3.Location = new Point(uc.Location.X, uc.Location.Y + 60);
            def4.Location = new Point(iki.Location.X, iki.Location.Y + 60);

            gk.Location = new Point(bir.Location.X, bir.Location.Y + 55);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            int SourceRow;
            SourceRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            dataGridView1.DoDragDrop(SourceRow, DragDropEffects.Copy);
        }

        public string[] ilkonbir = new string[12];
        public int onbirrate;
        public static int songenelrate;
        public int[] topyetenek = new int[11];

        public void onbir_DragDrop(object sender, DragEventArgs e)
        {
            fw2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[0] = songenelrate;


            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Forvet")
            {
                onbir.ImageLocation = uyari;
            }
            else
            {
                onbir.ImageLocation = secilebilir;
            }
            fw2.Visible = true;
        }
        private void onbir_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void on_DragDrop(object sender, DragEventArgs e)
        {
            fw1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[1] = songenelrate;

            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Forvet")
            {
                on.ImageLocation = uyari;
            }
            else
            {
                on.ImageLocation = secilebilir;
            }
            fw1.Visible = true;
        }
        private void on_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dokuz_DragDrop(object sender, DragEventArgs e)
        {
            os1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[2] = songenelrate;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Orta Saha")
            {
                dokuz.ImageLocation = uyari;
            }
            else
            {
                dokuz.ImageLocation = secilebilir;
            }
            os1.Visible = true;
        }

        private void dokuz_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void sekiz_DragDrop(object sender, DragEventArgs e)
        {
            os2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[3] = songenelrate;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Orta Saha")
            {
                sekiz.ImageLocation = uyari;
            }
            else
            {
                sekiz.ImageLocation = secilebilir;
            }
            os2.Visible = true;
        }

        private void sekiz_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void yedi_DragDrop(object sender, DragEventArgs e)
        {
            os3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[4] = songenelrate;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Orta Saha")
            {
                yedi.ImageLocation = uyari;
            }
            else
            {
                yedi.ImageLocation = secilebilir;
            }
            os3.Visible = true;
        }

        private void yedi_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void alti_DragDrop(object sender, DragEventArgs e)
        {
            os4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[5] = songenelrate;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Orta Saha")
            {
                alti.ImageLocation = uyari;
            }
            else
            {
                alti.ImageLocation = secilebilir;
            }
            os4.Visible = true;
        }

        private void alti_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void bes_DragDrop(object sender, DragEventArgs e)
        {
            def1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[6] = songenelrate;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Defans")
            {
                bes.ImageLocation = uyari;
            }
            else
            {
                bes.ImageLocation = secilebilir;
            }
            def1.Visible = true;
        }

        private void bes_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dort_DragDrop(object sender, DragEventArgs e)
        {
            def2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[7] = songenelrate;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Defans")
            {
                dort.ImageLocation = uyari;
            }
            else
            {
                dort.ImageLocation = secilebilir;
            }
            def2.Visible = true;
        }

        private void dort_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void uc_DragDrop(object sender, DragEventArgs e)
        {
            def3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[8] = songenelrate;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Defans")
            {
                uc.ImageLocation = uyari;
            }
            else
            {
                uc.ImageLocation = secilebilir;
            }
            def3.Visible = true;
        }

        private void uc_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void iki_DragDrop(object sender, DragEventArgs e)
        {
            def4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[9] = songenelrate;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Defans")
            {
                iki.ImageLocation = uyari;
            }
            else
            {
                iki.ImageLocation = secilebilir;
            }
            def4.Visible = true;
        }

        private void iki_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void bir_DragDrop(object sender, DragEventArgs e)
        {
            gk.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            topyetenek[10] = songenelrate;
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "Kaleci")
            {
                bir.ImageLocation = uyari;
            }
            else
            {
                bir.ImageLocation = secilebilir;
            }
            gk.Visible = true;
        }

        private void bir_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void gelecekmacbtn_Click(object sender, EventArgs e)
        {
            MacaGit();
        }

        private void rakiplogo_Click(object sender, EventArgs e)
        {
            MacaGit();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MacaGit();
        }

        private void gelecekmacbtn_Click_1(object sender, EventArgs e)
        {
            MacaGit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PuanDurumu puanDurumu = new PuanDurumu();
            puanDurumu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Taktik taktik = new Taktik();
            taktik.Show();
        }
    }

}
