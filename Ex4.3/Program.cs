internal class Program
{
    private static void Main(string[] args)
    {
        #region InputValidCheck
        Console.OutputEncoding=System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật ");
        Console.WriteLine("---Input---");
        Console.Write("Nhập ngày sinh (dd/mm/yyyy): ");
        string birthdayInput = Console.ReadLine();
        Console.WriteLine("---Output---");
        DateTime Birthday;
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
        #endregion
        int Age, daysUntilNextBirthday, daysLived;// Output variables
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
        if (!(Birthday.Month == 2 && Birthday.Day == 29)) // Check if birthday is not 29/02
        {
            TimeSpan timeLived = DateTime.Today - Birthday;
            daysLived = timeLived.Days;
            Console.WriteLine($"Bạn đã sống tổng cộng: {daysLived} ngày");
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
            Console.WriteLine("ưait");
        }    



    }
}