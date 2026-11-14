// 1. Viết lớp về sinh viên và có lưu trong đó danh sách gồm mã môn học,
// tên môn, số tín chỉ cùng với điểm đạt được của môn đó.
// 2. Viết thêm các phương thức cho lớp sinh viên để thêm mới điểm của
// 1 môn học (gồm mã môn, tên môn, số tín chỉ và điểm).
// 3. Viết thêm phương thức xóa điểm của lớp sinh viên, chỉ cần mã môn.
// 4. Thay đổi lớp sinh viên trên bằng cách tạo thêm 1 lớp định nghĩa
// môn học và làm lại với câu 1,2,3.
// 5. Xây dựng phương thức tìm kiếm điểm theo đầu vào là mã sinh viên
// và mã môn học.
class Program
{
    class Student
    {
        public List<string> StudentInfo { get; set; }
        public Student(string _courseId, string _courseName, string _courseCredit, string _courseGrade)
        {
            StudentInfo = new List<string> {_courseId, _courseName, _courseCredit, _courseGrade};
        }
    }
    static void Main()
    {
        Student anhDudu = new Student("12", "DSA", "3", "9");
        foreach (var item in anhDudu.StudentInfo)
        {
            Console.WriteLine(item);
        }
    }
}

