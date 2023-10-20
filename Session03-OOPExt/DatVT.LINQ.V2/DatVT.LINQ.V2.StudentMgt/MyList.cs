using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.LINQ.V2.StudentMgt
{
    //delegate tự t
    public delegate bool CheckStudent(Student x);
    //class này chứa danh sách các sinh viên. Có thể lấy từ DataBase lên, hoặc new trực tiếp, hoặc Hardcode
    internal class MyList
    {
        List<Student> _ds = new List<Student>()
        {
            new Student(){Id = "SE1", Name ="An Nguyễn", Address = "Dĩ An", Gpa = 8.8, Yob=2003},
            new Student(){Id = "SE2", Name ="Bình Lê", Address = "Bình Dương", Gpa = 9.0, Yob=2008},
            new Student(){Id = "SE5", Name ="Dương Lễ", Address = "Tân Bình", Gpa = 5.0, Yob=2004},
            new Student(){Id = "SE4", Name ="Dũng", Address = "Châu Thành", Gpa = 5.8, Yob=2006},
            new Student(){Id = "SE3", Name ="Thành", Address = "Long An", Gpa = 8.0, Yob=2000}
        }; // danh sách sinhviene khởi tạo sẵn luôn

        //ta lại muốn thống kê ở Bình Dương, 
        //code có câu if (x.Address == Bình Dương) thì...
        //CHỐT CHO 3 HÀM ĐÃ VIẾT VÀ NHỮNG HÀM CÙNG STYLE ĐÃ VIẾT
        //LOGIC LÀ DUYỆT QUA TỪNG BẠN SINH VIÊN,
        //HỎI XEM TỪNG BẠN SV X ĐÓ CÓ THỎA ĐK HAY HÔNG
        //NẾU THỎA THÌ DÙNG BẠN X ĐÓ. 

        //hàm nhận vào 1 delegate chẳng qua là nhận vào 1 hàm bool nào dó
        //cho nên ta cứ gửi từng bạn sv cho hàm này, trả về đúng sai cho mình
        //đúng sai trên gpa, yob, cả gpa & năm sinh, hoặc tỉnh, hoặc vô chừng
        //hàm thực sự làm thì để ở đâu cũng dc, rồi truyền vào delegate

        //ta đã giảm nhẹ gánh nặng cho class myList, chỉ ngồi chờ người ta đưa điều kiện 
        //vào để xét giùm

        //bạn có quyền tạo cái delegate riêng mà ko cần dùng Func nhưng ko nên như vậy
        //vì bạn phải export cả tên delegate cho nơi xài biết mà khai báo theo,
        //còn nếu dùng Func<> cả thế giới đều biết.

        //check = hàm nào đó nận vào sv trả về bool
        //      = CheckStudentByGpa
        //      = CheckStudentByGpaAndYob
        //      = CheckStudentByAdress
        //      Vô chừng
        //      Lambda
        public List<Student> GetStudents(Func<Student, bool> check)
        {

            List<Student> result = new(); 


            foreach (Student x in _ds) //với mọi x thuộc tập hợp y nào đó
            {
                if (check(x) == true) // condition, để kiểm soát data
                {
                    result.Add(x);//predicate, hàm, lệnh dự đoán, điều kiện có thỏa hog.
                }
            }
            return result;
        }

        //CLASS NÀY CHỨA DANH SÁCH SINH VIÊN, VÀ NÓ CUNG CẤP CÁC METHOD ĐỂ IN RA DANH SÁCH
        //THEO TIÊU CHÍ NÀO ĐÓ; VÍ DỤ
        //DS SINH VIÊN THEO TỈNH MÀ GPA >= 8
        //DS SINH VIÊN CÓ GPA >= 9
        //DS SINH VIEN CÓ NĂM SINH > 2005
        //DS SINH VIÊN CÓ NĂM SINH = 2000 VÀ QUÊ Ở ??
        //SỐ ĐIỀU KIỆN THỐNG KÊ NÀY LÀ VÔ CHỪNG!!!, CHƯA KỂ AND OR
        //LÀM SAO THIẾT KẾ CLASS NÀY CÓ THỂ THỎA MÃN BẤT KÌ TIÊU CHÍ THỐNG KÊ NÀO???
        //VÌ TA CHƯA, KO THỂ BIẾT ĐC CÓ BAO NHIÊU ĐK THÔNG KÊ, CHÍNH LÀ WHERE SQL

        //mỗi hàm ta làm thỏa  1 câu if, và số hàm là vô chừng

        //kĩ thuật thiết kế phải làm sao chấp tất cả các đk trong tương lai
        //thay vì ta / class này phải tự làm các câu if, vô chừng if
        //ta để câu if này cho bên ngoài, lúc xài class này đưa vào

        //DEPENDENCY INJECTION
        //BẢN CHẤT LÀ ĐƯA VÀO 1 DELEGATE , ĐƯA VÀO HÀM Ở XA, Ở NƠI XA CỦA AI ĐÓ
        //BÊN JAVA LÀ ĐƯA 1 INTERFACE CÓ 1 HÀM, 
        //CÒN JAVASCRIPT LÀ CALLBACK FUNCTION

        //hàm trả về danh sách sv có gpa >= 8. Trong code phải có chỗ so sánh điểm của từng sv
        //coi >= 8 hay ko
        //
        public List<Student> GetStudentsByGpa()
        {
            List<Student> result = new(); // viet full new List<Student>()
            //quét qua từng sv dedeer dò xem gpa có thỏa hay ko
            foreach (Student x in _ds) //với mọi x thuộc tập hợp y nào đó
            {
                if(x.Gpa >= 8) // condition, để kiểm soát data
                {
                    result.Add(x);//predicate, hàm, lệnh dự đoán, điều kiện có thỏa hog.
                }
            }
            return result;
        }
        //các bạn sinh viên có điểm trung bình có điểm GPA >= 8 && sinh năm >= 2005
        public List<Student> GetStudentsByGpaAndYob()
        {
            List<Student> result = new(); // viet full new List<Student>()
            //quét qua từng sv dedeer dò xem gpa có thỏa hay ko
            foreach (Student x in _ds) //với mọi x thuộc tập hợp y nào đó
            {
                if (x.Gpa >= 8 && x.Yob >= 2005) // condition, để kiểm soát data
                {
                    result.Add(x);//predicate, hàm, lệnh dự đoán, điều kiện có thỏa hog.
                }
            }
            return result;
        }
    }
}
