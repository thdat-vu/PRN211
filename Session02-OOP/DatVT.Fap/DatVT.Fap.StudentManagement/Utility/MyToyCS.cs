using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.Fap.StudentManagement.Utility
{

    /// <summary>
    /// Class này chúa các hàm dùng cho cho mọi nơi, 
    /// ko nhớ nhung riêng lẻ nào c ả, làm xong return luôn
    /// Và này là static class
    /// Static class ko cho phép tồn tại hàm non-static
    /// </summary>
    internal static class MyToyCS
    {
        //public void SayHello()
        //{

        //} //bị chủi vì hàm này là non-static, instance member
        //hàm ăn theo vùng new thì ko vào class này đc

        public const double PI = 3.1415;
        public const double Vat = 0.08;
        public static int c = 300_000; // dấu "_" phân cách phần ngàn
        
        /// <summary>
        /// hàm tính n!
        /// 0! = 1! = 1
        /// n! = 1.2.3..n
        /// 20! là vừa đủ kiểu long, 21! long chứa ko nổi
        /// </summary>
        /// <param name="n"></param>
        /// <returns>long</returns>
        public static long GetFactorial(int n)
        {
            if(n < 0 || n > 20)
            {
                throw new ArgumentException("Please supply n in the range of 0 to 20");
            }
            if(n == 0 || n == 1)
            {
                return 1;
            }
            long result = 1; //giai thừa khỏi đầu = 1

            for(int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        

    }
}

//ko bao giờ/ tuyệt đối KHONG DÙNG STATIC CHO NHỮNG BIẾN/PROPERTY, HÀM
//MÀ NÓ MÔ TẢ ĐĂC TÍNH, HÀNH XỬA CỦA TỪNG OBJECT 
//CÁI GÌ ANW THEO OBJECT THÌ KO ĐC LÀ STATICSSS
// VÍ DỤ tên ngườ, nam sinh, mã só là ăn wtheo từng người -> non
//KHI NÀO DÙNG STATIC
//KHI TA CÓ NHỮNG THỨ XÀI CHUNG GIỮA CÁC OBJECT, NHỮNG TOOL VÀ 
//CÔNG CỤ / HÀM XỬ LÝ RỒI RETURN. KO LƯU TRỮ VÀO ĐÂU, THÌ LÀ STATIC
//ví dụ : các hàm toán học, các tính tóa trar về giá trị rồi thôi
//TA HAY ĐẶT NHỮNG THỨ DÙNG CHUNG NÀY VÀO 1 CLASS RIÊNG BIỆT
//DẠNG LÀ UTITLITY, TOOL, ĐỒ NGHỀ DÙNG CHUNG
