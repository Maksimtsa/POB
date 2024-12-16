using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._12._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            bool exit = false;

            while (!exit)
            {
                DisplayMenu();
                Console.WriteLine("Twój wybór:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddElements(list);
                        break;
                    case "2":
                        AddRandomElements(list);
                        break;
                    case "3":
                        RemoveElement(list);
                        break;
                    case "4":
                        DisplayList(list);
                        break;
                    case "5":
                        SortAscending(list);
                        break;
                    case "6":
                        SortDescending(list);
                        break;
                    case "7":
                        ClearList(list);
                        break;
                    case "8":
                        exit = true;
                        break;
                    case "9":
                        FindElementAt(list);
                        break;
                    case "10":
                        DisplayStat(list);
                        break;
                    case "11":
                        RemoveDuplicates(list);
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Dodaj element do listy");
            Console.WriteLine("2. Dodaj losowe elementy do listy");
            Console.WriteLine("3. Usuń element z listy");
            Console.WriteLine("4. Wyświetl listę");
            Console.WriteLine("5. Posortuj niemalejąco");
            Console.WriteLine("6. Posortuj nierosnąco");
            Console.WriteLine("7. Wyczyść listę");
            Console.WriteLine("8. Wyjdź");
            Console.WriteLine("9. Wyszukiwanie w liscie");
            Console.WriteLine("10. Statystyki");
            Console.WriteLine("11. Usuń duplikaty z listy");
        }

        static void AddElements(List<int> list)
        {
            Console.WriteLine("Podaj liczbę do dodania:");
            int number = int.Parse(Console.ReadLine());
            list.Add(number);
            Console.WriteLine("Element został dodany do listy.");
        }

        static void AddRandomElements(List<int> list)
        {
            Console.WriteLine("Ile losowych liczb chcesz dodać?");
            int count = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                list.Add(rand.Next(1, 100));
            }
            Console.WriteLine($"{count} losowych liczb zostało dodanych do listy.");
        }

        static void RemoveElement(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Lista jest pusta. Nie można usunąć elementu.");
                return;
            }

            Console.WriteLine("Podaj indeks elementu do usunięcia:");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
                Console.WriteLine("Element został usunięty z listy.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy indeks.");
            }
        }

        static void DisplayList(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Lista jest pusta.");
                return;
            }

            Console.WriteLine("Aktualna lista:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void SortAscending(List<int> list)
        {
            list.Sort();
            Console.WriteLine("Lista została posortowana niemalejąco.");
        }

        static void SortDescending(List<int> list)
        {
            list.Sort();
            list.Reverse();
            Console.WriteLine("Lista została posortowana nierosnąco.");
        }

        static void ClearList(List<int> list)
        {
            list.Clear();
            Console.WriteLine("Lista została wyczyszczona.");
        }

        static void FindElementAt(List<int> list)
        {
            Console.WriteLine("Podaj liczbę do wyszukiwania:");
            int number = int.Parse(Console.ReadLine());

            var indices = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == number)
                {
                    indices.Add(i);
                }
            }

            if (indices.Count > 0)
            {
                Console.WriteLine($"Liczba {number} występuje w indeksach: {string.Join(", ", indices)}");
            }
            else
            {
                Console.WriteLine("Liczba nie występuje w liście.");
            }
        }

        static void DisplayStat(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Lista jest pusta.");
                return;
            }

            int count = list.Count;
            int sum = list.Sum();
            double average = list.Average();
            int min = list.Min();
            int max = list.Max();

            Console.WriteLine("Statystyki:");
            Console.WriteLine($"Liczba elementów: {count}");
            Console.WriteLine($"Suma elementów: {sum}");
            Console.WriteLine($"Średnia: {average}");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maksimum: {max}");
        }

        static void RemoveDuplicates(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Lista jest pusta.");
                return;
            }


            List<int> uniqueList = new List<int>(new HashSet<int>(list));
            list.Clear();
            list.AddRange(uniqueList);
            Console.WriteLine("Duplikaty zostały usunięte z listy.");
        }
    }
}
