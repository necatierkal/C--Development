using DelegateDemo;

//Demo1();

//Demo2();

//Demo3();

Action action;
Action<string> delege1;
Action<int> delege2;
Action<string, int, string, bool> delege3;


Func<bool> delege4;
Func<bool, string> delege5;
Func<int, long> delege6;
Func<int,int, long> delege7;

Predicate<string> delege8;
Func<string,bool> delege9;


Console.WriteLine("Bitti");



void MerhabaDunya()
{
    Console.WriteLine("Merhaba Dünya");
}

void HelloWorld() => Console.WriteLine("Hello World");

void Demo1()
{
    int sayi = 5;
    string ifade = "Salih";

    Temsilci1 delege1 = MerhabaDunya;
    delege1 += HelloWorld;
    delege1 += MerhabaDunya;
    delege1 += HelloWorld;

    delege1 += () => Console.WriteLine("Günaydın");
    delege1 += () =>
    {
        int sayi = Random.Shared.Next(0, 10);
        Console.WriteLine(sayi);
    };


    delege1 -= MerhabaDunya;


    //delege1.Invoke();
    //YADA
    delege1();
}

static void Demo2()
{
    Temsilci4 delege4 = MathHelper.KareAl;
    delege4 += sayi => sayi * sayi * sayi;

    long sonuc = delege4.Invoke(5);

    Console.WriteLine(sonuc);


    Console.WriteLine("------------");

    foreach (Temsilci4 delege in delege4.GetInvocationList())
    {
        Console.WriteLine($"{delege.Method.Name} -> {delege.Invoke(6)}");
    }
}

static void Demo3()
{
    Temsilci3 delege3 = new Temsilci3(MathHelper.Topla);
    delege3 += MathHelper.Carp;
    delege3 += (a, b) => a * b * 2;

    delege3 += (taban, us) =>
    {
        var sonuc = 1;

        for (int i = 1; i <= us; i++)
        {
            sonuc *= taban;
        }

        return sonuc;
    };

    var sonuc = delege3(2, 3);
    Console.WriteLine(sonuc);
}