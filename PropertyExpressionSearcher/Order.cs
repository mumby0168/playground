namespace PropertyExpressionSearcher;

public class Order
{
    public Order()
    {
        Id = Guid.NewGuid().ToString();
        ItemsOrdered = 5;
    }
    
    public string Id { get; set; }

    public int ItemsOrdered { get; set; }
}