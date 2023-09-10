using System.Threading.Channels;

namespace DatVT.CsIntro.LanguageIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello C#. Welcome to hell");

            PlayWithIntegers();
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

        }
    }
}