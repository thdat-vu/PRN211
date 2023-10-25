using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.FAP.V2.Repositories
{
    internal class StudentRepositoryMySQL : IStudentRepository
    {
        private List<Student> _ds = new List<Student>() { new Student() { Id = "SE1", Name = "MySQL", Address = "RDBMS", Gpa = 6.8 } };

        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(string keyword)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Student> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
