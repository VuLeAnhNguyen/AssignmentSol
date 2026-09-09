namespace Exercise_3
{
    internal class B2
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 2: Hệ Thống Theo Dõi Chỉ Số BMI & Đánh Giá Tình Trạng Sức Khỏe");
            Console.WriteLine("---Input---");
            Console.Write("Nhập chiều cao (m): ");
            double chieuCao = double.Parse(Console.ReadLine());
            Console.Write("Nhập cân nặng (kg): ");
            double canNang = double.Parse(Console.ReadLine());
            Console.WriteLine("---Output---");
            double bmi = canNang / Math.Pow(chieuCao, 2);
            Console.WriteLine($"Chỉ số BMI: {Math.Round(bmi, 2)}");
            if (bmi < 18.5)
            {
                Console.WriteLine("Phân loại khỏe: Gầy");
            }
            else if (bmi < 23)
            {
                Console.WriteLine("Phân loại khỏe: Bình thường");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Phân loại khỏe: Thừa cân");
            }
            else
            {
                Console.WriteLine("Phân loại khỏe: Béo phì");
            }
            double bmiMin = 18.5 * Math.Pow(chieuCao, 2);
            double bmiMax = 22.9 * Math.Pow(chieuCao, 2);
            Console.WriteLine($"Khuyên dùng: {Math.Round(bmiMin, 2)}kg đến {Math.Round(bmiMax, 2)}kg."); // round .5 trap
        }

    }
}
