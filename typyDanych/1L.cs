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
              		 *wieloliniowy
		 	 *ciąg znaków
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
			foreach(string word in words1)
			{
                		Console.Write(word + '.');//Janusz.Nowak.mieszka.w.Poznaniu.
			}
            		Console.WriteLine();


            //split z wieloma opccjami
            string sentece2 = "Franciszek;Nowak,Poznań";
			char[] separators = { ';', ',' };
			string[] words2 = sentece2.Split(separators);
            foreach(string word in words2)
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
			foreach(string word in words4)
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


			string trim  = text3.Trim();
            Console.WriteLine(trim.Length);//6



			//Join, Substring, ToUpper, ToLower, Contains, IndexOF







            Console.ReadKey();
		}
	}
}
