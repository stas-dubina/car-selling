namespace CarDealer.Domain;

public class Car
{
    public int Id { get; set; }

    public Model Model { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public CarStatus Status { get; set; }
    public List<Operation> Tasks { get; set; }
    public int Balance
    {
        get
        {
            return Tasks.Sum(t => t.Amount);
        }
    }

    public Car() { }

    public Car(int id, Model model, int year, string description, CarStatus status, List<Operation> tasks)
    {
        Id = id;
        Model = model;
        Year = year;
        Description = description;
        Status = status;
        Tasks = tasks;
    }
}