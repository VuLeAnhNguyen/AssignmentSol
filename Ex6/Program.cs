internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("---Input---");
        Console.Write($"Nhập họ tên thô: "); string fullNameInput = Console.ReadLine(); // assume input is 100% correct,=3 length for now
        // process
        string[] separatedLowerCaseName = fullNameInput.ToLower().Split();
        string ho, dem, ten;
        ho  = separatedLowerCaseName[0].Substring(0,1).ToUpper() + separatedLowerCaseName[0].Substring(1);
        dem = separatedLowerCaseName[1].Substring(0, 1).ToUpper() + separatedLowerCaseName[1].Substring(1);
        ten = separatedLowerCaseName[^1].Substring(0, 1).ToUpper() + separatedLowerCaseName[^1].Substring(1);
        Console.WriteLine("---Output---");
        Console.WriteLine($" Họ: {ho} | Tên đệm: {dem} | Tên: {ten}");
        string autoUsername = $"{ten}.{ho}{dem}";
        Console.WriteLine($"Username tạo tự động: "+ autoUsername);
        Console.WriteLine($"Email cấp phát: {autoUsername}@company.edu.vn");

    }
}