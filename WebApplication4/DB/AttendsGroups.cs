namespace KipperPro.API_ASP_CORE.DB
{
    public class AttendsGroups
    {
        public int AttendsGroupsId { get; set; }

        public string Info { get; set; }
        public int  NumberGroup {  get; set; }
        public DateTime Date { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }

    }
}
