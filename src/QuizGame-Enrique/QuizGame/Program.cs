// See https://aka.ms/new-console-template for more information
using QuizGame.Models;
Console.WriteLine("Hello, World!");

List<string> list = new List<string>() { "yes", "no"};
Question newQuestion = new Question("Is this a question", list, "yes");
Console.WriteLine(newQuestion.ToString());