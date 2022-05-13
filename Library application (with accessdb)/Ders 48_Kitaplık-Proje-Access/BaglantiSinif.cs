using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace Ders_48_Kitaplık_Proje_Access
{
    class BaglantiSinif
    {
        //OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\metin\Desktop\Mersin ÜNİ\C# Dersleri\Ders 48_Kitaplık-Proje-Access\Kitaplık.mdb");

        public string Adres = System.IO.File.ReadAllText(@"C:\Users\metin\Desktop\C# Program Ve Uygulamalarım\Ders 48_Kitaplık-Proje-Access\BaglantiAdres.txt");

        //public static string Adres = ConfigurationManager.ConnectionStrings["Kütüphane_Sistem_Uygulaması"].ConnectionString;
    }
}
