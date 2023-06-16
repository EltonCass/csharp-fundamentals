using QuizGame.Models.Enums;

namespace QuizGame.Models;

public class Collection
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int? TotalScore { get; set; }
    public Category Category { get; set; }
    public List<User> Users { get; set; }
    public List<Quiz> Quizzes { get; set; }
    public List<Question> Questions { get; set; }

    public Collection(string name, string description, Category category)
    {
        Name = name;
        Description = description;
        Category = category;
    }
}
