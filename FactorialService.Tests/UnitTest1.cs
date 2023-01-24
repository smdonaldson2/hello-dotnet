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
        Assert.Throws<Exception>(()=>{
            FactChecker.FactorialFinder(-2);
        });
    }        
}

