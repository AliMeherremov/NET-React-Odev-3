using System;

class Employee
{
    public int Id;
    public string Name;
    public double Salary;
    public string Department;

    public Employee(int id, string name, double salary, string department)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Department = department;
    }

    public virtual double CalculateBonus()
    {
        return 0; 
    }

    public void ShowInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}, Department: {Department}");
    }
}

class Manager : Employee
{
    public int TeamSize;

    public Manager(int id, string name, double salary, string department, int teamSize)
        : base(id, name, salary, department)
    {
        TeamSize = teamSize;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.20; // Yöneticilere %20 prim
    }
}

class Developer : Employee
{
    public string About;

    public Developer(int id, string name, double salary, string department, string about)
        : base(id, name, salary, department)
    {
        About = about;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.10; // Çalışanlara %10 prim
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager(1, "Ahmet", 10000, "Yönetim", 5);
        Developer developer = new Developer(2, "Mehmet", 8000, "Yazılım", "C# Öğreniyor");

        manager.ShowInfo();
        Console.WriteLine("Manager Bonus: " + manager.CalculateBonus() + " TL");

        Console.WriteLine("-----------------------");

        developer.ShowInfo();
        Console.WriteLine("Developer Bonus: " + developer.CalculateBonus() + " TL");
    }
}
