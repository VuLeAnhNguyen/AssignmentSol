class Program
{
    public interface IScorable
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    public class Student : IScorable
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public Student(int id, string name, int score)
        {
            StudentId = id;
            Name = name;
            Score = score;
        }
    }
    public class Player : IScorable
    {
        public int PlayerTag { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public Player(int id, string name, int score)
        {
            PlayerTag = id;
            Name = name;
            Score = score;
        }
    }
    public class Scoreboard<T> where T : IScorable
    {
        public T[] Participant { get; }

        public Scoreboard(T[] participant)
        {
            Participant = participant;
        }
        //public void PrintScore()
        //{
        //    foreach (var item in Participant)
        //    {
        //        Console.WriteLine($"{item.Name}: {item.Score}");
        //    }
        //}
        public void PrintAll()
        {
            foreach (var item in Participant)
            {
                Console.WriteLine($"{item.Name}: {item.Score}");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        Student s1 = new Student(101, "An", 93);
        Student s2 = new Student(202, "Binh", 78);

        Player p1 = new Player ( 1, "Kai", 1200 );
        Player p2 = new Player ( 2, "Mia", 1500 );

        Scoreboard<Student> ss = new Scoreboard<Student>(new Student[] { s1, s2 });
        Scoreboard<Player> pp  = new Scoreboard<Player> (new Player[] { p1, p2 });

        s1.Score = 100;

        ss.PrintAll();
        pp.PrintAll();
    }


}