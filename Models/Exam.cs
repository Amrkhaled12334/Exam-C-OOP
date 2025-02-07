namespace MyConsoleApp.Models;

public class Exam
{
    public List<Question> Questions { get; set; }

    public Exam()
    {
        Questions = new List<Question>();
    }

    public void AddQuestion(Question question)
    {
        Questions.Add(question);
    }

    public void StartExam()
    {
        int score = 0;
        foreach (var question in Questions)
        {
            question.ShowQuestion();
            Console.Write("✔️ Your Answer: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == question.CorrectAnswer)
            {
                Console.WriteLine("✅ Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"❌ Wrong! Correct answer is: {question.CorrectAnswer}\n");
            }
        }
        Console.WriteLine($"📊 Your Final Score: {score}/{Questions.Count}");
    }
}