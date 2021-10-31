using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 9; i++)
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Football;Integrated Security=True");
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select TakimAdi from Takimlar order by NEWID()", baglanti);
                SqlDataReader oku;
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Console.WriteLine(oku.GetString(0));                    
                }
                Console.WriteLine("----------------------------");
                baglanti.Close();
            }
           
            

            



            Console.ReadLine();


        }
    }
}
