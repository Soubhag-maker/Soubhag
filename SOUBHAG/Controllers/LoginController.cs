using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOUBHAG.Service;
using SOUBHAG.Model;

namespace SOUBHAG.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _LoginService;

        public LoginController(ILoginService service)
        {
            _LoginService = service;
        }

        [HttpPost]
        [Route("Login")]
        public LoginModel Login([FromBody] LoginModel model)
        {
            return _LoginService.Login(model);
        }

        [HttpGet]
        [Route("GetModules/{UserId}")]
        public Adm0001Model GetModules(int UserId)
        {
            return _LoginService.GetModules(UserId);
        }

        [HttpGet]
        [Route("GetSubModules/{MenuId}")]
        public Adm0001Model GetSubModules(int menuId)
        {
            return _LoginService.GetSubModules(menuId);
        }

        [HttpGet]
        [Route("GetPagesList/{UserId}")]
        public Adm0001Model GetPagesList(int UserId)
        {
            return _LoginService.GetPagesList(UserId);
        }

    }
}
