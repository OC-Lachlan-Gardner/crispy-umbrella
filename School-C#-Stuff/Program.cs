class Temperature
{
        public static double ToFahrenheit(double celsius)
    {
        double fahrenheit = celsius * 9 / 5 + 32;

        return fahrenheit;
    }

    public static double ToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit -32) * 5 / 9;

        return celsius;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<Double> temps = [12, 123, 321,  0, -234];

        foreach (double temp in temps)
        {
            Console.WriteLine($"{temp} to Fahrenheit: {Temperature.ToFahrenheit(temp)}");

            Console.WriteLine($"{temp} to Celsius: {Temperature.ToCelsius(temp)}");
        }
    }
}

// It's better because it keeps the code cleaner when it's contained within the Temperature class.