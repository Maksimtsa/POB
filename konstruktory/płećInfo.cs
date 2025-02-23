using System;

namespace str
{
    public enum Gender{
        Mężczyzna,
        Kobieta,
        Inna
    }
    public class Person{
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public DateTime DateOfBirth {get; set; }
        public Gender PersonGender {get; set; }
        public int Age {get{
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;

            if(DateOfBirth.Date > today.AddYears(-age)){
                --age;
            }
            return age;
        }}

        //konstruktor domyślny
        public Person(){
            FirstName = "Janusz";
            LastName = "Kowalski";
            DateOfBirth = new DateTime(2001, 1, 20);
            PersonGender = Gender.Mężczyzna;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth, Gender gender){
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PersonGender = gender;
        }
        public void DisplayInformation(){
            Console.WriteLine("Imie: {0}, Nazwisko: {1}, Data urodzenia: {2:yyyy-MM-dd}, Wiek: {3} Płeć: {4}", FirstName, LastName, DateOfBirth, Age, PersonGender);
        }

        public string GetFullName(){
            return $"{FirstName} {LastName}";
        }

        public Person InputInformation(){
            Console.Write("Podaj imie: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Podaj date urodzenia (YYYY-MM-DD): ");
            DateTime dateOfBirth;
            while(!DateTime.TryParse(Console.ReadLine(), out dateOfBirth)){
                Console.Write("Błędny format! Podaj datę ponownie (RRRR-MM-DD): ");
            }

            Console.Write("Wybierz płeć (1 - mężczyzna, 2 - kobieta, 3 - Inna): ");
            int genderChoice;
            while(!int.TryParse(Console.ReadLine(), out genderChoice) || genderChoice < 1 || genderChoice > 3){
                Console.WriteLine("Niepoprawny wybór. Wybierz ponownie (1 - mężczyzna, 2 - kobieta, 3 - Inna)");
            }

            Gender gender = (Gender)(genderChoice - 1);
            return new Person(firstName, lastName, dateOfBirth, gender);
        }
        public override string ToString(){
            return $"Osoba: {FirstName} {LastName}, Data urodzenia: {DateOfBirth:yyyy-MM-dd}, Wiek: {Age}, Płeć: {PersonGender}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1 = person1.InputInformation();
            Console.WriteLine(person1);
        }
    }
}
