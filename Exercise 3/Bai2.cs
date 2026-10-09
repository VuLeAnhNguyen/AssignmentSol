/*
Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe 
Tình huống thực tế: Một ứng dụng theo dõi sức khỏe cá nhân cần tính chỉ số khối cơ thể (BMI - Body Mass 
Index) dựa trên chiều cao và cân nặng do người dùng cung cấp, đồng thời đưa ra lời khuyên về cân nặng lý 
tưởng. 
Kiến thức trọng tâm: Kiểu double, ép kiểu, Math.Pow(), định dạng số thập phân ({0:F2}), cấu trúc rẽ nhánh. 
Yêu cầu bài toán: 
• Nhập vào chiều cao (tính bằng mét, ví dụ 1.72) và cân nặng (tính bằng kg, ví dụ 68.5). 
• Tính chỉ số BMI theo công thức: BMI = Cân nặng / (Chiều cao ^ 2). 
• Phân loại tình trạng sức khỏe theo chuẩn WHO dành cho người châu Á: 
•   + BMI < 18.5: Gầy (Thiếu cân) 
•   + 18.5 <= BMI < 23.0: Bình thường (Lý tưởng) 
•   + 23.0 <= BMI < 25.0: Thừa cân (Tiền béo phì) 
•   + BMI >= 25.0: Béo phì 
• Tính dải cân nặng lý tưởng cho chiều cao đó (Cân nặng tối thiểu = 18.5 * Chiều cao^2; Cân nặng tối đa = 
22.9 * Chiều cao^2). 
• Xuất ra chỉ số BMI (lấy 2 chữ số thập phân), phân loại và khoảng cân nặng lý tưởng. 
*/
class Bai2
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe");

        Console.WriteLine("Nhập chiều cao (mét): "); double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhập cân nặng (kg): "); double weight = double.Parse(Console.ReadLine());

        double indexBMI = weight / (Math.Pow(height,2));
        string category = "";

        if (indexBMI < 18.5)
        {
            category = "Gầy (Thiếu cân)";
        }
        else if (indexBMI <23)
        {
            category = "Bình thường (Lý tưởng)";
        }
        else if (indexBMI <25)
        {
            category = "Thừa cân (Tiền béo phì)";
        }
        else
        {
            category = "Béo phì";
        }

        double suggestMaxWeight = 18.5 * Math.Pow(height, 2),
               suggestMinWeight = 22.9 * Math.Pow(height, 2);

        Console.WriteLine($"Chỉ số BMI: {indexBMI:N}");
        Console.WriteLine($"Phân loại sức khỏe: {category}");
        Console.WriteLine($"Lời khuyên: Cân nặng lí tưởng của bạn nên từ {suggestMinWeight:N} kg đến {suggestMaxWeight:N} kg");
    }
}

