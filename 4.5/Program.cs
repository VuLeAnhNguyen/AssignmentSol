/* Write a C# Sharp program that takes a character as input and checks if it 
is a vowel, a digit, or any other symbol. */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---Input---");
        Console.WriteLine("Character type input check: "); char input = char.Parse(Console.ReadLine());
        switch ( char.ToLower(input) )
        {
            case 'a' or 'e' or 'i' or 'o' or 'u':
                Console.WriteLine("It is a Vowel");
                break;
            case char digit when char.IsDigit(digit):
                Console.WriteLine("It is a digit");
                break;
            default:
                Console.WriteLine("Other");
                break;

                
        }
    }
}