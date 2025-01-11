using MsbCore;
using System.Collections;

var isimler = new MsbGenericList<ArrayList>();
isimler.Ekle("Salih");
isimler.Ekle("Murat");
//isimler.Ekle(2000);

var isimSoyisimListesi = new MsbList();
isimSoyisimListesi.Ekle("Salih");
isimSoyisimListesi.Ekle("Murat");
isimSoyisimListesi.Ekle(2000);

var constraintList = new MsbGenericList<ArrayList>();
