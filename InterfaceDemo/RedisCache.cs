namespace InterfaceDemo;

internal class RedisCache : ICacheService
{
    public void Add(string key, object data)
    {
        Console.WriteLine("Redis ile eklendi");
    }

    public T Get<T>(string key)
    {
        Console.WriteLine("Redis ile getirildi");
        return default;
    }

    public bool IsExist(string key)
    {
        return false;
    }

    public void Remove(string key)
    {
        Console.WriteLine("Redis ile silindi");
    }
}
