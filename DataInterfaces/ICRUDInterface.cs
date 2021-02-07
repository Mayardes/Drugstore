using drugstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drugstore.DataInterfaces
{
    public interface ICRUDInterface <T>
    {
        Task<ActionResult<List<T>>> Get();
        Task<ActionResult<T>>Get(int id);
        void Insert(T model);
        void Update(T model);
        void Delete(int id);
        void Save();
        
    }
}
