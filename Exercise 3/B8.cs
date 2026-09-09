
namespace Exercise_3
{
    internal class B8
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 8: Kiểm Tra Mã Xác Thực OTP & Quản Lý Thời Gian Hiệu Lực");
            uint sentOTP = 839201;
            DateTime creationTime = DateTime.Now;//how to use this in this kind of input bellow? 
            Console.WriteLine("---Input---");
            Console.Write("Mã OTP nhận được: "); string inputOTP = Console.ReadLine();
            Console.Write("Thời gian trôi qua (hh:mm:ss): ");
            TimeSpan inputTimePassed = TimeSpan.Parse(Console.ReadLine()); // invalid cause crash
                                                                           //
            bool isOTPvalid = uint.TryParse(inputOTP, out uint OTP) && inputOTP.Length == 6;
            bool isOTPmatch = (OTP == sentOTP);
            bool isTimePassedValid = (inputTimePassed < TimeSpan.FromMinutes(5));
            //
            Console.WriteLine("---Output---");
            if (isOTPvalid && isOTPmatch && isTimePassedValid)
            {
                Console.WriteLine("THÀNH CÔNG - Giao dịch được phê duyệt.");
            }
            else
            {
                Console.WriteLine("Error:");
                if (!isOTPvalid)
                { Console.WriteLine("- Định dạng OTP không hợp lệ"); }
                if (!isOTPmatch)
                { Console.WriteLine("- Mã Sai."); }
                if (!isTimePassedValid)
                { Console.WriteLine("- Hết Hạn OTP / Nhập sai định dạng"); }
            }
        }
    }
}
