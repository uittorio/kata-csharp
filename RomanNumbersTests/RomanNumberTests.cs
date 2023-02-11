namespace RomanNumbersTests;

public class RomanNumbersTests
{

    [Test]
    public void Given1ReturnI()
    {
        string result = IntegerToRoman.Map(1);
        Assert.That(result, Is.EqualTo("I"));
    }
}


public class IntegerToRoman
{
    public static string Map(int i)
    {
        throw new NotImplementedException();
    }
}