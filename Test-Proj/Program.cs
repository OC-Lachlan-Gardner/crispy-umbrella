class Program
{
    static void Main(string[] args)
    {
        List<int> test = [0, 9, 34, 42, -9];

        Console.WriteLine(test.Aggregate((a, b) => a + b));
    }
}       