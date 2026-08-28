internal class Program4
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật ");
        Console.WriteLine("---Input---");
        Console.Write("Nhập ngày sinh (dd/mm/yyyy): ");
        string BirthdayInput = Console.ReadLine();
        bool isBirthdayValid = DateTime.TryParseExact(BirthdayInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthday);
        if (isBirthdayValid == true)
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (birthday.Month < DateTime.Now.Month || birthday.Month == DateTime.Now.Month && birthday.Day <= DateTime.Now.Day) 
            {
                Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
            }
            else
            {
                Console.WriteLine($"Tuổi hiện tại: {age - 1} tuổi");
            }
        }
        else
        {
            Console.WriteLine("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/mm/yyyy.");
        }
        Console.WriteLine("Bạn đã sống tộng cộng:" + (DateTime.Now - birthday).Days + " ngày");

    }
}