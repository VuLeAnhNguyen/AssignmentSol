/*Bài 5: Quản Lý Điểm Học Phần & Quy Đổi Thang Điểm GPA (4.0) 
Tình huống thực tế: Hệ thống quản lý đào tạo đại học cần tính điểm trung bình tín chỉ (GPA) học kỳ cho 
sinh viên dựa trên điểm số các môn học và quy đổi sang thang điểm chữ (A, B, C, D, F) cùng thang điểm 4. 
Kiến thức trọng tâm: Kiểu float hoặc double, char, enum, ép kiểu điểm số, định dạng bảng xuất. 
Yêu cầu bài toán: 
• Nhập điểm số (thang 10, kiểu double) và số tín chỉ (int) của 3 môn học: Lập trình C#, Toán rời rạc, Tiếng 
Anh. 
• Tính điểm trung bình trọng số (Weighted Average Score):  
Score_Avg = (Điểm1*TC1 + Điểm2*TC2 + Điểm3*TC3) / (TC1 + TC2 + TC3). 
• Quy đổi Score_Avg sang Điểm chữ (char/string) và Thang điểm 4 (double): 
•   + [8.5 - 10.0]: Điểm A | Thang 4: 4.0 | Xếp loại: Xuất sắc / Giỏi 
•   + [7.0 - 8.4] : Điểm B | Thang 4: 3.0 | Xếp loại: Khá 
•   + [5.5 - 6.9] : Điểm C | Thang 4: 2.0 | Xếp loại: Trung bình 
•   + [4.0 - 5.4] : Điểm D | Thang 4: 1.0 | Xếp loại: Yếu 
•   + [< 4.0]     : Điểm F | Thang 4: 0.0 | Xếp loại: Kém (Trượt) 
• Xuất bảng điểm chi tiết và GPA làm tròn 2 chữ số thập phân.*/
class Bai5
{
    public static void Run()
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Bài 5: Quản Lý Điểm Học Phần & Quy Đổi Thang Điểm GPA (4.0)");
        Console.WriteLine();

        string[] subjects = { "Lập trình C#", "Toán rời rạc", "Tiếng Anh" };
        double[] score = new double[3];
        double[] credit = new double[3];
        double[] GPs = new double[3];
        char[] letterGrades = new char[3];

        double totalCredit = 0;
        double totalScore4 = 0;
        double totalScore10 = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Nhập điểm môn {subjects[i]} thang 10: "); score[i] = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nhập số tín chỉ: "); credit[i] = double.Parse(Console.ReadLine());
            Console.WriteLine();

            GPs[i] = GP(score[i]);
            totalScore10 += score[i] * credit[i];
            totalCredit += credit[i];
            totalScore4 += (GPs[i] * credit[i]);
            letterGrades[i] = LG(GPs[i]);
        }

        double avrScore = totalScore10 / totalCredit;
        double GPA = totalScore4 / totalCredit;

        Console.WriteLine("Môn\t\tĐiểm Thang 4\t\tĐiểm chữ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{subjects[i]}\t\t{GPs[i]}\t\t{letterGrades[i]}");
        }
        Console.WriteLine();
        Console.WriteLine($"Điểm TB thang 10: {avrScore:N}");
        Console.WriteLine($"Điểm TB thang 4: {GPA:N}");


        static double GP(double score)
        {
            if (score >= 8.5) return 4.0;
            else if (score >= 7) return 3.0;
            else if (score >= 5.5) return 2.0;
            else if (score >= 4) return 1.0;
            else return 0.0;

        }
        static char LG(double GP)
        {
            switch (GP)
            {
                case 4:
                    return 'A';
                case 3:
                    return 'B';
                case 2:
                    return 'C';
                case 1:
                    return 'D';
                default:
                    return 'F';
            }
        }
    }
}
