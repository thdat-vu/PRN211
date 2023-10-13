using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Datvt.Delegate.Lambda
{
    /// <summary>
    /// Hàm đại diện nhận 2 tham số đầu vào trả về 1 giá trị mà không quan tâm việc tính toán 
    /// bên trong
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    delegate double TwoNumbersComputation(double x, double y);
    internal class Program
    {   
        /// <summary>
        /// Hàm tính toán nhận 2 tham số đầu vào là chiều rộng và chiều dài
        /// trả về diện tích hình chữ nhật
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static double ComputeRectangleArea(double width, double height) => width * height;
        
        /// <summary>
        /// Hàm tính toán với 2 giá trị đầu vào là chiều dài và chiều rộng
        /// trả về diện tích hình chữ nhật
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static double CouputeRectanglePerimeter(double width, double height) => (width + height) * 2;
        
        
        /// <summary>
        /// hàm tính toán nhận 2 tham số là cạnh đáy và chiều cao
        /// trả về diện tích hình tam giác
        /// </summary>
        /// <param name="baseEdge"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static double TriangleArea(double baseEdge, double height) => baseEdge * height / 2; 
        static void Main(string[] args)
        {
            //khai báo delegate
            TwoNumbersComputation f = ComputeRectangleArea;
            Console.WriteLine("Area of Rectangle: " +  f(20, 12));

            //viết lại hàm ComputeRectangleArea bằng anonymous function:
            f = delegate (double x , double y) { return (x + y) * 2; };
            Console.WriteLine("The Perimeter of the Rectangle written by anonymous function: " + f(5, 6));
            //viết lại hàm ComputeRectangleArea bằng lambda:
            f = (x, y) => x * y /2 ;
            Console.WriteLine("The Perimeter of the Triangle written by lambda expression: " + f(7,9));
        }
    }
}