using System.ComponentModel.DataAnnotations;

namespace KipperPro.API_ASP_CORE.DB
{
    public class AttendsPersonally
    {
        [Key]
        public int AttendsPersonallyId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }


        public DateTime Date { get; set; }

        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
    }
}
