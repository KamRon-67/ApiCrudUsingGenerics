using ApiCrudUsingGenerics.IService;
using ApiCrudUsingGenerics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudUsingGenerics.Service
{
    public class TeacherService : IGenericService<Teacher>
    {
        List<Teacher> _teachers = new List<Teacher>();

        public TeacherService()
        {
            for (int i = 1; i <= 10; i++)
            {
                _teachers.Add(new Teacher()
                {
                    TeacherId = i,
                    Name = "TeacherName" + i,
                    Subject = "Subject" + i
                });
            }
        }

        List<Teacher> IGenericService<Teacher>.Delete(int id)
        {
            _teachers.RemoveAll(x => x.TeacherId == id);
            return _teachers;
        }

        List<Teacher> IGenericService<Teacher>.GetAll()
        {
            return _teachers;
        }

        Teacher IGenericService<Teacher>.GetById(int id)
        {
            return _teachers.Where(x => x.TeacherId == id).SingleOrDefault();
        }

        List<Teacher> IGenericService<Teacher>.Insert(Teacher item)
        {
            _teachers.Add(item);
            return _teachers;
        }
    }
}
