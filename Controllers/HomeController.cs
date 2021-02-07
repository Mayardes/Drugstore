using drugstore.DataInterfaces;
using drugstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drugstore.Controllers
{
    [Route("v1/home")]
    public class HomeController : ControllerBase
    {
      private readonly IAdministratorInterface _administratorRepository;
        public HomeController(IAdministratorInterface administratorInterface)
        {
            _administratorRepository = administratorInterface;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<Administrator>> Index()
        {
            var admin = new Administrator()
            {
                Name = "Matheus",
                Password = "123"
            };

            _administratorRepository.Insert(admin);
            _administratorRepository.Save();
            return Ok(new {message = "Sucessfully" });


        }
    }
}
