using drugstore.Data;
using drugstore.DataInterfaces;
using drugstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drugstore.Repository
{
    public class AdministratorRepository : ICRUDInterface<Administrator>
    {
        private readonly DataContext _context;
        public AdministratorRepository(DataContext context)
        {
            _context = context;
        }

        public Task<ActionResult<Administrator>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<List<Administrator>>> Get()
        {
            return await _context.Administrators.AsNoTracking().ToListAsync();
        }

        public Task<ActionResult<Administrator>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<List<Administrator>>> Post(Administrator model)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<List<Administrator>>> Put(int id)
        {
            throw new NotImplementedException();
        }
    }
}
