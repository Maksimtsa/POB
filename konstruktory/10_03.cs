using System;

namespace ConsoleApp11
{
    public enum Grade
    {
        FirstGrade,
        SecondGrade,
        ThirdGrade,
        FourtsGrade,
        FifthGrade
    }
    public class School
    {
        //prywatne pola
        private string _studentName;
        private DateOnly _birthDate;
        private Grade _studentGrade;
        private DateOnly _schoolStartDate;

        //właściwości 
        public string StudentName
        {
            get => _studentName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("imię ucznia nie może być puste");
                _studentName = value;
            }
        }
        public DateOnly BirthDate
        {
            get => _birthDate;
            set
            {
                if (value >= DateOnly.FromDateTime(DateTime.Today))
                    throw new ArgumentException("Data urodzenia nie może być w przyszłości");
            }
        }

        public int StudentAge
        {
            get
            {
                int age = DateOnly.FromDateTime(DateTime.Today).Year - _birthDate.Year;

                if (DateOnly.FromDateTime(DateTime.Today).Month < _birthDate.Month ||
                    (DateOnly.FromDateTime(DateTime.Today).Month == _birthDate.Month && 
                     DateOnly.FromDateTime(DateTime.Today).Day < _birthDate.Day))
                {
                    age--;
                }

                return age;
            }
        }
        public Grade StudentGrade
        {
            get => _studentGrade;
            set
            {
                if (!Enum.IsDefined(typeof(Grade), value))
                    throw new ArgumentException("Nieprawidłowa klasa");
                _studentGrade = value;
            }
        }

        public DateOnly SchoolStartDate
        {
            get => _schoolStartDate;
            set
            {
                if (value > DateOnly.FromDateTime(DateTime.Today))
                    throw new ArgumentException("Data rozpoczęcia nauki nie może być w przyszłośći");
            }
        }

        //konstruktor domyślny
        //dokończyć
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
