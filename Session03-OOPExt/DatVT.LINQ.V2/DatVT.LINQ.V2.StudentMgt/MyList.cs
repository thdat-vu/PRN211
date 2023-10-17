using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.LINQ.V2.StudentMgt
{
    //class này chứa danh sách các sinh viên. Có thể lấy từ DataBase lên, hoặc new trực tiếp, hoặc Hardcode
    internal class MyList
    {
        List<Student> danhsach = new List<Student>()
        {
            new Student(){Id = "SE1", Name ="An Nguyễn", Address = "Dĩ An", Gpa = 8.8, Yob=2003},
            new Student(){Id = "SE2", Name ="Bình Lê", Address = "Bình Dương", Gpa = 9.0, Yob=2005},
            new Student(){Id = "SE5", Name ="Dương Lễ", Address = "Tân Bình", Gpa = 5.0, Yob=2004},
            new Student(){Id = "SE4", Name ="Dũng", Address = "Châu Thành", Gpa = 5.8, Yob=2006},
            new Student(){Id = "SE3", Name ="Thành", Address = "Long An", Gpa = 8.0, Yob=2000}
        }; // danh sách sinhviene khởi tạo sẵn luôn

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
    }
}
