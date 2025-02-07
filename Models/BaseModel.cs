namespace MyConsoleApp.Models;

public class BaseModel 
{
    public int Id { get; set; }
    public string Name { get; set; }

    public BaseModel(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}";
    }
}