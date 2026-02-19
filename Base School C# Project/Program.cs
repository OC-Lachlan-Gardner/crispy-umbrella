using System.ComponentModel.DataAnnotations;
using System.Data.Common;

public class Student
{
    public int id;

    public string name;

    public string NSN;

    public string email;

    public int age;

    public int score;

    public Student(int idNumber, string studentName, string studentNSN, string studentEmail, int studentAge, int studentScore)
    {
        id = idNumber;
        name = studentName;
        NSN = studentNSN;
        email = studentEmail;
        age = studentAge;
        score = studentScore;
    }

    public string summary()
    {
        return $"{name} has {score} points.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student lachlan = new(123, "Lachlan", "NSN1234", "lachlan.gardner@student.onslow.school.nz", 17, 14);

        Console.WriteLine(lachlan.id);
        Console.WriteLine(lachlan.name);
        Console.WriteLine(lachlan.NSN);
        Console.WriteLine(lachlan.email);
        Console.WriteLine(lachlan.age);

        Console.WriteLine(lachlan.summary());
        
    }
}
