//TODO Transformar em Generator
public class PrimeFactors
{
    public static List<ulong> Calculate(ulong number)
    {

        var product = number;
        var primeFators = new List<ulong>();
        var primes = new PrimeNumbersGenerator();

        while (product != 1)
        {
            ulong factor = primes.Where(n => product % n == 0).First();
            primeFators.Add(factor);
            product /= factor;
        }

        return primeFators;
    }
}