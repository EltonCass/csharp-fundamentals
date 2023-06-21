using QuizGame.Models;

namespace QuizGame.Data;

public class DataBase
{
    // ---------- QUESTIONS ----------------
    private static List<Question> _questions = new List<Question>
        {
            new FillBlankQuestion("The Pyramids of Giza are located in _____.", 10, "egypt", 8),
            new MultipleChoiceQuestion("What is the color of the 2nd 'G' in Google?", 10, "blue", new List<string> {"Red","Green","Blue","Yellow" }),
            new FillBlankQuestion("In the city of ______ MA, United States. Basketball were invented.", 10, "springfield", 0),
            new MultipleChoiceQuestion("Which country won the Fifa World Cup in 2014?", 10, "germany", new List<string> {"Argentina","France","Italy","Germany" }),
        };

    public static List<Question> GetQuestions() => _questions;

    // ---------- CATEGORIES ----------------
    private static List<Category> _categories = new List<Category>
        {
            new Category {Name = "History" },
            new Category {Name = "Science" },
            new Category {Name = "Sports" },
            new Category {Name = "Entertainment" }
        };

    public static List<Category> GetCategories() => _categories;

    // ---------- QUIZZES ----------------
    private static List<Quiz> _quizzes = new List<Quiz>
        {
            new Quiz(
                "World War II Quizz",
                "Some Description about WWII",
                new HashSet<Question>(GetQuestions()),
                new HashSet<Category>(GetCategories())
                ),
            new Quiz(
                "Sports Basics Quizz",
                "Introduction to sports",
                new HashSet<Question>
                    {
                        new FillBlankQuestion("Roger Federer is famous for playing _____.", 10, "tennis", 0),
                        new MultipleChoiceQuestion("How many NBA conferences are?", 10, "two", new List<string> {"One", "Two", "Three", "Four"})
                    },
                new HashSet<Category>(GetCategories().Where(c => c.Name == "Sports"))
                )
        };

    public static List<Quiz> GetQuizzs() => _quizzes;

    // ---------- COLLECTIONS ----------------
    private static List<Collection> _collections = new List<Collection>
        {
            new Collection("General", "All categories included", GetQuizzs()),
            new Collection("Sports", "Just Sports", GetQuizzs().Where(q => q.Name=="Sports Basics Quizz").ToList())
        };

    public static List<Collection> GetCollections() => _collections;

    // ---------- USERS ----------------
    private static List<User> _users = new List<User>
        {
            new User ( 1, "Luis", "luis.angarita@mail.com" )
        };

    public static void AddUser(User user)
    {
        user.Id = _users.Count + 1;
        _users.Add(user);
    }

    public static List<User> GetUsers() => _users;
}

