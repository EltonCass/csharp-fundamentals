namespace QuizGame.Models;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string? Score { get; set; }

    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public override string ToString()
    {
        return "User´s name: " + Name + "\nScore: " + Score + "\nEmail: " + Email;
    }
}


