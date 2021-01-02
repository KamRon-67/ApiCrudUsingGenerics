using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrudUsingGenerics.IService;
using ApiCrudUsingGenerics.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrudUsingGenerics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : GenericController<Student>
    {
        public StudentsController(IGenericService<Student> genericService) : base(genericService)
        {

        }
    }
}
