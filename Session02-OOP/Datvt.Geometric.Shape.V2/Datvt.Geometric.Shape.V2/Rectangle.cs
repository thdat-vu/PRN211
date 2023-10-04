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
            //Edge = edge;
        }

        //public double Edge { get; set;} 
        //HV cạnh edge là HCN có 2 cạnh kề == nhau = edge
        //tồn tại 1 điều thú vị
        //khai báo 
        //Square s = new Square (5.0, "HV", "...")
        //s. chấm sẽ xổ ra các thứ đc thuafwf kế từ Cha Rectangele và Ông Shape
        //có vẻ rằng s sẽ ra Width, Heigth == nhau, bình thường
        //TODO: Nếu ta xét width = 10 chằng hạn, thì length hình như vẫn bằng 5
        //SUY NGHĨ THÊM XEM SAO??
        
    }
}
