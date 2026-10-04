string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int midPoint = word.Length/2 +1;
    for (int i=0; i <midPoint-1; i++)
    {
        if (word[i] != word[word.Length - 1 -i])
        {
            return false;
        }
    }
    return true;
}