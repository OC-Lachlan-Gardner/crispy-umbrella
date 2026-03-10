using Newtonsoft.Json;

interface IIdentifiable
{
    Guid ID
    {
        set => Guid.NewGuid();
    }
}

interface IDescribable
{
    public string Description
    {
        get;
    }
}

interface Ipoints
{
    int points
    {
        get;
    }
}

interface IHashable
{
    string Hash
    {
        get;    
    }
}

class Student: IIdentifiable
{
    public Guid ID = Guid.NewGuid();
    
    public string Name;

    public int Age;

    public Student(string studentName, int studentAge)
    {
        Name = studentName;

        Age = studentAge;
    }
}

class Course: IIdentifiable, IDescribable
{
    public Guid ID = Guid.NewGuid();

    public string Title;
    public string Description => $"Title of the course is {Title}";

    public Course(string courseTitle)
    {
        Title = courseTitle;
    }
}

class Enrolled
{
    public Guid StudentID;

    public Guid CourseID;

    public string Hash => $"{StudentID}.{CourseID}";

    public Enrolled(Guid studentID, Guid courseID)
    {
        StudentID = studentID;

        CourseID = courseID;
    }

    public static string Encode(Enrolled enrolled)
    {

        string encodedString = JsonConvert.SerializeObject(enrolled);
        return encodedString;
    }

    public static Enrolled Decode(string encodedString)
    {
        Enrolled decodedString = JsonConvert.DeserializeObject<Enrolled>(encodedString)!;
        return decodedString;
    }
}

class ScoreEntry: Ipoints
{
    public Guid StudentID;

    int pointsInput;

    public int points => pointsInput;

    public ScoreEntry(Guid studentID, int studentsPoints)
    {
        StudentID = studentID;
        pointsInput = studentsPoints;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student testStudent1 = new Student("Lachlan", 17);
        Course testCourse1 = new Course("Digi");

        Student testStudent2 = new Student("Lachlan", 17);
        Course testCourse2 = new Course("Digi");

        Student testStudent3 = new Student("Lachlan", 17);
        Course testCourse3 = new Course("Digi");

        Student testStudent4 = new Student("Lachlan", 17);
        Course testCourse4 = new Course("Digi");

        Enrolled testEnrolled1 = new Enrolled(testStudent1.ID, testCourse1.ID);
        Enrolled testEnrolled2 = new Enrolled(testStudent2.ID, testCourse2.ID);
        Enrolled testEnrolled3 = new Enrolled(testStudent3.ID, testCourse3.ID);
        Enrolled testEnrolled4 = new Enrolled(testStudent4.ID, testCourse4.ID);

        ScoreEntry test1 = new ScoreEntry(testStudent1.ID, 33);
        ScoreEntry test2 = new ScoreEntry(testStudent2.ID, 334);
        ScoreEntry test3 = new ScoreEntry(testStudent3.ID, -09);
        ScoreEntry test4 = new ScoreEntry(testStudent4.ID, 234);

        int[] scores = {test1.points, test2.points, test3.points, test4.points};

        Array.Sort(scores);

        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }

        HashSet<string> newSet = new HashSet<string>();

        newSet.Add(testEnrolled1.Hash);
        newSet.Add(testEnrolled2.Hash);
        newSet.Add(testEnrolled3.Hash);

        // Shouldn't be added as it's a duplicate.
        newSet.Add(testEnrolled1.Hash);

        foreach (string item in newSet)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(newSet.Count);
    }
}