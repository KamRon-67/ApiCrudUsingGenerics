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
        List<Student> _students = new List<Student>();

        public StudentService()
        {
            for (int i = 1; i <= 10; i++)
            {
                _students.Add(new Student()
                {
                    StudentId = i,
                    Name = "StudentName" + i,
                    Roll = "100" + i
                });
            }
        }

        List<Student> IGenericService<Student>.Delete(int id)
        {
            _students.RemoveAll(x => x.StudentId == id);
            return _students;
        }

        List<Student> IGenericService<Student>.GetAll()
        {
            return _students;
        }

        Student IGenericService<Student>.GetById(int id)
        {
            return _students.Where(x => x.StudentId == id).SingleOrDefault();
        }

        List<Student> IGenericService<Student>.Insert(Student item)
        {
            _students.Add(item);
            return _students;
        }
    }
}
