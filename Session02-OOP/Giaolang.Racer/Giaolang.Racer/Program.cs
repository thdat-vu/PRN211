namespace Giaolang.Racer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor ex1 = new Motor()
            {
                PlateNumber = "53F1 04953",
                Name = "SH Italia 350 ABS 2020"
            };

            Console.WriteLine("SH speed: " + ex1.Run());
            Console.WriteLine("SH speed speed as a racer:  " + ex1.RunToDeath());

            //VÀ GIỜ TA CHO XE MÁY ĐI ĐUA, ĐỘ LẠI, ĐÔN NÒNG ĐÔN DÊN

            DeathRacer win = new Motor();
            Console.WriteLine("Winner speed as a racer: " + win.RunToDeath());
            //mún xe đi học, tốc độ bình thường thì phải kéo con trỏ win xuống đáy vùng new.

            //chuyện nhớ nha: 
            //KHAI BÁO CHA - NEW CON: VÙNG NHỚ TRỎ TỚI CHA DÙ DUNG LƯỢNG SINH RA LÀ CÓ CẢ CON
            Console.WriteLine("Winner speed as a normal: " + ((Motor)win).Run());
        }
    }
}