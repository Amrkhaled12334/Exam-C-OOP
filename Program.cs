// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using MyConsoleApp.Models;

class Program
{
    static void Main()
    {
        // Create a subject
        Subject programming = new Subject(1, "Programming");

        // Add questions to the exam
        programming.Exam.AddQuestion(new Question(101, "What is 2 + 2?", new string[] { "3", "4", "5" }, 2));
        programming.Exam.AddQuestion(new Question(102, "What is the capital of France?", new string[] { "Berlin", "Madrid", "Paris" }, 3));

        // Start the exam
        programming.Exam.StartExam();
    }
}
