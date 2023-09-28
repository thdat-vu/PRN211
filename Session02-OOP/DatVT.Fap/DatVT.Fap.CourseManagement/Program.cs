using System.Xml.Serialization;

namespace DatVT.Fap.CourseManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //AddNewCourse();
            //PlayWithArray();
            //PlayCourseList();
            PlayWithGenericCollections();

        }

        /// <summary>
        /// thử nghiệm chơi vs collection có sẵn trong .NET
        /// GIỐNG NHƯ CHƠI VS COLLECTIONS TRONG JAVA
        /// COLLECTIONS LÀ TẬP HỢP CỦA NHỮNG CLASS - TÚI - THÙNG CHỨA BÊN TRONG
        /// CÁC MÓN ĐỒ - OBJECT
        /// NHÉT ĐỒ VÀO TRONG, THƯỜNG GỌI LÀ ADD() PUT()
        /// LẤY ĐỒ RA KHỎI TÚI, BỎ ĐI, THƯỜNG GỌI LÀ REMOVE(), DELETE()
        /// LẤY RA XEM RỒI BỎ VÀO TRỞ LẠI [VỊ TRÍ] GÉT(VỊ TRÍ), VIEW()
        /// TÚI CÓ 2 LOẠI: CHỈ ĐỰNG LUNG TUNG, HỖN T ẠP
        /// TÚI CHỈ ĐỰNG 1 LOẠI ĐỒ: TÚI GENERIC <LOẠI MÓN GÌ>
        /// </summary>

        public static void PlayWithGenericCollections()
        {
            List<Course> list = new();
            //list hàng chuẩn của .NET có sẵn khi cài .NET, VS
            //Java phải viết thế này.
            //List<Course> list2 = new ArrayList<Course>();
            //Java ko new List() vì List abstract/interface
            Course prn211 = new Course()
            {
                Id = "PRN211",
                Name = "Cross-platform Programming with C#",
                Credits = 3
            };
            list.Add(item: prn211); // name arguement, truyền tham số cho hàm và ghi luôn tham số cho rõ nghĩa
            list.Add(item: new Course()
            {
                Id = "SWP301",
                Name = "Software Mini Capstone",
                Credits = 3
            });
            list.Add(item: new Course()
            {
                Id = "SWT301",
                Name = "Software testing",
                Credits = 3
            });

            //in 3 món, dùng for bình thường
            Console.WriteLine("There is /are "+list.Count +" course(s) in the list: ");
            foreach(Course x in list)
            {
                Console.WriteLine(x);

            }//in 1 biến object thì mặc định sẽ đi gọi .ToString()
            //ko cần ghi là .ToString() nếu mún gọi hàm này

            //in List theo kiểu mảng xem sao
            Console.WriteLine("Print the list by using list[] like array");
            for (int i = 0; i < list.Count; i++)
            {   

                Console.WriteLine(list[i]);
            }
        }
        public static void PlayCourseList()
        {
            //mình sẽ dùng class List<T> vừa tạo
            //với T là Course, danh sách môn học
            MyList<Course> list = new();
            Course prn211 = new Course()
            {
                Id = "PRN211",
                Name = "Cross-platform Programming with C#",
                Credits = 3
            };
            list.AddNew(obj: prn211); // name arguement, truyền tham số cho hàm và ghi luôn tham số cho rõ nghĩa
            list.AddNew(obj: new Course()
            {
                Id = "SWP301",
                Name = "Software Mini Capstone",
                Credits = 3
            });
            list.AddNew(obj: new Course()
            {
                Id = "SWT301",
                Name = "Software testing",
                Credits = 3
            });
            list.PrintAll();
        }

        //hàm nhỏ để biết về mảng
        //mảng là object, biến mảng sẽ trỏ 1 vùng new bự
        //chứa bên trong nó các phần tử mảng, value gì đó
        //biến mảng CHẤM XỔ RĂ NHỮNG ĐẶC TÍNH CỦA MẢNG, VÍ DỤ LENGTH
        //DÙNG [SỐ THỨ TỰ PHẦN TỬ ĐẾM TỪ 0]
        //FOR TRUYỀN THỐNG NHƯ BÊN JAVA
        public static void PlayWithArray()
        {
            //int[] list = new int[10]; list[0] = 5; list[1] = 10;.....

            int[] list = { 1, 2 }; // new ngầm
            int[] list2 = new int[4] { 1, 2, 3, 4 };
            //xin 4 gán 4

            //in mảng
            Console.WriteLine("the array has value of");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("");
            foreach (int x in list2)
            {
                Console.Write(x + " ");
            }
        }
        public static void AddNewCourse()
        {
            //tạo mới 1 môn học, nhập từ bàn phím
            //new hard-code

            Course c1 = new Course() { Id = "PRN211", Name = ".NET Cross Platform", Description = "!!!!!", Credits = 3, };
            c1.PrintCourseInfo();

            //Khai báo biến lẻ để nhạp từ bàn phím, sau đó new
            //biến cục bộ của hàm, quy tắc đặt tên là con Lạc Đà
            string id, name, description;
            int credit;

            Console.WriteLine("input the course info");
            Console.Write("ID: "); //in và không xuống hàng
            id = Console.ReadLine();
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Description: ");
            description = Console.ReadLine();

            //mặc định nhập từ bàn phím vào luôn là string, dù yêu cầu gõ số
            //vậy ta cần convert về số như Java

            Console.WriteLine("Credit: ");
            credit = Convert.ToInt32(Console.ReadLine());
            //tương đương Integer.parseInt(chuỗi đưa vào);

            //new nào
            Course c2 = new Course() { Id = id, Name = name, Credits = credit, Description = description };
            c2.PrintCourseInfo();
        }
    }
}