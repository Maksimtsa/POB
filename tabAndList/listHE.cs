using System;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int[] array = null;
            bool exit = false;

            while(!exit){
                DisplayMenu();
                string choice = Console.ReadLine();
                switch(choice){
                    case "1":
                        Console.WriteLine("Podaj rozmiar tablicy: ");
                        int size = int.Parse(Console.ReadLine());
                        array = CreateArray(size);
                        Console.WriteLine("Tablica została utworzona.");
                        break;
                    case "2":
                        if(array != null){
                            FillArrayRandom(array);
                        }
                        else
                        {
                            Console.WriteLine("Najpierw utwórz tablicę wybierając opcję 1.");
                        }
                    break;
                    case "3":
                        if(array != null){
                            FillArrayManually(array);
                        }
                        else
                        {
                            Console.WriteLine("Najpierw utwórz tablicę wybierając opcję 1.");
                        }
                    break;
                    case "4":
                        if(array != null){
                            ShowTab(array);
                        }
                        else
                        {
                            Console.WriteLine("Najpierw utwórz tablicę wybierając opcję 1.");
                        }
                        break;
                    case "5":
                        if(array != null){
                            SortAsc(array);
                        }
                        else
                        {
                            Console.WriteLine("Najpierw utwórz tablicę wybierając opcję 1.");
                        }
                        break;
                    case "6":
                        if(array != null){
                            SortDesc(array);
                        }
                        else
                        {
                            Console.WriteLine("Najpierw utwórz tablicę wybierając opcję 1.");
                        }
                        break;
                }    
            }
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
        static int[] CreateArray(int size){
            int[] array = new int[size];
            Random r = new Random();
            for(int i = 0; i < size; i++){
                array[i] = r.Next(1, 100);
            }
            return array;
        }
        static void FillArrayRandom(int[] array){
            Random r = new Random();
            for(int i = 0; i <= array.Length; i++){
                array[i] = r.Next(1, 100);
            }
            Console.WriteLine("Tablica została wypełniona losowymi wartościami.");
        }
        static void FillArrayManually(int[] array){
            for(int i = 0; i <= array.Length; i++){
                Console.WriteLine($"Podaj wartosci dla elementu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        static void ShowTab(int[] array){
            foreach(var item in array){
                Console.WriteLine(item);
            }
        }
        static void SortAsc(int[] array){
            Array.Sort(array);
            Console.WriteLine("Tablica została posortowana rosnąco.");
        }
        static void SortDesc(int[] array){
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Tablica została posortowana malejąco.");
        }
    }
}

