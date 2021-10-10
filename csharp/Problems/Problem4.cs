namespace ProjectEuler;

public partial class MainApp
{
    static int Problem4()
    {
        var max = 0;

        for (int i = 1; i <= 999; i++)
        {
            for (int j = 1; j <= 999; j++)
            {
                var number = i * j;
                if (IsPalindrome(number.ToString()))
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }
            }
        }

        return max;
    }

    static bool IsPalindrome(string s)
    {
        for (int i = 0, j = 1; i < s.Length / 2; i++, j++)
        {
            if (s[i] != s[^j])
            {
                return false;
            }
        }

        return true;
    }
}