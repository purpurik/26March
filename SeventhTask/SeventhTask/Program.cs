using System;
using System.Collections.Generic;

class Student : IComparable<Student>
{
    public string Name { get; }
    public int Grade { get; }

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public int CompareTo(Student other)
    {
        return Grade.CompareTo(other.Grade);
    }

    public override string ToString()
    {
        return $"{Name}: {Grade}";
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Анна", 85),
            new Student("Борис", 92),
            new Student("Виктор", 78),
            new Student("Галина", 90)
        };

        students.Sort();

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
