using System.Dynamic;

namespace DatVT.CsIntro.Processing
{
    internal class Program
    {
        //svm tab tab
        //static void Main(string[] args)
        //{
        //    int n = 3979;
        //    Console.WriteLine("In main before calling f(), n = " + n);
        //    //PassByReferenceV1(ref n);
        //    PassByReferenceV2(out n);
        //    Console.WriteLine("In main after calling f(), n = " + n);
        //}

        static void Main(string[] args)
        {
            //PassByReferenceV2(out int n); //vãi kiểu khai báo
            //Console.WriteLine("n = " + n);
            Sum(100, out int sum); //nhận kết quả trả về ngay trên tham số
            Console.WriteLine("The sum from 1..100 " + sum);
        }


        //viết hàm tính tổng từ 1 .. n, camass dùng lệnh return mà vẫn trả về giá trị

        static void Sum(int n, out int sum)
        {
            sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
        }


        //chơi với out, trong hàm bắt buộc phải có lệnh sửa value của biến out
        //tao hứa sẽ out 1 cái gì đó
        static void PassByReferenceV2(out int n)
        {
            n = 60;
        }

        // muốn chơi với ref, biến nơi goi phải  có sẵn 1 value nào đó
        //lát hồi hàm sửa sau!!!
        //nhưng hàm có quyền ko thèm sửa
        static void PassByReferenceV1(ref int n)
        {   //bên ngoài nên gọi tôi ơi, hãy đưa cho tôi nơi bạn muốn tôi 
            //bắn cannon tới.
            //trong này sửa, ngoài kia toang, đứng ở đây bùm ở nơi gọi!!!!!!!
            n = 5;


        }
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Hello, World!");
        //    int sum = Sum(100);
        //    //Console.WriteLine("sum from 1 to 100: " + sum);
        //    //Console.WriteLine("sum from 1 to 100: " + Sum(100));
        //    //Console.WriteLine($"sum from 1 to 100: {Sum(100)} " );

        //    int n = 69; // n trong main(), gửi nó qua cái hàm, hàm sẽ biến đổi thành 5
        //    Console.WriteLine("In main before calling f(), n  = " + n);
        //    PassByValue(n);
        //    Console.WriteLine("In main after calling f(), n = " + n);

        //}

        //C# cung cấp thêm 2 món lạ liên quan đến tham số của hàm!!!
        //đó là out và ref
        //kiểu như truyền tham chiếu/con trỏ!!!
        //2 cái này giúp cho mở rộng việc trả về  của 1 cái hàm!!!

        //hàm nhận vào 1 con số nguyên, tạm gọi tên là n
        //viết kiểu này gọi là truyền tham trị!!! Y CHANG BÊN C, JAVA
        //n này sẽ hứng value từ 1 biến khác ở nơi gọi hàm này
        //ai gọi hàm này thì phải truyền 1 value cho hàm, value thường nằm trong biến nào đó

        //static void PassByValue(int n)
        //{
        //    //biến đổi n, bên ngoài đưa vào n là mấy, ko care, ta sửa
        //    Console.WriteLine("In function PassByValue(), before modifying n-parameter = " + n);
        //    n = 5; // 5 tỏi
        //    Console.WriteLine("In function PassByValue(), after modifying n-parameter = " + n);
        //}

        //các hàm sẽ nằm ngoài main() và trong class
        //từng học: static thì chơi vs static 

        //hàm tính  tổng của các số nguyên tử 1..n

        static int Sum(int n)
        {
            int sum = 0;
            int i = 1;
            do
            {
                sum += i;
                i++;
            } while (i <= n);
            return sum;
        }


        //static int Sum(int n)
        //{
        //    int sum = 0;
        //    for (int i = 0; i <= n; i++)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        //Ctrl + K + C: Comment
        //Ctrl + K + U: Uncomment
        //Ctrl + K + D: Deformat
    }
}