namespace EnumDemo;

enum OgretimDurumuEnum
{
    IlkOgretim,
    Lise,
    OnLisans,
    Lisans,
    YuksekLisans,
    Doktora
}

internal class Okul
{
    public string Adi { get; set; }
    public string Sehir { get; set; }
    public OgretimDurumuEnum OgretimDurumu { get; set; }
}

internal class Ogrenci
{
    public string AdiSoyadi { get; set; }
    public int Yas { get; set; }
    public Okul Okul { get; set; }
}
