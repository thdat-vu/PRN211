using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.FAP.V2.Repositories
{
    /// <summary>
    /// Class này là nguồn Data cho các UI Forms.
    /// Nó chịu trách nhiệm lấy Data từ CSDL SQLServer đem lên
    /// Chứa lệnh móc vào CSDL, lấy và đẩy data về cho Form
    /// </summary>
    public class StudentRepositorySqlserver
    {
        //ds sinh viên
        private List<Student> _list = new List<Student>()
        {
            new Student(){ Id = "SE1", Name = "An", Address = "Tân Bình", Gpa = 8.0},
            new Student(){ Id = "SE3", Name = "Dương", Address = "Tân Thành", Gpa = 5.0},
            new Student(){ Id = "SE5", Name = "Bình", Address = "Dương Đông", Gpa = 3.0},
        };

        //các hàm móc vào CSDL để lấy data

        //các hàm CRUD cung cấp cho UI
        /// <summary>
        /// Hàm trả về ds sinh viên
        /// </summary>
        /// <returns>List<Student></returns>
        public List<Student> GetAll()
        {
            //đọc DB select * from Studeny
            return _list;
        }

        /// <summary>
        /// Hàm nhận vào 1 sinh viên và lưu vào CSDL
        /// </summary>
        /// <param name="x"></param>x là 1 Student đủ infor và sẽ đc add vào CSDL
        public void Add(Student x)
        {
            _list.Add(x);
            //insert into Student values(...) trên SqlServer
        }
        public void Update(Student udtStudent)
        {
            //LINQ trở lại, tìm 1 sv và update info
            var existingStudent = _list.FirstOrDefault(x => x.Id == udtStudent.Id);
            //where trả về 1
            //ko trả new STudent()
            //tham chiếu/trỏ vùng student đã có từ trc trg list
            if (existingStudent != null)
            {
                existingStudent.Name = udtStudent.Name;
                existingStudent.Address = udtStudent.Address;
                existingStudent.Gpa = udtStudent.Gpa;
            }
        }
        public void Delete(string id)
        {
            var existingStudent = _list.FirstOrDefault(x => x.Id == id);
            if (existingStudent != null)
            {
                _list.Remove(existingStudent);
            }
        }

        public List<Student> Search(string keyword)
        {
            //where keyword || cột mình thích
            //search keyword nằm trong 2 cột Name hoặc Address
            var result = _list.Where(s => s.Name.ToLower().Contains(keyword) || 
                                          s.Address.ToLower().Contains(keyword));
            return result.ToList();
        }
    }
}
