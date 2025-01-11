namespace StaticsDemo;

internal class MsbList
{
    public static int MaxElemanSayi { get; set; } = 100;

    public int ElemanSayisi { get; }

    public void Ekle(object eleman)
    {
        if (ElemanSayisi >= MaxElemanSayi)
            throw new Exception("Liste max eleman sayısına ulaşmıştır");
    }
}