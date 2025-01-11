using PropertyDemo;

var kisi = new Kisi();
kisi.SetDogumTarihi(new DateTime(1986, 11, 10));
kisi.SetAdSoyad("Salih Demiroğ");

Console.WriteLine("Ad Soyad:{0}", kisi.GetAdSoyad());
Console.WriteLine("Doğum Tarihi:{0}", kisi.GetDogumTarihi());
Console.WriteLine("Yaş:{0}", kisi.GetYas());


var sahis = new Sahis();
sahis.AdSoyad = "Zeynep Liya";
sahis.DogumTarihi = new DateTime(2018, 6, 29);
//sahis.Yas = 20;
//sahis.RandomSayi = 12;
//sahis.BabaAdi = "Bilal";

Console.WriteLine("-------");
Console.WriteLine("Ad Soyad:{0}", sahis.AdSoyad);
Console.WriteLine("Doğum Tarihi:{0}", sahis.DogumTarihi);
Console.WriteLine("Yaş:{0}", sahis.Yas);
Console.WriteLine("Adres:{0}", sahis.Adres);
Console.WriteLine("Ugurlu Sayi:{0}", sahis.RandomSayi);

var urun = new Urun
{
    Adi = "Bilgisayar",
    StokMiktari = 100,
    BirimFiyati = 34_000,
    Aciklama = "16 gb ram ...",
};

urun.Adi = "Laptop";
//urun.StokMiktari = 40;


var ogrenci = new Ogrenci
{
    AdiSoyadi = "Salih Demiroğ",
    Yas = 20,
    Okul = new Okul
    {
        Adi = "Gazi Üni",
        OgretimDurumu = "Lisans",
        Sehir = "Ankara"
    },
    Dersler = new List<Ders> {
        new Ders
        {
            Adi="Programalama",
            KrediPuani=3.0
        },
        new Ders
        {
            Adi="Tarih",
            KrediPuani=1.5
        },
        new Ders
        {
            Adi="İngilizce",
            KrediPuani=2.5
        }
    }
};
