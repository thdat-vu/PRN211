using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaolang.Racer
{
    internal interface DeathRacer
    {
        //phàm đã là đua thủ, thì nhịm vụ là đua
        //ai mún là đua thủ, thì phải cam kết đua
        //đua thế nào, tùy mỗi đứa, nhưng phải đua, vì đã tham
        //đua thế nào: Bốc đầu, cà chân trống, tung mình, ...
        //mỗi đua thủ tự lo - IMPLEMENTS THEO CÁCH CỦA HỌ
        //ĐA HÌNH: Đua() đi, mỗi đứa tự đua() theo cách riêng
        //Hàm ĐUA() ở đây sẽ là ABSTRACT(), TAO NÓI Ý Z THÔI
        // CÒN MỖI ĐỨA HẾT MÌNH THẾ NÀO, TÙY
        public double RunToDeath(); //ko cần từ khóa abstract như bên 
                                    // class abstract, mặc định là vậy
                                    //TÁT CẢ AI THAM GIA ĐUA - CLASS "CON"
                                    //PHẢI IMPLEMENTS
                                    
        //một class nào đó (concrete) chỉ có tối đa 1 class cha - kế thừa
        //nhưng có thể tham gia vào N Interface - CLB 
        //Mỗi người chỉ có 1 dòng họ - ba mẹ
        //và có thể tham gia nhiều CLB - HỘI NHÓM

        //JAVA: Motor extends Cha implements DeathRacer {}
        //Motor extends Vehicle implements DeathRacer

        //C#: Motor : Cha, DeathRacer {}
        //    Motor: Vehicle, DeathRacer


    }
}
