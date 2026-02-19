class Car
{
    public string brand;

    public string model;

    public int year;

    public Car(string carBrand, string carModel, int carYear)
    {
        brand = carBrand;
        model = carModel;
        year = carYear;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car Rolls = new Car("Rolls Royce", "Something from Rolls Royce", 1989);

        Car Porsche = new Car("Porshce", "Something from Porsche", 1999);

        Console.WriteLine($"Car from {Rolls.brand}, model is {Rolls.model}, made in {Rolls.year}");

        Console.WriteLine($"Car from {Porsche.brand}, model is {Porsche.model}, made in {Porsche.year}");
    }
}
