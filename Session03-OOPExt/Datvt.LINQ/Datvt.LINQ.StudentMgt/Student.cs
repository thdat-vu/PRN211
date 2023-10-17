using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datvt.LINQ.StudentMgt
{
    internal class Student
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }

        public override string? ToString()
        {
            return Id + " | " + Name + " | " + Yob + " | ";
        }
        //thay vì hàm nhận vào biến bình thường int long string 
        //hay 1 object nào đó, ta nhận vào 1 delegate, tức là đứng
        //ở SV NHƯNG SẼ TRỎ HÀM Ở NƠI XA
        //MAI MỐT MÚN SV LÀM GÌ, THÌ TRUYỀN HÀM ĐÓ THÔNG QUA DELEGATE
        //KĨ THUẬT MỞ RỘNG KHẢ NĂNG CỦA 1 CLASS

        public void DoExtraodinary(Action doSomething)
        {
            Console.WriteLine("For now, I will do something " +
                "as a a style of 'Ơ mây zing gút job em'");
            doSomething();
        }

        public void DoComputation(Func<int, long> doCalculation, int n)
        {
            Console.WriteLine("For now, I will compute something on " + n);

            Console.WriteLine("Result: "+doCalculation(n)); 
        }
    }
}
