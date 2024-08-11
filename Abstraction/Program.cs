
using Abstraction;

//Çalışan nesneleri
Calisan yazilimGelistirici = new YazilimGelistirici
{
    Ad = "Ali",
    Soyad = "Deli",
    Departman = "Yazılım"
};

Calisan projeYoneticisi = new ProjeYoneticisi
{
    Ad = "Hasan",
    Soyad = "Soysal",
    Departman = "Proje Yönetimi"
};

Calisan satisTemsilcisi = new SatisTemsilcisi
{
    Ad = "Ayşe",
    Soyad = "Yılmaz",
    Departman = "Satış"
};

// Görevleri yazdır
yazilimGelistirici.Gorev();
projeYoneticisi.Gorev();
satisTemsilcisi.Gorev();