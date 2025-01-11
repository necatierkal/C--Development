namespace DelegateSample;

public static class ListHelper
{
    public static List<string> BesKarakterFiltrele(List<string> data)
    {
        List<string> filtreliData = new List<string>();

        foreach (var isim in data)
        {
            bool kosul = Kosul(isim);
            if (kosul)
                filtreliData.Add(isim);
        }

        return filtreliData;
    }

    private static bool Kosul(string isim)
    {
        return isim.Length == 5;
    }

    public static List<string> AGecenFiltrele(List<string> data)
    {
        List<string> filtreliData = new List<string>();

        foreach (var isim in data)
        {
            if (isim.ToLower().Contains("a"))
                filtreliData.Add(isim);
        }

        return filtreliData;
    }

    public static List<string> IIleBitenFiltrele(List<string> data)
    {
        List<string> filtreliData = new List<string>();

        foreach (var isim in data)
        {
            if (isim.EndsWith("i"))
                filtreliData.Add(isim);
        }

        return filtreliData;
    }

    public static List<string> Filtrele(this List<string> data, Func<string,bool> kosul)
    {
        List<string> filtreliData = new List<string>();

        foreach (var isim in data)
        {
            bool sonuc = kosul.Invoke(isim);
            if (sonuc)
                filtreliData.Add(isim);
        }

        return filtreliData;
    }
}
