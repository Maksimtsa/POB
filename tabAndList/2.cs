using System;

namespace _02._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = null;
            bool exit = false;
            while (!exit)
            {
                DisplayMenu();
                Console.WriteLine("Twój wybór: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Podaj rozmiar tablicy: ");
                        int size = int.Parse(Console.ReadLine());
                        array = CreateArray(size);
                        Console.WriteLine("Tablica została utworzona.");
                        break;
                    case 2:
                        if (array != null)
                        {
                            FillArrayRandom(array);
                        }
                        else
                        {
                            Console.WriteLine("Najpierw utwórz tablicę wybierając opcję 1.");
                        }
                        break;
                    case 3:
                        if (array != null)
                        {
                            FillArrayManually(array);
                        }
                        else
                        {
                            Console.WriteLine("Najpierw utwórz tablicę wybierając opcję 1.");
                        }
                        break;
                    case 4:
                        if (array != null)
                        {
                            DisplayArray(array);
                        }
                        else
                        {
                            Console.WriteLine("Tablica nie została utworzona.");
                        }
                        break;
                    case 5:
                        if (array != null)
                        {
                            SortArrayAscending(array);
                        }
                        else
                        {
                            Console.WriteLine("Tablica nie została utworzona.");
                        }
                        break;
                    case 6:
                        if (array != null)
                        {
                            SortArrayDesc(array);
                        }
                        else
                        {
                            Console.WriteLine("Tablica nie została utworzona.");
                        }
                        break; 
                    case 7:
                        exit = true;
                        Console.WriteLine("Wyjście z programu");
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór, spróbuj ponownie.");
                        break;
                }
            }
        }

        static int[] CreateArray(int size)
        {
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(1, 101); 
            }
            return array;
        }

        static void FillArrayRandom(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 101); 
            }
            Console.WriteLine("Tablica została wypełniona losowymi wartościami.");
        }

        static void FillArrayManually(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Podaj wartość dla elementu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tablica została wypełniona ręcznie podanymi wartościami.");
        }

        static void DisplayArray(int[] array)
        {
            Console.WriteLine("Zawartość tablicy:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Utwórz tablicę");
            Console.WriteLine("2. Wylosuj zawartość tablicy");
            Console.WriteLine("3. Dodaj wartości do tablicy");
            Console.WriteLine("4. Wyświetl tablicę");
            Console.WriteLine("5. Sortuj rosnąco");
            Console.WriteLine("6. Sortuj malejąco");
            Console.WriteLine("7. Wyjdź");
            Console.WriteLine("Wybierz opcję: ");
        }

        // Funkcja sortowania tablicy rosnąco
        static void SortArrayAscending(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("Tablica została posortowana rosnąco.");
        }

        // Funkcja sortowania tablicy malejąco
        static void SortArrayDesc(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Tablica została posortowana malejąco.");
        }
    }
}
