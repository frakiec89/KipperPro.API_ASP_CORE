using System.ComponentModel.DataAnnotations;

namespace KipperPro.API_ASP_CORE.DB
{
    public class Visitor
    {
        [Key]
        public int VisitorId { get; set; }
        public  string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime  DateOfBirth { get; set; }
        public string  Passport { get; set; }
    
        public string Login { get; set; }
        public string Password { get; set; }



        public Visitor() { }

        public Visitor(string name, string pass, string emeil)
        {
            Name = name;
            Password = pass;
            Email = emeil;
            Login = emeil;
            DateOfBirth = new DateTime();
            Passport = string.Empty;
            Phone = string.Empty;
        }
    }
}
