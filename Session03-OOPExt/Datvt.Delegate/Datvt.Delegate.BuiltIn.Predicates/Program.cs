using System.Reflection.Metadata.Ecma335;

namespace Datvt.Delegate.BuiltIn.Predicates
{

    //CÓ 2 LOẠI HÀM: TAR VỀ GIÁ TRỊ, VÀ KO TRẢ VỀ GIÁ TRỊ
    //.NET TẠO SẴN CHO TA 2 LOẠI DELEGATE TƯƠNG ỨNG LÀ FUNC VÀ ACTION
    //ACTION<TỐI ĐA 16 THAM SỐ ĐẦU VÀO>
    //FUNC<TỐI ĐA 16 THAM SỐ ĐẦU VÀO, ĐẦU RA>

    //Func(string, string ,int, double)
    //                  -> hàm nhận 3 đầu vào (string, string, int) return double

    //.NET TÁCH RIÊNG 1 DELEGATE TRẢ VỀ GIÁ TRỊ VÌ TÍNH CHẤT QUAN TRONAGJ CỦA LOẠI
    //HÀM NÀY
    //CÓ 1 HÀM NHẬN VÀO 1 THAM SỐ, TRẢ VỀ KIỂU BOOL
    //Func<?, bool>
    //Predicate(nhận 1 đầu vào, trả về kiểu boolean)

    //tui có 1 hàm nhận vào 1 con số, trả về xem con số đó có lớn hơn 56 hay ko ??
    

    internal class Program
    {
        //static bool CheckGt56(int num)
        //{
        //    if(num >= 56)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //static bool CheckGt56(int num)
        //{
        //    return (num >= 56);
        //}
        static bool CheckGt56(int num) => num >= 56;

        //TRỎ HÀM NÀY = 3 CÁCH
        //C1: TỰ TẠO DELEGATE 
        delegate bool CheckHang(int num); // dùng sau đó CheckHang = CheckGt56;

        static void Main(string[] args)
        {
            CheckHang chk = CheckGt56;
            Console.WriteLine("Ngọc Trinh > 56? " + chk(70)); // true

            Func<int, bool> chk2 = CheckGt56;
            Console.WriteLine("Ngọc Trinh > 56? " + chk2(50)); // false

            Predicate<int> chk3 = CheckGt56;
            Console.WriteLine("Ngọc Trinh 45 > 56? " + chk3(45)); //False

            //đẳng cấp anonymous
            Predicate<int> chk4 = delegate (int num)
            {
                return num > 56;
            };

            //đẳng cấp lambda
            Predicate<int> chk5 = num => num > 56;

            Console.WriteLine("ckh5 (100)? true:false    " + chk5(100));
        }
    }
}