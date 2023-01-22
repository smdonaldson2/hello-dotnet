namespace FactorialService;
public class FactChecker
{
    public static int FactorialFinder(int i)
    {
        if (i < 0)
            return 0;
        if (i <= 1)
            return 1;
        return i * FactorialFinder(i-1);
    }

}



