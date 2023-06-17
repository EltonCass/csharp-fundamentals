using QuizGame.Models.Enums;

namespace QuizGame.Models;

public class Quiz
{
    public string Name { get; set; }
    public string Description { get; set; }
    public HashSet<string> Categories { get; set; }
    public List<Question> Questions { get; set; }

    public Quiz(string name, string description, HashSet<string> categories)
    {
        Name = name;
        Description = description;
        Categories = categories;
    }

    public override string ToString()
    {
        string categories = Helper.EnumerableToString(Categories);
        return "User´s name: " + Name + "\nDescription: " + Description + "\nCategories: " + categories;
    }

}
