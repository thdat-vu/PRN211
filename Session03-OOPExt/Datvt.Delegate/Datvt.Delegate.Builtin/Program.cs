namespace Datvt.Delegate.Builtin
{
    //Hàm đa dạng nhưng rơi vào 2 loại: Có trả về kq,       và ko trả về kq
    //Quy ước gọi tên cho 2 loại hàm:   function               Action
    //                              làm gì đó có trả về        làm gì đó, vậy hoi

    //xét loại hàm ĐIỀU GÌ ĐÓ, KKO TRẢ VỀ KẾT QUẢ
    
    internal class Program
    {
        //xét loại hàm ĐIỀU GÌ ĐÓ, KO TRẢ VỀ KẾT QUẢ void F(... có tham số hoặc ko)
        static void SayHello() => Console.WriteLine("From SayHello(): Hi Message");
        static void SayHi() => Console.WriteLine("From SayHi(): Hi Everyone");
        static void SayNow() => Console.WriteLine("From SayNow(): Today is Friday");

        //khai báo delegate chung cho 3 cháu này
        delegate void DoSomethingDelegate(); //trỏ chung 3 thằng trên và kkhacs nữa
                                            //và anonymous và lambda

        //.NET cung cấp sẵn 1 delegate tên là Action cho xài thôi, y chang delegate DoSomethingDelegate();

        //delegate void Action();
        //xài Action y chang như xài DoSomethingDelegate

        static void UseActionDelegate()
        {
            Action f = SayHi;
            f += () => {
                Console.WriteLine("This msg comes from a lambda expression" +
                "using predefined Action delegate");
            };
            f();// gọi cả 2 hàm cùng chạy thôi
        }

        static void UseDoSomethingDelegate()
        {
            SayHello(); // gọi hàm kiểu bình thường
            DoSomethingDelegate f = SayHello; // dấu ngoặc tròn là gọi hàm mất tiêu r
                                              //đây là trỏ, tham chiếu thôi
            f(); //DoSomethingDelegate() ~ SayHello()


            //dùng anonymous function, trỏ đến hàm thứ 4, ko thèm trỏ đến 3 hàm đã biết
            f = delegate ()
            {
                Console.WriteLine("This msg comes from an anonymous function");
            };

            f += () => Console.WriteLine("This msg comes from a lambda expression");
            f(); //lần này mới thật sự là chạy cả 2 hàm anonymous và lambda đấy
        }
        static void Main(string[] args)
        
        {
            //UseDoSomethingDelegate(); //main gọi
            UseActionDelegate();
        }
    }
}