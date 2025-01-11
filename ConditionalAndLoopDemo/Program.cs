//IfElseSwitchCaseDemo();
//LoopDemo();

for (int i = 0; i < 10; i++)
{
    //if (i % 2 == 1)
    //    continue;

    //if (i == 5)
    //    break;

    if (i == 5)
        return;

    Console.WriteLine(i);
}

Console.WriteLine("Bitti");

static void IfElseSwitchCaseDemo()
{
    Console.Write("Bir sayı giriniz:");
    var ifade = Console.ReadLine();
    var sayi = Convert.ToInt32(ifade);

    var tekSayimi = sayi % 2 == 1;

    //if (tekSayimi)
    //    Console.WriteLine("Bu bir tek sayıdır");

    //if (!tekSayimi)
    //{
    //    Console.WriteLine("Bu bir çift sayıdır");
    //}

    if (tekSayimi)
        Console.WriteLine("Bu bir tek sayıdır");
    else
        Console.WriteLine("Bu bir çift sayıdır");


    if (sayi < 50)
        Console.WriteLine("Sayı 50 den küçüktür.");
    else if (sayi >= 50 && sayi < 100)
        Console.WriteLine("Sayı 50-100 arasındadır");
    else if (sayi >= 100 && sayi < 200)
        Console.WriteLine("Sayı 100-200 arasındadır");
    else
        Console.WriteLine("Sayı 200 den büyüktür");

    if (sayi > 100)
    {
        if (sayi % 5 == 0)
        {
            Console.WriteLine("Sayı 100 den büyük ve 5'e tam bölünebilir");
        }
    }

    if (sayi < 0)
        Console.WriteLine("Sayı negatiftir");


    switch (sayi)
    {
        case 1:
            Console.WriteLine("Bir");
            break;
        case 2:
            Console.WriteLine("İki");
            break;
        case 3:
            Console.WriteLine("Üç");
            break;
        case 4:
        case 5:
        case 6:
            Console.WriteLine("Dört,Beş,Altı");
            break;
        default:
            Console.WriteLine(sayi);
            break;
    }
}

static void LoopDemo()
{
    int sayac = 1;
    while (sayac <= 10)
    {
        Console.WriteLine("Merhaba Dünya!");
        //sayac = sayac + 1;
        //sayac += 1;
        sayac++;
    }

    int counter = 1;
    do
    {
        Console.WriteLine("Hello World!");
        counter++;
    } while (counter <= 10);


    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("SLD YAZILIM");
    }
}