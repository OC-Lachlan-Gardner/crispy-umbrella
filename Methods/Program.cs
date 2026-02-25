class Badge
{
    public string name;

    public int level;

    public string Label;

    public Badge(string badgeName, int badgeLevel)
    {
        name = badgeName;

        level = badgeLevel;

        Label = $"{name} - Level {level}";
    }

    public string label()
    {
        return $"{name} - Level {level}";
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Badge newBadge = new Badge("Ranger", 4);

        Console.WriteLine(newBadge.label());

        Badge newerBadge = new Badge("Mage", 9);

        Console.WriteLine(newerBadge.Label);


    }
}