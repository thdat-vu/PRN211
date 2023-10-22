using System.Threading.Channels;

namespace DatVT.LINQ.V3.StudentMgt
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string? ToString()
        {
            return Id + " | " + Name + " | " + Address + " | " + Yob + " | " + Gpa;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> _ds = new List<Student>()
            {
                new Student(){Id = "SE1", Name ="An Nguyễn", Address = "Dĩ An", Gpa = 8.8, Yob=2003},
                new Student(){Id = "SE2", Name ="Bình Lê", Address = "Bình Dương", Gpa = 9.0, Yob=2008},
                new Student(){Id = "SE5", Name ="Dương Lễ", Address = "Tân Bình", Gpa = 5.0, Yob=2004},
                new Student(){Id = "SE4", Name ="Dũng", Address = "Châu Thành", Gpa = 5.8, Yob=2006},
                new Student(){Id = "SE3", Name ="Thành", Address = "Long An", Gpa = 8.0, Yob=2000}
            }; // danh sách sinhviene khởi tạo sẵn luôn
               //.Where (cần 2 biểu thức Lambda - hàm nhận Student trả về bool)
               //~~~ select * from ... where
               //tức là where sẽ lấy hết đầy đủ property của bất cứ đối tượng nào đã đc lọc

            //.Select(cần biểu thức lambda...) ~~~ select cột 1, cột 2,...
            //anonymous object - nghĩa là obj đc tạo ra ko có tên class cụ thể
            var ct = new { Name = "Ngoc Trinh", Province = "Tra Vinh" };
            Console.WriteLine("Anonymous obj: " + ct.Name + " | " + ct.Province);
            var selectResult = _ds.Select(x => new { Name = x.Name, Province = x.Address }).ToList();
            selectResult.ForEach(x => Console.WriteLine(x));
        }

        //static void Main(string[] args)
        //{
        //    List<Student> _ds = new List<Student>()
        //    {
        //        new Student(){Id = "SE1", Name ="An Nguyễn", Address = "Dĩ An", Gpa = 8.8, Yob=2003},
        //        new Student(){Id = "SE2", Name ="Bình Lê", Address = "Bình Dương", Gpa = 9.0, Yob=2008},
        //        new Student(){Id = "SE5", Name ="Dương Lễ", Address = "Tân Bình", Gpa = 5.0, Yob=2004},
        //        new Student(){Id = "SE4", Name ="Dũng", Address = "Châu Thành", Gpa = 5.8, Yob=2006},
        //        new Student(){Id = "SE3", Name ="Thành", Address = "Long An", Gpa = 8.0, Yob=2000}
        //    }; // danh sách sinhviene khởi tạo sẵn luôn

        //    //in cho t danh sách sinh viên ở Bình Dương
        //    //LINQ bắt đầu
        //    //ko cần tự viết hàm nữa
        //    //var result = _ds.Where(xxx => xxx.Address == "Bình Dương");
        //    //var result = _ds.Where(CheckStudentYob);
        //    //var result = _ds.Where(delegate (Student xxx) { return xxx.Yob >= 2005; });
        //    var result = _ds.Where((xxx) =>  xxx.Yob >= 2005 ).ToList();
        //    //stream API bên JAVA
        //    //Ghi nhận 1 danh sách sv nhưng ko new, ko clone danh sách
        //    //duyệt động trên ds gốc, ko tạo ds mới INumerable
        //    //nếu muốn List để xài danh sách, ta convert thành ds thật

        //    //Console.WriteLine("The list of sv from bình dương :");

        //    Console.WriteLine("filtering YOB: ");
        //    foreach (var x in result)
        //    {
        //        Console.WriteLine(x); // gọi thầm toString();
        //    }
        //    Console.WriteLine("filtering YOB: (new way to print)");
        //    //result.ForEach(PrintAStudent);
        //    result.ForEach(x => { Console.WriteLine(x);
        //        Console.WriteLine("Ahihi");
        //    });
        //}

        static void PrintAStudent(Student x) => Console.WriteLine(x);
        //expression body

        static bool CheckStudentYob(Student a) => a.Yob <= 2000;


    }
}