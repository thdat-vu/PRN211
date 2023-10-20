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

            //in cho t danh sách sinh viên ở Bình Dương
            //LINQ bắt đầu
            //ko cần tự viết hàm nữa
            var result = _ds.Where(xxx => xxx.Address == "Bình Dương");
            Console.WriteLine("The list of sv from bình dương :");
            foreach (var x in result)
            {
                Console.WriteLine(x); // gọi thầm toString();
            }
        }
    }
}