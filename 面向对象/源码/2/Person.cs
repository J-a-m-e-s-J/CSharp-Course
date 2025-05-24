namespace Constructor;

public class Person(string name = "default name", int age = 0)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public void Show()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public void Show(string item)
    {
        switch (item)
        {
            case "name":
                Console.WriteLine($"Name: {Name}");
                break;
            case "age":
                Console.WriteLine($"Age: {Age}");
                break;
        }
    }
}