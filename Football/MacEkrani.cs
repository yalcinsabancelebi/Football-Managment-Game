using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace Football
{
    public partial class MacEkrani : Form
    {
        public MacEkrani()
        {
            InitializeComponent();
        }
        public static int sayac;
        public static int takimevson;
        public static int takimdepson;
        public static int sondigerevson;
        public static int sondigerdepson;
        public static int min;
        public static int max;
        public static string[][] Diziler;

        public void SureSay()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            string duduk = Application.StartupPath + "\\Sesler\\Duduk.wav";
            soundPlayer.SoundLocation = duduk;
            label2.Text = sayac.ToString() + "'";
            if (sayac.ToString() == "46")
            {
                label2.Text = "Devre arası";
                label2.Location = new Point(606, 50);
                soundPlayer.Play();
            }
            else
            {
                label2.Location = new Point(664, 50);
            }

            if (sayac.ToString() == "90")
            {
                label2.Text = "Maç Bitti!";
                Dakika.Stop();
                soundPlayer.Play();
                label2.Location = new Point(624, 50);
                pictureBox1.Visible = false;
                EveDonBtn.Visible = true;
                MacSonuclari();
            }
            sayac++;
        }
        public static int RastgeleSayi(int alt, int ust)
        {
            Random r = new Random();
            if (alt > ust)
            {
                alt = ust;
                ust = alt;
            }
            return r.Next(alt, ust);
        }
        public static string sql;
        public static int[] Veriler = new int[19];
        public void DonenDeger()
        {
            int sonuc = Anasayfa.DeplasmanMı.LastIndexOf('(');
            if (sonuc > 0)
            {
                pictureBox2.ImageLocation = Anasayfa.deplogo;
                pictureBox3.ImageLocation = Anasayfa.evlogo;

                Depratelbl.Text = Convert.ToInt32(Anasayfa.songenelrate / 12).ToString();
                label6.Text = Anasayfa.secilitakim;
                label4.Text = Anasayfa.rakip;
                takimevson = Int32.Parse(Depratelbl.Text);
                takimdepson = Int32.Parse(Evratelbl.Text);
                MacMotoru.TakimRate(this, label4.Text);
                Evratelbl.Text = RakimKimlbl.Text;
            }
            else
            {
                pictureBox2.ImageLocation = Anasayfa.evlogo;
                pictureBox3.ImageLocation = Anasayfa.deplogo;

                Evratelbl.Text = Convert.ToInt32(Anasayfa.songenelrate / 12).ToString();
                label4.Text = Anasayfa.secilitakim;

                label6.Text = Anasayfa.rakip;

                takimevson = Int32.Parse(Evratelbl.Text);
                takimdepson = Int32.Parse(Depratelbl.Text);
                MacMotoru.TakimRate(this, label6.Text);
                Depratelbl.Text = RakimKimlbl.Text;
            }
        }
        public void OrtakKontrol()
        {
            if (takimevson > takimdepson)
            {
                min = takimdepson - 20;
                max = takimevson - 10;
            }
            else
            {
                max = takimdepson - 15;
                min = takimevson - 10;
            }
        }
        public void DigerMaclar()
        {
            textBox1.Text = TakimListesi.takimdizisi[1].ToString();
            textBox2.Text = TakimListesi.takimdizisi[2].ToString();
            textBox3.Text = TakimListesi.takimdizisi[3].ToString();
            textBox4.Text = TakimListesi.takimdizisi[4].ToString();
            textBox5.Text = TakimListesi.takimdizisi[5].ToString();
            textBox6.Text = TakimListesi.takimdizisi[6].ToString();
            textBox7.Text = TakimListesi.takimdizisi[7].ToString();
            textBox8.Text = TakimListesi.takimdizisi[8].ToString();
            textBox9.Text = TakimListesi.takimdizisi[9].ToString();
            textBox10.Text = TakimListesi.takimdizisi[10].ToString();
            textBox11.Text = TakimListesi.takimdizisi[11].ToString();
            textBox12.Text = TakimListesi.takimdizisi[12].ToString();
            textBox13.Text = TakimListesi.takimdizisi[13].ToString();
            textBox14.Text = TakimListesi.takimdizisi[14].ToString();
            textBox15.Text = TakimListesi.takimdizisi[15].ToString();
            textBox16.Text = TakimListesi.takimdizisi[16].ToString();
            textBox17.Text = TakimListesi.takimdizisi[17].ToString();
            textBox18.Text = TakimListesi.takimdizisi[18].ToString();

            logo1.ImageLocation = TakimListesi.takimlogolari[1].ToString();
            logo2.ImageLocation = TakimListesi.takimlogolari[2].ToString();
            logo3.ImageLocation = TakimListesi.takimlogolari[3].ToString();
            logo4.ImageLocation = TakimListesi.takimlogolari[4].ToString();
            logo5.ImageLocation = TakimListesi.takimlogolari[5].ToString();
            logo6.ImageLocation = TakimListesi.takimlogolari[6].ToString();
            logo7.ImageLocation = TakimListesi.takimlogolari[7].ToString();
            logo8.ImageLocation = TakimListesi.takimlogolari[8].ToString();
            logo9.ImageLocation = TakimListesi.takimlogolari[9].ToString();
            logo10.ImageLocation = TakimListesi.takimlogolari[10].ToString();
            logo11.ImageLocation = TakimListesi.takimlogolari[11].ToString();
            logo12.ImageLocation = TakimListesi.takimlogolari[12].ToString();
            logo13.ImageLocation = TakimListesi.takimlogolari[13].ToString();
            logo14.ImageLocation = TakimListesi.takimlogolari[14].ToString();
            logo15.ImageLocation = TakimListesi.takimlogolari[15].ToString();
            logo16.ImageLocation = TakimListesi.takimlogolari[16].ToString();
            logo17.ImageLocation = TakimListesi.takimlogolari[17].ToString();
            logo18.ImageLocation = TakimListesi.takimlogolari[18].ToString();


        }
        public void RakiplerMacYap1(int digerevson, int digerdepson)
        {
            if (min > max)
            {
                int min1 = min;
                int max1 = max;
                max = min1;
                min = max1;
            }
            if (digerevson > digerdepson)
            {
                int sonuclar = RastgeleSayi(min - 2, max + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(min - 15, digerevson + 15);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim1Gol.Text);
                    evgolsayisi++;
                    Takim1Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(min - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim2Gol.Text);
                    deplasmangolsayisi++;
                    Takim2Gol.Text = deplasmangolsayisi.ToString();
                }
            }
            else
            {
                int sonuclar = RastgeleSayi(max - 2, min + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(max - 20, digerdepson);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim1Gol.Text);
                    evgolsayisi++;
                    Takim1Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(max - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim2Gol.Text);
                    deplasmangolsayisi++;
                    Takim2Gol.Text = deplasmangolsayisi.ToString();
                }
            }
        }
        public void RakiplerMacYap2(int digerevson, int digerdepson)
        {
            if (digerevson > digerdepson)
            {
                int sonuclar = RastgeleSayi(min - 2, max + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(min - 15, digerevson + 15);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim3Gol.Text);
                    evgolsayisi++;
                    Takim3Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(min - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim4Gol.Text);
                    deplasmangolsayisi++;
                    Takim4Gol.Text = deplasmangolsayisi.ToString();
                }
            }
            else
            {
                int sonuclar = RastgeleSayi(max - 2, min + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(max - 20, digerdepson);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim3Gol.Text);
                    evgolsayisi++;
                    Takim3Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(max - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim4Gol.Text);
                    deplasmangolsayisi++;
                    Takim4Gol.Text = deplasmangolsayisi.ToString();
                }
            }
        }
        public void RakiplerMacYap3(int digerevson, int digerdepson)
        {
            if (digerevson > digerdepson)
            {
                int sonuclar = RastgeleSayi(min - 2, max + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(min - 15, digerevson + 15);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim5Gol.Text);
                    evgolsayisi++;
                    Takim5Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(min - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim6Gol.Text);
                    deplasmangolsayisi++;
                    Takim6Gol.Text = deplasmangolsayisi.ToString();
                }
            }
            else
            {
                int sonuclar = RastgeleSayi(max - 2, min + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(max - 20, digerdepson);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim5Gol.Text);
                    evgolsayisi++;
                    Takim5Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(max - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim6Gol.Text);
                    deplasmangolsayisi++;
                    Takim6Gol.Text = deplasmangolsayisi.ToString();
                }
            }
        }
        public void RakiplerMacYap4(int digerevson, int digerdepson)
        {
            if (digerevson > digerdepson)
            {
                int sonuclar = RastgeleSayi(min - 2, max + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(min - 15, digerevson + 15);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim7Gol.Text);
                    evgolsayisi++;
                    Takim7Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(min - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim8Gol.Text);
                    deplasmangolsayisi++;
                    Takim8Gol.Text = deplasmangolsayisi.ToString();
                }
            }
            else
            {
                int sonuclar = RastgeleSayi(max - 2, min + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(max - 20, digerdepson);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim7Gol.Text);
                    evgolsayisi++;
                    Takim7Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(max - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim8Gol.Text);
                    deplasmangolsayisi++;
                    Takim8Gol.Text = deplasmangolsayisi.ToString();
                }
            }
        }
        public void RakiplerMacYap5(int digerevson, int digerdepson)
        {
            if (digerevson > digerdepson)
            {
                int sonuclar = RastgeleSayi(min - 2, max + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(min - 15, digerevson + 15);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim9Gol.Text);
                    evgolsayisi++;
                    Takim9Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(min - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim10Gol.Text);
                    deplasmangolsayisi++;
                    Takim10Gol.Text = deplasmangolsayisi.ToString();
                }
            }
            else
            {
                int sonuclar = RastgeleSayi(max - 2, min + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(max - 20, digerdepson);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim9Gol.Text);
                    evgolsayisi++;
                    Takim9Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(max - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim10Gol.Text);
                    deplasmangolsayisi++;
                    Takim10Gol.Text = deplasmangolsayisi.ToString();
                }
            }
        }
        public void RakiplerMacYap6(int digerevson, int digerdepson)
        {
            if (digerevson > digerdepson)
            {
                int sonuclar = RastgeleSayi(min - 2, max + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(min - 15, digerevson + 15);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim11Gol.Text);
                    evgolsayisi++;
                    Takim11Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(min - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim12Gol.Text);
                    deplasmangolsayisi++;
                    Takim12Gol.Text = deplasmangolsayisi.ToString();
                }
            }
            else
            {
                int sonuclar = RastgeleSayi(max - 2, min + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(max - 20, digerdepson);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim11Gol.Text);
                    evgolsayisi++;
                    Takim11Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(max - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim12Gol.Text);
                    deplasmangolsayisi++;
                    Takim12Gol.Text = deplasmangolsayisi.ToString();
                }
            }
        }
        public void RakiplerMacYap7(int digerevson, int digerdepson)
        {
            if (digerevson > digerdepson)
            {
                int sonuclar = RastgeleSayi(min - 2, max + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(min - 15, digerevson + 15);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim13Gol.Text);
                    evgolsayisi++;
                    Takim13Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(min - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim14Gol.Text);
                    deplasmangolsayisi++;
                    Takim14Gol.Text = deplasmangolsayisi.ToString();
                }
            }
            else
            {
                int sonuclar = RastgeleSayi(max - 2, min + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(max - 20, digerdepson);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim13Gol.Text);
                    evgolsayisi++;
                    Takim13Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(max - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim14Gol.Text);
                    deplasmangolsayisi++;
                    Takim14Gol.Text = deplasmangolsayisi.ToString();
                }
            }
        }
        public void RakiplerMacYap8(int digerevson, int digerdepson)
        {
            if (digerevson > digerdepson)
            {
                int sonuclar = RastgeleSayi(min - 2, max + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(min - 15, digerevson + 15);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim15Gol.Text);
                    evgolsayisi++;
                    Takim15Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(min - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim16Gol.Text);
                    deplasmangolsayisi++;
                    Takim16Gol.Text = deplasmangolsayisi.ToString();
                }
            }
            else
            {
                int sonuclar = RastgeleSayi(max - 2, min + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(max - 20, digerdepson);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim15Gol.Text);
                    evgolsayisi++;
                    Takim15Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(max - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim16Gol.Text);
                    deplasmangolsayisi++;
                    Takim16Gol.Text = deplasmangolsayisi.ToString();
                }
            }
        }
        public void RakiplerMacYap9(int digerevson, int digerdepson)
        {
            if (digerevson > digerdepson)
            {
                int sonuclar = RastgeleSayi(min - 2, max + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(min - 15, digerevson + 15);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim17Gol.Text);
                    evgolsayisi++;
                    Takim17Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(min - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim18Gol.Text);
                    deplasmangolsayisi++;
                    Takim18Gol.Text = deplasmangolsayisi.ToString();
                }
            }
            else
            {
                int sonuclar = RastgeleSayi(max - 2, min + 2);
                Random cakisma1 = new Random();
                int sayi1 = cakisma1.Next(max - 20, digerdepson);
                if (sonuclar == sayi1)
                {
                    int evgolsayisi = Int32.Parse(Takim17Gol.Text);
                    evgolsayisi++;
                    Takim17Gol.Text = evgolsayisi.ToString();
                }

                Random cakisma2 = new Random();
                int sayi2 = cakisma2.Next(max - 20, digerdepson + 20);
                if (sonuclar == sayi2)
                {
                    int deplasmangolsayisi = Int32.Parse(Takim18Gol.Text);
                    deplasmangolsayisi++;
                    Takim18Gol.Text = deplasmangolsayisi.ToString();
                }
            }
        }
        public void Dakika_Tick(object sender, EventArgs e)
        {
            SureSay();
            DonenDeger();
            OrtakKontrol();

            RakiplerMacYap1(MacOynat.sonuclar[0], MacOynat.sonuclar[1]);
            RakiplerMacYap2(MacOynat.sonuclar[2], MacOynat.sonuclar[3]);
            RakiplerMacYap3(MacOynat.sonuclar[4], MacOynat.sonuclar[5]);
            RakiplerMacYap4(MacOynat.sonuclar[6], MacOynat.sonuclar[7]);
            RakiplerMacYap5(MacOynat.sonuclar[8], MacOynat.sonuclar[9]);
            RakiplerMacYap6(MacOynat.sonuclar[10], MacOynat.sonuclar[11]);
            RakiplerMacYap7(MacOynat.sonuclar[12], MacOynat.sonuclar[13]);
            RakiplerMacYap8(MacOynat.sonuclar[14], MacOynat.sonuclar[15]);
            RakiplerMacYap9(MacOynat.sonuclar[16], MacOynat.sonuclar[17]);

            TextBox[] textBoxes = {
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5,
                textBox6,
                textBox7,
                textBox8,
                textBox9,
                textBox10,
                textBox11,
                textBox12,
                textBox13,
                textBox14,
                textBox15,
                textBox16,
                textBox17,
                textBox18,
            };
            Label[] labels = {
                Takim1Gol,
                Takim2Gol,
                Takim3Gol,
                Takim4Gol,
                Takim5Gol,
                Takim6Gol,
                Takim7Gol,
                Takim8Gol,
                Takim9Gol,
                Takim10Gol,
                Takim11Gol,
                Takim12Gol,
                Takim13Gol,
                Takim14Gol,
                Takim15Gol,
                Takim16Gol,
                Takim17Gol,
                Takim18Gol,
            };
            for (int i = 0; i < 18; i++)
            {
                if (textBoxes[i].Text == label4.Text)
                {
                    Evgol.Text = labels[i].Text;
                    Deplasmangol.Text = labels[i + 1].Text;
                }
            }
        }
        public void MacEkrani_Load(object sender, EventArgs e)
        {
            Dakika.Enabled = true;
            Dakika.Start();
            DigerMaclar();
            MacOynat.macOynat(this);
        }

        public void Evgol_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            string path = Application.StartupPath + "\\Sesler\\GolSesi.wav";
            soundPlayer.SoundLocation = path;
            soundPlayer.Play();
        }
        private void Deplasmangol_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            string path = Application.StartupPath + "\\Sesler\\RakipGol.wav";
            soundPlayer.SoundLocation = path;
            soundPlayer.Play();
        }
        private void EveDonBtn_Click(object sender, EventArgs e)
        {
            sayac = 0;
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        public static Dictionary<string, int> Sonuclar = new Dictionary<string, int>();
        public static int takim1;
        public static int takim2;
        public void MacSonuclari()
        {
            if (Sonuclar.ContainsKey(textBox1.Text))
            {

            }
            else
            {
                Sonuclar.Add(textBox1.Text, 0);
                Sonuclar.Add(textBox2.Text, 0);
                Sonuclar.Add(textBox3.Text, 0);
                Sonuclar.Add(textBox4.Text, 0);
                Sonuclar.Add(textBox5.Text, 0);
                Sonuclar.Add(textBox6.Text, 0);
                Sonuclar.Add(textBox7.Text, 0);
                Sonuclar.Add(textBox8.Text, 0);
                Sonuclar.Add(textBox9.Text, 0);
                Sonuclar.Add(textBox10.Text, 0);
                Sonuclar.Add(textBox11.Text, 0);
                Sonuclar.Add(textBox12.Text, 0);
                Sonuclar.Add(textBox13.Text, 0);
                Sonuclar.Add(textBox14.Text, 0);
                Sonuclar.Add(textBox15.Text, 0);
                Sonuclar.Add(textBox16.Text, 0);
                Sonuclar.Add(textBox17.Text, 0);
                Sonuclar.Add(textBox18.Text, 0);
            }

            void Mac1()
            {
                if (Convert.ToInt32(Takim1Gol.Text) > Convert.ToInt32(Takim2Gol.Text))
                {
                    Sonuclar[textBox1.Text] += 3;
                    Sonuclar[textBox2.Text] += 0;
                }
                if (Convert.ToInt32(Takim1Gol.Text) < Convert.ToInt32(Takim2Gol.Text))
                {
                    Sonuclar[textBox1.Text] += 0;
                    Sonuclar[textBox2.Text] += 3;
                }
                if (Convert.ToInt32(Takim1Gol.Text) == Convert.ToInt32(Takim2Gol.Text))
                {
                    Sonuclar[textBox1.Text] += 1;
                    Sonuclar[textBox2.Text] += 1;
                }

            }
            void Mac2()
            {
                if (Convert.ToInt32(Takim3Gol.Text) > Convert.ToInt32(Takim4Gol.Text))
                {
                    Sonuclar[textBox3.Text] += 3;
                    Sonuclar[textBox4.Text] += 0;
                }
                if (Convert.ToInt32(Takim3Gol.Text) < Convert.ToInt32(Takim4Gol.Text))
                {
                    Sonuclar[textBox3.Text] += 0;
                    Sonuclar[textBox4.Text] += 3;
                }
                if (Convert.ToInt32(Takim3Gol.Text) == Convert.ToInt32(Takim4Gol.Text))
                {
                    Sonuclar[textBox3.Text] += 1;
                    Sonuclar[textBox4.Text] += 1;
                }
            }
            void Mac3()
            {
                if (Convert.ToInt32(Takim5Gol.Text) > Convert.ToInt32(Takim6Gol.Text))
                {
                    Sonuclar[textBox5.Text] += 3;
                    Sonuclar[textBox6.Text] += 0;
                }
                if (Convert.ToInt32(Takim5Gol.Text) < Convert.ToInt32(Takim6Gol.Text))
                {
                    Sonuclar[textBox5.Text] += 0;
                    Sonuclar[textBox6.Text] += 3;
                }
                if (Convert.ToInt32(Takim5Gol.Text) == Convert.ToInt32(Takim6Gol.Text))
                {
                    Sonuclar[textBox5.Text] += 1;
                    Sonuclar[textBox6.Text] += 1;
                }
            }
            void Mac4()
            {
                if (Convert.ToInt32(Takim7Gol.Text) > Convert.ToInt32(Takim8Gol.Text))
                {
                    Sonuclar[textBox7.Text] += 3;
                    Sonuclar[textBox8.Text] += 0;
                }
                if (Convert.ToInt32(Takim7Gol.Text) < Convert.ToInt32(Takim8Gol.Text))
                {
                    Sonuclar[textBox7.Text] += 0;
                    Sonuclar[textBox8.Text] += 3;
                }
                if (Convert.ToInt32(Takim7Gol.Text) == Convert.ToInt32(Takim8Gol.Text))
                {
                    Sonuclar[textBox7.Text] += 1;
                    Sonuclar[textBox8.Text] += 1;
                }
            }
            void Mac5()
            {
                if (Convert.ToInt32(Takim9Gol.Text) > Convert.ToInt32(Takim10Gol.Text))
                {
                    Sonuclar[textBox9.Text] += 3;
                    Sonuclar[textBox10.Text] += 0;
                }
                if (Convert.ToInt32(Takim9Gol.Text) < Convert.ToInt32(Takim10Gol.Text))
                {
                    Sonuclar[textBox9.Text] += 0;
                    Sonuclar[textBox10.Text] += 3;
                }
                if (Convert.ToInt32(Takim9Gol.Text) == Convert.ToInt32(Takim10Gol.Text))
                {
                    Sonuclar[textBox9.Text] += 1;
                    Sonuclar[textBox10.Text] += 1;
                }
            }
            void Mac6()
            {
                if (Convert.ToInt32(Takim11Gol.Text) > Convert.ToInt32(Takim12Gol.Text))
                {
                    Sonuclar[textBox11.Text] += 3;
                    Sonuclar[textBox12.Text] += 0;
                }
                if (Convert.ToInt32(Takim11Gol.Text) < Convert.ToInt32(Takim12Gol.Text))
                {
                    Sonuclar[textBox11.Text] += 0;
                    Sonuclar[textBox12.Text] += 3;
                }
                if (Convert.ToInt32(Takim11Gol.Text) == Convert.ToInt32(Takim12Gol.Text))
                {
                    Sonuclar[textBox11.Text] += 1;
                    Sonuclar[textBox12.Text] += 1;
                }
            }
            void Mac7()
            {
                if (Convert.ToInt32(Takim13Gol.Text) > Convert.ToInt32(Takim14Gol.Text))
                {
                    Sonuclar[textBox13.Text] += 3;
                    Sonuclar[textBox14.Text] += 0;
                }
                if (Convert.ToInt32(Takim13Gol.Text) < Convert.ToInt32(Takim14Gol.Text))
                {
                    Sonuclar[textBox13.Text] += 0;
                    Sonuclar[textBox14.Text] += 3;
                }
                if (Convert.ToInt32(Takim13Gol.Text) == Convert.ToInt32(Takim14Gol.Text))
                {
                    Sonuclar[textBox13.Text] += 1;
                    Sonuclar[textBox14.Text] += 1;
                }
            }
            void Mac8()
            {
                if (Convert.ToInt32(Takim15Gol.Text) > Convert.ToInt32(Takim16Gol.Text))
                {
                    Sonuclar[textBox15.Text] += 3;
                    Sonuclar[textBox16.Text] += 0;
                }
                if (Convert.ToInt32(Takim15Gol.Text) < Convert.ToInt32(Takim16Gol.Text))
                {
                    Sonuclar[textBox15.Text] += 0;
                    Sonuclar[textBox16.Text] += 3;
                }
                if (Convert.ToInt32(Takim15Gol.Text) == Convert.ToInt32(Takim16Gol.Text))
                {
                    Sonuclar[textBox15.Text] += 1;
                    Sonuclar[textBox16.Text] += 1;
                }
            }
            void Mac9()
            {
                if (Convert.ToInt32(Takim17Gol.Text) > Convert.ToInt32(Takim18Gol.Text))
                {
                    Sonuclar[textBox17.Text] += 3;
                    Sonuclar[textBox18.Text] += 0;
                }
                if (Convert.ToInt32(Takim17Gol.Text) < Convert.ToInt32(Takim18Gol.Text))
                {
                    Sonuclar[textBox17.Text] += 0;
                    Sonuclar[textBox18.Text] += 3;
                }
                if (Convert.ToInt32(Takim17Gol.Text) == Convert.ToInt32(Takim18Gol.Text))
                {
                    Sonuclar[textBox17.Text] += 1;
                    Sonuclar[textBox18.Text] += 1;
                }
            }
            Mac1();
            Mac2();
            Mac3();
            Mac4();
            Mac5();
            Mac6();
            Mac7();
            Mac8();
            Mac9();
        }
    }
}
