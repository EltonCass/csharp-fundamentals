using QuizGame.Models.Enums;

namespace QuizGame.Models;

public class Quiz
{
    public string Name { get; set; }
    public string Description { get; set; }
    public HashSet<Category> Categories { get; set; }

    public Quiz(string name, string description, HashSet<Category> categories)
    {
        Name = name;
        Description = description;
        Categories = categories;
    }

    public override string ToString()
    {
        string categories = showChoice(Categories);
        return "User´s name: " + Name + "\nDescription: " + Description + "\nCategories: " + categories;
    }

    private string showChoice(HashSet<Category> choices)
    {
        string result = string.Empty;
        foreach (var choice in choices)
        {
            result = result + "\n" + choice;
        }
        return result;
    }

}
