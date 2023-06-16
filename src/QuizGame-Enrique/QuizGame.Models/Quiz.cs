namespace QuizGame.Models
{
    internal class Quiz
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public HashSet<string> Categories { get; set; }

        public Quiz(string name, string description, HashSet<string> categories)
        {
            Name = name;
            Description = description;
            Categories = categories;
        }

        public override string ToString()
        {
            return "Username: " + Name + "\nDescription: " + Description + "\n Email: " + showCategories(Categories);
        }

        private string showCategories(HashSet<string> categories)
        {
            string result = string.Empty;
            foreach (var category in categories)
            {
                result = result + "\n" + category;
            }
            return result;
        }
    }
}
