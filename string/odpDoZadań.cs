using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _2str
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //zad 1
            Console.Write("podaj imie: ");
            string name = Console.ReadLine();
            Console.Write("podaj nazwisko: ");
            string surname = Console.ReadLine();
            string data = $"imie: {name}, nazwisko: {surname}";
            Console.WriteLine(data);

            //zad 2
            Console.WriteLine("podaj scieżkę: ");
            string path = Console.ReadLine();
            Console.WriteLine($"Śsieżka: {path}");
            Console.WriteLine($@"Śsieżka dosłowna: {path}");


            //zad 3 
            Console.Write("napisz zdanie: ");
            string sentence = Console.ReadLine();
            Console.Write("napisz słowo które chcesz zmienić: ");
            string oldWord = Console.ReadLine();
            Console.Write("napisz słowo które chcesz wstawić: ");
            string newWord = Console.ReadLine();

            string newSentence = sentence.Replace(oldWord, newWord);
            Console.WriteLine(newSentence);

            string[] word = newSentence.Split(' ');
            foreach (string word2 in word)
            {
                Console.WriteLine(word2);
            }


            //zad 4
            Console.Write("napisz zdanie z różnymi separatorami: ");
            string sentence1 = Console.ReadLine();
            char[] separators = { ';', ',', ' ' };
            string[] newSentence1 = sentence1.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word1 in newSentence1)
            {
                Console.WriteLine(word1);
            }

            //zad 5
            Console.Write("podaj słowo z nadmiarem spacji: ");
            string txt = Console.ReadLine();

            Console.WriteLine(txt.Trim());


            //zad 6
            string[] fruits = { "banan", "czereśnia", "arbuz" };
            string result = string.Join(", ", fruits);
            Console.WriteLine(result);


            //zad 7
            Console.Write("podaj zdanie do zadania 7: ");
            string sentence2 = Console.ReadLine();
            string substring = sentence2.Substring(5);
            Console.WriteLine(sentence2.ToUpper());
            Console.WriteLine(sentence2.ToLower());
            bool cont = sentence2.Contains("Tomek");
            int index = sentence2.IndexOf("Tomek");
            Console.WriteLine(index);
            Console.WriteLine(cont);

            //8 funkcje
            Console.Write("Wprowadz imie do formatowania: ");
            string nameFormat = Console.ReadLine();
            string formatName = FormattedName(nameFormat);
            Console.WriteLine(formatName);

            //zad 9 
            Console.Write("podaj tekst do liczenia słów: ");
            string textToCount = Console.ReadLine();

            int wordCount = CountWords(textToCount);
            Console.WriteLine(wordCount);

            //zad 10
            Console.Write("tekst to wyszukiwania i zmiany: ");
            string txtToSAR = Console.ReadLine();

            Console.Write("słowo do wyszuk: ");
            string txtToS = Console.ReadLine();

            Console.Write("słowo do zmiany: ");
            string txtToR = Console.ReadLine();

            string replacedText = (string)SearchAndReplace(txtToSAR, txtToS, txtToR);


            //zad 11
            Console.Write("podaj ciąg znaków: ");
            string sings = Console.ReadLine();
            bool continueOperations = true;

            while (continueOperations)
            {
                Console.WriteLine("\nWybierz operację:");
                Console.WriteLine("1. Odwrócenie ciągu znaków");
                Console.WriteLine("2. Usunięcie samogłosek");
                Console.WriteLine("3. Zamiana małych liter na wielkie i odwrotnie");
                Console.WriteLine("4. Usunięcie spacji");
                Console.WriteLine("5. Wyjście");

                Console.Write("Wybór: ");
                string choice = Console.ReadLine();
            }

            




            Console.ReadKey();
                
        }

        private static object SearchAndReplace(string txtToSAR, string txtToS, string txtToR)
        {
            if (string.IsNullOrEmpty(txtToSAR) || string.IsNullOrEmpty(txtToS) || string.IsNullOrEmpty(txtToR))
            {
                return txtToSAR;
            }
            return txtToSAR.Replace(txtToS, txtToR);
        }

        private static int CountWords(string text)
        {
            if(string.IsNullOrEmpty(text)) return 0;

            string[] words = text.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        

        private static string FormattedName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }

            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }
    }
}
