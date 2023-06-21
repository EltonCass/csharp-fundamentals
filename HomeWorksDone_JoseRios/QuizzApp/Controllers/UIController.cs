using QuizzApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizzApp.FakeDB;
using QuizzApp.Interfaces;

namespace QuizzApp.Controllers
{
    public class UIController
    {
        public static void PrintMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" __________ ");
            Console.WriteLine("| QUIZZapp |");
            Console.WriteLine(" ---------- ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.WriteLine("(select any option by typing the number)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Available Quizz Collections");
            Console.ResetColor();
        }

        public static void PrintAvailableCollections()
        {
            List<QuizzCollection> collections = DB.GetCollections();
            foreach (var pair in AppController.QuizzCollectionMap)
                Console.WriteLine($"[{pair.Key}] {pair.Value.Name}");
        }

        public static void PrintAvailableQuizzes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Selected Collection: {AppController.SelectedCollection?.Name}");
            Console.WriteLine($"Quizzes in {AppController.SelectedCollection?.Name}");
            Console.ResetColor();
            for(int i = 0; i < AppController.SelectedCollection?.Quizzes?.Count; i++)
                Console.WriteLine($"[{i+1}] {AppController.SelectedCollection?.Quizzes[i].Name}");
        }

        public static void PrintSelectedQuizz()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(AppController.SelectedQuizz!.Name!);
            Console.WriteLine(AppController.SelectedQuizz!.Description!);
            Console.WriteLine("");
            Console.ResetColor();
        }
    }
}
