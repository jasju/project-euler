namespace ProjectEuler;

using ProjectEuler.Generators;

public partial class MainApp
{
    static UInt64 Problem2()
    {
        const uint k = 4_000_000;
        var fibSequences = new FibonacciGenerator();


        var solution = fibSequences
            .TakeWhile(fib => fib < k)
            .Where(fib => fib % 2 == 0)
            .Sum(fib => (decimal)fib);

        return (UInt64)solution;
    }
}