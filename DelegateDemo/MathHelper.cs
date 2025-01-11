namespace DelegateDemo;

internal static class MathHelper
{
    public static double PiSayisiGetir() => 3.1415;

    public static long KareAl(int sayi)
    {
        return sayi * sayi;
    }

    public static long Topla(int a, int b) => a + b;
    public static long Cikar(int a, int b) => a - b;
    public static long Carp(int a, int b) => a * b;
    public static double Bol(int a, int b) => a / b;

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