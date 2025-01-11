var ogrenci = new
{
    AdSoyad = "Salih Demiroğ",
    Yas = 20,
    Cinsiyet = 'E'
};

Console.WriteLine(ogrenci.GetType().FullName);

Console.WriteLine(ogrenci.AdSoyad);
Console.WriteLine(ogrenci.Yas);
Console.WriteLine(ogrenci.Cinsiyet);

var ogretmen = new
{
    AdiSoyadi = "Salih Demiroğ",
    Yas = 38,
    CalistigiOkul = new
    {
        Adi = "Gazi Üni",
        OgretimDurumu = "Lisans",
        Sehir = "Ankara"
    },
    VerilenDersler = new[] {
        new
        {
            Adi="Programalama",
            KrediPuani=3.0
        },
        new
        {
            Adi="Tarih",
            KrediPuani=1.5
        },
        new
        {
            Adi="İngilizce",
            KrediPuani=2.5
        }
    }
};

Console.WriteLine(ogretmen.CalistigiOkul.Adi);

