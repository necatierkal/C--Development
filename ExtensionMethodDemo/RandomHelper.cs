namespace ExtensionMethodDemo;

public static class RandomHelper
{
    public static int TekSayiUret(this Random random, int min, int max)
    {
        var randomSayi = random.Next(min, max);
        if (randomSayi % 2 == 0)
            return randomSayi + 1;

        return randomSayi;
    }

    public static int ToInt32(this object obj)
    {
        return Convert.ToInt32(obj);
    }
}
