using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2fstr
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //zad 1
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
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór");
                        break;
                }
            }
        }

        private static void DisplySquareCalculatiin()
        {
            double side = GetPositiveNumber("Podaj długość boku kwadratu: ");
            (double area, double perimetr) = CalculateSquare(side);
            Console.WriteLine($"Pole kwadratu wynosi {area}");
            Console.WriteLine($"Obwód kwadratu wynosi {perimetr}");
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
      //zad 2
    }
}

