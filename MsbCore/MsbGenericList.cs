using System.Collections;

namespace MsbCore;

public class Deneme<Salih, Ahmet>
    where Salih : class
    where Ahmet : struct
{

}

public class MsbGenericList<TParam>
    //where TParam : class //TParam Referans tip olmak zorunda
    //where TParam : struct  //TParam Değer tip olmak zorunda
    //where TParam : new() //TParam public parametresiz ctor bloguna sahip olmalı
    //where TParam : ICollection
    where TParam : class, new()
{
    private TParam[] _dizi;

    public MsbGenericList()
    {
        //var deger = new TParam();

        _dizi = new TParam[0];
    }

    public TParam this[int index]
    {
        get => _dizi[index];
        set => _dizi[index] = value;
    }

    public int ElemanSayisi => _dizi.Length;

    public void Ekle(TParam eleman)
    {
        var yedekDizi = _dizi;
        _dizi = new TParam[ElemanSayisi + 1];

        yedekDizi.CopyTo(_dizi, 0);

        _dizi[ElemanSayisi - 1] = eleman;
    }

    public void Sil(int indexNo)
    {
        var yedekDizi = _dizi;
        _dizi = new TParam[ElemanSayisi - 1];

        int sayac = 0;
        for (int i = 0; i < yedekDizi.Length; i++)
        {
            if (indexNo == i)
                continue;

            _dizi[sayac] = yedekDizi[i];
            sayac++;
        }
    }
}