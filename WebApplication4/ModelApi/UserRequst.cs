namespace WebApplication4.ModelApi
{
    public class UserRequst
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }


    }

    public class UserResponse
    {
        public int  Id { get; set; }
        public string Name { get; set; }
    }
}