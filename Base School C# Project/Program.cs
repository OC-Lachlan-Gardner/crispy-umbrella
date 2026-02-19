class Rectangle
{
    public double width;

    public double height;

    public Rectangle(double rectWidth, double rectHeight)
    {
        width = rectWidth;
        height = rectHeight;
    }

    public double Area()
    {
        return width * height;
    }
}
class Program
{
    static double compare(Rectangle rectangleOne, Rectangle rectangleTwo)
    {
        double largerArea = Math.Max(rectangleOne.Area(), rectangleTwo.Area());

        return largerArea;
    }

    static void Main(string[] args)
    {
        Rectangle rectOne =  new Rectangle(1.34, 2.43);

        Rectangle rectTwo = new Rectangle(2.32, 5.6);

        Console.WriteLine(rectOne.Area());

        Console.WriteLine(rectTwo.Area());

        Console.WriteLine($"The largest area is {compare(rectOne, rectTwo)}.");
    }
}
