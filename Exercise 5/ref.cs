class asa
{

        public static void Msin(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("""
                                ________  .__                 ________                       
                \______ \ |__| ____  ____    /  _____/_____    _____   ____  
                 |    |  \|  |/ ___\/ __ \  /   \  ___\__  \  /     \_/ __ \ 
                 |    `   \  \  \__\  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ 
                /_______  /__|\___  >___  >  \______  (____  /__|_|  /\___  >
                        \/        \/    \/          \/     \/      \/     \/ 
                """);
            dice_game();
        }

        /// <summary>
        /// Gieo 2 con súc sắc rồi tính tổng giá trị 2 mặt
        /// nếu lớn hơn 6 thì gọi là tài, nhỏ hơn 6 thì gọi là xỉu, bằng 6 thì gọi là đặc biệt
        /// 
        /// đầu tiên,máy sẽ gieo súc sắc, sau đó người chơi sẽ đặt cược tài hoặc xỉu, 
        /// nếu kết quả của máy và người chơi trùng nhau thì người chơi thắng, ngược lại thì thua
        /// trong trường hợp đoán đúng số 6 thì người chơi sẽ được thưởng 3 lần số tiền đặt cược
        /// 
        /// sau mỗi lần chơi, máy sẽ hỏi người chơi có muốn chơi tiếp không, 
        /// nếu người chơi đồng ý thì quay lại gieo súc sắc, ngược lại thì kết thúc trò chơi.
        /// Khi kết thúc trò chơi, máy sẽ thông báo tổng số tiền thắng hoặc thua của người chơi.
        /// 
        /// </summary>
        public static void dice_game()
        {
            long tien = 1000_000; //giả sử người chơi có 1 triệu đồng
            int soLanChoi = 0; //biến đếm số lần chơi
            int soLanThua = 0; //biến đếm số lần thua
            int soLanDacBiet = 0; //biến đếm số lần thắng đặc biệt
            bool continuePlaying = true; //giả sử chơi tiếp
            do
            {
                soLanChoi++;
                Console.Write($"Bạn có {tien} đồng. Bạn đặt bao nhiêu? ");
                /*int tienDatCuoc = int.Parse(Console.ReadLine());*/
                long tienDatCuoc = 0;
                do
                {
                    bool ok = long.TryParse(Console.ReadLine(), out long result);
                    if (ok && result <= tien && result > 1000)
                    {
                        tienDatCuoc = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Vui lòng nhập một số hợp lệ hoặc số tiền đặt cược không được vượt quá số tiền hiện có {tien}. Hoặc trên 1000 đồng");
                        Console.Write("Bạn đặt bao nhiêu? ");
                    }
                } while (true);

                // Gieo 2 con súc sắc
                Random rand = new Random();
                int dice1 = rand.Next(1, 7); //rand.Next(6)+1;
                int dice2 = rand.Next(1, 7);
                int sum = dice1 + dice2;
                //hỏi người chơi đoán tài hay xỉu hay lục

                /* Console.Write("Bạn đoán tài (T), xỉu (X) hay lục (L)? ");
                 string guess = Console.ReadLine().ToLower();*/
                string guess;
                do
                {
                    Console.Write("Bạn đoán tài (T), xỉu (X) hay lục (L)? ");
                    guess = Console.ReadLine().ToLower();
                    if (guess != "t" && guess != "x" && guess != "l")
                    {
                        Console.WriteLine("Vui lòng nhập T, X hoặc L.");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                // Kiểm tra kết quả
                bool isWin = false; //giả sử bạn thua
                bool isSpecial = false; //giả sử không phải đặc biệt
                if (guess == "t" && sum > 6)
                {
                    isWin = true;
                }
                else if (guess == "x" && sum < 6)
                {
                    isWin = true;
                }
                else if (guess == "l" && sum == 6)
                {
                    isWin = true;
                    isSpecial = true;// là đặc biệt
                }
                Console.WriteLine($"Kết quả gieo súc sắc: {dice1} + {dice2} = {sum}");
                if (isWin)
                {
                    if (isSpecial)
                    {
                        soLanDacBiet++;
                        tien += tienDatCuoc * 3;
                        Console.WriteLine($"Bạn thắng đặc biệt! Tổng số tiền hiện tại: {tien} đồng.");
                    }
                    else
                    {
                        tien += tienDatCuoc;
                        Console.WriteLine($"Bạn thắng! Tổng số tiền hiện tại: {tien} đồng.");
                    }
                }
                else
                {
                    tien -= tienDatCuoc;
                    soLanThua++;
                    Console.WriteLine($"Bạn thua! Tổng số tiền hiện tại: {tien} đồng.");
                }

                //sau mỗi lần chơi, máy sẽ hỏi người chơi có muốn chơi tiếp không, 
                Console.Write("\nBạn có muốn chơi tiếp không? (C/K): ");
                string input = Console.ReadLine();//C
                if (input.ToLower() == "k")
                {
                    continuePlaying = false;
                }
            } while (continuePlaying);
            // Khi kết thúc trò chơi, máy sẽ thông báo tổng số tiền thắng hoặc thua của người chơi.
            Console.WriteLine($"\nTrò chơi kết thúc!");
            Console.WriteLine($"Tổng số lần chơi: {soLanChoi}");
            Console.WriteLine($"Tổng số lần thắng: {soLanChoi - soLanThua - soLanDacBiet}");
            Console.WriteLine($"Tổng số lần thua: {soLanThua}");
            Console.WriteLine($"Tổng số lần thắng đặc biệt: {soLanDacBiet}");
        }
    

        void test(long tien)
        {
            /*
             * 6 uocc so = 1,2,3 tong =6 --> perfect number
             * 28 -> 1,2,4,7,14 tong = 28 --> perfect number
             * 
             * i chạy từ 1 đế n/2, nếu n % i == 0 (chia hết ~ ước số) thì cộng i vào tổng
             * kiểm tra tổng có bằng n hay không, nếu bằng thì là perfect number
             */
        }
}
