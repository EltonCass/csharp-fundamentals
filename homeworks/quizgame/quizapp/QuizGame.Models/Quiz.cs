using QuizGame.Models.Enums;

namespace QuizGame.Models;

public class Quiz
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public HashSet<Category> Categories { get; set; }
    public HashSet<Question> Questions { get; set; }

    public Quiz(string? name, string? description, HashSet<Question> questions, HashSet<Category> categories)
    {
        Name = name;
        Description = description;
        Categories = categories;
        Questions = questions;
    }

}
