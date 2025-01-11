using ExceptionHandlingDemo;

try 
{
    Console.Write("Bölüm Giriniz: ");
    int bolum = int.Parse(Console.ReadLine());

    Console.Write("Bölen Giriniz: ");
    int bolen = int.Parse(Console.ReadLine());

    if (bolen == 0)
        throw new MsbException("Sayı sıfıra bölünemez");

    int sonuc = bolum / bolen;
    Console.WriteLine("Sonuc:{0}", sonuc);
}
//catch (FormatException ex)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Hata Oluştu:{0}", "Lütfen sayısal değer giriniz");
//    Console.ForegroundColor = ConsoleColor.White;
//}
//catch (DivideByZeroException ex)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Hata Oluştu:{0}", "Bölen 0 olamaz");
//    Console.ForegroundColor = ConsoleColor.White;
//}
catch (MsbException ex) //when (ex.Message.StartsWith("a"))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Hata Oluştu:{0}", ex.Message);
    Console.ForegroundColor = ConsoleColor.White;
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Hata Oluştu:{0}", "Beklenmedik bir hata oluştu. Lütfen yöneticinize başvurunuz");
    Console.ForegroundColor = ConsoleColor.White;
}
finally
{
    Console.WriteLine("İşlem hatalı veya hatasız sonuclandı");
}


Console.WriteLine("Bitti");