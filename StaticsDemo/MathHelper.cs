namespace StaticsDemo;

internal static class MathHelper
{
    static MathHelper()
    {
        Console.WriteLine("Static ctor çalıştı");
    }

    public static double PiSayisiGetir => 3.1415;

    public static long KareAl(int sayi)
    {
        return sayi * sayi;
    }

    public static double OrtalamaAl(int a, int b) => (a + b) / 2d;

    public static double OrtalamaAl(int[] sayilar)
    {
        var toplam = 0d;
        foreach (var sayi in sayilar)
        {
            toplam += sayi;
        }

        return toplam / sayilar.Length;
    }
}