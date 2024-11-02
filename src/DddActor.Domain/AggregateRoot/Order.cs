namespace DddActor.Domain.AggregateRoot;

public partial class Order
{
    public Guid Id { get; private set; }
    public DateTime CreateStamp { get; private set; }

    private Order(Guid id, DateTime createStamp)
    {
        Id = id;
        CreateStamp = createStamp;
    }
}