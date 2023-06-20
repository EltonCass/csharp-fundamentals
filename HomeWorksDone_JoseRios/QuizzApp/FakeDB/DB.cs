using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizzApp.Interfaces;
using QuizzApp.Models;

namespace QuizzApp.FakeDB
{
    public class DB
    {
        // ---------- QUESTIONS ----------------
        private static List<IQuestion> _questions = new List<IQuestion>
        {
            new Question_FillBlank("The Pyramids of Giza are located in ______.", 10, "egypt", 0),
            new Question_MultipleChoise("What is the color of the 2nd 'G' in Google?", 10, "blue", new string[4] {"Red","Green","Blue","Yellow" }),
            new Question_FillBlank("In the city of ______ MA, United States. Basketball were invented.", 10, "springfield", 0),
            new Question_MultipleChoise("Which country won the Fifa World Cup in 2014?", 10, "germany", new string[4] {"Argentina","France","Italy","Germany" }),
        };

        public static List<IQuestion> GetQuestions() => _questions;

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
        private static List<Quizz> _quizzes = new List<Quizz>
        {
            new Quizz(
                "World War II Quizz",
                "Some Description about WWII",
                new HashSet<IQuestion>(GetQuestions()),
                new HashSet<Category>(GetCategories())
                ),
            new Quizz(
                "Sports Basics Quizz",
                "Introduction to sports",
                new HashSet<IQuestion>
                    {
                        new Question_FillBlank("Roger Federer is famous for playing _____.", 10, "tennis", 0),
                        new Question_MultipleChoise("How many NBA conferences are?", 10, "two", new string[4]{"One", "Two", "Three", "Four"})
                    },
                new HashSet<Category>(GetCategories().Where(c => c.Name == "Sports"))
                )
        };

        public static List<Quizz> GetQuizzs() => _quizzes;

        // ---------- COLLECTIONS ----------------
        private static List<QuizzCollection> _collections = new List<QuizzCollection>
        {
            new QuizzCollection("General", "All categories included", GetQuizzs()),
            new QuizzCollection("Sports", "Just Sports", GetQuizzs().Where(q => q.Name=="Sports Basics Quizz").ToList())
        };

        public static List<QuizzCollection> GetCollections() => _collections;

        // ---------- USERS ----------------
        private static List<User> _users = new List<User>
        {
            new User { Id = 1, Name = "JR", Email = "jr@mail.com" }
        };

        public static void AddUser(User user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }

        public static List<User> GetUsers() => _users;
    }
}
