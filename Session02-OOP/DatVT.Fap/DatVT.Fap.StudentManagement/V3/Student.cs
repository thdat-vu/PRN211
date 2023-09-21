using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.Fap.StudentManagement.V3
{
    internal class Student
    {
        //đây gọi là data-field
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; } = 2005;

        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new();

            Student x = new() { Id = 1, Name = "Vũ Thành Đạt", Yob = 2001 };

            Student y = new Student() { Id = 1, Name = "Vũ Thành Đạt", Yob = 2001 };

            Student z = new Student { Id = 1, Name = "Vũ Thành Đạt", Yob = 2001 };
            //đây ko phải là constructor
            //đây là phép gán đặc tính
            Student sv1 = new Student { Id = 1, Name = "An Nguyen" };
        }
    }
}
