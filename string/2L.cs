﻿using System;

namespace str2f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interpolacja ciągów
            string firstName = "Janusz";
            string lastName = "Nowak";
            string fullName = $"{firstName} {lastName}";
            Console.WriteLine(fullName);//Janusz Nowak

            //literały dowłowne
            string path = "C:\\Projekty\\str2f";//C:\Projekty\str2f
            Console.WriteLine(path);


            string path1 = @"C:\Projekty\str2f";//C:\Projekty\str2f
            Console.WriteLine(path1);


            string multiline = @"To jest 
			wieloliniowy 
			ciąg znaków";
            Console.WriteLine(multiline);
            /*
			 * To jest
             *           wieloliniowy
             *           ciąg znaków
			 */


            //metody manipulacji  ciągami
            //Replace
            string text = "programowanie obiektowe";
            string newText = text.Replace("obiektowe", "strukturalne");
            Console.WriteLine(newText);//programowanie strukturalne

            newText = newText.Replace('e', 'E');
            Console.WriteLine(newText);//programowaniE strukturalnE


            //split
            string sentence = "Franciszek,Nowak,Programista";
            string[] words = sentence.Split(',');
            foreach (string word in words)
            {
                Console.WriteLine(word);//Franciszek
                                        //Nowak
                                        //Programista
            }

            string sentence1 = "Janusz Nowak mieszka w Poznaniu";
            string[] words1 = sentence1.Split(' ');
            foreach (string word in words1)
            {
                Console.Write(word + '.');//Janusz.Nowak.mieszka.w.Poznaniu.
            }
            Console.WriteLine();


            //split z wieloma opccjami
            string sentece2 = "Franciszek;Nowak,Poznań";
            char[] separators = { ';', ',' };
            string[] words2 = sentece2.Split(separators);
            foreach (string word in words2)
            {
                Console.WriteLine(word);/*Franciszek
										* Nowak
										* Poznań
										*/

            }



            //split z opcjami StringSplitOptions
            string sentece3 = "Franciszek;;Nowak,Poznań";
            char[] separators1 = { ';', ',' };
            string[] words3 = sentece3.Split(separators1, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words3)
            {
                Console.WriteLine(word);/*Franciszek
										* Nowak
										* Poznań
										*/

            }


            //split z ograniczeniem liczby podcągów
            string sentence4 = "Franciszek;Nowak;Poznań;Programista";
            char[] separator4 = { ';' };
            string[] words4 = sentence4.Split(separator4, 3);
            foreach (string word in words4)
            {
                Console.WriteLine(word);
            }
            //Franciszek
            //Nowak
            //Poznań; Programista




            //Trim
            string text2 = "  Franciszek";
            Console.WriteLine(text2.Length);
            Console.WriteLine(text2);//  Franciszek
            text2 = text2.Trim();
            Console.WriteLine(text2.Length);
            Console.WriteLine(text2);//Franciszek


            string text3 = " Janusz  ";
            string trimmedStart = text3.TrimStart();
            string trimmedEnd = text3.TrimEnd();
            Console.WriteLine(text3.Length);//9
            Console.WriteLine(trimmedStart.Length);//8
            Console.WriteLine(trimmedEnd.Length);//7


            string trim = text3.Trim();
            Console.WriteLine(trim.Length);//6



            //Join, Substring, ToUpper, ToLower, Contains, IndexOF

            //join
            string[] fruits = { "banan", "czereśnia", "arbuz" };
            string result = string.Join(", ", fruits);
            Console.WriteLine(result);//banan, czereśnia, arbuz




            string[] numbers = { "jeden", "dwa", "trzy" };
            string result1 = string.Join(" - ", numbers);
            Console.WriteLine(result1);//jeden - dwa - trzy



            //substring
            text = "Janusz Nowak";
            string substring = text.Substring(7);
            Console.WriteLine(substring);//Nowak
            substring = text.Substring(7, 4);
            Console.WriteLine(substring);//Nowa
            substring = text.Substring(0, 6);
            Console.WriteLine(text);//Janusz
            substring = text.Substring(text.Length - 1);//k
            substring = text.Substring(text.Length - 2);//ak
            substring = text.Substring(text.Length - 2, 1);//a
            substring = text.Substring(text.Length - 5);//Nowak
            substring = text.Substring(text.Length - 5, 0);//nic nie wyszwietli



            //ToUpper
            text ="arbuz";
            string upperText = text.ToUpper();
            Console.WriteLine(upperText);//ARBUZ

            //ToLower
            text = "Janusz";
            string lowerText = text.ToLower(); 
            Console.WriteLine(lowerText); //janusz


            //Contain
            text = "Janusz Kowalski";
            bool containsText = text.Contains("Janusz");
            bool containsText1 = text.Contains("janusz");
            Console.WriteLine(containsText);//True
            Console.WriteLine(containsText);//False
            bool containsTextIgnoreCase = text.Contains("janusz", StringComparison.OrdinalIgnoreCase);//True !!!!!!!

            //IndexOff
            text = "Anna Paweł Anna Tomasz Anna";
            int index = text.IndexOf("Anna");//0
            index = text.IndexOf("Paweł");//5
            Console.WriteLine(index);

            index = text.IndexOf("Anna", 6);//11
            index = text.IndexOf("anna", 6);//-1
            index = text.IndexOf("anna", 6, StringComparison.OrdinalIgnoreCase);//11
            index = text.IndexOf("anna", 6, 8, StringComparison.OrdinalIgnoreCase);//-1
            index = text.IndexOf("anna", 6, 4, StringComparison.OrdinalIgnoreCase);//-1


            Console.WriteLine(index);











            Console.ReadKey();
        }
    }
}
