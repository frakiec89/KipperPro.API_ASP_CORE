using WebApplication4.ModelApi;

namespace KipperPro.API_ASP_CORE.Services
{
    internal class UsersService
    {
        DB.MsContext context = new DB.MsContext();
        internal void AddUser(UserRequest request)
        {
            try
            {
                var us = new DB.Visitor(request.Name, request.Password, request.Email);
                context.Visitors.Add(us);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception( e.Message);
            }
        }

        internal UserResponse GetUser(UserRequest request)
        {
            try
            {
                var us = 
                context.Visitors.Single(x => x.Email == request.Email
                && x.Password == request.Password) ;
                return new UserResponse { Id = us.VisitorId , Name = us.Name };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}