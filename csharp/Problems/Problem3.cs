namespace ProjectEuler;

public partial class MainApp
{
    static UInt64 Problem3()
    { 
        UInt64 n = 600851475143;
                  

        var solution = PrimeFactors.Calculate(n).Max();

        return solution;
    }
}