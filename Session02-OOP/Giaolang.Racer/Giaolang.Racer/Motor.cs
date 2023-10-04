using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaolang.Racer
{
    internal class Motor : DeathRacer
    {
        public string Name { get; set; }
        public double Volumn { get; set; }
        public string PlateNumber { get; set; }
        //tốc độ chạy trên đường phố
        //expression bodies
        //ko nhầm lẫn vs lambda expression học sau!!
        public double Run() => new Random().NextDouble() * 120;

        public double RunToDeath() => Run() * 3;
       
        //{   
        //Random random = new Random(); //tạo ra máy sinh số ngẫu nhiên
        //                              //giống như máy ném trái banh ngẫu nhiên cho việc 
        //                              //luyện tập phản xạ
        //                              //MáyNgẫuNhiên có hành động thảy ra ngẫu nhiên
        //                              //con số, trái banh, tọa độ.
        //double speed = random.NextDouble() * 120; // con số ngẫu nhiên 0,... < 120 
        //return speed;
        //return new Random().NextDouble() * 120;
        //}
    }
}
