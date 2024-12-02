using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pobranie rozmiaru tablicy od użytkownika
            Console.WriteLine("podaj rozmiar tablicy: ");
            int size = int.Parse(Console.ReadLine());

            //wywołanie funkcji
            int[] array = FillArrayRandom(size);

            Console.WriteLine("czy chesz wyświetlić dane t/n");
            string response = Console.ReadLine().ToLower();
            if(response == "t")
            {
                DisplayArray(array);
            }
            else
            {
                Console.WriteLine("zawartość nie została wyświetlona");
            }
            Console.ReadKey();

        }
        //funkcjaa statyczna do losowego wypełniania tablicy
        static int[] FillArrayRandom(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 101);
            }
            Console.WriteLine("Tablica została wyświetlona losowymi wartościami");
        }
        //funkcja wywołania
        static void DisplayArray(int[] array)
        {
            foreach(int element in array)
            {
                Console.WriteLine(element + " ");
            }
            Console.WriteLine();
        }
    }
}
