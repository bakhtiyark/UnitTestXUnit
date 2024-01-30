using Counter;

namespace UnitTestTaskxUnit;

public class CounterClassShould
{
    [Theory]
    [InlineData("SKKT", 2)]
    [InlineData("DjiSamSoe234", 12)]
    [InlineData("Sassy", 3)]
    [InlineData("", 0)]
    [InlineData(null, 0)]
    public void CorrectlyCalculateUnequalCharacters(string input, int result)
    {
        Counters sut = new Counters();
        int actual = sut.CountUnequalConsecutiveCharacters(input);
        Assert.Equal(result, actual);
    }
    
    [Theory]
    [InlineData("Schloss", 2)]
    [InlineData("XXX", 3)]
    [InlineData("Xavier", 1)]
    [InlineData("YouUuUuUuU", 8)]
    [InlineData("", 0)]
    [InlineData(null, 0)]
    public void CorrectlyCalculateIdenticalLatinCharacters(string input, int result)
    {
        Counters sut = new Counters();
        
        int actual = sut.CountEqualConsecutiveLatinCharacters(input);
        
        Assert.Equal(result, actual);
    }
    
    [Theory]
    [InlineData("669988111", 3)]
    [InlineData("69", 1)]
    [InlineData("100", 2)]
    [InlineData("", 0)]
    [InlineData(null, 0)]
    public void CorrectlyCalculateMaximumConsecutiveNumbers(string input, int result)
    {
        Counters sut = new Counters();
        
        int actual = sut.CountMaxConsecutiveNumbers(input);
        
        Assert.Equal(result, actual);
    }
}