namespace QuizGame.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string? Score { get; set; }

    public User(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public override string ToString()
    {
        return "ID: " + Id + "User´s name: " + Name + "\nScore: " + Score + "\nEmail: " + Email;
    }
}


