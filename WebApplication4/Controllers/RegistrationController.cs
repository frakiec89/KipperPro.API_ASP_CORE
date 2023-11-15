using KipperPro.API_ASP_CORE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.ModelApi;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly ValidationService _validation;
        public RegistrationController(ValidationService validation)
        {
            _validation = validation;
        }
        
        [HttpPost("registration")]
        public IActionResult Registration(UserRequest request)
        {
            if (request == null)
            {  return BadRequest("пустой запрос");            }

            if (string.IsNullOrWhiteSpace(request.Password))
            {return BadRequest("пустой пароль");            }

            if (string.IsNullOrWhiteSpace(request.Name))
            { return BadRequest("пустое имя"); }

            if (string.IsNullOrWhiteSpace(request.Email))
            { return  BadRequest("Email логин"); }


            if (request.Password.Length < 8)
                return BadRequest("пароль короткий");

            if (request.Password.ToLower() == request.Password ||
                request.Password.ToLower() == request.Password
                )
                return BadRequest("пароль плохой");
            // todo - куча  проверок 

            try
            {
                UsersService service = new UsersService();
                service.AddUser (request);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
            return true ;
        }

        [HttpPost("authUser")]
        public IActionResult AuthUser (UserRequest request)
        {
            if (request == null)
            { return BadRequest("пустой запрос"); }

            if (string.IsNullOrWhiteSpace(request.Password))
            { return BadRequest("пустой пароль"); }

            if (string.IsNullOrWhiteSpace(request.Email))
            { return BadRequest("пустой логин"); }

            try
            {
                UsersService service = new UsersService();
                UserResponse us = service.GetUser (request);

                return us;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
