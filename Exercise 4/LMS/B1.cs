namespace Exercise__4.LMS
{
    internal class B1
    {
        static void Run()
        {
            //input
            Console.WriteLine("Bài 1: Hệ thống tính giá vé xem phim (Cinema Ticket)");
            Console.WriteLine("---Input---");
            Console.Write("Nhập số tuổi: ");
            uint age;
            while (!(uint.TryParse(Console.ReadLine(), out age) ) )
                Console.Write("Vui lòng nhập số tuổi hợp lệ: ");
            Console.Write("Nhập giờ chiếu: ");
            uint intTime;
            while ( !(uint.TryParse(Console.ReadLine(), out intTime) ) || intTime <=23   )
                Console.WriteLine("Vui lòng nhập giờ chiếu hợp lệ: ");
            //process & output
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("---Output---");
            if (age > 60 || age < 12) Console.WriteLine("Giá vé của bạn là 50,000 VNĐ");
            else
            {
                if (intTime < 17) Console.WriteLine("Giá vé của bạn là 80,000 VNĐ");
                else Console.WriteLine("Giá vé của bạn là 110,000 VNĐ");
            }
        }

    }
}
