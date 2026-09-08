/*
1. Write a C# Sharp program that takes two numbers as input and 
performs an operation (+,-,*,x,/) on them and displays the result of that 
operation.
*/
internal class Program1
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---Input---");
        Console.Write("First number: "); decimal firstNum = decimal.Parse(Console.ReadLine());
        Console.Write("Second Number: "); decimal secondNum = decimal.Parse(Console.ReadLine());
        //
        Console.WriteLine("---Output---");
        Console.WriteLine($"Sum: {firstNum + secondNum}");
        Console.WriteLine($"Different: {firstNum - secondNum}");
        Console.WriteLine($"Product: {firstNum * secondNum}");
        Console.WriteLine($"Quotient: {firstNum / secondNum}");
    }
}