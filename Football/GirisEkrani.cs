using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Football
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void combodoldur()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\database\Football.mdf; Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from Takimlar", baglanti);

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["TakimAdi"]);
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            combodoldur();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string logo;
        public static string TakimAdi;
        public static string Kurulus;
        public static string Stadyum;
        public static string Butce;
        public static string TeknikDirektor;

        public static string Yas;
        public static string Defans;
        public static string Ortasaha;
        public static string Forvet;
        public static string Aciklama;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\database\Football.mdf; Integrated Security=True");
            baglanti.Open();
            string takim = comboBox1.SelectedItem.ToString();

            string SqlSorguMetni = "Select * from Takimlar where TakimAdi='" + takim + "'";

            SqlCommand sqlKomudum = new SqlCommand(SqlSorguMetni, baglanti);
            SqlDataReader Okuyucum = sqlKomudum.ExecuteReader();



            while (Okuyucum.Read())
            {
                label6.Text = Okuyucum.GetString(2);
                int kurulus = Okuyucum.GetInt32(3);
                label7.Text = kurulus.ToString();
                pictureBox1.ImageLocation = Application.StartupPath.ToString()+Okuyucum.GetString(1);
                label8.Text = Okuyucum.GetString(4);
                int butce = Okuyucum.GetInt32(5);
                label11.Text = butce.ToString() + " €";
                panel1.Visible = true;
            }

            logo = pictureBox1.ImageLocation;
            TakimAdi = label6.Text;
            Kurulus = label7.Text;
            Butce = label11.Text;
            TeknikDirektor = textBox1.Text + " " + textBox2.Text;
            Stadyum = label8.Text;
            Yas = textBox3.Text;

            Okuyucum.Close();
            baglanti.Close();

            baglanti.Open();

            string sorgu = "select t.TakimAdi,sum(y.Kalecilik+y.Defans)/COUNT(f.TakimId) as Savunma,sum(y.Ortasaha)/COUNT(f.TakimId) as [Orta Saha],sum(y.Forvet)/COUNT(f.TakimId) as Hucum,sum(y.Kalecilik+y.Defans+y.Ortasaha+y.Forvet)/COUNT(f.TakimId) as [Genel Rate] from Futbolcu f inner join Yetenekler y on f.FutbolcuId=y.FutbolcuId inner join Takimlar t on f.TakimId=t.TakimId where t.TakimAdi='" + takim + "' group by t.TakimAdi";
            SqlCommand sorgukomut = new SqlCommand(sorgu, baglanti);
            SqlDataReader goster = sorgukomut.ExecuteReader();
            while (goster.Read())
            {
                int defans = goster.GetInt32(1);
                label14.Text = defans.ToString();

                int ortasaha = goster.GetInt32(2);
                label16.Text = ortasaha.ToString();

                int forvet = goster.GetInt32(3);
                label18.Text = forvet.ToString();
            }
            Defans = label14.Text;
            Ortasaha = label16.Text;
            Forvet = label18.Text;



            goster.Close();
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.ToString() == "-1" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Giriş Bilgilerinizi Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
        }

        private void takimBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
