using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Football
{
    public class MacMotoru
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\database\Football.mdf; Integrated Security=True");
        public static void TakimRate(MacEkrani macEkrani, string rakiptakimad)
        {
            baglanti.Open();
            string rakipratekomut = "select t.TakimAdi, sum(y.Kalecilik + y.Defans) / COUNT(f.TakimId) as Savunma, sum(y.Ortasaha) / COUNT(f.TakimId) as [Orta Saha], sum(y.Forvet) / COUNT(f.TakimId) as Hucum, sum(y.Kalecilik + y.Defans + y.Ortasaha + y.Forvet) / COUNT(f.TakimId) as [Genel Rate] from Futbolcu f inner join Yetenekler y on f.FutbolcuId = y.FutbolcuId inner join Takimlar t on f.TakimId = t.TakimId where t.TakimAdi = '" + rakiptakimad + "' group by t.TakimAdi";
            SqlCommand depkomut = new SqlCommand(rakipratekomut, baglanti);
            SqlDataReader okuyucu = depkomut.ExecuteReader();
            while (okuyucu.Read())
            {
                int sonuc = okuyucu.GetInt32(4);
                macEkrani.RakimKimlbl.Text = sonuc.ToString();
            }
            baglanti.Close();
        }
    }
    public static class MacOynat
    {
        public static int[] sonuclar = new int[18];
        public static void macOynat(MacEkrani macEkrani)
        {
            string[] takimListesi = {
                macEkrani.textBox1.Text,
                macEkrani.textBox2.Text,
                macEkrani.textBox3.Text,
                macEkrani.textBox4.Text,
                macEkrani.textBox5.Text,
                macEkrani.textBox6.Text,
                macEkrani.textBox7.Text,
                macEkrani.textBox8.Text,
                macEkrani.textBox9.Text,
                macEkrani.textBox10.Text,
                macEkrani.textBox11.Text,
                macEkrani.textBox12.Text,
                macEkrani.textBox13.Text,
                macEkrani.textBox14.Text,
                macEkrani.textBox15.Text,
                macEkrani.textBox16.Text,
                macEkrani.textBox17.Text,
                macEkrani.textBox18.Text,
            };

            MacMotoru.baglanti.Open();
            for (int i = 0; i < 18; i++)
            {
                string takimiHesapla = "select t.TakimAdi, sum(y.Kalecilik + y.Defans + y.Ortasaha + y.Forvet) / COUNT(f.TakimId) as [Genel Rate] from Futbolcu f inner join Yetenekler y on f.FutbolcuId = y.FutbolcuId inner join Takimlar t on f.TakimId = t.TakimId where t.TakimAdi = '" + takimListesi[i] + "' group by t.TakimAdi";
                SqlCommand komut = new SqlCommand(takimiHesapla, MacMotoru.baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    int sonuc = oku.GetInt32(1);
                    sonuclar[i] = sonuc;
                }
                oku.Close();
            }
            for (int i = 0; i <= 17; i++)
            {
                MacEkrani.Veriler[i] = sonuclar[i];
            }
            MacMotoru.baglanti.Close();
        }
    }
}
