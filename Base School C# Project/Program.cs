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
    static string compare(Rectangle rectangleOne, Rectangle rectangleTwo)
    {
        int largerArea = Math.Max(rectangleOne.Area(), rectangleTwo.Area());
    }

    static void Main(string[] args)
    {
        Rectangle rectOne =  new Rectangle(1.34, 2.43);

        Rectangle rectTwo = new Rectangle(2.32, 5.6);

        
    }
}
