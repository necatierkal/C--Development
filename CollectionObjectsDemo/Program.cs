using System.Collections;

//ArrayListDemo();
//HashtableDemo();
//SortedListDemo();
//StackDemo();

var kuyruk = new Queue();
kuyruk.Enqueue("Salih");
kuyruk.Enqueue("Mehmet");
kuyruk.Enqueue("Ali");

var siradaki = kuyruk.Peek();
Console.WriteLine("Peek sonrası eleman sayısı:{0}", kuyruk.Count);

var siradakiKisi = kuyruk.Dequeue();
Console.WriteLine("Sıraki kisi {0}. Kalan Sayı:{1}", siradakiKisi, kuyruk.Count);

kuyruk.Dequeue();

foreach (var item in kuyruk)
{
    Console.WriteLine(item);
}

kuyruk.Clear();


static void ArrayListDemo()
{
    ArrayList isimler = new ArrayList()
{
    "Mehmet",
    "Mustafa",
    "Engin",
};

    Console.WriteLine("Eleman Sayısı:{0}", isimler.Count);

    isimler.Add("Salih");
    isimler.Add("Özge");
    isimler.Add("Zeynep");

    Console.WriteLine("Listedeki İsimler:{0}", string.Join(",", isimler.ToArray()));

    object ilkIsim = isimler[0];
    isimler[1] = "Ahmet";

    Console.WriteLine("Güncelleme Sonrası Listedeki İsimler:{0}", string.Join(",", isimler.ToArray()));

    isimler.Remove("Ahmet");
    isimler.RemoveAt(1);

    Console.WriteLine("Silme Sonrası Listedeki İsimler:{0}", string.Join(",", isimler.ToArray()));

    //isimler.RemoveRange(0, 2);

    Console.WriteLine("Listede Liya var mı? : {0}", isimler.Contains("Liya"));
    Console.WriteLine("Listede Liya değerinin index numarası:{0}", isimler.IndexOf("Liya"));
    Console.WriteLine("Listede Zeynep değerinin index numarası:{0}", isimler.LastIndexOf("Zeynep"));

    isimler.Insert(2, "Cevdet");

    Console.WriteLine("Insert Sonrası Listedeki İsimler:{0}", string.Join(",", isimler.ToArray()));

    isimler.Reverse();

    Console.WriteLine("Reverse Sonrası Listedeki İsimler:{0}", string.Join(",", isimler.ToArray()));

    isimler.Clear();

    Console.WriteLine("Eleman Sayısı:{0}", isimler.Count);
}

static void HashtableDemo()
{

    //Hashtable sehirler = new Hashtable();
    //sehirler.Add("01", "Adana");
    //sehirler.Add("21", "Diyarbakır");
    //sehirler.Add("06", "Ankara");
    //sehirler.Add("34", "İstanbul");
    //sehirler.Add("14", "Bolu");

    Hashtable sehirler = new Hashtable
{
    { "01", "Adana" },
    { "21", "Diyarbakır" },
    { "06", "Ankara" },
    { "34", "İstanbul" },
    { "14", "Bolu" }
};

    sehirler["06"] = "Angara";
    object baskent = sehirler["06"];

    if (!sehirler.ContainsKey("10"))
    {
        sehirler.Add("10", "Balıkesir");
    }

    sehirler.Remove("21");

    Console.WriteLine("Eleman Sayısı:{0}", sehirler.Count);

    //foreach (var sehirKey in sehirler.Keys)
    //{
    //    Console.WriteLine("{0} -> {1}", sehirKey, sehirler[sehirKey]);
    //}

    foreach (DictionaryEntry sehir in sehirler)
    {
        Console.WriteLine("{0} -> {1}", sehir.Key, sehir.Value);
    }

    sehirler.Clear();
}

static void SortedListDemo()
{
    var sehirler = new SortedList
    {
        { "01", "Adana" },
        { "21", "Diyarbakır" },
        { "06", "Ankara" },
        { "34", "İstanbul" },
        { "14", "Bolu" }
    };

    sehirler["06"] = "Angara";
    object baskent = sehirler["06"];

    if (!sehirler.ContainsKey("10"))
    {
        sehirler.Add("10", "Balıkesir");
    }

    sehirler.Remove("21");

    Console.WriteLine("Eleman Sayısı:{0}", sehirler.Count);

    //foreach (var sehirKey in sehirler.Keys)
    //{
    //    Console.WriteLine("{0} -> {1}", sehirKey, sehirler[sehirKey]);
    //}

    foreach (DictionaryEntry sehir in sehirler)
    {
        Console.WriteLine("{0} -> {1}", sehir.Key, sehir.Value);
    }

    sehirler.Clear();
}

static void StackDemo()
{
    var yigin = new Stack();
    yigin.Push("Salih");
    yigin.Push("Mehmet");
    yigin.Push("Ali");

    object yigindanCikarilacakVeri = yigin.Peek();
    Console.WriteLine("Peek sonrası eleman sayısı:{0}", yigin.Count);

    var yigindanCikarilanVeri = yigin.Pop();
    Console.WriteLine("Yigindan {0} çıktı. Kalan Sayı:{1}", yigindanCikarilanVeri, yigin.Count);

    yigin.Pop();

    foreach (var item in yigin)
    {
        Console.WriteLine(item);
    }

    yigin.Clear();
}