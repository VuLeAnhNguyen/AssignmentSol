class GameXiNgau
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Game Xí Ngầu");
        long tien = 1_000_000;
        int playTimes = 1, winTimes = 0, specialTimes = 0;

        Console.WriteLine("-------------------------");
    Play:
        Console.Write($"Hiện có {tien:N0}, đặt bao nhiêu?: ");
        int bet;
        while (!int.TryParse(Console.ReadLine(), out bet)|| bet > tien)
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
            Console.Write("Vui lòng nhập T, X, L");
        }
        bool isWin; bool isSpecial = false;
        if ((guess == "t" && result > 6) || (guess == "l" && result == 6)) { isWin = true; }
        else if (guess == "x" && result < 6) { isWin = true; isSpecial = true; }
        else isWin = false;
        if (isWin && isSpecial)
        {
            tien += bet * 4;
            Console.WriteLine($"Thắng x3!!! Số tiền nhận được: {bet * 3}. Số tiền hiện tại {tien}");
            winTimes++; specialTimes++;
        }
        else if (isWin && !isSpecial)
        {
            tien += bet*2;
            Console.WriteLine($"Thắng! Số tiền nhận được: {bet}. Số tiền hiện tại {tien}");
            winTimes++;
        }
        else if (!isWin)
        {
            Console.WriteLine($"Thua. Số tiền mất {bet}. Số tiền còn lại {tien}");
        }
        else { Console.WriteLine("Lỗi Else"); return; }
        if (tien == 0) {Console.WriteLine("Thua sạch"); return;}
        Console.Write("Bạn có muốn chơi tiếp không?(Y/N): ");
        char yn;
        while (!(char.TryParse(Console.ReadLine().ToLower(), out yn) && (yn =='y'|| yn =='n') ) )
        {
            Console.Write("Vui lòng nhập Có(Y) hoặc Không(N): ");
        }
        if (yn == 'n')
        {
            Console.WriteLine($"\nTrò chơi kết thúc!");
            Console.WriteLine($"Tổng số lần chơi: {playTimes}");
            Console.WriteLine($"Tổng số lần thắng: {winTimes}");
            Console.WriteLine($"Tổng số lần thua: {playTimes-winTimes}");
            Console.WriteLine($"Tổng số lần thắng đặc biệt: {specialTimes}");
            return;
        }
        else if (yn == 'y') playTimes++; goto Play;

        



    }
}
 