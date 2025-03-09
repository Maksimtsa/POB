using System;

namespace ConsoleApp8
{
    internal class Program
    {
        public class Employee
        {
            public string Name { get; }
            public DateOnly DateOfBirth { get; }
            public int Age => CalculateAge();

            public Employee(string name, DateOnly dateOfBirth)
            {
                Name = name;
                DateOfBirth = dateOfBirth;
            }

            private int CalculateAge()
            {
                var today = DateOnly.FromDateTime(DateTime.Today);
                int age = today.Year - DateOfBirth.Year;
                if (DateOfBirth > today.AddYears(-age)) --age;
                return age;
            }
        }

        static void Main(string[] args)
        {
            string name = GetValidName();
            DateOnly dateOfBirth = GetValidDateOfBirth();

            Employee emp = new Employee(name, dateOfBirth);
            Console.WriteLine($"Pracownik: {emp.Name}, wiek: {emp.Age}");
        }

        private static DateOnly GetValidDateOfBirth()
        {
            DateOnly dateOfBirth;
            bool isValidDate = false;
            do
            {
                Console.WriteLine("Podaj datę urodzenia (RRRR - MM - DD): ");
                string input = Console.ReadLine();

                if (DateOnly.TryParse(input, out dateOfBirth) && dateOfBirth <= DateOnly.FromDateTime(DateTime.Now))
                {
                    isValidDate = true;
                }
                else
                {
                    Console.Write("Błędny format! Podaj datę ponownie (RRRR-MM-DD): ");
                }
            }
            while (!isValidDate);
            return dateOfBirth;
            //Console.Write("Podaj datę urodzenia (RRRR-MM-DD): ");
            //DateOnly dateOfBirth;

            //while (!DateOnly.TryParse(Console.ReadLine(), out dateOfBirth))
            //{
            //    Console.Write("Błędny format! Podaj datę ponownie (RRRR-MM-DD): ");
            //}
            //return dateOfBirth;
        }

        private static string GetValidName()
        {
            string name;
            const byte MinLength = 3;
            const byte MaxLength = 50;

            string[] errorMessange = new string[]
            {
                "Imie new może być puste!",
                $"Imie musi mieć co najmniej {MinLength} znaków",
                $"Imie nie może mieć więcej niż {MaxLength} znaków"
            };

            while (true)
            {
                Console.WriteLine("Podaj imie(Min: 3 znaki, Max: 50 znaków): ");
                name = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine(errorMessange[0]);
                }
                else if (name.Length < MinLength)
                {
                    Console.WriteLine(errorMessange[1]);
                }
                else if (name.Length < MaxLength)
                {
                    Console.WriteLine(errorMessange[2]);
                }
                while (string.IsNullOrWhiteSpace(name) || name.Length < MinLength || name.Length > MaxLength) return name;
            }
        }
    }
}
