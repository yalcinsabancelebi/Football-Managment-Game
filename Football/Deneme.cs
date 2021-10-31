using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace Football
{
    public partial class Deneme : Form
    {
        public Deneme()
        {
            InitializeComponent();

        }

        public static string sql;

        public void Fixtur()
        {
            int[] sayilar = new int[19];
            Random r = new Random();
            int a = 1;

            while (a <= 18)
            {
                int sayi = r.Next(1, 19);
                if (sayilar.Contains(sayi))
                    continue;
                sayilar[a] = sayi;

                SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\database\Football.mdf; Integrated Security=True");
                baglanti.Open();

                sql = "select * from Takimlar t where t.TakimId='" + sayi + "'";

                SqlCommand komut = new SqlCommand(sql, baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ((TextBox)this.Controls["textBox" + (a).ToString()]).Text = oku.GetString(2);
                    ((PictureBox)this.Controls["pictureBox" + (a).ToString()]).ImageLocation = oku.GetString(1);
                    TakimListesi.takimdizisi[a]= oku.GetString(2);
                    TakimListesi.takimlogolari[a]= Application.StartupPath+oku.GetString(1);
                }
                a++;
                baglanti.Close();

            }
        }

        public void Deneme_Load(object sender, EventArgs e)
        {
            Fixtur();
        }
    }
    public static class TakimListesi
    {
        public static string[] takimdizisi = new string[19];
        public static string[] takimlogolari = new string[19];
    }
}
