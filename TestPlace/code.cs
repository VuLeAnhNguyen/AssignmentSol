string text = "dog is doctor";

Console.WriteLine(ReverseWord(text));
Console.WriteLine(ReverseSentence(text));
string ReverseWord(string text)
{
    string result = "";

    for (int i = text.Length-1; i >= 0; i--)
    {
        result += text[i];
    }

    return result;
}
string ReverseSentence(string text)
{
    string result = "";

    string[] words = text.Split(" ");
    foreach (string word in words)
    {
        result += ReverseWord(word)+ " ";
    }

    return result.Trim();
}