using System.Collections;

/*
ArrayList sayilar = new()
{
    10,20,340 //,"20",false,DateTime.Now
};

var toplam = 0;
foreach (var sayi in sayilar)
{
    toplam += (int)sayi;
}
*/

List<int> sayilar = new List<int>
{
    10,20,340
};

Console.WriteLine("Eleman Sayısı:{0}",sayilar.Count);

var toplam = 0;
foreach (var sayi in sayilar)
{
    toplam += sayi;
}

Console.WriteLine("Toplam:{0}", toplam);

sayilar[0] = 1000;


Hashtable hashtable = new Hashtable();
hashtable.Add(false, "Ankara");
hashtable.Add(3, "Üç");
hashtable.Add("Salih", 5000);

//Dictionary<int, string> rakamKarsiliklari = new();
var rakamKarsiliklari = new Dictionary<int,string>();

rakamKarsiliklari.Add(1, "Bir");
rakamKarsiliklari.Add(2, "İki");
//rakamKarsiliklari.Add("Üç", 3);
rakamKarsiliklari.Add(3, "Üç");

foreach (var rakamKarsiligi in rakamKarsiliklari)
{
    Console.WriteLine(rakamKarsiligi);
}

