using System;
using System.Collections.Generic;
using System.Linq;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>  list = new List<int>();
            bool exit = false;

            while (!exit){
                DisplayMenu();
                string choice = Console.ReadLine();
                switch(choice){
                    case "1":
                        AddElements(list);
                        break;
                    case "2":
                        AddRandomElements(list);
                        break;
                    case "3":
                        DeleteElement(list);
                        break;
                    case "4":
                        ShowList(list);
                        break;
                    case "5":
                        SortAsc(list);
                        break;
                    case "6":
                        SortDesc(list);
                        break;
                    case "7":
                        ClearList(list);
                        break;
                    case "9":
                        FindElement(list);
                        break;
                    case "10":
                        Stat(list);
                        break;
                    case "11":
                        DeleteDuplcates(list);
                        break;
                    case "8":
                        exit = true;
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
        static void AddElements(List<int> list){
            Console.WriteLine("Podaj liczbe do dodania");
            int listAdd = int.Parse(Console.ReadLine());
            list.Add(listAdd);
            Console.WriteLine("Element zostal dodany");
        }
        static void AddRandomElements(List<int> list){
            Console.WriteLine("podaj ile losowych elementow chcesz dodac");
            int count = int.Parse(Console.ReadLine());
            Random r = new Random();
            for(int i = 0; i <= count; i++){
                list.Add(r.Next(1, 100));
            }
            Console.WriteLine($"{count} losowych elementow zostalo dodano");
        }
        static void DeleteElement(List<int> list){
            Console.WriteLine("Podaj indeks elementu ktory chcesz usunac");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
                Console.WriteLine("Element został usunięty z listy.");
            }
        } 
        static void ShowList(List<int> list){
            foreach(var item in list){
                Console.WriteLine(item);
            }
        }
        static void SortAsc(List<int> list){
            list.Sort();
            Console.WriteLine("Lista została posortowana niemalejąco.");
        }
        static void SortDesc(List<int> list){
            list.Sort();
            list.Reverse();
            Console.WriteLine("Lista została posortowana nierosnąco.");
        }
        static void ClearList(List<int> list){
            list.Clear();
            Console.WriteLine("Lista zostala clear");
        }
        static void FindElement(List<int> list){
            Console.WriteLine("Podaj element do wyszukania");
            int number = int.Parse(Console.ReadLine());
            
            var indices = new List<int>();
            for(int i = 0; i < list.Count; i++){
                if(list[i] == number){
                    indices.Add(i);
                }
            }
            if(indices.Count > 0){
                Console.WriteLine($"{number} wystepuje w indeksach: {string.Join(", ", indices)}");
            } 
            else{
                Console.WriteLine("liczba nie wystepuje");
            }
        }
        static void Stat(List<int> list){
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
        static void DeleteDuplcates(List<int> list){
            List<int> uniqueList = new List<int>(new HashSet<int>(list));
            list.Clear();
            list.AddRange(uniqueList);
            Console.WriteLine("Duplikaty zostały usunięte z listy.");
        }
    }
}

