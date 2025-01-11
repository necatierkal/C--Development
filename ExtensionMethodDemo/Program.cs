using ExtensionMethodDemo;
using System;

var random = new Random();

for (int i = 0; i < 10; i++)
{
    var randomSayi = random.TekSayiUret(1, 200);


    Console.WriteLine(randomSayi);

    string deger = "123";
    int sonuc = deger.ToInt32();
}

