namespace InterfaceDemo;

internal class UserManager
{
    private readonly ICacheService _cacheService;
    public UserManager(ICacheService cacheService)
    {
        _cacheService = cacheService;
    }

    public void DeleteUser(int id)
    {
        //db den kullanıcı silindi;

        //_cacheService = new RedisCache();//readonly den dolayı Hatalı
        _cacheService.Remove(CacheKeys.USER_CACHE_KEY);

        _cacheService.Clear();
    }

    public void AddNewUser(User user)
    {
        //db ye kullanıcı eklendi;
        _cacheService.Remove(CacheKeys.USER_CACHE_KEY);
    }

    public List<User> GetUsers()
    {
        if (_cacheService.IsExist(CacheKeys.USER_CACHE_KEY))
            return _cacheService.Get<List<User>>(CacheKeys.USER_CACHE_KEY);

        //kullanıcılar db den getirildi
        var dataFromDb = new List<User>()
        {
            new User() { Id = 1,Name="Salih Demiroğ"},
            new User() { Id = 2,Name="Zeynep Liya Demiroğ"},
        };

        _cacheService.Add(CacheKeys.USER_CACHE_KEY, dataFromDb);

        return dataFromDb;
    }
}
