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
        public T Participant { get; }

        public Scoreboard(T participant)
        {
            Participant = participant;
        }

        public void PrintScore()
        {
            Console.WriteLine($"{Participant.Name}: {Participant.Score}");
        }
    }
    static void Main()
    {
        Student s1 = new Student(101, "An", 93);

        Player p1 = new Player ( 1, "Kai", 1200 );

        Scoreboard<Student> ss1 = new Scoreboard<Student> (s1);
        Scoreboard<Player> pp1 = new Scoreboard<Player>(p1);

        ss1.PrintScore();
        pp1.PrintScore();



    }


}