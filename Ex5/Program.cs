internal class Program
{
    enum LetterGrade
    {
        A,
        B,
        C,
        D,
        F
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int invalidCount = 0;
        Console.WriteLine("---Input---");
        Console.WriteLine("- Môn C# -");
        Console.Write("Số Tín chỉ: "); int creditCSharp = int.Parse(Console.ReadLine());
        Console.Write("Điểm Thang 10: "); double scoreCSharp = double.Parse(Console.ReadLine());
        //
        Console.WriteLine("- Môn Toán -");
        Console.Write(" Số Tín chỉ: "); int creditMath = int.Parse(Console.ReadLine());
        Console.Write("Điểm Thang 10: "); double scoreMath = double.Parse(Console.ReadLine());
        //
        Console.WriteLine("-Môn Tiếng Anh -");
        Console.Write(" Số Tín chỉ: "); int creditEnglish = int.Parse(Console.ReadLine());
        Console.Write("Điểm Thang 10: "); double scoreEnglish = double.Parse(Console.ReadLine());
        //
        decimal scoreAvarage = (decimal)((scoreCSharp * creditCSharp + scoreMath * creditMath + scoreEnglish * creditEnglish) / (creditCSharp + creditEnglish + creditMath));
        char letterGrade;
        double GPA;
        string rank;
        switch (scoreAvarage)
        {
            case >= 8.5m:
                letterGrade = 'A';
                GPA = 4.0;
                rank = "Giỏi";
                break;
            case >= 7:
                letterGrade = 'B';
                GPA = 3.0;
                rank = "Khá";
                break;
            case >= 5.5m:
                letterGrade = 'C';
                GPA = 2.0;
                rank = "Trung bình";
                break;
            case >= 4:
                letterGrade = 'D';
                GPA = 1;
                rank = "Yếu";
                break;
            case < 4:
                letterGrade = 'F';
                GPA = 0.0;
                rank = "Kém";
                break;
            default:
                Console.WriteLine("Bug");
                return;
        }
        Console.WriteLine("---Output---");
        Console.WriteLine($"Điểm TB Thang 10: {scoreAvarage}");
        Console.WriteLine($"Điểm chữ quy đổi: {letterGrade}");
        Console.WriteLine($"Điểm GPA: {GPA}");
        Console.WriteLine($" Xếp loại học lực: {rank}");
    }
}// wrong GPA calculation, fix later