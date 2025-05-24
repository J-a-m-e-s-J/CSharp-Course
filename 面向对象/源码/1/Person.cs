namespace ClassAndObject;

public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Set(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}