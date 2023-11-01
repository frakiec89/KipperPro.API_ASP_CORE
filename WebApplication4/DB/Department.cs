using System.ComponentModel.DataAnnotations;

namespace KipperPro.API_ASP_CORE.DB
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        public string Name { get; set; }    
    }
}