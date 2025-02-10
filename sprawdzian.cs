using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

enum DyscyplinaSportowa
{
    PilkaNozna,
    Koszykowka,
    Siatkowka,
    Lekkoatletyka,
    Tenis,
    Hokej
}

public class Program
{
    static Dictionary<string, List<(string imie, string nazwisko, DyscyplinaSportowa dyscyplina, int wiek, int punkty)>> druzyny =
        new Dictionary<string, List<(string, string, DyscyplinaSportowa, int, int)>>();

    public static void Main()
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    DisplayTeam();
                    break;
                case "2":
                    AddPlayerToTeam();
                    break;
                case "3":
                    RemovePlayer();
                    break;
                case "4":
                    DisplayPlayer();
                    break;
                case "5":
                    UpdatePlayerPoint();
                    break;
                case "6":

                    break;
                case "7":
                    DisplayAllTeams();
                    break;
                case "8":
                    Console.WriteLine("Zakończono program.");
                    return;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }

    private static void UpdatePlayerPoint()
    {
        Console.WriteLine("Podaj nazwę drużyny: ");
        string teamName = Console.ReadLine();
        Console.WriteLine("Podaj imię zawodnika: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko zawodnika: ");
        string lastName = Console.ReadLine();

        if (druzyny.ContainsKey(teamName))
        {
            

        }
        else
        {
            Console.WriteLine("Drużyna o podanej nazwie nie istnieje.");
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("1. Wyświetl drużyne");
        Console.WriteLine("2. Dodaj zawodnika");
        Console.WriteLine("3. Usuń zawidnika");
        Console.WriteLine("4. Wyświetl zawodników");
        Console.WriteLine("5. Zaktualizuj punkty zawodnika");
        Console.WriteLine("6. Wyszukaj zawodnika po nazwisku");
        Console.WriteLine("7. Wyświetl wszystkie drużyny");
        Console.WriteLine("8. Zakończ program");
        Console.WriteLine("Wybierz opcję: ");

    }

    private static void DisplayTeam()
    {
        Console.WriteLine("Podaj nazwę drużyny: ");
        string teamName = Console.ReadLine();
        if (druzyny.ContainsKey(teamName))
        {
            Console.WriteLine($"Zawodnicy drużyny {teamName}:");
            foreach (var player in druzyny[teamName])
            {
                Console.WriteLine($"{player.imie} {player.nazwisko}, Dyscyplina: {player.dyscyplina}, Wiek: {player.wiek}, Punkty: {player.punkty}");
            }
        }
        else
        {
            Console.WriteLine("Drużyna o podanej nazwie nie istnieje.");
        }
    }


    private static void AddPlayerToTeam()
    {
        Console.WriteLine("Podaj nazwę drużyny: ");
        string teamName = Console.ReadLine();
        Console.WriteLine("Podaj imię zawodnika: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko zawodnika: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Podaj wiek zawodnika: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj punkty zawodnika: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Wybierz dyscyplinę sportową:");
        foreach (var sport in Enum.GetValues(DyscyplinaSportowa))
        {
            Console.WriteLine($"{(int)sport}. {sport}");
        }
        int disciplineChoice = int.Parse(Console.ReadLine());
        DyscyplinaSportowa chosenDiscipline = (DyscyplinaSportowa)disciplineChoice;       

        var player = (firstName, lastName, chosenDiscipline, age, points);

        if (!druzyny.ContainsKey(teamName))
        {
            druzyny[teamName] = new List<(string, string, DyscyplinaSportowa, int, int)>();
        }
        druzyny[teamName].Add(player);
        Console.WriteLine("Zawodnik został dodany do drużyny.");
    }
    private static void RemovePlayer()
    {
        Console.WriteLine("Podaj nazwę drużyny: ");
        string teamName = Console.ReadLine();
        Console.WriteLine("Podaj imię zawodnika: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko zawodnika: ");
        string lastName = Console.ReadLine();

        if (druzyny.ContainsKey(teamName))
        {
            var player = druzyny[teamName].Find(p => p.imie == firstName && p.nazwisko == lastName);
            druzyny[teamName].Remove(player);
            Console.WriteLine("Zawodnik został usunięty z drużyny.");

        }
        else
        {
            Console.WriteLine("Drużyna o podanej nazwie nie istnieje.");
        }
    }

    private static void DisplayPlayer()
    {
        Console.WriteLine("Wybierz dyscyplinę sportową:");
        foreach (var sport in Enum.GetValues(DyscyplinaSportowa))
        {
            Console.WriteLine($"{(int)sport}. {sport}");
        }

        int disciplineChoice = int.Parse(Console.ReadLine());
        foreach (var team in druzyny.Values)
        {
            foreach (var player in team)
            {   
               Console.WriteLine($"{player.imie} {player.nazwisko}, Wiek: {player.wiek}, Punkty: {player.punkty}");
            }
        }
    }

    private static void DisplayAllTeams()
    {
        foreach (var team in druzyny.Keys)
        {
            Console.WriteLine($"Drużyny: {team}");
        }
    }
}
