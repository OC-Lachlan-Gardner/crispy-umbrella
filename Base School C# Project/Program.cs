using System.ComponentModel.DataAnnotations;
using System.Data.Common;

public struct Student
{
    public int id;

    public string name;

    public string NSN;

    public string email;

    public int age;

    public Student(int idNumber, string studentName, string studentNSN, string studentEmail, int studentAge)
    {
        id = idNumber;
        name = studentName;
        NSN = studentNSN;
        email = studentEmail;
        age = studentAge;
    }

    static void Main(string[] args)
    {
        Student lachlan = new(123, "Lachlan", "NSN1234", "lachlan.gardner@student.onslow.school.nz", 17);

        Console.WriteLine(lachlan.id);
        Console.WriteLine(lachlan.name);
        Console.WriteLine(lachlan.NSN);
        Console.WriteLine(lachlan.email);
        Console.WriteLine(lachlan.age);
        
    }
}
