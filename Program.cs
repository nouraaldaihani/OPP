// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




var student = new Student("Noura", "EE", 4.0);

student.PrintInformation();
public class Student
{

    public string Name { get; set; }
    public string Major { get; set; }
    public double GPA { get; set; }

    public Student(string name, string major, double gpa)

    {
        Name = name;
        Major = major;
        GPA = gpa;

    }

    public void PrintInformation()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Major : {Major}");
        Console.WriteLine($"GPA : {GPA}");

    }
}