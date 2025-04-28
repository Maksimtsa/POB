using ConsoleApp2.Models;

namespace TaskApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ConsoleApp2.Models.Task task1 = new ConsoleApp2.Models.Task();

            task1.Title = "123";
            task1.Description = "321";
            task1.DueDate = DateTime.Now;
            task1.IsCompleted = false;
            task1.DisplayInfo();

            ConsoleApp2.Models.Task task2 = new ConsoleApp2.Models.Task("zadanie 2", "Opis 2 zad", DateTime.Now.AddDays(5), true, PriorityLevel.Niski);
            task2.DisplayInfo();

            try
            {
                task2.DueDate = DateTime.Now.AddDays(-5);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }

            task2.DueDate.AddDays(5);
            task2.DisplayInfo();

            try
            {
                //task2.Priority = PriorityLevel.Niski;
                task2.Priority = (PriorityLevel)0;
            }
            catch(AggregateException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }

            task2.DisplayInfo();
        }
    }
}
