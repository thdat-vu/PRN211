using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.FAP.V2.Repositories
{
    public interface IStudentRepository //CLB đưa ra tiêu chí nói chung
                                          //để ae tự implements
    {
        //định nghĩa: đặt ra cuộc chơi, yêu cầu ae tuân thủ.
        //phải viết code cho những hàm ở đây, ko care code như thế nào
        //chỉ cần tuân thủ tên hàm
        //chứa hàm ko code - ABSTRACT METHOD
        //interfacef vẫn cho phép có code , nhưng....
        public List<Student> GetAll();
        public void Add(Student student);
        public void Update(Student student);
        public void Delete(string keyword);
        public List<Student> Search(string keyword);
    }
}
