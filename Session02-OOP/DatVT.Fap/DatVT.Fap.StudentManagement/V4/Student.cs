using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.Fap.StudentManagement.V4
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Student(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        //ctor tab là derder có constructor rỗng
        public Student()
        {
            
        }
        //svm tab tab
        static void Main(string[] args)
        {
            //constructor không tham số
            //và có thể gán value cho các đặc tính
            //qua con đường set()
            Student s1 = new Student();
            Student s2 = new ();
            Student s3 = new() { Id = 1};
            Student s4 = new() { Id = 1, Name = "Datvt" };
            Student s5 = new() { Id = 1 , Description = "VTD"};
            Student s6 = new() { Id = 1 , Name = "DatVT", Description = "VTD"};
            Student s7 = new() { Description = "VTD" };
            Student s10 = new Student { Id = 1, Name = "DatVT", Description = "VTD" };
            Student s11 = new Student() { Id = 1, Name = "DatVT", Description = "VTD" };
            //dùng constructor có tham số
            Student s8 = new Student(1, "DatVT", "VTD");
            Student s9 = new(1, "DatVT", "VTD");
            Student s12 = new(id: 1, name: "DatVT", description: "VTD");
            //                named argument, đưa tham số cho hàm
            //                nhưng ghi luôn tên tham số cho đẹp dễ theo dõi
            Student s13 = new Student (id: 1, name: "DatVT", description: "VTD");

            //gọi hàm kiểu truyền thống
            SayHello("Dat");
            SayHello(msg: "Dat"); //named argument
        }

        public static void SayHello(string msg)
        {
            Console.WriteLine("Welcome to" + msg);
        }
    }
}
