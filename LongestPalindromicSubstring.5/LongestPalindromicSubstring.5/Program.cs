// See https://aka.ms/new-console-template for more information
const string inStr = "xabax";
var longestPalindrome = "";

for (int i = 0; i < inStr.Length; i++)
{
    for (int length = 1; length <= inStr.Length - i; length++)
    {
        var substring = inStr.Substring(i, length);
        var equals = substring == new string(substring.Reverse().ToArray());
        if (equals && substring.Length > longestPalindrome.Length)
        {
            longestPalindrome = substring;
        }
    }
}

Console.WriteLine(longestPalindrome);