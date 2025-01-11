namespace InheritanceDemo;

internal class Kisi : Object
{
    public string AdiSoyadi { get; set; }
    public int Yas { get; set; }
    public string TcNo { get; set; }
}

internal class Ogrenci : Kisi
{
    public string OkulNo { get; set; }
}

internal class Ogretmen : Kisi
{
    public decimal Maas { get; set; }
}

internal sealed class BasariliOgretmen : Ogretmen
{
    public decimal Prim { get; set; }
}

//internal class EnBasariliOgretmen : BasariliOgretmen //sealed sınıflar kalıtımda kullanılamaz
//{

//}
