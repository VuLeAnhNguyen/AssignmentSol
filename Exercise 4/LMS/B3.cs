namespace Exercise__4.LMS
{
    internal class B3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 3: Xử lý giao dịch rút tiền ATM");
            Console.WriteLine("---Input---");
            decimal balance;
            Console.Write("Nhập số dư tài khoản "); 
            while ( !(decimal.TryParse(Console.ReadLine(), out balance) || balance <0) )
                Console.WriteLine("Số dư không hợp lệ, vui lòng nhập lại: ");
        }
    }
}
