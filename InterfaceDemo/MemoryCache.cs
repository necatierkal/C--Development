namespace InterfaceDemo;

internal class MemoryCache : ICacheService
{
    public void Add(string key, object data)
    {
        Console.WriteLine("Memory Cache ile eklendi");
    }

    public T Get<T>(string key)
    {
        Console.WriteLine("Memory Cache ile getirildi");

        return default(T);
    }

    public bool IsExist(string key)
    {
        return false;
    }

    public void Remove(string key)
    {
        Console.WriteLine("Memory Cache ile silindi");
    }
}
