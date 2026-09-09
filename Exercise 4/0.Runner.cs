class Runner
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Chọn bài tập: "); string choiceNum = Console.ReadLine();
        Console.WriteLine();
        switch (choiceNum)
        {
            case "1":
                B1.Run();
                break;
            case "2":
                B2.Run();
                break;
            case "3":
                B3.Run(); 
                break;
            case "4":
                B4.Run();
                break;
            case "5":
                B5.Run(); 
                break;      
        }



    }
}
