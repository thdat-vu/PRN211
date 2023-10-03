using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datvt.Geometric.Shape.V2_
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area => Width * Height;

        public Rectangle(double width, double height, string name, string description) : base(name, description)
        {
            
            Width = width;
            Height = height;
        }//base(,,,) chính là gọi ctor của class cha
        //new Con bản chất bên trong là phải new Cha, có Cha rồi mới làm bệ đỡ cho Con
    }
    //VUÔNG  LÀ HCN VÀ LÀ HH, CHO NÊN CÓ 2 CÁCH KẾ THỪA
    //VUÔNG: SHAPE PHẢI CODE LẠI TÍNH S
    //VUONG : RECTANGLE , KO CẦN CODE LẠI S

    class Square : Rectangle
    {
        public Square(double edge, string name, string description) : base(edge, edge, name, description)
        {
            Edge = edge;
        }

        public double Edge { get; set;} 
    }
}
