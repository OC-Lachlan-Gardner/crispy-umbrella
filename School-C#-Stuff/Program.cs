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

// It doesn't have to access specific assigned properties, so it's better to have it as a static method.