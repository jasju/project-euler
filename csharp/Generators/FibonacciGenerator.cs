namespace ProjectEuler.Generators;

using System.Collections;

public class Fibonacci : IEnumerable<ulong>
{
    //public static Apply
    public IEnumerator<ulong> GetEnumerator()
    {
        return fibonacci().GetEnumerator();
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
        //return Fibonacci();
    }

    IEnumerable<ulong> fibonacci()
    {
        ulong first = 0;
        ulong second = 1;

        yield return first;
        yield return second;

        while (true)
        {
            (first, second) = (second, second + first);

            yield return second;
        }
    }
}