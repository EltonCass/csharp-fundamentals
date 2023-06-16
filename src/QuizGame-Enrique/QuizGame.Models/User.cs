namespace QuizGame.Models;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string? Score { get; set; }

    public User(string name, string email, string? score)
    {
        Name = name;
        Email = email;
        Score = score;
    }

    public override string ToString()
    {
        return "Username: " + Name + "\nScore: " + Score + "\n Email: " + Email;
    }
}