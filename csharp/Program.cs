// See https://aka.ms/new-console-template for more information

// var Print = (Action<object>)Console.WriteLine;

// Console.WriteLine(Problem1.Solve());
// Console.WriteLine($"Problem3 Solution -> {Problem3.Solve()}");

// FibonacciGenerator fg = new();

// var values = PrimeFactors.Calculate(80);
// return;

// void Problem4()
// {

// }

namespace ProjectEuler;

public partial class MainApp
{
    public static void Main()
    {
        Console.WriteLine("Oi!");
        
        var problems = new List<IProblem>
        {
            new Problem<int>()
            {
                Number = 1,
                Title = "Multiples of 3 or 5",
                Payload = Problem1
            },
            new Problem<ulong>()
            {
                Number = 2,
                Title = "Even Fibonacci Numbers",
                Payload = Problem2
            },
            new Problem<ulong>()
            {
                Number = 3,
                Title = "Largest Prime Factor",
                Payload = Problem3
            },
            new Problem<int>()
            {
                Title = "Largest Palindrome Product",
                Number = 4,
                Payload = Problem4
            }
        };

        //problems.Add(p4);

        Func<int> action = Problem4;
        //action.BeginInvoke()

        var sumNumbers = (int a, int b) => a + b;

        //var solution = Problem4();

        foreach(var problem in problems)
        {
            problem.Solve();
            Console.WriteLine(problem);
        }

    }
}