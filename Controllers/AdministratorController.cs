using drugstore.DataInterfaces;
using drugstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace drugstore.Controllers
{
    [Route("v1/admin")]
    public class AdministratorController : ControllerBase
    {
        private readonly IAdministratorInterface _administratorRepository;
        public AdministratorController(IAdministratorInterface administratorInterface)
        {
            _administratorRepository = administratorInterface;
        }


        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Administrator>>> Get()
        {
            return await _administratorRepository.Get();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Administrator>>Get(int id)
        {

            var admin = await _administratorRepository.Get(id);
            if(admin == null)
                return BadRequest();
            else
                return Ok(admin);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<Administrator>>> Post([FromBody]Administrator model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            else
            {
                try
                {
                    _administratorRepository.Insert(model);
                    _administratorRepository.Save();
                    return Ok(model);

                }catch(DBConcurrencyException E)
                {
                    return BadRequest(new { message = E.Message});
                }catch(Exception E)
                {
                    return BadRequest(new { message = E.Message});
                }
            }
        }

        [HttpPut]
        [Route("id:int")]
        public async Task<ActionResult<List<Administrator>>> Put([FromBody]Administrator model, int id)
        {
            if(id != model.Id)
                return BadRequest(new { message="Admin not found"});

            var admin = _administratorRepository.Get(id);

            if(admin == null)
                return BadRequest(new { message="Admin not found"});
            else
            {
                try
                {
                    _administratorRepository.Update(model);
                    _administratorRepository.Save();
                    return Ok(model);

                }catch(DBConcurrencyException E)
                {
                    return BadRequest(new { message = E.Message});
                }catch(Exception E)
                {
                    return BadRequest(new { message = E.Message});
                }
            }

        }

        [HttpDelete]
        [Route("id:int")]
        public async Task<ActionResult<Administrator>>Delete(int id)
        {
            _administratorRepository.Delete(id);
            _administratorRepository.Save();
            return Ok();
        }

    }
}
