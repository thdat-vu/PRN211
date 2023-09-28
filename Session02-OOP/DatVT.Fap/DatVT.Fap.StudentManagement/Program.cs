using DatVT.Fap.StudentManagement.Utility;
using DatVT.Fap.StudentManagement.V1;

using DatVT.Fap.StudentManagement.V5;
//y chang import tên-package; ỏ bên Java

//câu lệnh using và phải viết viết ở trên cùng trước namespace
//                     #include<tên thư viện.h> bên C, C++
namespace DatVT.Fap.StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test mytoy class");
            Console.WriteLine("PI: " + MyToyCS.PI);
            Console.WriteLine("5! = " + MyToyCS.GetFactorial(5));
        }
        //static void Main(string[] args)
        //{
        //    //CreateNewStudent();

        //    //new Student của version 5, package V5, namespace V5

        //    DatVT.Fap.StudentManagement.V5.Student s = new V5.Student(100, "an", 2005);
        //    s.PrintProfile();

        //    //chạm vào static nè, tên class chấm
        //    Console.WriteLine("ID static:" + 
        //        DatVT.Fap.StudentManagement.V5.Student.Id);

        //    //ko dùng namespace dài, do lúc này ko đụng đến
        //    //Student owrw main gốc và V5
        //}

        //static void CreateNewStudent()
        //{
        //    V1.Student s1 = new V1.Student("SE1", "An Nguyễn", 2005, "annn@");
        //    V1.Student s2 = new V1.Student(id: "SE2", name: "Bình Lê", yob: 2005, email: "bình@");
        //    V1.Student s3 = new ("SE3","Cường Võ", yob: 2004, email: "cuong@");

        //    var s4 = new V1.Student(id: "SE4", name: "Dung Trần", yob: 2003, email: "dung@");
        //    s1.ShowProfile();
        //    s2.ShowProfile();
        //    s3.ShowProfile();
        //    s4.ShowProfile();

        //}
    }
}