Random random = new Random();
int coinFlip = random.Next(0, 100);

int target = 60;
int[] coins = new int[] { 5, 5, 5, 25, 25, 10, 5 };
int[] result = TwoCoins(coins, target);
if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

int[] TwoCoins(int[] coins, int target)
{
    for (int i=0; i < coins.Length-1; i++)
    {
        for (int j=i+1; j <coins.Length; j++)
        {
            if (coins[i] + coins[j]==target)
            {
                return new int[] { i, j };
            }
        }

    }

    return new int[0];
}