using System;
using System.Collections.Generic;

namespace _16._12._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> translations = new Dictionary<string, string>();

            while (true)
            {
                DisplayMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Podaj słowo w języku angielskim:");
                        string key = Console.ReadLine();
                        Console.WriteLine("Podaj tłumaczenie w języku polskim:");
                        string value = Console.ReadLine();
                        if (translations.ContainsKey(key))
                        {
                            Console.WriteLine("To słowo już istnieje w słowniku.");
                        }
                        else
                        {
                            translations.Add(key, value);
                            Console.WriteLine("Tłumaczenie dodane.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Podaj słowo do tłumaczenia: ");
                        string searchKey = Console.ReadLine();
                        if (translations.TryGetValue(searchKey, out string translation))
                        {
                            Console.WriteLine($"Tłumaczenie: {translation}");
                        }
                        else
                        {
                            Console.WriteLine("Nie znaleziono tłumaczenia dla podanego słowa.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nLista wszystkich tłumaczeń:");
                        foreach (var item in translations)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Podaj słowo do usunięcia: ");
                        string deleteKey = Console.ReadLine();
                        if (translations.Remove(deleteKey))
                        {
                            Console.WriteLine("Tłumaczenie usunięte.");
                        }
                        else
                        {
                            Console.WriteLine("Nie znaleziono takiego słowa.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Podaj słowo, którego tłumaczenie chcesz zaktualizować: ");
                        string updateKey = Console.ReadLine();
                        if (translations.ContainsKey(updateKey))
                        {
                            Console.WriteLine("Podaj nowe tłumaczenie: ");
                            string newValue = Console.ReadLine();
                            translations[updateKey] = newValue;
                            Console.WriteLine("Tłumaczenie zaktualizowane.");
                        }
                        else
                        {
                            Console.WriteLine("Nie znaleziono takiego słowa.");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Program zakończony.");
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1. Dodaj nowe tłumaczenie");
            Console.WriteLine("2. Znajdź tłumaczenie");
            Console.WriteLine("3. Wyświetl wszystkie tłumaczenia");
            Console.WriteLine("4. Usuń tłumaczenie");
            Console.WriteLine("5. Zaktualizuj tłumaczenie");
            Console.WriteLine("6. Wyjdź");
        }
    }
}

