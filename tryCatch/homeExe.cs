using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str2f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Wybierz funkcję: ");
                Console.WriteLine("1. Obliczanie pola i obwodu kwadratu");
                Console.WriteLine("2. Obliczanie pola i obwodu prostokąta");
                Console.WriteLine("3. Obliczanie pola i obwodu koła");
                Console.WriteLine("4. Wyjście z programu");

                double answ = int.Parse(Console.ReadLine());

                switch(answ)
                {
                case(1):
                    SquareCalculations();
                    break;
                case(2):
                    RectangleCalculations();
                    break;
                case(3):
                    CircleCalculations();
                    break;
                case(4):
                    return;
                default:
                    Console.WriteLine("try again");
                    break;
                }
            }
        }
        private static void SquareCalculations()
        {
            double height = GetPositiveNumber("Podaj długość boku kwadratu: ");
            double area = height * height;
            double perimeter = 4 * height;
            Console.WriteLine($"Pole kwadratu: {area}");
        }

        private static void RectangleCalculations()
        {
            double height = GetPositiveNumber("Podaj wysokość prostokąta: ");
            double width = GetPositiveNumber("Podaj szrokość prostokąta: ");
            double area = height * width;
            double perimetr = 2 * (height + width);
            Console.WriteLine($"Pole prostokąta: {area}, obwód prostokąta: {perimetr}");
        }

        private static void CircleCalculations()
        {
            double radius = GetPositiveNumber("Podaj promień koła: ");
            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Pole koła: {area}, obwód koła: {perimeter}");
        }

        private static double GetPositiveNumber(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);

                if (double.TryParse(Console.ReadLine(), out double number) && number > 0)
                    if(number > 0)
                        return number;
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nieprawidłowa wartość, try again");
                        Console.ResetColor();
                    }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nieprawidłowa wartość, try again");
                    Console.ResetColor();
                }
            }
        }
    }
}
