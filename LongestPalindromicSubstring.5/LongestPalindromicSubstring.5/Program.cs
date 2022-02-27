https://leetcode.com/problems/longest-palindromic-substring/

const string s = "jsfpmgkuxqnmtruslzgyvexhqjoamvyuyedhybqqcjhhhgmwqudgldvspgugibdsqfhucpfcqzriqqusvspgbqhgkswlzdkytyqphexemwxpduxplkquvgvhefsxubjluopighxbpscekijrqjhcgmqcuoczwbvueuviyfokdoqqsckjdorsettkkpiyyxxdsfczyhkyxlvrmhvflqbvlrukqcplbxnyokdxvhubsisxrodolmpmkdczavqlsnrggffagoddaldlcexwvozjxxdjtfjrfciwpacpbajcpmgfpefngqfbzehaaqyfvthtrbhkzrzqmzdcgrkezpqgbqjembeqaziuubbvdfpfyqanilcjggkudsyigiqgrcmauyugyhepvduudvpehyguyuamcrgqigiysdukggjclinaqyfpfdvbbuuizaqebmejqbgqpzekrgcdzmqzrzkhbrthtvfyqaahezbfqgnfepfgmpcjabpcapwicfrjftjdxxjzovwxecldladdogaffggrnslqvazcdkmpmlodorxsisbuhvxdkoynxblpcqkurlvbqlfvhmrvlxykhyzcfsdxxyyipkkttesrodjkcsqqodkofyivueuvbwzcoucqmgchjqrjikecspbxhgipouljbuxsfehvgvuqklpxudpxwmexehpqytykdzlwskghqbgpsvsuqqirzqcfpcuhfqsdbigugpsvdlgduqwmghhhjcqqbyhdeyuyvmaojqhxevygzlsurtmnqxukgmpfsj";
Console.WriteLine(getLongestPalindrome(s));

string getLongestPalindrome(string s)
{
    var n = s.Length;
    if (n < 2)
    {
        return s;
    }
    var maxLength = 1;
    var startPosition = 0;

    int low, high;
    for (int i = 0; i < s.Length; i++)
    {
        low = i - 1;
        high = i + 1;

        while (high < n && s[i] == s[high])
        {
            high++;
        }
        while (low >= 0 && s[low] == s[i])
        {
            low--;
        }

        while (low >= 0 && high < n && s[low] == s[high])
        {
            low--;
            high++;
        }

        var length = high - low - 1;
        if (length > maxLength)
        {
            maxLength = length;
            startPosition = low + 1;
        }
    }

    return s[startPosition..(startPosition + maxLength)];
}