using WebApplication4.ModelApi;

namespace KipperPro.API_ASP_CORE.Services;

public class ValidationService
{
    public bool IsValidRegistraion(UserRequest? request)
    {
        if(request is null)
            return false;
        
        if (string.IsNullOrWhiteSpace(request.Password) || string.IsNullOrWhiteSpace(request.Email) ||
            string.IsNullOrWhiteSpace(request.Name))
            return false;

        if (request.Password.Length < 8)
            return false;

        return true;
    }
    
    public bool IsValidLogin(UserRequest? request)
    {
        if(request is null)
            return false;
        
        if (string.IsNullOrWhiteSpace(request.Password) || string.IsNullOrWhiteSpace(request.Email) ||
            string.IsNullOrWhiteSpace(request.Name))
            return false;

        return true;
    }
}