using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric.Shapes
{
    internal abstract class Shape
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public abstract double GetArea();
    }//một class chứa hàm abstract thì bắt buộc nó phải là abstract 
    //chữ abstract ở class sẽ ngăn việc new, vì nó là khái niệm
    //new nó, rồi chấm cái abstract method làm gì giờ vì làm  gì có code??????\
    
    //viet class ke thua Shape o day
    //abstract class Rectangle : Shape

    class Rectangle : Shape
        //tại sao lại có dòng bị báo đỏ, vì nó ko implement hết các abstract method
    {
        public double Width { get; set; }
        public double Height { get; set; }
        //@Override
        public override double GetArea()
        {
            return Width * Height;
        }
    }
}

//class abstract chỉ nói về ý  tưởng, ko nói về thực thi\
//nó chỉ đại diện cho nhóm những object kiểu khái niệm mà thôi
//hình học là khái niệm
//thú cưng là khái niệm
//khi nói về khái niệm, ta chỉ nói ý thôi
//ko có phiên bản đời thật, mang ý nghĩa phân nhóm, phân loại
//classify