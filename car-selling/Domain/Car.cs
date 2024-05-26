namespace CarDealer.Domain;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public FuelType Type { get; set; }
    public string Description { get; set; }
    public List<Operation> Tasks { get; set; }
    public decimal Balance
    {
        get
        {
            return Tasks.Sum(t => t.Amount);
        }
    }

    public Car(int id, string name, int year, FuelType type, string description, List<Operation> tasks)
    {
        Id = id;
        Name = name;
        Year = year;
        Type = type;
        Description = description;
        Tasks = tasks;
    }
}