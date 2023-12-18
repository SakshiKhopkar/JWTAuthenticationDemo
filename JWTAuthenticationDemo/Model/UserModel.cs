namespace JWTAuthenticationDemo.Model
{
    public class UserModel
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
    public class UserLogin
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
    public class UserConstants
    {
        public static List<UserModel> Users = new()
        {
            new UserModel(){UserName="admin",Password="admin",Role="Admin"},
            new UserModel(){UserName ="user",Password="user",Role="Customer"}
        };
    }
}
