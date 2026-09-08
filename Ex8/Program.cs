internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 8: Kiểm Tra Mã Xác Thực OTP & Quản Lý Thời Gian Hiệu Lực");
        uint sentOTP = 839201;
        DateTime creationTime = DateTime.Now;
        Console.WriteLine("---Input---");
        Console.Write("Mã OTP nhận được: "); uint inputOTP = uint.Parse(Console.ReadLine());
        Console.WriteLine(" Thời gian trôi qua (hh:mm:ss): "); TimeSpan timePassed = TimeSpan.Parse(Console.ReadLine());
        //
        bool isInputValid;
        uint.TryParse(inputOTP, out uint OTP);
    }
}