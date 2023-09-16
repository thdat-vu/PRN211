namespace DatVT.Fap.StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateNewStudent();
        }

        static void CreateNewStudent()
        {
            Student s1 = new Student("SE1", "An Nguyễn", 2005, "annn@");
            Student s2 = new Student(id: "SE2", name: "Bình Lê", yob: 2005, email: "bình@");
            Student s3 = new ("SE3","Cường Võ", yob: 2004, email: "cuong@");

            var s4 = new Student(id: "SE4", name: "Dung Trần", yob: 2003, email: "dung@");
            s1.ShowProfile();
            s2.ShowProfile();
            s3.ShowProfile();
            s4.ShowProfile();
        }
    }
}