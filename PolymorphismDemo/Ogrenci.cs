namespace PolymorphismDemo;

internal class Kisi : Object
{
    public string AdiSoyadi { get; set; }
    public virtual int Yas { get; set; }
    public string TcNo { get; set; }

    public virtual void BilgiYazdir()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Adı Soyadı:{0}", AdiSoyadi);
        Console.WriteLine("Yaş:{0}", Yas);
        Console.WriteLine("TcNo:{0}", TcNo);
    }
}

internal class Ogrenci : Kisi
{
    public string OkulNo { get; set; }

    public override string ToString()
    {
        return $"{AdiSoyadi} - {Yas}";
    }

    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine("Okul No:{0}", OkulNo);
    }
}

internal class Ogretmen : Kisi
{
    public decimal Maas { get; set; }

    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine("Maaş:{0}", Maas);
    }

    public override int Yas 
    { 
        get => base.Yas;
        set
        {
            if (value < 18)
                throw new Exception("Öğretmenin yaşı 18 den küçük olamaz");

            base.Yas = value;
        }
    }
}

internal sealed class BasariliOgretmen : Ogretmen
{
    public decimal Prim { get; set; }
}
