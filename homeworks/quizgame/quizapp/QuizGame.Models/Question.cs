namespace QuizGame.Models;

public class Question
{
    public string Text { get; init; }
    public string CorrectAnswer { get; init; }
    public int Score { get; set; } = 0;

    public Question(string text, int score, string correctAnswer)
    {
        Score = score;
        Text = text;
        CorrectAnswer = correctAnswer;
    }

    public override string ToString()
    {
        return "Text: " + Text + "CorrectAnswer: " + CorrectAnswer + "Score: " + Score;
    }

}
