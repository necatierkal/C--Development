using ClassDemo;
using System.Collections;

//Urun pc = new Urun();
//var gida = new Urun();

//Urun bilgisayar = new();
//bilgisayar.Ad = "Huawei Laptop";
//bilgisayar.Stok = 100;
//bilgisayar.Fiyat = 32000;

Urun bilgisayar = new()
{
    Ad = "Huawei Laptop",
    Fiyat = 32_000,
    Stok = 100
};  

Console.WriteLine("Ad:{0}", bilgisayar.Ad);
Console.WriteLine("Stok:{0}", bilgisayar.Stok);
Console.WriteLine("Birim Fiyat:{0}", bilgisayar.Fiyat);

