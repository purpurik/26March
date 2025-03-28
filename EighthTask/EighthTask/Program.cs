using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; }
    public decimal Salary { get; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{Name}: {Salary:C}";
    }
}

class EmployeeComparer : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
    {
        return x.Salary.CompareTo(y.Salary);
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Анна", 55000),
            new Employee("Борис", 72000),
            new Employee("Виктор", 48000),
            new Employee("Галина", 62000)
        };

        employees.Sort(new EmployeeComparer());

        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}
