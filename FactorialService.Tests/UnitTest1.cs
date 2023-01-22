namespace FactorialService.Tests;

public class FactTest
{
    [Fact]
    public void FactBasic()
    {
        Assert.Equal(24,FactChecker.FactorialFinder(4));
    }

    [Fact]
    public void FactBasic2()
    {
        Assert.Equal(6,FactChecker.FactorialFinder(3));
    }

    [Fact]
    public void FactBasic3()
    {
        Assert.Equal(0,FactChecker.FactorialFinder(-2));
    }



/*
    [Fact]
        public void Factorial_NoNegative()
        {








            int x = -2;

            Assert.Throws<Exception>(()=>{
                FactChecker.FactorialFinder(x);
            });

            if (x < 0)
            {
                throw new Exception("No negative!");
            }

        }
        */
        
}

