namespace MethodsDemo;

internal class MathHelper
{
    //public double PiSayisiGetir()
    //{
    //    return 3.1415;
    //}

    public double PiSayisiGetir() => 3.1415;

    public long KareAl(int sayi)
    {
        return sayi * sayi;
    }

    //public double OrtalamaAl(int a, int b)
    //{
    //    return (a + b) / 2d;
    //}

    public double OrtalamaAl(int a, int b) => (a + b) / 2d;

    public double OrtalamaAl(int a, int b, int c)
    {
        return (a + b + c) / 3d;
    }

    public double OrtalamaAl(int[] sayilar)
    {
        var toplam = 0d;
        foreach (var sayi in sayilar)
        {
            toplam += sayi;
        }

        return toplam / sayilar.Length;
    }

    public double OrtalamaAlParams(params int[] sayilar)
    {
        var toplam = 0d;
        foreach (var sayi in sayilar)
        {
            toplam += sayi;
        }

        return toplam / sayilar.Length;
    }


    public long Carp(byte a, byte b, byte c = 1, byte d = 1, byte e = 1, byte f = 1)
    {
        return a * b * c * d * e * f;
    }

    public double DaireAlanHesapla(int yaricap)
    {
        var piSayisi = PiSayisiGetir();
        return yaricap * yaricap * piSayisi;
    }

    public void DortIslem(int a, int b, out int toplama,
        out int cikarma, out long carpma, out double bolme)
    {
        toplama = a + b;
        cikarma = a - b;
        carpma = a * b;
        bolme = a / (double)b;
    }

    public void RefDemo(ref int sayi)
    {
        sayi = 1000;
    }

    //5!=5*4*3*2*1
    //public int FaktHesapla(int sayi)
    //{
    //    if (sayi == 0)
    //        return 1;

    //    var sonuc = 1;

    //    for (int i = 1; i <= sayi; i++)
    //    {
    //        sonuc *= i;
    //    }

    //    return sonuc;
    //}

    //5!=5*4!
    public int FaktoriyelHesaplaRec(int sayi)
    {
        if (sayi == 0)
            return 1;

        return sayi * FaktoriyelHesaplaRec(sayi - 1);
    }
}