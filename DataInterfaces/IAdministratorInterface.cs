using drugstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drugstore.DataInterfaces
{
    public interface IAdministratorInterface
    {
        Task<ActionResult<List<Administrator>>> Get();
        Task<ActionResult<Administrator>>Get(int id);
        void Insert(Administrator model);
        void Update(Administrator model);
        void Delete(int id);
        void Save();
        
    }
}
