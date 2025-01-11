using MethodsDemo;

//Demo1();

var mathHelper = new MathHelper();

int toplama;
mathHelper.DortIslem(10, 2, out toplama, out int cikarma, out long carpma, out _);

Console.WriteLine("10+2={0}", toplama);
Console.WriteLine("10-2={0}", cikarma);
Console.WriteLine("10*2={0}", carpma);

Console.Write("Bir Değer Giriniz:");
var ifade = Console.ReadLine();

if(int.TryParse(ifade, out int deger))
{
    Console.WriteLine("Sonuc:{0}", deger / 2.0);
}
else
{
    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
}

int x = 1;
mathHelper.RefDemo(ref x);

Console.WriteLine("X:{0}", x);


Console.WriteLine("5!={0}", mathHelper.FaktoriyelHesaplaRec(5));

static void Demo1()
{
    var textHelper = new TextHelper();

    Console.Write("Bir ifade giriniz:");
    string ifade = Console.ReadLine();

    string cikti = textHelper.ToTitleCase(ifade);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(cikti);

    string sonuc = textHelper.ToTitleCase("sALiH demiroğ");
    string yeniIfade = textHelper.ToTitleCase("bugun hava çok güzel");

    var mathHelper = new MathHelper();

    var ortSonuc = mathHelper.OrtalamaAl(c: 10, a: 5, b: 20);
    Console.WriteLine("Ort Sonucu:{0}", ortSonuc);


    int[] sayilar = { 3, 54, 65, 22, 4354, 65 };
    var ortSonucDizi = mathHelper.OrtalamaAl(sayilar);
    Console.WriteLine("Ort Dizi Sonucu:{0}", ortSonucDizi);

    var ortSonucParams = mathHelper.OrtalamaAlParams(43, 2, 5, 2, 65, 45, 43, 565, 3);
    Console.WriteLine("Ort Dizi Params Sonucu:{0}", ortSonucParams);

    var carpimSonuc = mathHelper.Carp(4, 6, f: 2, d: 5);
    Console.WriteLine("Carpim Sonucu:{0}", carpimSonuc);
}
