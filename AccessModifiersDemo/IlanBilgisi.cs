namespace AccessModifiersDemo;

public class IlanBilgisi
{

    private object PrivateProp { get; set; }
    protected object ProtectedProp { get; set; }
    internal object InternalProp { get; set; }
    public object PublicProp { get; set; }

    protected internal object ProtectedInternalProp { get; set; }
    private protected object PrivateProtectedProp { get; set; } //C# 7.2

    public IlanBilgisi()
    {
        //Tüm proplara erişilebilir
    }
}

internal class KonutIlanBilgisi: IlanBilgisi
{
    public KonutIlanBilgisi()
    {
       //PrivateProp hariç hepsi erişilebilir
    }
}



