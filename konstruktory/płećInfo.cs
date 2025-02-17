using System;
using System.Net.Cache;
namespace str
{
    public enum Gender
    {
        Mężczyzna,
        Kobieta,
        Inna
    }
    public class Person
    {
        //właściwości klasy person
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - DateOfBirth.Year;

                //sprawdzamy czy osoba miała urodziny w tym roku
                if (DateOfBirth.Date > today.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
        }

        //konstruktor domyślny
        public Person()
        {
            FirstName = "Janusz";
            LastName = "Nowak";
            DateOfBirth = new DateTime(2001, 1, 10);
            Gender = Gender.Mężczyzna;
        }
        //konstuktor parametryczny
        public Person(string firstName, string lastName, DateTime dateOfBirth, Gender gender)
        {
            this.FirstName = FirstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        public void DisplayInformation()
        {
            Console.WriteLine("imie: {0}, nazwisko: {1}, data orodzenia: {2: yyyy-MM-dd}, wiek: {3}, płeć: {4}", FirstName, LastName, DateOfBirth, Age, Gender);
        }
        
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        //napisanie metody ToString do czytelnej reprezentacji obiketu
        public override string ToString()
        {
            return $"Osoba; {GetFullName()}, data urodzebia: {DateOfBirth: yyyy-MM-dd}, wiek: {Age}, płeć: {Gender}";
        }

        public Person inputPersonData()
        {
            Console.Write("podaj imie: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Podaj datę orodzenia (RRRR-MM-DD): ");
            DateTime dateOfBirth;
            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
            {
                Console.Write("Błędny format! Podaj datę ponownie (RRRR-MM-DD): ");
            }
            Console.WriteLine("Wybierz płeć (1 - mężczyzna, 2 - kobieta, 3 - Inna): ");
            int genderChoice;
            while (!int.TryParse(Console.ReadLine(), out genderChoice) || genderChoice < 1 || genderChoice > 3)
            {
                Console.WriteLine("Niepoprawny wybór. Wybierz ponownie (1 - mężczyzna, 2 - kobieta, 3 - Inna)");
            }

            Gender persnonGender = (Gender)(genderChoice - 1);
            //tworzenie i zwrócenie noweo obiektu
            try
            {
                Person person = new Person(firstName, lastName, dateOfBirth, Gender);
            }
            catch(ArgumentException x)
            {
                Console.WriteLine($"Błąd: {x.Message}");
                return null;
            }
            
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                //Person p1 = new Person();
                //p1.DateOfBirth = new DateTime(2000, 1, 20);
                //Console.WriteLine();
                //tworzenie obiektu klasy Person przy użyciu konstruktora domyślnego
                Person person1 = new Person();

                //tworzenie obiektu klasy Person przy użyciu konstruktora parametrycznego
                Person person2 = new Person("Janina", "Nowak", new DateTime(1935, 2, 17), Gender.Kobieta);
                Console.WriteLine(person2.Age);

                person1.DisplayInformation();
                person2.DisplayInformation();

                Console.WriteLine("imie i nazwisko: " + person2.GetFullName());
                Console.WriteLine(person2.ToString());

                Person newPerson = Person.inputPersonData();
                if(newPerson == null)
                {
                    Console.WriteLine("\nDane osoby: ");
                    Console.WriteLine(newPerson.ToString());
                }
                else
                {
                    Console.WriteLine("\nNie udało się utworzyć osoby. Proszę spróbować ponownie");
                }
            }
        }
    }
}
