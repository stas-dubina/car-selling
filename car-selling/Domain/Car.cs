namespace CarDealer.Domain;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public FuelType Type { get; set; }
    public string Description { get; set; }

    public Car(int id, string name, int year, FuelType type, string description)
    {
        Id = id;
        Name = name;
        Year = year;
        Type = type;
        Description = description;
    }
}