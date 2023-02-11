namespace RomanNumbersTests;

public class RomanNumbersTests
{
    [Test]
    public void Given1ReturnI()
    {
        string result = IntegerToRoman.Map(1);
        Assert.That(result, Is.EqualTo("I"));
    }

    [Test]
    public void Given2ReturnII()
    {
        string result = IntegerToRoman.Map(2);
        Assert.That(result, Is.EqualTo("II"));
    }

    [Test]
    public void Given3ReturnIII()
    {
        string result = IntegerToRoman.Map(3);
        Assert.That(result, Is.EqualTo("III"));
    }

    [Test]
    public void Given4ReturnIV()
    {
        string result = IntegerToRoman.Map(4);
        Assert.That(result, Is.EqualTo("IV"));
    }

    [Test]
    public void Given5ReturnV()
    {
        string result = IntegerToRoman.Map(5);
        Assert.That(result, Is.EqualTo("V"));
    }

    [Test]
    public void Given6ReturnVI()
    {
        string result = IntegerToRoman.Map(6);
        Assert.That(result, Is.EqualTo("VI"));
    }
}

public class IntegerToRoman
{
    public static string Map(int number)
    {
        if (number == 4)
        {
            return "IV";
        }

        bool isAtLeast5 = number >= 5;

        number = number % 5;
        string result = "";


        if(isAtLeast5)
        {
            result += "V";
        }

        for (int i = 0; i < number; i++)
        {
            result += "I";
        }

        return result;
    }
}