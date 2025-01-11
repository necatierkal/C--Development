using DelegateSample;

List<string> isimler = new List<string>
{ "Salih", "Mehmet", "Ahmet", "Zeynep"
 ,"Liya","Ali","Veli","Engin","Mustafa" };


//List<string> besKarakterliIsimler = ListHelper.BesKarakterFiltrele(isimler);
Func<string, bool> filtre = t => t.Length == 5;
List<string> besKarakterliIsimler = ListHelper.Filtrele(isimler, BesKarakterFiltre);
Console.WriteLine(string.Join(",", besKarakterliIsimler));

//List<string> aGecenIsimler = ListHelper.AGecenFiltrele(isimler);
List<string> aGecenIsimler = ListHelper.Filtrele(isimler, a => a.ToLower().Contains("a"));
Console.WriteLine(string.Join(",", aGecenIsimler));

List<string> iIleBitenIsimler = ListHelper.Filtrele(isimler, i => i.ToLower().EndsWith("i"));
Console.WriteLine(string.Join(",", iIleBitenIsimler));

//List<string> sIleBaslayanIsimler = isimler.Filtrele(t => t.StartsWith("S"));
var sIleBaslayanIsimler = isimler.Where(t => t.StartsWith("S"));
Console.WriteLine(string.Join(",", sIleBaslayanIsimler));

static bool BesKarakterFiltre(string t)
{
    return t.Length == 5;
}