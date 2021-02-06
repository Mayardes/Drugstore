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
        Task<ActionResult<List<T>>>Post(T model);
        Task<ActionResult<List<T>>>Put(int id);
        Task<ActionResult<T>> Delete(int id);
        
    }
}
