/*
Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật 
 
Tình huống thực tế: Hệ thống chăm sóc khách hàng của một công ty bán lẻ cần tự động tính tuổi chính xác 
của khách hàng và đếm số ngày còn lại đến sinh nhật tiếp theo để gửi voucher ưu đãi. 
Kiến thức trọng tâm: Kiểu DateTime, TimeSpan, DateTime.ParseExact, toán tử trừ hai ngày, ép kiểu. 
Yêu cầu bài toán: 
• Nhập ngày tháng năm sinh của người dùng dưới dạng chuỗi 'dd/MM/yyyy' (ví dụ: '25/10/2002'). 
• Chuyển đổi chuỗi thành DateTime sử dụng DateTime.TryParseExact để đảm bảo không bị lỗi định dạng. 
• Lấy ngày hiện tại hệ thống (DateTime.Now.Date). 
• Tính tuổi chính xác tính theo số năm. 
• Xác định ngày sinh nhật tiếp theo trong năm nay hoặc năm sau. Tính số ngày còn lại đến sinh nhật đó. 
• Hiển thị: Tuổi hiện tại, Tổng số ngày đã sống từ lúc sinh ra, và Số ngày còn lại đến sinh nhật kế tiếp.
*/
class Bai4
{
    public static void Run()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();

        bool isValidInput = false;
        DateTime userBirthday;
        do
        {
            Console.WriteLine("Nhập ngày sinh (dd/MM/yyyy): ");
            string? input = Console.ReadLine();

            isValidInput = DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out userBirthday) && userBirthday <= DateTime.Today;
            if (!isValidInput)
            {
                Console.WriteLine("Không hợp lệ, thử lại:");
            }
        }
        while (!isValidInput);

        bool isBirthdayPassed = userBirthday.Month < DateTime.Today.Month || (userBirthday.Month == DateTime.Today.Month && userBirthday.Day <= DateTime.Today.Day); //if today is birthday still mean passed

        int age = isBirthdayPassed ? DateTime.Today.Year - userBirthday.Year : DateTime.Today.Year - userBirthday.Year - 1;
        int daysLived = (int)(DateTime.Today - userBirthday).TotalDays;
        int nextBirthdayYear = DateTime.Today.Year;
        int daysUntilNextBirthday;
        if (userBirthday.Day == 29 && userBirthday.Month == 2)
        {
            if (DateTime.IsLeapYear(nextBirthdayYear) && isBirthdayPassed)
            {
                nextBirthdayYear++;
            }

            while (!DateTime.IsLeapYear(nextBirthdayYear) )
            {
                nextBirthdayYear++;
            }
        }
        else
        {
            nextBirthdayYear = isBirthdayPassed ? DateTime.Today.Year + 1 : DateTime.Today.Year;
        }

        daysUntilNextBirthday = (int)(new DateTime(nextBirthdayYear, userBirthday.Month, userBirthday.Day) - DateTime.Today).TotalDays;

        Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
        Console.WriteLine($"Số ngày đã sống: {daysLived:N0} ngày");
        Console.WriteLine($"Sinh nhật tiếp theo còn {daysUntilNextBirthday} ngày");
    }
}
