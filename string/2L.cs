using System;

namespace str2f
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
