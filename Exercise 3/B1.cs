namespace Exercise_3
{
    internal class B1
    {
        public static void Run()
        {

            Console.WriteLine("Bài 1: Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang (EVN)\n---Input---");
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            decimal chiSoDienCu = decimal.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số điện mới (kWh): ");
            decimal chiSoDienMoi = decimal.Parse(Console.ReadLine());
            Console.WriteLine("---OutPut---");
            decimal soDienTieuThu = chiSoDienMoi - chiSoDienCu;
            Console.WriteLine($"Số điện tiêu thụ: {soDienTieuThu} Kwh");
            decimal tienDienChuaThue = 0;
            //Hệ số tiền
            decimal b1 = 1806m;
            decimal b2 = 1866m;
            decimal b3 = 2167m;
            decimal b4 = 2729m;
            decimal b5 = 3050m;

            if (soDienTieuThu <= 50)
            {
                tienDienChuaThue = soDienTieuThu * b1;
            }
            else
            {
                if (soDienTieuThu <= 100)
                {
                    tienDienChuaThue = 50 * b1 + (soDienTieuThu - 50) * b2;
                }
                else
                {
                    if (soDienTieuThu <= 200)
                    {
                        tienDienChuaThue = 50 * b1 + 50 * b2 + (soDienTieuThu - 100) * b3;
                    }
                    else
                    {
                        if (soDienTieuThu <= 300)
                        {
                            tienDienChuaThue = 50 * b1 + 50 * b2 + 100 * b3 + (soDienTieuThu - 200) * b4;
                        }
                        else
                        {
                            tienDienChuaThue = 50 * b1 + 50 * b2 + 100 * b3 + 100 * b4 + (soDienTieuThu - 300) * b5;
                        }
                    }

                }
            }
            Console.WriteLine($"Tiền điện chưa thuế: {tienDienChuaThue} Vnđ ");
            decimal thueVAT = tienDienChuaThue * 0.08m;
            Console.WriteLine($"Tiền thuế VAT: {thueVAT} Vnđ ");
            Console.WriteLine($"Tổng thanh toán: {tienDienChuaThue + thueVAT} Vnđ ");
        }
    }
}
