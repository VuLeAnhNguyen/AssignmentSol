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
    public class Scoreboard
    {
        public static void PrintScore(IScorable item)
        {
            Console.WriteLine(item.Name +": "+ item.Score);
        }
        public static bool IsFirstHigher<T>(T item1, T item2) where T : IScorable
        {
            return item1.Score > item2.Score;
        }
    }


}