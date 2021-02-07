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
    public class AdministratorRepository : IAdministratorInterface
    {
        private readonly AppDataContext _context;
        public AdministratorRepository(AppDataContext context)
        {
            _context = context;
        }


        public async Task<ActionResult<List<Administrator>>> Get()
        {
            return await _context.Administrators.ToListAsync();
        }

        public async Task<ActionResult<Administrator>> Get(int id)
        {
            return await _context.Administrators.FindAsync(id);
        }

        public void Insert(Administrator model)
        {
             _context.Administrators.Add(model);
        }

        public void Update(Administrator model)
        {
            _context.Entry<Administrator>(model).State = EntityState.Modified;
        }

        public void Save()
        {
           _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var admin = _context.Administrators.Find(id);
            _context.Administrators.Remove(admin);
        }
    }
}
