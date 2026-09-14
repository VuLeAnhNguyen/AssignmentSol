namespace Exercise__4.LMS
{
    internal class B2
    {
        static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 2: Phân quyền truy cập hệ thống (Role Authorization)");
            Console.WriteLine("---Input---");
            Console.Write("Role: "); string role = Console.ReadLine().ToUpper();
            Console.WriteLine("---Output---");
            switch (role)
            {
                case "ADMIN":
                    Console.WriteLine("[Thông báo]: Toàn quyền quản trị hệ thống.");
                    break;
                case "MANAGER":
                    Console.WriteLine("[Thông báo]: Quyền quản lý nhân sự và xem báo cáo.");
                    break;
                case "EMPLOYEE":
                    Console.WriteLine("[Thông báo]: Quyền tạo và chỉnh sửa hồ sơ cá nhân.");
                    break;
                case "GUEST":
                    Console.WriteLine("[Thông báo]: Chỉ có quyền xem thông tin công khai");
                    break;
                default:
                    Console.WriteLine("[Thông báo]: Mã vai trò không hợp lệ!");
                    break;
            }
        }
    }
}
