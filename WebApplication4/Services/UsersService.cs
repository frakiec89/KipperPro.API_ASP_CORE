using KipperPro.API_ASP_CORE.DB;
using WebApplication4.ModelApi;

namespace KipperPro.API_ASP_CORE.Services;

internal class UsersService
{
    private MsContext _context;
    public UsersService(MsContext context)
    {
        _context = context;
    }

    public void AddUser(UserRequest request)
    {
        try
        {
            var us = new DB.Visitor(request.Name, request.Password, request.Email);
            _context.Visitors.Add(us);
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public UserResponse GetUser(UserRequest request)
    {
        try
        {
            var us =
                _context.Visitors.Single(x => x.Email == request.Email
                                              && x.Password == request.Password);
            return new UserResponse { Id = us.VisitorId, Name = us.Name };
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
}