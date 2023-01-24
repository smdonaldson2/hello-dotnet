namespace FactorialService;
public class FactChecker
{
    public static int FactorialFinder(int i)
    {
        if (i < 0)
            throw new Exception("No negative!");
        if (i <= 1)
            return 1;
        return i * FactorialFinder(i-1);
    }
    

}




