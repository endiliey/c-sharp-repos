public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public string Greet(string otherName)
    {
        return "Hi " + otherName + ", my name is " + name;
    }
}