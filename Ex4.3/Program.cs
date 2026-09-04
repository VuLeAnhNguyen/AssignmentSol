internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding=System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật ");
        Console.WriteLine("---Input---");
        Console.Write("Nhập ngày sinh (dd/mm/yyyy): ");
        string birthdayInput = Console.ReadLine();
        DateTime Birthday;
        #region InputValidCheck
        for (int i = 0; (!(DateTime.TryParseExact(birthdayInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out Birthday))) && i<5; i++)
        {
            Console.Write(" Nhập sai định dạng, hãy nhập đúng định dạng dd/mm/yyyy: ");
            birthdayInput = Console.ReadLine();
            if(i==4)
            {
                Console.WriteLine("Bạn đã nhập sai quá nhiều lần, vui lòng thử lại sau.");
                return;
            }
        }
        Console.WriteLine("---Output---");
        if (Birthday.Month == DateTime.Today.Month && Birthday.Day == DateTime.Today.Day)
        {
            Console.WriteLine("Chúc mừng sinh nhật bạn! Hãy tận hưởng ngày đặc biệt này!");
        }
        else if ( Birthday.Year == DateTime.Today.Year)
        {
            Console.WriteLine(" Bạn vừa mới sinh ra, chúc mừng bạn đã đến với thế giới này!");
        }
        #endregion
        int daysLived;
        #region isBirthdayPassedCheck
        bool isBirthdayPassed;
        if (Birthday.Month < DateTime.Today.Month || Birthday.Month == DateTime.Today.Month && Birthday.Day <= DateTime.Today.Day)
        {
            isBirthdayPassed = true;
        }
        else
        {
            isBirthdayPassed = false;
        }
        #endregion
        #region AgeCalculation
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
        #endregion
        TimeSpan timeLived = DateTime.Today - Birthday;
        daysLived = timeLived.Days;
        Console.WriteLine($"Bạn đã sống tổng cộng: {daysLived} ngày");
        #region NextBirthdayCalculation
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
                while ( !(DateTime.IsLeapYear(BirthdayLeapYear.Year) ) )
                {
                 BirthdayLeapYear = BirthdayLeapYear.AddYears(1);
                }
                daysUntilNextBirthday = (new DateTime(BirthdayLeapYear.Year, 2, 29) - DateTime.Today).Days;
            }
            Console.WriteLine($"Sinh nhật tiếp theo còn: {daysUntilNextBirthday} ngày");
        }


    }
}