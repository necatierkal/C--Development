using System.ComponentModel;

namespace AbstractClassDemo;

internal abstract class Kisi
{
    private int sayi = 0;

    protected Kisi()
    {
        
    }

    public string AdiSoyadi { get; set; }
    public int Yas { get; set; }
    public string TcNo { get; set; }

    public abstract string Meslek { get; }

    public void BilgiYazdir()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Adı Soyadı:{0}", AdiSoyadi);
        Console.WriteLine("Yaş:{0}", Yas);
        Console.WriteLine("TcNo:{0}", TcNo);
        Console.WriteLine("Meslek:{0}", Meslek);

        EkstraBilgiYazdir();
    }

    protected abstract void EkstraBilgiYazdir();
}

internal class Ogrenci : Kisi
{
    public string OkulNo { get; set; }

    public override string Meslek => "Öğrenci";

    protected override void EkstraBilgiYazdir()
    {
        Console.WriteLine("Okul No:{0}", OkulNo);
    }
}

internal class Ogretmen : Kisi
{
    public decimal Maas { get; set; }

    public override string Meslek => "Öğretmen";

    protected override void EkstraBilgiYazdir()
    {
        Console.WriteLine("Maaş:{0}", Maas);
    }
}