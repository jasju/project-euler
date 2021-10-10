using System.Collections;

public class PrimeNumbersGenerator : IEnumerable<ulong>
{
    public IEnumerator<ulong> GetEnumerator()
    {
        return _generator().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerable<ulong> _generator()
    {
        ulong i = 2;

        while (true)
        {
            if (IsPrime(i))
            {
                yield return i;
            }
            i++;
        }
    }

    static bool IsPrime(ulong n)
    {
        if (n < 2)
        {
            return false;
        }
        if (n == 2 || n == 3)
        {
            return true;
        }
        if (n % 2 == 0)
        {
            return false;
        }
        for (ulong i = 3; i < n / 2; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}