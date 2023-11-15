using KipperPro.API_ASP_CORE.Services;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.ModelApi;

namespace KipperPro.API_ASP_CORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly ValidationService _validation;
        private readonly UsersService _service;

        public RegistrationController(ValidationService validation, UsersService usersService)
        {
            _validation = validation;
            _service = usersService;
        }

        [HttpPost("registration")]
        public IActionResult Registration(UserRequest request)
        {
            if (_validation.IsValidRegistraion(request))
                return BadRequest(
                    "Запрос не прошел валидацию. Логин либо пустой, пароль возможно тоже, пароль должен быть не меньше 6 символов");

            _service.AddUser(request);
            
            return Ok();
        }

        [HttpPost("authUser")]
        public IActionResult AuthUser(UserRequest request)
        {
            if (_validation.IsValidLogin(request))
                return BadRequest(
                    "Запрос не прошел валидацию. Логин либо пустой, пароль возможно тоже");

            return Ok(_service.GetUser(request));
        }
    }
}