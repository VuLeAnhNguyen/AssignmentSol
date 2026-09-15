class GameXiNgau
{
    static void run(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Game Xí Ngầu");
        long tien = 1_000_000;
        Console.WriteLine($"Số tiền gốc {tien}");
        Console.WriteLine("-------------------------");
        Console.Write($" Hiện có {tien:N0}, đặt bao nhiêu?: ");
        int bet;
        while (!int.TryParse(Console.ReadLine(), out bet))
        {
            Console.Write("Số tiền cược k hợp lệ, yêu cầu nhập lại: ");
        }
        tien -= bet;
        //
        Random dice = new Random();
        int roll_1 = dice.Next(1, 7);
        int roll_2 = dice.Next(1, 7);
        int result = roll_1 + roll_2;
        //
        Console.WriteLine("Đoán Tài (T) hay Xỉu (X) hay Lục (L): "); string guess = Console.ReadLine().ToLower();
        while (guess != "t" && guess != "x" && guess != "l")
        {
            Console.WriteLine("Vui lòng nhập T, X, L");
        }
        bool isWin; bool isSpecial = false;
        if ((guess == "t" && result > 6) || (guess == "l" && result == 6)) isWin = true;
        else if (guess == "x" && result < 6) { isWin = true; isSpecial = true; }
        else isWin = false;
        if (isWin && isSpecial)
        {
            tien += bet * 3;
            Console.WriteLine($"Thắng x3!!! Số tiền nhận được: {bet * 3}. Số tiền hiện tại {tien}");
        }
        else if (isWin && !isSpecial)
        {
            tien += bet;
            Console.WriteLine($"Thắng! Số tiền nhận được: {bet}. Số tiền hiện tại {tien}");
        }


    }
}
 