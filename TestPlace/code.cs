public class Solution
{
    public static int Main()
    {
        int[] nums = { 1, 90, 14, 98, 12 };
        int[] totals = new int[nums.Length];
        string[] str = new string[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int total = 0;
            str[i] = nums[i].ToString();
            foreach (char c in str[i])
            {
                total += int.Parse(c.ToString());
            }
            totals[i] = total;
        }
        int[] totalsClone = (int[])totals.Clone();
        Array.Sort(totals);

        return 0;
    }
}