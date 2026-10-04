Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1,7);
        Console.WriteLine($"Roll a number greater than {target} to win!");
        var roll = random.Next(1, 7);
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine( WinOrLose(roll,target) );
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

////
bool ShouldPlay()
{
    string? input = Console.ReadLine();
    input = input?.ToLower();
    if (input =="y")
    {
        return true;
    }
    else if (input =="n")
    {
        return false;
    }
    else
    {
        Console.WriteLine("Invalid, try again");
    }
    return ShouldPlay();
}
string WinOrLose(int roll, int target)
{
    if (roll < target)
    {
        return "U lose!";
    }
    else
    {
        return "U win!";
    }
}