using QuizzApp.FakeDB;
using QuizzApp.Helpers;
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
            //////////
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(SelectedQuizz.Name);
            Console.WriteLine(SelectedQuizz.Description);
            Console.ResetColor();
        }
    }
}
