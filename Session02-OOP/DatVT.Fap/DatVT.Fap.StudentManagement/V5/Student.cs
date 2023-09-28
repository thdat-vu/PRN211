using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.Fap.StudentManagement.V5
{
    internal class Student
    {
        public static int Id { get; set; } //static property
        public string Name { get; set; } //instance property
        public int Yob {  get; set; }

        public Student(int id, string name, int yob)
        {
            Id = id;
            Name = name;
            Yob = yob;
        }

        public Student()
        {

        }
        public void PrintProfile()
        {
            Console.WriteLine("Student V5: ID: " + Id + "" +
                "| Name: " + Name +
                "| Yob:" + Yob);
        }
        static void Main(string[] args)
        {
            Student s1 = new(1, "An", 2001);
            s1.PrintProfile();
            Student s2 = new(2, "Bình", 2002);
            //Student s2 = new() { Id = 2, Name = "Bình Lê", Yob = 2002 };
            
            s2.PrintProfile();

            Console.WriteLine("Print profile again");
            s1.PrintProfile();
            s2.PrintProfile();
            //Console.WriteLine(Name);
            //static ko thể chơi vs non-static
            //do non nằm ăn theo vùng new, có quá nhiều vùng new thì biết ăn theo thàng nào
            Console.WriteLine(Id);
            //static chơi đc vs static
            //sờ chạm static (hàm, field) ta 
            //dùng tên-class
            //do đây là đồ dùng chung cho toàn bộ các
            //object
            
        }
    }
}
