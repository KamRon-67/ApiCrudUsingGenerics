using ApiCrudUsingGenerics.IService;
using ApiCrudUsingGenerics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudUsingGenerics.Service
{
    public class StudentService : IGenericService<Student>
    {
        List<Student> IGenericService<Student>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Student> IGenericService<Student>.GetAll()
        {
            throw new NotImplementedException();
        }

        Student IGenericService<Student>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Student> IGenericService<Student>.Insert(Student item)
        {
            throw new NotImplementedException();
        }
    }
}
