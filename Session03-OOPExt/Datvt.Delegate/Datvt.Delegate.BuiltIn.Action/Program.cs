using System.Threading.Channels;

namespace Datvt.Delegate.BuiltIn.Action
{
    internal class Program
    {

        static void SayHello(string msg, int number)
        {
            Console.WriteLine($"From SayHello(), msg: {msg}, number : {number}");
        }
        //nếu khai báo delegate thì sẽ là 
        delegate void FMessage(string msg, int number);

        //NHƯNG .NET ĐÃ CUNG CẤP CÁI DELEGATE CÓ SẴN TÊN LÀ ACTION
        //Action<tham số 1, tham số 2>
        //delegate void FMessage(string msg, int number);
        //delegate void Action  <string ,    int        >;
        
        static void Main(string[] args)
        {
            //ko thèm xài delegate tự làm, ta xài Action có sẵn
            //Action<string, int> sẵn con trỏ vào hàm có đầu vào(string, int)
            Action<string, int> f = SayHello;
            f += (msg, num) => Console.WriteLine($"msg: {msg}, num: {num}");
            f("Ngọc Trinh", 4_800_000);
        }
        
        
        //static void Main(string[] args)
        //{
        //    FMessage f = SayHello;
        //    f += (msg, number) => Console.WriteLine($"msg: {msg}, num: {number}");
        //    f("Ngọc Trinh", 4_800_000);
            
        //}

    }
}