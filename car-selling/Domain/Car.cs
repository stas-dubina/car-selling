namespace CarDealer.Domain;

public class Car
{
    public int Id { get; set; }

    public CarModel Model { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public List<Operation> Tasks { get; set; }
    public decimal Balance
    {
        get
        {
            return Tasks.Sum(t => t.Amount);
        }
    }

    public Car() { }

    public Car(int id, CarModel model, int year, string description, List<Operation> tasks)
    {
        Id = id;
        Model = model;
        Year = year;
        Description = description;
        Tasks = tasks;
    }
}