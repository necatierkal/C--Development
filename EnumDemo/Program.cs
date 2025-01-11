using EnumDemo;

var ogrenci = new Ogrenci
{
    AdiSoyadi = "Salih Demiroğ",
    Yas = 20,
    Okul = new Okul
    {
        Adi = "Gazi Uni.",
        Sehir = "Ankara",
        OgretimDurumu = OgretimDurumuEnum.Lisans
    }
};

Console.WriteLine(ogrenci.Okul.OgretimDurumu);

Console.WriteLine((int)ogrenci.Okul.OgretimDurumu); //3
Console.WriteLine(ogrenci.Okul.OgretimDurumu.GetHashCode());//3

Console.WriteLine(ogrenci.Okul.OgretimDurumu.ToString("d")); // "3"
Console.WriteLine(ogrenci.Okul.OgretimDurumu.ToString("g")); // "Lisans"
Console.WriteLine(ogrenci.Okul.OgretimDurumu.ToString("x")); // "000003" Hexdecimal

Console.WriteLine(ogrenci.ToString());

Console.WriteLine("------------------------------");

Renk renk = Renk.Sari;
renk = Renk.Kirmizi;

Renk turuncu = Renk.Sari | Renk.Kirmizi;

Console.WriteLine($"renk: {renk}, int değeri: {(int)renk}");
Console.WriteLine($"renk: {turuncu}, int değeri: {(int)turuncu}");

var renkler = Enum.GetNames<Renk>();

Console.WriteLine(string.Join(",", renkler));

Console.WriteLine(sizeof(Renk));