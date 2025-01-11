object obj = "Salih";
Console.WriteLine(obj.GetType());

obj = 100d;
Console.WriteLine(obj.GetType());

obj = false;
Console.WriteLine(obj.GetType());

obj = "100a";
Console.WriteLine(obj.GetType());

obj = 200;
Console.WriteLine(obj.GetType());

int toplam = (int)obj + 50;
Console.WriteLine(toplam);
