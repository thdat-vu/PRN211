using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.Fap.StudentManagement.V2
{
    internal class Student
    {
        string _id;
        string _name;
        int _yob;

        public Student()
        {
            //empty constructor, dùng để new() bình thường không tham số
            //nếu 1 classss ko có 1 ctor nào, thì .NET sẽ tự tạo dùng
            //nếu 1 class bất kì đã có sẵn 1 ctor nào đó thì ctor rỗng ko đc tạo ra nũa, trù phi bạn chủ động
            //tạo = tay


        }

        public Student(string id, string name, int yob)
        {
            _id = id;
            _name = name;
            _yob = yob;
        }

        public string GetNamme() => _name; //truyền thống Java
        //style C#
        public string Name //property đại diện cho biến back-field
                           //_name
        {
            get { return _name; }
            set { _name = value; } //value chính là đầu vào 
                                   //cho hàm SetName() truyền thống
                                   //ngày xua, C## cung cấp sãn.
            //tự nhiên: s1.Name là lấy giá trị biến _name
            //tụ nhiên: s1.Name = "Ahihi"; gán tên rất tự nhiên.
                        //tôi duocdj đổi tên mói là Ahihi
                        // y chang _name = "Ahihi"
                        //gộp get/set mang ý nghĩa: tui nói về cái tên
                        //.Name tùy gán hay get
        }

        public int Yob
        {
            //get { return _yob; }
            //set { _yob = value; }

            get => _yob;
            set => _yob = value;
        }

        //mã sóp sinh viên chỉ xem thou, ko thay đổi

        //public string Id
        //{
        //    get => _id;
        //}

        public string Id => _id;

        //main() func here
        static void Main(string[] args)
        {
            Student s1 = new Student(id: "Se1", name: "An nguyen", yob: 2005);
            Student s2 = new Student("Se2", "Binh Le", 2004);

            //in tên mỗi bạn qua hàm get() style mói.
            Console.WriteLine("s1: " + s1.Name);
            Console.WriteLine("s2: " + s2.Name);
        }
    }
}
