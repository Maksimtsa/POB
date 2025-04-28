using System;

namespace ConsoleApp2.Models
{
    public enum PriorityLevel
    {
        Niski,
        Średni,
        Wysoki
    }
    public class Task
    {
        // Prywatne pola
        private string _title;
        private string _description;
        private DateTime _dueTime;
        private bool _isCompleted;
        private PriorityLevel _priority;

        public PriorityLevel Priority
        {
            get { return _priority; }
            set 
            {
                if(!Enum.IsDefined(typeof(PriorityLevel), value))
                {
                    throw new ArgumentException($"Priorytet: '{value}' nie jest dozwolony. Dozwolone prioritety: {string.Join(", ", Enum.GetNames(typeof(PriorityLevel)))} ");
                }
                _priority = value;
            }
        }

        // Właściwości z walidacją
        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Tytuł zadania nie może być pusty");
                }
                _title = value;
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Opis zadania nie może być pusty");
                }
                _description = value;
            }
        }

        public DateTime DueDate
        {
            get { return _dueTime; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("Data wykonania zadania nie może być w przeszłości");
                }
                _dueTime = value;
            }
        }

        public bool IsCompleted
        {
            get { return _isCompleted; }
            set { _isCompleted = value; }
        }

        // Konstruktor domyślny
        public Task()
        {
            _title = "Nieokreślony tytuł";
            _description = "Brak opisu";
            _dueTime = DateTime.Now.AddDays(1);
            _isCompleted = false;
            _priority = PriorityLevel.Średni;
        }

        // Konstruktor z parametrami
        public Task(string title, string description, DateTime dueTime, bool isCompleted, PriorityLevel priority)
        {
            Title = title;
            Description = description;
            DueDate = dueTime;
            IsCompleted = isCompleted;
            Priority = priority;
        }

        // Metoda wyświetlająca informacje o zadaniu
        public void DisplayInfo()
        {
            Console.WriteLine($"Zadanie: {Title}\nOpis: {Description}\nTermin wykonania:{DueDate}\nStan: {IsCompleted}\nPriorited{Priority}");
        }
    }
}
