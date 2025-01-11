using InheritanceDemo;

var ogrenci = new Ogrenci()
{
    AdiSoyadi = "Zeynep Liya",
    OkulNo = "5",
    TcNo = "23232432432",
    Yas = 18
};


var ogretmen = new Ogretmen
{
    AdiSoyadi = "Salih Demiroğ",
    TcNo = "2323232432",
    Yas = 38,
    Maas = 65_000
};

var kisi = new Kisi();

bool isKisi = ogretmen is Kisi; //true
bool isBasariliOgretmen = ogretmen is BasariliOgretmen; //false

BilgileriYazdir(ogrenci);
BilgileriYazdir(ogretmen);


Console.WriteLine("#############");

var c = new C("salih");

var kisiler = new List<Kisi>();
kisiler.Add(ogretmen);
kisiler.Add(ogrenci);
kisiler.Add(new Kisi
{
    AdiSoyadi = "Salih"
});



static void BilgileriYazdir(Kisi kisi)
{
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Adı Soyadı:{0}", kisi.AdiSoyadi);
    Console.WriteLine("Yaş:{0}", kisi.Yas);
    Console.WriteLine("TcNo:{0}", kisi.TcNo);

    //if (kisi is Ogrenci)
    //{
    //    var ogrencim = (Ogrenci)kisi;
    //    Console.WriteLine("Okul No:{0}", ogrencim.OkulNo);
    //}

    if (kisi is Ogrenci ogrencim) //C# 6.0
        Console.WriteLine("Okul No:{0}", ogrencim.OkulNo);


    Ogretmen ogretmenim = kisi as Ogretmen;
    if (ogretmenim is not null) //C# 9.0
        Console.WriteLine("Maaş:{0}", ogretmenim.Maas);
}

