class GameXiNgau
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Game Xí Ngầu");
        long tien = 1_000_000;
        int playTimes = 1, winTimes = 0, specialTimes = 0;

        Console.WriteLine("-------------------------");
        //
        Random dice = new Random();
        //
    Play:
        Console.Write($"Hiện có {tien:N0}, đặt bao nhiêu?: ");
        long bet;
        while (!long.TryParse(Console.ReadLine(), out bet) || (bet > tien || bet <=0) )
        {
            Console.Write("Số tiền cược k hợp lệ, yêu cầu nhập lại: ");
        }
        tien -= bet;
        Console.Write("Đoán Tài (T) hay Xỉu (X) hay Lục (L): ");
        char guess;
        while (!(char.TryParse(Console.ReadLine().ToLower(), out guess) && (guess == 't' || guess == 'x' || guess == 'l')))
        {
            Console.Write("Vui lòng nhập T, X, L: ");
        }
        Console.WriteLine("\nRoll Roll....");
        int roll_1 = dice.Next(1, 7);
        Console.WriteLine($"Roll 1: {roll_1}");
        int roll_2 = dice.Next(1, 7);
        Console.WriteLine($"Roll 2: {roll_2}\n");
        int result = roll_1 + roll_2;
        bool isWin; bool isSpecial = false;
        if ((guess == 't' && result > 6) || (guess == 'x' && result < 6) || (guess == 'l' && result == 6))
        {
            isWin = true;
            if (guess == 'l') isSpecial = true;
        }
        else isWin = false;
        if (isWin && isSpecial)
        {
            tien += bet * 4;
            Console.WriteLine($"Thắng x3!!! Số tiền lời được: {bet * 3}. Số tiền hiện tại {tien}");
            winTimes++; specialTimes++;
        }
        else if (isWin && !isSpecial)
        {
            tien += bet * 2;
            Console.WriteLine($"Thắng! Số tiền lời được: {bet}. Số tiền hiện tại {tien}");
            winTimes++;
        }
        else if (!isWin)
        {
            Console.WriteLine($"Thua. Số tiền mất {bet}. Số tiền còn lại {tien}");
        }
        if (tien == 0)
        {
            Console.WriteLine("Thua sạch");
            goto End;
        }
        Console.Write("Bạn có muốn chơi tiếp không?(Y/N): ");
        char yn;
        while (!(char.TryParse(Console.ReadLine().ToLower(), out yn) && (yn == 'y' || yn == 'n')))
        {
            Console.Write("Vui lòng nhập Có(Y) hoặc Không(N): ");
        }
        if (yn == 'y') { playTimes++; goto Play; }
    End:
        Console.WriteLine("\n--------------------------------");
        Console.WriteLine($"Trò chơi kết thúc!");
        Console.WriteLine($"Tổng số lần chơi: {playTimes}");
        Console.WriteLine($"Tổng số lần thắng: {winTimes}");
        Console.WriteLine($"Tổng số lần thua: {playTimes - winTimes}");
        Console.WriteLine($"Tổng số lần thắng đặc biệt: {specialTimes}");
        return;
    }
}
 