namespace MyConsoleApp.Models;

public class Subject : BaseModel
{
    public Exam Exam { get; set; }

    public Subject(int id, string name) : base(id, name)
    {
        Exam = new Exam();
    }
}