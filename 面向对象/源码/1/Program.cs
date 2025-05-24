namespace ClassAndObject;

internal static class ClassAndObject
{
    public static void Main(string[] args)
    {
        Person person1 = new Person();
        Person person2 = new Person();
        
        person1.Set("John", 30);
        person2.Set("Jane", 25);

        Console.WriteLine("Name: " + person1.Name + ", Age: " + person1.Age);
        Console.WriteLine("Name: " + person2.Name + ", Age: " + person2.Age);
    }
}