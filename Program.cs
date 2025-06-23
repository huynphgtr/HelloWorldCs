public class Greeter
{
    public string GetGreeting() => "Hello, World!";
}

class Program
{
    static void Main()
    {
        var greeter = new Greeter();
        for (int i = 0; i < 4; i++)
            Console.WriteLine(greeter.GetGreeting());
    }
}
