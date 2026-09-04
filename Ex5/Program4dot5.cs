internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(" ---Input---");
        Console.Write("Nhập ngày sinh (dd/mm/yyyy): ");
        string birthdayInput = Console.ReadLine();
        Console.WriteLine(" ---Output---");
        bool isBirthdayValid = DateTime.TryParseExact(birthdayInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthday);
        if (isBirthdayValid == true)
        {
            bool isBirthdayPassed = birthday.Month < DateTime.Today.Month || birthday.Month == DateTime.Today.Month && birthday.Day <= DateTime.Today.Day;
            int age;
            if (isBirthdayPassed == true) { age = DateTime.Today.Year - birthday.Year; }
            else { age = DateTime.Today.Year - birthday.Year - 1; }
            Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
            int daysLived = (DateTime.Today - birthday).Days;
            Console.WriteLine($"Bạn đã sống tổng cộng: {daysLived} ngày");
            // 29/02 ahh problem
            //===========================================================================================
            if (birthday.Day == 29 && birthday.Month == 2)
            {
                DateTime LeapBirthdayYear = new DateTime(DateTime.Today.Year, 1, 1);
                while (!DateTime.IsLeapYear(LeapBirthdayYear.Year))
                {
                    LeapBirthdayYear = LeapBirthdayYear.AddYears(1);
                }
            }
            DateTime nextBirthday = new DateTime(LeapBirthdayYear.Year, birthday.Month, birthday.Day);        
            
            int daysUntilNextBirthday;
            if (!isBirthdayPassed)
            {
                daysUntilNextBirthday = (nextBirthday - DateTime.Today).Days;
            }
            else
            {

                if ( !(birthday.Day == 29 && birthday.Month == 2 && isBirthdayPassed)  )
                { nextBirthday = nextBirthday.AddYears(1); }
                daysUntilNextBirthday = (nextBirthday - DateTime.Today).Days;
            }
            //=============================================================================================
            Console.WriteLine($"Sinh nhật tiếp theo còn {daysUntilNextBirthday:N0} ngày");
        }
        else
        {
            Console.WriteLine("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/mm/yyyy.");
        }
    }
    
}