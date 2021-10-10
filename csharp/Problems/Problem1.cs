namespace ProjectEuler;

public partial class MainApp
{
    static int Problem1()
    {
        var result = 0;
        for (var i = 1; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                result += i;
            }
        }
        return result;
    }
}