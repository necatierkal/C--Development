namespace PropertyDemo;

internal class Sahis
{
    private string _adSoyad;

    public string AdSoyad
    {
        //get
        //{
        //    //kod
        //    return _adSoyad;
        //}
        //set
        //{
        //    //kod
        //    _adSoyad = value;
        //    //kod
        //}

        get => _adSoyad; //C# 7.0
        set => _adSoyad = value; //C# 7.0
    }

    public DateTime DogumTarihi { get; set; }

    //public int Yas
    //{
    //    get
    //    {
    //        return DateTime.Now.Year - DogumTarihi.Year;
    //    }
    //}

    public int Yas => DateTime.Now.Year - DogumTarihi.Year; //C# 6.0

    public string Adres { get; set; } = "Ankara"; //C# 6.0
    public int RandomSayi { get; } = Random.Shared.Next(1, 100);

    public string BabaAdi { get; private set; }


}
