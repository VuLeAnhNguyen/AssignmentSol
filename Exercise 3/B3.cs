namespace Exercise_3
{
    internal class B3
    {
        enum CurrencyType
        {
            USD = 1,
            EUR = 2,
            JPY = 3,
            GBP = 4
        }
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng");
            Console.WriteLine("Bảng  tỷ giá");
            Console.WriteLine($"1 USD = 25,400 VND");
            Console.WriteLine($"1 EUR = 27,200 VND");
            Console.WriteLine($"1 JPY = 165 VND");
            Console.WriteLine($"1 GBP = 32,100 VND");
            Console.WriteLine("---Input---");
            decimal tienViet = 0;
            Console.Write("Nhập số tiền VNĐ: ");
            tienViet = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("---Output---");
            Console.WriteLine($"Phí dịch vụ (0,5%): {tienViet * 0.005m:N0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {tienViet * 0.995m:N0} VNĐ");
            decimal tyGia = 1;
            switch (choice)
            {
                case 1:
                    tyGia = 25400;
                    break;
                case 2:
                    tyGia = 27200;
                    break;
                case 3:
                    tyGia = 165;
                    break;
                case 4:
                    tyGia = 32100;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Chỉ chấp nhận 1, 2, 3 hoặc 4.");
                    return;
            }
            Console.WriteLine($"Số tiền {(CurrencyType)choice}: {tienViet * 0.995m / tyGia:N2} {(CurrencyType)choice} ");


        }
    }
}
