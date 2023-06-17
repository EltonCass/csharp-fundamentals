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
            string categories = Helper.CollectionToString(Categories);
            return $"Username: {Name} \nDescription: {Description} \nCategories: {categories}";
        }
    }
}
