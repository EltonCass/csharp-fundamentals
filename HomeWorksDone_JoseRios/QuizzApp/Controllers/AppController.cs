using QuizzApp.FakeDB;
using QuizzApp.Helpers;
using QuizzApp.Interfaces;
using QuizzApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Controllers
{
    public class AppController
    {
        public static Dictionary<int, QuizzCollection> QuizzCollectionMap = new Dictionary<int, QuizzCollection>();
        public static QuizzCollection? SelectedCollection { get; set; }
        public static Quizz? SelectedQuizz { get; set; }
        private static int _collectionsCount;

        public static void Run()
        {
            SelectionOfCollection();
            SelectionOfQuizz();
            AnswerTheQuestions();
        }

        private static void InitializeQuizzCollectionMap()
        {
            List<QuizzCollection> collections = DB.GetCollections();
            _collectionsCount = collections.Count;
            for (int i = 0; i < collections.Count; i++)
                QuizzCollectionMap.Add(i+1, collections[i]);
        }

        private static void SelectionOfCollection()
        {
            InitializeQuizzCollectionMap();
            UIController.PrintMenu();
            UIController.PrintAvailableCollections();
            string? input = InputValidator.InputWithoutNull();
            int selectedCollectionIndex = InputValidator.VerifyNumberInSelectOptions(input, _collectionsCount);
            var collection = new QuizzCollection();
            QuizzCollectionMap.TryGetValue(selectedCollectionIndex, out collection);
            SelectedCollection = collection;
        }

        private static void SelectionOfQuizz()
        {
            UIController.PrintAvailableQuizzes();
            string? input = InputValidator.InputWithoutNull();
            int indexQuizz = InputValidator.VerifyNumberInSelectOptions(input, SelectedCollection!.Quizzes!.Count);
            SelectedQuizz = SelectedCollection.Quizzes.ElementAt(indexQuizz - 1);
            UIController.PrintSelectedQuizz();
        }

        private static void AnswerTheQuestions()
        {
            foreach (IQuestion q in SelectedQuizz!.Questions!)
            {
                q.PrintQuestion();
                string answer = InputValidator.InputWithoutNull();
                if (typeof(QuestionMultipleChoice) == q.GetType())
                    answer = InputValidator.VerifyMultipleChoiceInput((QuestionMultipleChoice)q, answer);

                if (answer == q.CorrectAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Good (^ v ^)");
                    Console.WriteLine("+"+q.Score+"pts earned");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("keep studying...");
                    Console.ResetColor();
                }
            }
        }
    }
}
