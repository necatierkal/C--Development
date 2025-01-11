using InterfaceDemo;

var userManager = new UserManager(new RedisCache());
userManager.DeleteUser(1);
userManager.AddNewUser(new User());
userManager.GetUsers();

var memoryCache = new MemoryCache();
