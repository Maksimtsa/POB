using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2fstr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wybierz opcję: ");
                Console.WriteLine("1. Pole i obwód kwadratu");
                Console.WriteLine("2. Pole i obwód prosokąta");
                Console.WriteLine("3. Pole i obwód koła");
                Console.WriteLine("twój wybór: ");

                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        DisplySquareCalculatiin();
                        break;
                    case "2":
                        DisplayRectangleCalculation();
                        break;
                    case "3":
                        DisplayCircleleCalculation();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór");
                        break;
                }
            }
        }

        private static void DisplayCircleleCalculation()
        {
            double radius = GetPositiveNumber("podaj promien koła: ");
            double area = CalculateCircleArea(radius);
            double perimetr = CalculateCirclePerimetr(radius);
            Console.WriteLine($"pole koła {Math.Round(area, 2)}");
            Console.WriteLine($"obwód koła {Math.Round(perimetr, 2)}");
        }

        private static double CalculateCirclePerimetr(double radius)
        {
            return 2 * Math.PI * radius;
        }

        private static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius;
        }

        private static void DisplayRectangleCalculation()
        {
            double height = GetPositiveNumber("pdoaj wysokość prostokąta");
            double width = GetPositiveNumber("pdoaj szerokość prostokąta");
            double area = CalculateRectangleArea(height, width);
            double perimetr = CalculateRectanglePerimetr(height, width);
            Console.WriteLine($"Pole prostokąta {Math.Round(area, 2)}");
            Console.WriteLine($"Obwód kwadratu {Math.Round(perimetr, 2)}");

        }

        private static double CalculateRectanglePerimetr(double height, double width)
        {
            return 2 * (height * width);
        }

        private static double CalculateRectangleArea(double height, double width)
        {
            return height * width;
        }

        private static void DisplySquareCalculatiin()
        {
            double side = GetPositiveNumber("Podaj długość boku kwadratu: ");
            (double area, double perimetr) = CalculateSquare(side);
            Console.WriteLine($"Pole kwadratu wynosi {Math.Round(area, 2)}");
            Console.WriteLine($"Obwód kwadratu wynosi {Math.Round(perimetr, 2)}");
        }

        private static (double area, double perimetr) CalculateSquare(double side)
        {
            double area = side * side;
            double perimetr = 4 * side;
            return (area, perimetr);
        }

        private static double GetPositiveNumber(string promt)
        {
            while (true)
            {
                Console.WriteLine(promt);

                if (double.TryParse(Console.ReadLine(), out double number) && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa wartość, try again");
                }
            }
        }
    }
}