using System;
using System.Collections.Generic;
using System.Linq;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> translations = new Dictionary<string, List<string>>();

            while(true){
                DisplayMenu();
                string choice = Console.ReadLine();
                
                switch(choice){
                    case "1":
                        Console.WriteLine("podaj slowo do tlumaczenia");
                        string key = Console.ReadLine();
                        Console.WriteLine("podaj tlumaczenie");
                        string value = Console.ReadLine();
                    
                        if(!translations.ContainsKey(key)){
                            translations[key] = new List<string>();
                        }
                        if(!translations[key].Contains(value)){
                            translations[key].Add(value);
                        }
                        else{
                            Console.WriteLine("Juz istnieje");
                        }
                        break;
                    case "2":
                        Console.WriteLine("podaj slowo ktorego chcesz znalejsc tlumaczenie");
                        string find = Console.ReadLine();
                        if(translations.TryGetValue(find, out List<string> translationList))
                        {
                            Console.WriteLine($"Tlumaczenia dla {find}: {string.Join(", ", translationList)}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Lista wszystkich tlumaczen");
                        foreach(var item in translations){
                            Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Podaj słowo do usunięcia tłumaczenia:");
                        string deleteKey = Console.ReadLine();

                        if (translations.ContainsKey(deleteKey))
                        {
                            Console.WriteLine("Podaj tłumaczenie do usunięcia:");
                            string trDelete = Console.ReadLine();

                            if (translations[deleteKey].Remove(trDelete))
                            {
                                Console.WriteLine("Tłumaczenie usunięto.");
                                
                                if (translations[deleteKey].Count == 0)
                                {
                                    translations.Remove(deleteKey);
                                    Console.WriteLine("Brak pozostałych tłumaczeń, usunięto klucz.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie znaleziono takiego tłumaczenia.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nie znaleziono słowa.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Podaj słowo, którego tłumaczenie chcesz zaktualizować: ");
                        string updtKey = Console.ReadLine();
                        if(translations.ContainsKey(updtKey)){
                            Console.WriteLine("podaj nowe tlumaczenie");
                            string newValue = Console.ReadLine();
                            translations[updtKey].Add(newValue);
                            Console.WriteLine("Tłumaczenie zaktualizowane.");
                        }
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("nieprawidlowa opcja");
                        break;
            }
        }
        static void DisplayMenu(){
            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1. Dodaj nowe tłumaczenie");
            Console.WriteLine("2. Znajdź tłumaczenie");
            Console.WriteLine("3. Wyświetl wszystkie tłumaczenia");
            Console.WriteLine("4. Usuń tłumaczenie");
            Console.WriteLine("5. Zaktualizuj tłumaczenie");
            Console.WriteLine("6. Wyjście");
        }
    }
}
}
