using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrudUsingGenerics.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int Name { get; set; }
        public int Subject { get; set; }
        public int Messages { get; set; }
    }
}
