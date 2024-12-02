using System;

namespace _02._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                
            
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. losuj zawartosc tablicy jendo wymierowj");
            Console.WriteLine("2. dodaj do tablicy jednowymiarowej");
            Console.WriteLine("3. wyświetl tab jedowym");
            Console.WriteLine("4. sortuj tablice jedno wymiarową");
            Console.WriteLine("5. sortuj tablice jedno wym");
            Console.WriteLine("6. utworz tablice wielowymiarową");
            Console.WriteLine("7. Wuswietl wielowymiarowa");
            Console.WriteLine("8. exit");
        }
        static int[,] CreateMultiArray()
        {
            Console.WriteLine("podaj liczbę wierszy");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbe kolumn");
            int cols = int.Parse(Console.ReadLine());

            int[,] multiArray = new int [rows, cols];
            Random rand = new Random();
            for(int i =  0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    multiArray[i, j] = rand.Next(1, 100);
                }
            }
            Console.WriteLine("wypelnienie random");
            return multiArray;

        }
        static void DisplayMultiarray(int[,] multiArray)
        {
            for(int i = 0; i < multiArray.GetLength(0); i++)
            {
                for(int j = 0; j < multiArray.GetLength(1); j++)
                {
                    Console.WriteLine($"{multiArray[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
