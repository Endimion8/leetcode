// See https://aka.ms/new-console-template for more information
const string inStr = "xabay";
var maxLength = 1;
var startPosition = 0;

for (int i = 0; i < inStr.Length; i++)
{
    for (int j = i; j < inStr.Length; j++)
    {
        var isPalindrome = true;
        var length = (j - i + 1);
        var middle = length / 2;
        for (int k = 0; k < middle; k++)
        {
            if (inStr[i + k] != inStr[j - k])
            {
                isPalindrome = false;
            }
        }

        if (isPalindrome && length > maxLength)
        {
            maxLength = length;
            startPosition = i;
        }
    }
}

Console.WriteLine(inStr.Substring(startPosition, maxLength));
Console.WriteLine(inStr[startPosition..(startPosition + maxLength)]);