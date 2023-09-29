using System.Security.Cryptography;

namespace Geometric.Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //PlayWithRectangle();
            SortShape();
        }

        static void SortShape()
        {
            //hãy sắp xếp theo thứ tự tăng dần của diện tích của 2 tròn, 2 cn
            //MÚN SẮP XẾP THÌ PHẢI CHUNG MẢNG, CHUNG COLLECTION
            //MẢNG DÀNH CHO NHỮNG THẰNG CÙNG KIỂU/CÙNG DATA TYPE

            Rectangle r1 = new Rectangle() {Width = 5, Height = 6 , Name = "R1 56"}; //30
            Rectangle r2 = new Rectangle() { Width = 1, Height = 2, Name = "R2 12" }; //2
            Disk d1 = new Disk() {Radius = 2, Name = "D1 2" };//12.56
            Disk d2 = new Disk() { Radius = 1, Name = "D2 1" };//3.14

            Shape[] shapes = {r1, r2, d1, d2 };
            //khai báo mảng và gán 4 hình vào mảng
            //in mảng trước khi sort 
            Console.WriteLine("The array befort soring area:");
            foreach (Shape x in shapes)
            {
                Console.WriteLine(x.Name + " Area: " + x.GetArea());
                                    //                 Đa hình: gọi cha, nhưng 2 con hưởng 
                                    //                 1 cha có nhiều hành động khác biệt ở con
            }
            Console.WriteLine("The array after sorting by area ascending");
            for (int i = 0; i < shapes.Length - 1; i++) //for ngoài đến áp chót
            {
                for (int j = i + 1; j < shapes.Length; j++) //for cho đến chót
                {
                    if (shapes[i].GetArea() > shapes[j].GetArea()) 
                    { //phần tử thứ i mà lớn hơn phần tử thứ j thì đổi chỗ
                        Shape tmp = shapes[i];
                        shapes[i] = shapes[j];
                        shapes[j] = tmp;
                        
                    }
                }
            }

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i].Name + "| Area " + shapes[i].GetArea());
            }
        }



        static void PlayWithRectangle()
        {
            //khai báo các class con và tạo đối tương object hình chữ nhật:
            //có 2 cách khai báo: Khai cha, new Con
            //                    Khai con new con
            Rectangle r1 = new Rectangle(); // W L N D mang trị default
            Console.WriteLine("Rectangle 1 > W: " + r1.Width + " cm");
            Rectangle r2 = new Rectangle()
            {
                Width = 15,
                Height = 8,
                Name = "Rectangle 15|8",
                Description = ""
            };

            Console.WriteLine("Rectangle 2 -> W: " + r2.Width + " H: " + r2.Height + "| Area: " + r2.GetArea());

            //Khai Cha new Con
            //Shape r3 = new Shape(); //Cấm bên C#
            //Còn bên Java là Anonymous Class

            Shape r3 = new Rectangle() {Width = 10, Height = 10 };
            //vietsub: HCM r3 là HH, đem dòng họ ra hù

            Console.WriteLine("Rectangle 3 => W: " + ((Rectangle)r3).Width + " H: " + ((Rectangle)r3).Height + "| Area: " +r3.GetArea());

            //Rectangle r4 = ((Rectangle)r3);
            //Console.WriteLine("Rectangle r4 cx la r3 -> W: " + r4.Width + "H: " + r4.Height + " Area: " + r4.GetArea());

           // Rectangle r5 = new Shape() { };
            //Viết khai con rồi new cha => Lệ phí đổi ngành có niêm yết từng kì trong FAP
            //vietsub : Hình học là HCM
            //KẾ THỪA CHỈ ĐỌC 1 CHIỀU, 'IS A' CHỈ ĐỌC 1 CHIỀU
            //HV LÀ HCN, LÀ HH
            //HH LÀ HTR ĂN ĐÒN
            //HH LÀ HCN ĂN ĐÒN

        }
    }
}