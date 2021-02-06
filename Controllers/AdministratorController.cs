using drugstore.DataInterfaces;
using drugstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drugstore.Controllers
{
    [Route("v1/admin")]
    public class AdministratorController : ControllerBase
    {
        private readonly ICRUDInterface<Administrator> _administratoriterfaces;
        public AdministratorController(ICRUDInterface<Administrator> administratorInterface)
        {
            _administratoriterfaces = administratorInterface;
        }


        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Administrator>>> Get()
        {
            return await _administratoriterfaces.Get();
        }

    }
}
