namespace KipperPro.ConnsoleClient.ModelApi
{
    public class UserRequst
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }

    public class UserResponse
    {
        public int  Id { get; set; }
        public string Name { get; set; }
    }
}