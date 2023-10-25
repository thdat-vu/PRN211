using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.FAP.V2.Repositories
{
    public class StudentRepositoryMySQL
    {
        List<Student> _ds = new List<Student>
        {   
            new Student(){ Id = "SE1", Name = "MySQL", Address = "RDBMS", Gpa = 6.8}            
        };
        //hàm thêm xóa sửa tìm kiếm từ DB MySQL đưa cho form xài
        public List<Student> GetAllStudents()
        {
            return _ds;

        }
        public void AddAStudent(Student x)
        {
            _ds.Add(x);
        }
        public List<Student> SearchStudentsByAddress(string keyword)
        {
            var result = _ds.Where(s => s.Name.ToLower().Contains(keyword) ||
                                          s.Address.ToLower().Contains(keyword));
            return result.ToList();

        }
        public Student? SearchById(string id)
        {
            //...first or default
            return _ds.FirstOrDefault(x => x.Id == id);
        }
    }
}
