namespace Datvt.Delegate.InsideOut
{
    //một cái tên đại diện cho 3 hàm, và còn nhiều hơn thế các hàm cùng signature
    delegate void FDelegate(int x);
    internal class Program
    
    {
        /// <summary>
        /// Nhận vào tham số x trả về x
        /// </summary>
        /// <param name="x"></param>
        static void F1(int x)
        {
            Console.WriteLine("Call F1() with x = " + x);
        }

        /// <summary>
        /// Nhận vào 1 tham số x và trả về x^2
        /// </summary>
        /// <param name="x"></param>
        static void F2(int x)
        {
            Console.WriteLine("Call F2() with x^2 = " + Math.Pow(x, 2));
        }
        
        /// <summary>
        /// Nhận vào 1 tham số hàm là x và trả về x^3
        /// </summary>
        /// <param name="x"></param>
        static void F3(int x)
        {
            Console.WriteLine("Call F3() with x^3 = " + Math.Pow(x, 3));
        }
        static void Main(string[] args)
        {
            FDelegate f = F1; // dấu() thì là gọi hàm, trong khi đây mới chỉ là trỏ tới hàm
            f(42);
            //f hay hơn biến thường, nó có thể trỏ cùng lúc nhiều hàm hơn bằng toán tử +=
            f += F2;
            f += F3;
            //giờ ta gọi cùng lúc cả 2 hàm đi.
            f(12);

            //muốn f trỏ đến hàm F4(int x) trả về x^4, thì cách truyền thống, ta phải tạo hàm F4()
            //riêng rồi gán f = F4()
            //thì giờ tạo hàm ON-THE-GO, TAKE-AWAY. Đây là anonymous function
            f += delegate (int x)
            {
                Console.WriteLine("Anonymous method F4() x^4: " + Math.Pow(x, 4));
            };
            Console.WriteLine("Invoke functions with x = 30");
            f(30);
            //nâng cấp tiếp tục anonymous method
            //f = delegate (int x) { Console.WriteLine("anonymous method x^5: " + Math.Pow(x, 5)); };
            //f = (int x) => { Console.WriteLine("anonymous method x^5: " + Math.Pow(x, 5)); };
            f(2);
            //vì sao chỗ này nó chỉ chạy mỗi hàm lambda mà ko chạy 4 hàm còn lại???
            //xin thưa vì dùng 54 55 là phép gán ko phải phép cộng bằng
            //sau dòng 54 và dòng 55 biến f từ giá trị F1() + F2() + F3() + F4() 
            //trờ thành giá trị của f = anonymous expression ở trên.

            ////LAMBDA EXPRESSION - Kỹ thuật rút gọn 1 hàm ẩn danh đến mức tối thiểu
            f = x => { Console.WriteLine("Anonymous method  x^5 = " + Math.Pow(x, 5)); };
            //bên C# cái lambda là => chứ ko phải là -> NHA NHA NHA
            //triển thôi
            f(54);
        }
    }
}