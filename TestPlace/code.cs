class Program
{
    public interface IHasScore
    {
        public int Score { get; set; }
    }
    public class Student : IHasScore
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
    public class Player : IHasScore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
    public static bool IsFirstHigher<T>(T first, T second)
        where T : IHasScore
    {
        return first.Score > second.Score;
    }

    static void Main()
    {
        Student s1 = new Student("An", 85);
        Student s2 = new Student("Binh", 72);

        Player p1 = new Player("Kai", 1200);
        Player p2 = new Player("Mia", 1500);

        Console.WriteLine(IsFirstHigher<Student>(s1,s2));
        Console.WriteLine(IsFirstHigher<Player>(p1, p2));

    }
}