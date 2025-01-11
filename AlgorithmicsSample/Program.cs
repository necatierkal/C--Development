var toplam = 0;

for (int i = 1; i <= 100; i++)
{
    toplam += i;
}

Console.WriteLine("1-100 arası sayıların toplamı: " + toplam);

for (int sayi = 2; sayi <= 20; sayi++)
{
    bool asalMi = true;

    for (int i = 2; i < sayi; i++)
    {
        if (sayi % i == 0) 
        {
            asalMi = false;
            break;
        }
    }

    if (asalMi)
        Console.WriteLine("Asal Sayı:" + sayi);
}

Console.Write("Sayı Giriniz:");
int faktSayi = int.Parse(Console.ReadLine());
long sonuc = 1;
for (int i = 1; i <= faktSayi; i++)
{
    sonuc *= i;
}

string sonucFormat = string.Format("{0}! = {1}", faktSayi, sonuc);
string sonucInterpolation = $"{faktSayi}! = {sonuc}";

Console.WriteLine(sonucInterpolation);