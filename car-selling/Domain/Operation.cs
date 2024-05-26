namespace CarDealer.Domain;

public class Operation
{
    public DateTime Timestamp { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }

    public Operation(DateTime timestamp, string description, decimal amount)
    {
        this.Timestamp = timestamp;
        this.Description = description;
        this.Amount = amount;
    }
}

