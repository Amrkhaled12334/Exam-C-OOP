namespace MyConsoleApp.Models;

public class Question : BaseModel
{
    public string[] Choices { get; set; }
    public int CorrectAnswer { get; set; }

    public Question(int id, string text, string[] choices, int correctAnswer) 
        : base(id, text)
    {
        Choices = choices;
        CorrectAnswer = correctAnswer;
    }

    public void ShowQuestion()
    {
        Console.WriteLine($"🔹 Question: {Name}");
        for (int i = 0; i < Choices.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Choices[i]}");
        }
    }
}