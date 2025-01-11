//int sayi1 = 100;
//int sayi2= 200;
//int sayi3 = 300;
//int sayi = new int();
int[] sayilar = new int[3];

sayilar[0] = 2;
sayilar[1] = 5;
sayilar[2] = 9;

var elemanSayisi = sayilar.Length;
Console.WriteLine($"Eleman Sayısı :{elemanSayisi}");

//for (int i = 0; i < elemanSayisi; i++)
//{
//    Console.WriteLine($"{i + 1}. Eleman:{sayilar[i]}");
//}

foreach (var sayi in sayilar)
{
    Console.WriteLine($"Eleman:{sayi}");
}

//int[] rakamlar = new int[10];
//rakamlar[0] = 0;
//rakamlar[1] = 1;
//rakamlar[2] = 2;
//rakamlar[3] = 3;
//rakamlar[4] = 4;
//rakamlar[5] = 5;
//rakamlar[6] = 6;
//rakamlar[7] = 7;
//rakamlar[8] = 8;
//rakamlar[9] = 9;

//int[] rakamlar = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//var rakamlar = new int[] { 0, 1, 2, 3, 4, 5 };
int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

Console.Write("Son rakamı giriniz:");
var sonRakam = int.Parse(Console.ReadLine());
var yedekDizi = rakamlar;

rakamlar = new int[rakamlar.Length + 1];

//for (int i = 0; i < yedekDizi.Length; i++)
//{
//    rakamlar[i] = yedekDizi[i];
//}

yedekDizi.CopyTo(rakamlar, 0);

rakamlar[rakamlar.Length - 1] = sonRakam;

foreach (var rakam in rakamlar)
{
    Console.WriteLine(rakam);
}



