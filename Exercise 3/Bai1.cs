/* 
Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang (EVN) 
Tình huống thực tế: Tập đoàn Điện lực Việt Nam (EVN) áp dụng biểu giá điện sinh hoạt bậc thang lũy tiến 
để khuyến khích người dân tiết kiệm điện. Hãy viết chương trình tính hóa đơn tiền điện hàng tháng cho một 
hộ gia đình. 
Kiến thức trọng tâm: Kiểu decimal, ép kiểu dữ liệu, định dạng tiền tệ ({0:C} hoặc #,##0 VNĐ), tính toán toán 
học. 
Yêu cầu bài toán: 
• Nhập vào chỉ số điện cũ (kWh) và chỉ số điện mới (kWh). Kiểm tra điều kiện chỉ số mới phải lớn hơn hoặc 
bằng chỉ số cũ. 
• Tính lượng điện tiêu thụ trong tháng = Chỉ số mới - Chỉ số cũ. 
• Tính tiền điện theo các bậc giá chưa thuế (Giá giả định năm 2026): 
•   + Bậc 1: Cho 50 kWh đầu tiên (từ 0 - 50 kWh): 1.806 VNĐ/kWh 
•   + Bậc 2: Cho 50 kWh tiếp theo (từ 51 - 100 kWh): 1.866 VNĐ/kWh 
•   + Bậc 3: Cho 100 kWh tiếp theo (từ 101 - 200 kWh): 2.167 VNĐ/kWh 
•   + Bậc 4: Cho 100 kWh tiếp theo (từ 201 - 300 kWh): 2.729 VNĐ/kWh 
•   + Bậc 5: Cho toàn bộ kWh từ 301 kWh trở lên: 3.050 VNĐ/kWh 
• Cộng thêm 8% Thuế Giá trị gia tăng (VAT). 
• In hóa đơn chi tiết gồm: Số kWh tiêu thụ, Tiền điện chưa thuế, Tiền thuế VAT và Tổng tiền phải thanh toán 
<<<<<<< HEAD
(làm tròn đến hàng đơn vị decimal).
*/
class Bai1
{
    public static void Run()
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang (EVN)");
        Console.WriteLine("Nhập số điện cũ  (kWh): "); int oldIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số điện mới (kWh): "); int newIndex = int.Parse(Console.ReadLine());
        if (oldIndex > newIndex)
        {
            Console.WriteLine("Số điện mới phải lớn hơn số điện cũ");
            return;
        }
        decimal consumption = (newIndex - oldIndex);
        decimal cost = 0;

        decimal b1 = 1.806m;
        decimal b2 = 1.866m;
        decimal b3 = 2.167m;
        decimal b4 = 2.729m;
        decimal b5 = 3.050m;

        if (consumption <= 50)
        { cost = consumption * b1; }
        else if (consumption <= 100)
        { cost = (50m * b1) + (consumption - 50) * b2; }
        else if (consumption <= 200)
        { cost = (50 * b1) + (50 * b2) + (consumption - 100) * b3; }
        else if (consumption <= 300)
        { cost = (50 * b1) + (50 * b2) + (100 * b3) + (consumption - 200) * b4; }
        else
        { cost = (50 * b1) + (50 * b2) + (100 * b3) + (100 * b4) + (consumption - 300) * b5; }

        decimal vat = cost * 0.08m;

        Console.WriteLine($"Số kWh tiêu thụ {consumption} kWh");
        Console.WriteLine($"Tiền điện chưa thuế {cost:N}k VND");
        Console.WriteLine($"Thuế: {vat:N}K VND");
        Console.WriteLine($"Tổng tiền phải thanh toán {vat + cost:N}k VND");
    }
}