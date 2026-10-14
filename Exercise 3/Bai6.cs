/*Bài 6: Chuẩn Hóa Họ Tên Người Dùng & Tự Động Tạo Email/Username 
Tình huống thực tế: Bộ phận Nhân sự (HR) cần một công cụ xử lý dữ liệu thô nhập vào từ biểu mẫu đăng 
ký. Họ tên nhập vào thường bị lỗi thừa khoảng trắng, hoa thường lộn xộn. Cần chuẩn hóa tên và tạo tài 
khoản công ty. 
Kiến thức trọng tâm: Kiểu string, các phương thức Trim(), Split(), Substring(), ToLower(), ToUpper(), 
string.Join(). 
Yêu cầu bài toán: 
• Nhập vào một chuỗi họ tên thô từ bàn phím (Ví dụ: "   ngUYỄN   vĂn   aN   "). 
• Loại bỏ khoảng trắng thừa ở đầu, cuối và giữa các từ (chỉ giữ lại 1 khoảng trắng giữa các từ). 
• Chuyển đổi chuỗi thành dạng Viết Hoa Chữ Cái Đầu Mỗi Từ (Title Case): "Nguyễn Văn An". 
• Tách thành Họ, Tên Đệm và Tên chính. 
• Tạo Username không dấu theo quy tắc: ten.hovatenm. (Ví dụ: an.nguyenvan). 
• Tạo Email công ty: username + "@company.edu.vn".*/
class Bai6
{
    public static void Run()
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Bài 6: Chuẩn Hóa Họ Tên Người Dùng & Tự Động Tạo Email/Username");
        Console.WriteLine();

        string? input = Console.ReadLine()?.Trim().ToLower();
        string[] word = input?.Split()


    }
}

