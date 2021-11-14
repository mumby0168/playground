namespace PropertyExpressionSearcher;

public class Customer
{
    public string Name { get; set; }

    public int Age { get; set; }
    
    public Order Order { get; set; } = new();

    public Customer(string name, int age)
    {
        Name = name;
        Age = age;
    }
}