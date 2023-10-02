using System.Linq.Expressions;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What\'s your favorite subject in?");
            var subject  = (Console.ReadLine());
            Console.WriteLine();
            switch (subject)
            {
                case "math":
                case "Math":
                    Console.WriteLine("I like Math too!");
                    break;
                case "science":
                case "Science":
                    Console.WriteLine("I like Science too!");
                    break;
                case "biology":
                case "Biology":
                    Console.WriteLine("I like biology too!");
                    break;
                case "gym":
                case "Gym":
                    Console.WriteLine("I like Gym too!");
                   break;
                case "art":
                case "Art":
                    Console.WriteLine("I like Art too!");
                    break;
                default:
                    Console.WriteLine("I like most subjects in school because I " +
                        "like to learn.");
                    break;
            }
        }

    }
}