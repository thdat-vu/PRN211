using System.Threading.Channels;

namespace DatVT.CsIntro.LanguageIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello C#. Welcome to hell");

            // PlayWithIntegers();
            PlayWithDouble();
        }

        static void PlayWithDouble() 
        {
            float pi = 3.14F;
            Console.WriteLine("pi = " + pi);
            Console.WriteLine($"pi = {pi, -10:N3}and coin");
            double piNew = 3.14;
            Console.WriteLine("piNew: " + piNew);
            //mặc định số thực đc coi là double, ko cần ghi chú đuôi phân loại

            const double vat = 0.8;
            //vat = 0.1; ko đổi đc giá trị của hằng số


        }
        static void PlayWithIntegers()
        {
            int a;
            a = 10;
            int b = 3;
            Console.WriteLine("a has value of "+ a);
            Console.WriteLine("b has value of " + b); // cách in kiểu truyền thống

            Console.WriteLine("a has value of {0}", a); 
            //Console.WriteLine("b has value of {0}", b); // cách số 2
            Console.WriteLine("a and b have values of {0}, {1}", a, b);
            //interpolation - In theo kiểu nội suy
            Console.WriteLine($"a has value of {a}");

            var c = 69;
            Console.WriteLine($"c has value of {c}");
            //khai báo biến mà ngầm định kiểu dữ liệu (implicit)
            //kiểu dữ liệu sẽ đc xác định khi ta gán value cho biến và bắt buộc 
            //gán ngay lúc khai báo.
            // var c ; c = 69 là ăn cức

            //kiểm tra xêm data type của biến này là gì????

            Console.WriteLine("the data type of a is " + a.GetType().ToString());
            Console.WriteLine("the data type of c is " + c.GetType().ToString());


            //long d = 3000000000;
            long e = 3_000_000_000;
            //in ra màn hình
            Console.WriteLine("e: " + e);
            Console.WriteLine($"e:  {e}"); //interpolation
            Console.WriteLine("e: {0}", e);//place holder

            //chơi vs hệ 16
            int f = 0xFA;
            Console.WriteLine("f: " + f);
        }
    }
}