namespace DddActor.Domain.AggregateRoot;

public partial class Order
{
    public static Order Create(Guid id, DateTime createStamp)
    {
        return new Order(id, createStamp);
    }
}