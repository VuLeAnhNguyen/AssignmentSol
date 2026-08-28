internal class Program4
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật ");
        Console.WriteLine("---Input---");
        Console.Write("Nhập ngày sinh (dd/mm/yyyy): ");
        string BirthdayInput = Console.ReadLine();
        Console.WriteLine("---Output---");
        bool isBirthdayValid = DateTime.TryParseExact(BirthdayInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthday);
        if (isBirthdayValid == true)
        {
            int age = DateTime.Today.Year - birthday.Year;
            bool isBirthdayPassed;
            if (birthday.Month < DateTime.Today.Month || birthday.Month == DateTime.Today.Month && birthday.Day <= DateTime.Today.Day)
            {
                Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
                isBirthdayPassed = true;
            }
            else
            {
                age--;
                Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
                isBirthdayPassed = false;
            }
            TimeSpan thoiGianThowr = DateTime.Today - birthday;
            Console.WriteLine("Bạn đã sống tộng cộng:" + thoiGianThowr.Days + " ngày");
            DateTime nextBirthday = DateTime.Today;
            int dayUntilNextBirthday;
            if (isBirthdayPassed == false)
            {
                dayUntilNextBirthday = (birthday - DateTime.Today).Days;
            }
            else
            {
                nextBirthday = new DateTime(DateTime.Today.Year, birthday.Month, birthday.Day);
                dayUntilNextBirthday = (nextBirthday - DateTime.Today).Days;
            }
            if (birthday.Month == 2 && birthday.Day == 29 && DateTime.IsLeapYear(birthday.Year) == true)
            {
                while (DateTime.IsLeapYear(nextBirthday.Year)==false)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }
                dayUntilNextBirthday = (nextBirthday - DateTime.Today).Days;
                Console.WriteLine($"Sinh nhật tiếp theo còn: {dayUntilNextBirthday} ngày");
            }
            else
            {
                Console.WriteLine($"Sinh nhật tiếp theo còn: {dayUntilNextBirthday} ngày");
            }
        }
        else
        {
            Console.WriteLine("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/mm/yyyy.");
        }
    }
}