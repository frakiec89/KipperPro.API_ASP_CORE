using System.ComponentModel.DataAnnotations;

namespace KipperPro.API_ASP_CORE.DB
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public Division? Division { get; set; }
        public int? DivisionId { get; set; }
        public Department? Department { get; set; }
        public int? DepartmentId { get; set; }


        public int  Code { get; set; }  
    }
}
