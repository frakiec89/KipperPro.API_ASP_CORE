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
            if (_validation.IsValidRegistraion(request))
                return BadRequest(
                    "Запрос не прошел валидацию. Логин либо пустой, пароль возможно тоже, пароль должен быть не меньше 6 символов");

            try
            {
                UsersService service = new UsersService();
                service.AddUser(request);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

            return true;
        }

        [HttpPost("authUser")]
        public IActionResult AuthUser(UserRequest request)
        {
            if (_validation.IsValidLogin(request))
                return BadRequest(
                    "Запрос не прошел валидацию. Логин либо пустой, пароль возможно тоже");

            try
            {
                UsersService service = new UsersService();
                UserResponse us = service.GetUser(request);

                return us;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}