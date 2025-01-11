using System;

ExpHandling(() =>
{
    Bolme(20, 0);
});

ExpHandling(() => ToTitleCase(null));

static void ExpHandling(Action action)
{
    try
    {
        action();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Hata Oluştu: {0}", ex.Message);
        Console.ForegroundColor = ConsoleColor.White;

        //throw; //Oluşan hatayı fırlatır
    }
}

static double Bolme(int bolunen, int bolen)
{
    return bolunen / bolen;
}

static string ToTitleCase(string ifade)
{
    string cikti = ifade[0].ToString().ToUpper();

    return cikti;
}


