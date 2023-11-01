using System.ComponentModel.DataAnnotations;

namespace KipperPro.API_ASP_CORE.DB
{
    public class Division
    {
        [Key]
        public int DivisionId { get; set; }
        public string Name { get; set; }
    }
}