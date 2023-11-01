using WebApplication4.ModelApi;

namespace KipperPro.API_ASP_CORE.Services
{
    internal class UsersService
    {
        DB.MsContext context = new DB.MsContext();
        internal void AddUser(UserRequst requst)
        {
            try
            {
                var us = new DB.Visitor(requst.Name, requst.Password, requst.Email);
                context.Visitors.Add(us);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception( e.Message);
            }
        }

        internal UserResponse GetUser(UserRequst requst)
        {
            try
            {
                var us = 
                context.Visitors.Single(x => x.Email == requst.Email
                && x.Password == requst.Password) ;
                return new UserResponse { Id = us.VisitorId , Name = us.Name };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}