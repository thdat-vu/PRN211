

using static DatVT.MathUtility.Math.MathUtility;

namespace Datvt.LINQ.StudentMgt

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() {Id = "SE1", Name = "Đạt", Yob = 2001 };

            s.DoExtraodinary(SayHello);

            //sinh viên có thể in ra dãy số từ 1...100
            s.DoExtraodinary(PrintIntegerList);

            //sinh viên có thể tính giai thừa ở nơi khác!!!
            //s.DoExtraodinary(1 hàm khác ở đâu đó!!);
            s.DoComputation(GetFactorial, 5);

            //callback
            //s.DoExtraodinary(() => Console.WriteLine("Call back nè"));
        }
        static void SayHello()
        {
            Console.WriteLine("Vai~ delegate");
        }
        static void PrintIntegerList()
        {
            Console.WriteLine("The list of numbers from 1...100: ");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}