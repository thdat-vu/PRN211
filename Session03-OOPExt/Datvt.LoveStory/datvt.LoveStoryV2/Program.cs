using System.Threading.Channels;

namespace datvt.LoveStoryV2
{
    internal class Program
    {
        //delegate liên quan đến tạo ra 1 kiểu dữ liệu mới
        //nó sánh ngang vai với class, interface
        //ví dụ: class Student là kiểu dữ liệu mới dùng lưu trữ các
        //Student x nào đó
        //An, Bình Cường, DŨng là các bạn Student nào đó -data type
        //Nếu mún nói  bạn cụ thể thì gọi bạn ấy là Student  x =???

        //Exciter, Winner, RGV, Kawasaki -> DeadRacer


        //DeadRacer win = con xe cụ thể nào đó
        //STYLE: Kiểu-dữ-liệu x = VALUE-cụ-thể;
        //                                          int
        //                                interface Delegate
        //                                class     Student
        //DELEGATE: TÊN GỌI CHO 1 ĐÁM HÀM delegate void F();
        //HÀM CỤ  THỂ NÀO ĐÓ                       F x = hàm-nào??
        //

        //delegate - class - interface ĐỂ TẠO RA KIỂU DỮ LIỆU MỚI, TẠO LƯU TÊN HÀM
        //NÓ ĐƯỢC QUYỀN KHAI BÁO Ở NGOÀI CLASS, TRONG NAMESPACE/PACKAGE.



        //TUI MUỐN ĐẶT TÊN GỌI CHUNG CHO 1 LOẠT CÁC HÀM STYLE VOID - VOID
        //                                                    KO NHẬN ĐẦU VÀO, KO ĐẦU RA

        //hàm bình thường void void
        static void SayHer() => Console.WriteLine("Cuoc song em o RMIT on ko???");
        static void TellHer() => Console.WriteLine("Chuc em hanh phuc o Phu Tho");
        static void TellThaoMai() => Console.WriteLine("Xa em anh phai hanh phuc");

        //DELEGATE BẮT ĐẦU, 3 hàm trên cùng style void F(void)  void F()

        //class Student{}
        delegate void F(); // nói về F là nói về n hàm cùng void void
                           //và còn những hàm void void khác chưa kịp nghĩ ra!!!!
                           //F đại diện cho tát cả các hàm void - void
                           //Có Kiểu Student, F, ta khai báo viến để nói về 1 cái cụ thể
                           //Next, ta khai báo biến để nói về 1 cái cụ thể nào đó
                           //thay vì int x = lưu con số
                           //thì giờ F = tên hàm - lưu tên hàm => TRỎ TỚI HÀM, CON TRỎ HÀM
    
        static int DoubleNumber (int x)
        {
            return x*2;
        }
        static int TripleNumber(int x)
        {
            Console.WriteLine("Run Tripple");
            return x * 3;
        }
        static int Subtract10(int x)
        {
            return x - 10;
        }
        static int DividedBy2(int x)
        {
            Console.WriteLine("Run Divided by 2");
            return x / 2;
        }
        //định nghĩa tên gọi chung cho đám hàm mới này
        delegate int CalculateNumber(int x); // đại diện cho 1 đám hàm int-int
        static void Main(string[] args)
        {
            //đẳng cấp thú cưng khi chơi vs CalculateNumber(int x)
            //hàm ẩn danh, tức là ko cần đưa tên hàm luôn
            //Chỉ cần có xử lý trên đầu vào là đc

            //CalculateNumber x = trỏ 1 hàm cụ thể nào đó kiểu là int f(int)
            //                    hàm này có sẵn ở đâu đó
            //                    hoặc làm ngay đây luôn
            
            CalculateNumber troHam = delegate (int x)
            {
                return (int)Math.Pow(10, x);
            };
            Console.WriteLine(troHam(3));
            //ĐẨY LÊN TỚI HẠN -EXHAUSTIVE
            troHam = x => (int)Math.Pow(10, x);
            //SUY NGHĨ THỬ XEM TẠI SAI KO CẦN ĐỊNH DẠNG INT Ở CHỖ (x)
            //LINQ

        }


        //static void Main(string[] args)
        //{
        //    //F x = Subtract10; // gẫy do khác style

        //    CalculateNumber x = new CalculateNumber(TripleNumber);
        //    //cách viết ngắn CalculateNumber x = DividedBy2;
        //    //x(10);  //phải in giá trị chứ vì hàm trả về value
        //    Console.WriteLine(DividedBy2(10)); //gọi trực tiếp như xưa nay
        //    Console.WriteLine(x(10));//gọi thông qua Delegate
        //    x += TripleNumber;
        //    Console.WriteLine("Two methods inside: ");
        //    Console.WriteLine(x(10));
        //    //x.Invoke(100);
        //    Console.WriteLine(x.Invoke(100));
        //}


        //static void Main(string[] args)
        //{   //in cùng lúc 3 hàm, 3 câu, gọi cả 3 vì đã ủy quyền, đã có đại diện

        //    F x = TellThaoMai;
        //    x += TellHer;
        //    x += SayHer; 
        //    //gọi hàm bằng cách TellThaoMai();  x()
        //    //x();
        //    //TellThaoMai();
        //    x();
        //}
    }
}