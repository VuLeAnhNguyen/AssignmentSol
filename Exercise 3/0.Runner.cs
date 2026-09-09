using Exercise_3;
using System.Text;

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
                B3.Run(); //enum
                break;
            case "4":
                B4.Run();
                break;
            case "5": 
                B5.Run(); //enum
                break;
            case "6":
                B6.Run();
                break;
            case "7":
                B7.Run();
                break;
            case "8":
                B8.Run();
                break;
            /*case "9":
                B9.Run();
                beak;
            case "10":
                B10.Run();
                break;
            case "11":
                B11.Run();
                break;
            case "12":
                B12.Run();
                break;
            case "13":
                B13.Run();
                break;
            case "14":
                B14.Run();
                break;
            case "15":
                B15.Run();
                break;*/
        }



    }
}
