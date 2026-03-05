using System.Text.Json; 

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
    Guid StudentID;

    Guid CourseID;

    public Enrolled(Guid studentID, Guid courseID)
    {
        StudentID = studentID;

        CourseID = courseID;
    }

    public static string Encode(Enrolled enrolled)
    {

        string encodedString = JsonSerializer.Serialize(enrolled);
        return encodedString;
    }

    // public static Enrolled Decode(string encodedString)
    // {
    //     return JsonSerializer.Deserialize<Enrolled>(encodedString);
    // }
}

class Program
{
    public static void Main(string[] args)
    {
        Student testStudent = new Student("Lachlan", 17);

        Course testCourse = new Course("Digi");
        
        Console.WriteLine(testCourse.Description);

        Enrolled testEnrolled = new Enrolled(testStudent.ID, testCourse.ID);

        string encodedStudent = JsonSerializer.Serialize(testStudent);

        Enrolled testDecode = JsonSerializer.Deserialize<Enrolled>(encodedStudent)!;
        Console.WriteLine(testDecode);
    }
}