namespace DatVT.MathUtility.Math
{
    /// <summary>
    /// Class này dùng để lưu trữ 1 điểm trong tọa độ 2 chiều x y
    /// </summary>
    public class Point
    {
        public Double X { get; set; }
        public Double Y { get; set; }
    }

    /// <summary>
    /// Class này dùng để chứa các hàm toán học hay dùng và 1 số tính toán mở rộng
    /// </summary>
    public class MathUtility
    {
        /// <summary>
        /// Hằng số PI trong tính toán diện tích chu vi hình tròn
        /// </summary>
        public const Double PI = 3.14; // mặc định const public sẽ đc xem là STATICs
        
        /// <summary>
        /// Hàm này để tính n giai thừa = 1.2.3...n Không có giai thừa cho số âm
        /// </summary>
        /// <param name="n"> phải nằm trong khoảng từ 0..20 . Vượt 20 bị tràn kiểu long</param>
        /// <returns>hàm trả về tích 1.2.3..n 0! = 1</returns>
        public static long GetFactorial(int n)
        {
            if (n < 0 || n > 20)
                throw new ArgumentException("n must be between 0..20 please!");
            if(n == 0 || n == 1)
            {
                return 1;
            }

            return n * GetFactorial(n - 1); // dùng đệ quy - gọi lại chính mình với quy mô nhỏ hơn
                                            //recursion
        }
    }
}