using CtorDemo;
using System.Collections;

ArrayList list = new ArrayList(16);

Kategori kategori = new Kategori("Mobilya","Açıklama");

Console.WriteLine("Id:{0}", kategori.Id);
Console.WriteLine("Adı:{0}", kategori.Adi);
Console.WriteLine("Açıklama:{0}", kategori.Aciklama);
Console.WriteLine("Kayıt Tarihi:{0}", kategori.KayitTarihi);


List<string> erkekIsimleri = new List<string>()
{
    "Salih","Ahmet"
};

//List<string> isimler = new List<string>();
//isimler.AddRange(erkekIsimleri);

List<string> isimler = new List<string>(erkekIsimleri);