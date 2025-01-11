namespace CtorDemo;

internal class Kategori
{
    //public Kategori()
    //{
    //    Console.WriteLine("Ctor çalıştı");

    //    Id = Guid.NewGuid();
    //    Adi = "Gıda";
    //    Aciklama = "Gıda ürünlerinin kategorisi";
    //}

    public Kategori()
    {
        KayitTarihi = DateTime.Now;
        Id = Guid.NewGuid();
    }

    public Kategori(string adi) : this()
    {
        Adi = adi;
    }

    public Kategori(string adi, string aciklama) : this(adi)
    {
        Aciklama = aciklama;
    }

    public Guid Id { get; set; }
    public string Adi { get; set; }
    public string Aciklama { get; set; }
    public DateTime KayitTarihi { get; }

    ~Kategori()
    {
        //nesne bellekten atılmadan önce çalışan yıkıcı bloğumuz

        //kod
        //kod
        //yönetilmeyen kaynaklarınb bağlantıları kapatılıp nesne serbest bırakılır

        //Dispose pattern burada uygulanır
    }
}
