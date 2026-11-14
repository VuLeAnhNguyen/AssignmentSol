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
    class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseCredit { get; set; }
        public string CourseGrade { get; set; }
        public Course(string _courseId, string _courseName, string _courseCredit, string? _courseGrade)
        {
            CourseId = _courseId;
            CourseName = _courseName;
            CourseCredit = _courseCredit;
            CourseGrade = _courseGrade;
        }
    }
    class School
    {
        public List<Student> StudentList { get; set; }
        public string StudentCourseGrade(string _studentId, string _courseId)
        {
            foreach (Student sdentu in StudentList)
            {
                if (sdentu.StudentId == _studentId)
                    foreach (Course course in sdentu.StudentCoursesInfo)
                    {
                        if (course.CourseId == _courseId)
                            return course.CourseGrade;
                    }
            }
            return "sdasdasd";
        }
        public School()
        {
            StudentList = new();
        }
    }
    class Student
    {
        public string StudentId { get; set; }
        public List<Course?> StudentCoursesInfo { get; set; }
        public void AddNewCourse(string _courseId, string _courseName, string _courseCredit, string? _courseGrade )
        {
            Course newCourse = new(_courseId, _courseName, _courseCredit, _courseGrade);
            StudentCoursesInfo.Add(newCourse);
        }
        public void RemoveCourseGrade(string _courseId)
        {
            foreach (Course item in StudentCoursesInfo)
            {
                if (item?.CourseId == _courseId)
                    item.CourseGrade = null;
            }
        }
        public Student(string _studentId)
        {
            StudentCoursesInfo = new();
            StudentId = _studentId;
        }
    }
    static void Main()
    {

        Student anhDudu = new Student("1");
        anhDudu.AddNewCourse("111", "as", "3", "9");

        Student anhDudasdu = new Student("2");
        anhDudasdu.AddNewCourse("112", "DSA", "3", "6");

        Student anhasDudu = new Student("3");
        anhasDudu.AddNewCourse("113", "DSA", "3", "99");

        Student anhDfasudu = new Student("4");
        anhDfasudu.AddNewCourse("114", "DSA", "3", "2");


        School havet = new();
        havet.StudentList.Add(anhDudu);
        havet.StudentList.Add(anhDudasdu);
        havet.StudentList.Add(anhasDudu);
        havet.StudentList.Add(anhDfasudu);


        Console.WriteLine(havet.StudentCourseGrade("3", "113"));
    }
}

