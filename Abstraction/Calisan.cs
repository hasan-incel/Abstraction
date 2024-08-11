using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstraction
{
    // Soyut temel sınıf
    public abstract class Calisan
    {
        // Ortak özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        // Soyut metot, her alt sınıf bu metodu kendi görevine göre uygulayacak
        public abstract void Gorev();
        public void Bilgiler()
        {
            Console.WriteLine("\nAdı: " + Ad);
            Console.WriteLine("Soyadı: " + Soyad);
            Console.WriteLine("Departman: " +Departman);
        }
    }

    // Yazılım Geliştirici sınıfı
    public class YazilimGelistirici : Calisan
    {
        public override void Gorev()
        {
            Bilgiler();
            Console.WriteLine("Yazılım Geliştirici olarak çalışıyorum.");
        }
    }

    // Proje Yöneticisi sınıfı
    public class ProjeYoneticisi : Calisan
    {
        public override void Gorev()
        {
            Bilgiler();
            Console.WriteLine("Proje Yöneticisi olarak çalışıyorum.");
        }
    }

    // Satış Temsilcisi sınıfı
    public class SatisTemsilcisi : Calisan
    {
        public override void Gorev()
        {
            Bilgiler();
            Console.WriteLine("Satış Temsilcisi olarak çalışıyorum.");
        }
    }

}
