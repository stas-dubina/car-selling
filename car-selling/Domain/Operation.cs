namespace CarDealer.Domain;

public class Operation
{

    public int Id { get; set; }

    public DateTime Timestamp { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }

    public Operation() { }

    public Operation(DateTime timestamp, string description, int amount)
    {
        this.Timestamp = timestamp;
        this.Description = description;
        this.Amount = amount;
    }
}

