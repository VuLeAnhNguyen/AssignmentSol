
class bai1
{
    public static void Run()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
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
class bai2
{
    private static void Run()
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
class bai3
{
    enum CurrencyType
    {
        USD = 1,
        EUR = 2,
        JPY = 3,
        GBP = 4
    }
    private static void Run(string[] args)
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
class bai4
{
    private static void Run(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật ");
        Console.WriteLine("---Input---");
        Console.Write("Nhập ngày sinh (dd/mm/yyyy): ");
        string birthdayInput = Console.ReadLine();
        DateTime Birthday;
        // InputValidCheck
        for (int i = 1; (!(DateTime.TryParseExact(birthdayInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out Birthday)) || Birthday > DateTime.Today) && i < 7; i++)
        {
            if (i == 6)
            {
                Console.WriteLine("Bạn đã nhập sai quá nhiều lần, vui lòng thử lại sau.");
                return;
            }
            if (Birthday > DateTime.Today)
            {
                Console.Write(" Ngày sinh không thể lớn hơn ngày hiện tại, vui lòng nhập lại: ");
            }
            else
                Console.Write(" Nhập sai định dạng, hãy nhập đúng định dạng dd/mm/yyyy: ");
            birthdayInput = Console.ReadLine();
        }

        Console.WriteLine("---Output---");
        if (Birthday.Month == DateTime.Today.Month && Birthday.Day == DateTime.Today.Day)
        {
            if (Birthday.Year == DateTime.Today.Year)
            {
                Console.WriteLine(" Bạn vừa mới sinh ra, chúc mừng bạn đã đến với thế giới này!");
            }
            else { Console.WriteLine("Chúc mừng sinh nhật bạn! Hãy tận hưởng ngày đặc biệt này!"); }
        }

        //isBirthdayPassedCheck
        bool isBirthdayPassed;
        if (Birthday.Month < DateTime.Today.Month || Birthday.Month == DateTime.Today.Month && Birthday.Day <= DateTime.Today.Day)
        {
            isBirthdayPassed = true;
        }
        else
        {
            isBirthdayPassed = false;
        }

        //AgeCalculation 
        int Age;
        if (isBirthdayPassed)
        {
            Age = DateTime.Today.Year - Birthday.Year;
        }
        else
        {
            Age = DateTime.Today.Year - Birthday.Year - 1;

        }
        Console.WriteLine($"Tuổi hiện tại: {Age} tuổi");

        //DaysLivedCalculation
        TimeSpan timeLived = DateTime.Today - Birthday;
        int daysLived = timeLived.Days;
        Console.WriteLine($"Bạn đã sống tổng cộng: {daysLived} ngày");

        // NextBirthdayCalculation
        int daysUntilNextBirthday;
        if (!(Birthday.Month == 2 && Birthday.Day == 29)) // Check if birthday is not 29/02
        {

            if (isBirthdayPassed)
            {
                daysUntilNextBirthday = (new DateTime(DateTime.Today.Year + 1, Birthday.Month, Birthday.Day) - DateTime.Today).Days;
            }
            else
            {
                daysUntilNextBirthday = (new DateTime(DateTime.Today.Year, Birthday.Month, Birthday.Day) - DateTime.Today).Days;
            }
            Console.WriteLine($"Sinh nhật tiếp theo còn: {daysUntilNextBirthday} ngày");
        }
        else // If birthday is 29/02
        {
            if (DateTime.IsLeapYear(DateTime.Today.Year) && !isBirthdayPassed)
            {
                daysUntilNextBirthday = (new DateTime(DateTime.Today.Year, 2, 29) - DateTime.Today).Days;
            }
            else
            {
                DateTime BirthdayLeapYear = DateTime.Today;
                while (!(DateTime.IsLeapYear(BirthdayLeapYear.Year)) || DateTime.IsLeapYear(BirthdayLeapYear.Year) && isBirthdayPassed)
                {
                    BirthdayLeapYear = BirthdayLeapYear.AddYears(1);

                }
                daysUntilNextBirthday = (new DateTime(BirthdayLeapYear.Year, 2, 29) - DateTime.Today).Days;
            }
            Console.WriteLine($"Sinh nhật tiếp theo còn: {daysUntilNextBirthday} ngày");
        }


    }
}
class bai5
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
        Console.WriteLine("Bài 5: Quản Lý Điểm Học Phần & Quy Đổi Thang Điểm GPA (4.0)");
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
}
class bai6
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 6: Chuẩn Hóa Họ Tên Người Dùng & Tự Động Tạo Email/Username");
        Console.WriteLine("---Input---");
        Console.Write($"Nhập họ tên thô: "); string fullNameInput = Console.ReadLine(); // assume input is 100% correct,=3 length for now, still >2space error
        // process
        string[] separatedLowerCaseName = fullNameInput.ToLower().Split();
        string ho, dem, ten;
        ho = separatedLowerCaseName[0].Substring(0, 1).ToUpper() + separatedLowerCaseName[0].Substring(1);
        dem = separatedLowerCaseName[1].Substring(0, 1).ToUpper() + separatedLowerCaseName[1].Substring(1);
        ten = separatedLowerCaseName[^1].Substring(0, 1).ToUpper() + separatedLowerCaseName[^1].Substring(1);
        Console.WriteLine("---Output---");
        Console.WriteLine($" Họ: {ho} | Tên đệm: {dem} | Tên: {ten}");
        string autoUsername = $"{ten}.{ho}{dem}";
        Console.WriteLine($"Username tạo tự động: " + autoUsername);
        Console.WriteLine($"Email cấp phát: {autoUsername}@company.edu.vn");

    }
}
class bai7
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 7: Lập Kế Hoạch Chi Phí Nhiên Liệu & Chia Sẻ Chuyến Đi (Car-pooling)");
        Console.WriteLine("---Input---");
        Console.Write("Quãng đường (Km): "); double distance = double.Parse(Console.ReadLine());
        Console.Write("Mức tiêu hao (lít/100km): "); double fuelConsumptionRate = double.Parse(Console.ReadLine());
        Console.Write("Giá xăng (VNĐ/lít): "); decimal fuelPrice = decimal.Parse(Console.ReadLine());
        Console.Write("Số người đi: "); int passengerCount = int.Parse(Console.ReadLine());
        //
        double fuelConsumption = (distance / 100) * fuelConsumptionRate;
        decimal fuelCost = (decimal)fuelConsumption * fuelPrice;
        decimal costPerPassenger = fuelCost / (decimal)passengerCount;
        //
        Console.WriteLine("---Output---");
        Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {fuelConsumption} Lít");
        Console.WriteLine($"Tổng chi phí xăng dầu: {fuelCost} VNĐ");
        Console.WriteLine($"Chi phí mỗi người ({passengerCount}):  {Math.Ceiling(costPerPassenger)} VNĐ");
    }
}
class bai8
{
    private static void Main(string[] args)
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
