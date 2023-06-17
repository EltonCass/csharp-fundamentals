namespace QuizGame.Models;

public class Question
{
    public string Text { get; set; }
    public List<string> Choices { get; set; }
    public string CorrectAnswer { get; set; }

    public Question(string text, List<string> choices, string correctAnswer)
    {
        Text = text;
        Choices = choices;
        CorrectAnswer = correctAnswer;
    }

    public override string ToString()
    {
        string choices = Helper.EnumerableToString(Choices);
        return "Text: " + Text + "\nChoices: \n" + choices + "CorrectAnswer: " + CorrectAnswer;
    }

}
