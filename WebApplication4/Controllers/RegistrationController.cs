using KipperPro.API_ASP_CORE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.ModelApi;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {

        [HttpPost("registration")]
        public ActionResult<bool> Registration(UserRequst requst)
        {
            if (requst == null)
            {  return BadRequest("пустой запрос");            }

            if (string.IsNullOrWhiteSpace(requst.Password))
            {return BadRequest("пустой пароль");            }

            if (string.IsNullOrWhiteSpace(requst.Name))
            { return BadRequest("пустое имя"); }

            if (string.IsNullOrWhiteSpace(requst.Email))
            { return  BadRequest("Email логин"); }


            if (requst.Password.Length < 8)
                return BadRequest("пароль короткий");

            if (requst.Password.ToLower() == requst.Password ||
                requst.Password.ToLower() == requst.Password
                )
                return BadRequest("пароль плохой");
            // todo - куча  проверок 

            try
            {
                UsersService service = new UsersService();
                service.AddUser (requst);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
            return true ;
        }

        [HttpPost("authUser")]
        public ActionResult<ModelApi.UserResponse> AuthUser (UserRequst requst)
        {
            if (requst == null)
            { return BadRequest("пустой запрос"); }

            if (string.IsNullOrWhiteSpace(requst.Password))
            { return BadRequest("пустой пароль"); }

            if (string.IsNullOrWhiteSpace(requst.Email))
            { return BadRequest("пустой логин"); }

            try
            {
                UsersService service = new UsersService();
                UserResponse us = service.GetUser (requst);

                return us;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
