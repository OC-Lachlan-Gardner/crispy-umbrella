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

    public static Enrolled? Decode(string encodedString)
    {
        Enrolled decodedString = JsonConvert.DeserializeObject<Enrolled>(encodedString)!;
        return decodedString;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Student testStudent = new Student("Lachlan", 17);

        Course testCourse = new Course("Digi");

        Enrolled testEnrolled = new Enrolled(testStudent.ID, testCourse.ID);

        string testEnrolledEncoded = Enrolled.Encode(testEnrolled);

        Enrolled testEnrolledDecoded = Enrolled.Decode(testEnrolledEncoded)!;

        Console.WriteLine(testEnrolledEncoded);

        Console.WriteLine(testEnrolledDecoded.StudentID);
    }
}