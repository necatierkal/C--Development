using AbstractClassDemo;

var ogrenci = new Ogrenci()
{
    AdiSoyadi = "Zeynep Liya",
    OkulNo = "5",
    TcNo = "23232432432",
    Yas = 18
};


var ogretmen = new Ogretmen
{
    AdiSoyadi = "Salih Demiroğ",
    TcNo = "2323232432",
    Yas = 10,
    Maas = 65_000
};
ogrenci.BilgiYazdir();
ogretmen.BilgiYazdir();