using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;

namespace UserRegistrationApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUserRegistrationBL _userRegistrationBL;
        
        public UserRegistrationController(IUserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpGet]
        public string Registration()
        {
            string username = "root";
            string password = "root";
            return _userRegistrationBL.RegistrationBL(username, password);
        }

    }
}
