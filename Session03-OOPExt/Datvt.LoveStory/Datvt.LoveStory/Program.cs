namespace Datvt.LoveStory
{

    //Đây là 1 dạng class đặc biệt; chứa info là TÊN CỦA CÁC HÀM NÀO ĐÓ tồn tại ngoài kia
    //khác hoàn toàn interface và abstract class CHỨA HÀM CÓ CODE, KO CODE VÀ CẦN
    //IMPLEMENT 
    //1 danggj class đặc biệt này chứa info là TÊN CỦA CÁC HÀM ĐÃ Ở ĐÂU ĐÓ
    //TRONG CÁC CLASS KHÁC, CLASS NÀY NẰM DANH SÁCH CÁC HÀM NƠI KHÁC
    //                            THAM CHIẾU ĐẾN CÁC HÀM NƠI KHÁC
    //                            TRỎ ĐẾN CÁC HÀM NƠI KHÁC
    //BẢNG PHONG THẦN, NIÊM YẾT, THÔNG BÁO CÓ CÁC HÀNH ĐỘNG GÌ ĐÓ Ở ĐÂU ĐÓ
    //CODE CÓ ĐÂU ĐÓ RỒI
    //[CÒN CÓ 1 TRÒ, TRỎ ĐẾN CÁI HÀM ON-THE-GO, TAKE-AWAY -> ANONYMOUS FUNCTION, LAMBDA]
    public delegate void BoCauDuaThu();
    //                   đại diện cho tất cả các hàm void trên đời này và ko đầu vào
    //                   do đó 2 hàm TellHer() GuiEm() thỏa tiêu chí BoCauDuaThu
    //LOẠI BẢNG TIN CHỨA TẤT CẢ CÁC HÀM VOID F(VOID)
    internal class Program
    {
        static void Main(string[] args)
        {
            BoCauDuaThu ThangKia = Tui.tellHer;
            ThangKia += Ban.NhanEm;
            ThangKia();
        }
    }
}

//3 chàng trai và 1 cô gái chơi thân với nhau
//Tui, Bạn, Thằng kia, Cô ấy
//Tôi yêu cô ấy -> chia tay, kẻ thủ - cô ấy ko mún nhìn mặt tui
//Bạn yêu cô ấy -> chia tay, kẻ thủ - cô ấy ko mún nhìn mặt tui

//HIỆN NAY: THằng kia đang yêu cô ấy
//3 thằng vẫn chơi với nhau. Bạn thân
//Một ngày thằng kia nói rằng đi gặp cô ấy
//Tui và bạn muốn nói với cô ấy vài câu, nhưng nói trực tiếp ko được, nhờ
//Tui muốn nói, nhưng ko gặp trực tiếp được, "Cuộc sống em ổn không???"
//Bạn Tui muốn nói, nhưng ko gặp trực tiếp được, "Chúc em hp bên người???"

//MÔ PHỎNG CÂU CHUYỆN NÀY TRONG C#