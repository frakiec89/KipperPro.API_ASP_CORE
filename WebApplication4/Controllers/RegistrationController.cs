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

            if (string.IsNullOrWhiteSpace(requst.Login))
            { return  BadRequest("пустой логин"); }

            return true ;
        }

        [HttpPost("authUser")]
        public ActionResult<ModelApi.UserResponse> AuthUser (UserRequst requst)
        {
            if (requst == null)
            { return BadRequest("пустой запрос"); }

            if (string.IsNullOrWhiteSpace(requst.Password))
            { return BadRequest("пустой пароль"); }

            if (string.IsNullOrWhiteSpace(requst.Login))
            { return BadRequest("пустой логин"); }

            return new UserResponse() { Id = 1, Name = "test" };
        }

    }
}
