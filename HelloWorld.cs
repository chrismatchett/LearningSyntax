using NUnit.Framework;

[TestFixture]
public class HelloWorldTest
{
    [Test]
    public void TestHelloWorld()
    {
        string expected = "Hello, World!";
        string actual = HelloWorld.GetMessage();
        Assert.AreEqual(expected, actual);
    }
}

public class HelloWorld
{
    public static string GetMessage()
    {
        return "Hello, World!";
    }
}
