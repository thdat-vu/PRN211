namespace DatVT.Dll.Usage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tính giai thừa bằng thư viện mình tự viết");
            Console.WriteLine("5! = " + MathUtility.Math.MathUtility.GetFactorial(5));
        }
    }
}