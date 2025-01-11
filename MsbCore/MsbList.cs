namespace MsbCore;

public class MsbList
{
    private object[] _dizi;

    public MsbList()
    {
        _dizi = new object[0];
    }

    public object this[int index]
    {
        get => _dizi[index];
        set => _dizi[index] = value;
    }

    public int ElemanSayisi => _dizi.Length;

    public void Ekle(object eleman)
    {
        var yedekDizi = _dizi;
        _dizi = new object[ElemanSayisi + 1];

        yedekDizi.CopyTo(_dizi, 0);

        _dizi[ElemanSayisi - 1] = eleman;
    }

    public void Sil(int indexNo)
    {
        var yedekDizi = _dizi;
        _dizi = new object[ElemanSayisi - 1];

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