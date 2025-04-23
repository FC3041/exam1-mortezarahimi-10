public class Q4Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Q4Person(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}