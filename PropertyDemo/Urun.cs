namespace PropertyDemo;

internal class Urun
{
    public string Adi { get; set; } = null!;
    public decimal BirimFiyati { get; init; } //C# 9.0 init-only
    public int StokMiktari { get; init; } //C# 9.0
    public string Aciklama { get; set; } = string.Empty;
    private string? Tedarikci { get; set; }
}
