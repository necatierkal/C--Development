using StaticsDemo;

//var mathHelper = new MathHelper();
//mathHelper.OrtalamaAl(2,3);

var ortSonuc = MathHelper.OrtalamaAl(2, 3);
var ortSonuc2 = MathHelper.OrtalamaAl(2, 3);
var ortSonuc3 = MathHelper.OrtalamaAl(2, 3);

var piSayisi = MathHelper.PiSayisiGetir;

MsbList.MaxElemanSayi = 200;

var isimler = new MsbList();
//isimler.MaxElemanSayi = 200;
isimler.Ekle("Salih");

Console.WriteLine("Bitti");
