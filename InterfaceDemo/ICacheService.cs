namespace InterfaceDemo;

internal interface ICacheService
{
    public void Add(string key, object data);

    public void Remove(string key);

    public T Get<T>(string key);

    public bool IsExist(string key);

    public void Clear() //C# 8.0 ile gelen özellik
    {
        Console.WriteLine("Temizlendi");
    }
}
