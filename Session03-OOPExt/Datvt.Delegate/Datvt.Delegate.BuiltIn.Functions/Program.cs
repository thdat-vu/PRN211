namespace Datvt.Delegate.BuiltIn.Functions
{
    internal class Program
    {
        //TA ĐỊNH NGHĨA VÀI HÀM CÓ TRẢ VỀ GIÁ TRỊ, SAU ĐÓ DÙNG
        //DELEGATE TỰ TẠO, VÀ DELEGATE CÓ SẴN - FUNC(có trả về)
        //                              CHỨ KO PHẢI LÀ ACTION(ko trả về - void)

        static int ComputeNumbers() => 5 * 5;
        static int SubtractNumbers() => 8 - 5;

        //tự khai báo delegate 
        delegate int FNumber();
        //.NET CHO Func<int>  // ÍT NHẤT TRONG INT PHẢI CÓ 1 DATA TYPE ĐẠI DIỆN CHO KIỂU DỮ LIỆU
        //TRẢ VỀ CỦA HÀM

        //NÂNG CAO ĐỘ KHÓ, TUI CÓ HÀM NHẬN VÀO 3 THAM SỐ INT, TRẢ VỀ TỔNG CỦA CHÚNG 
        //CHU VI TAM GIÁC (A, B, C) -> P
        //HÃY TÍNH CHU VI TAM GIÁC ĐÃ CHO MÀ KO ĐC GỌI TRỰC TIẾP HÀM TÍNH CHU VI
        //MÀ KO ĐC DÙNG DELEGATE CỦA MÌNH

        static int GetPerimeter(int a, int b, int c) => a + b + c;


        static void Main(string[] args)
        {
            Func<int, int, int, int> f = GetPerimeter;
            Console.WriteLine("Perimeter: " + f(3, 5, 7));
        }


        //static void Main(string[] args)
        //{
        //    FNumber f = SubtractNumbers;
        //    f(); // ko thấy gì vì hàm trả về giá trị mà ko chịu in ra
        //    Console.WriteLine("Call Substract: " + f());
        //    f += () => 30 - 40;
        //    Console.WriteLine("Call Substract Lambda: " + f());

        //    //tui ko thèm xài delegate của tui mà tui xài của .NET
        //    Func<int> ff = SubtractNumbers;
        //    Console.WriteLine("Call Substract by function: " + ff());
        //}
    }
}