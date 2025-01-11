namespace PropertyDemo;

internal class Kisi
{
    private string _adSoyad;
    private DateTime _dogumTarihi;

    public string GetAdSoyad()
    {
        //kod
        return _adSoyad;
    }

    public void SetAdSoyad(string adSoyad)
    {
        //kod
        _adSoyad = adSoyad;
        //kod
    }

    public void SetDogumTarihi(DateTime dogumTarihi)
    {
        _dogumTarihi = dogumTarihi;
    }

    public DateTime GetDogumTarihi() => _dogumTarihi;

    public int GetYas() => DateTime.Now.Year - _dogumTarihi.Year;
}
