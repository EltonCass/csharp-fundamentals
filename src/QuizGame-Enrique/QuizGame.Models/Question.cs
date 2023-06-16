namespace QuizGame.Models
{
    internal class Question
    {
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public string CorrectAnswer { get; set; }
        public Question(string text, List<string> choices, string correctAnswer)
        {
            Text = text;
            Choices = choices;
            CorrectAnswer = correctAnswer;
        }

        public override string ToString()
        {
            string choices = showChoices(Choices);
            return "Text: " + Text + "\nChoices: " + choices + "\nCorrectAnswer: " + CorrectAnswer;
        }

        private string showChoices(List<string> choices)
        {
            string result = string.Empty;
            foreach (var choice in choices)
            {
                result = result + "\n" + choice;
            }
            return result;
        }
    }
}
