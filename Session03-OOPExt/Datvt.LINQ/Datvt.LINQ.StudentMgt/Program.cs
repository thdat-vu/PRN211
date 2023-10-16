namespace Datvt.LINQ.StudentMgt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() {Id = "SE1", Name = "Đạt", Yob = 2001 };

            s.DoExtraodinary(SayHello);
            //callback
            s.DoExtraodinary(() => Console.WriteLine("Call back nè"));
        }
        static void SayHello()
        {
            Console.WriteLine("Vai~ delegate");
        }
    }
}