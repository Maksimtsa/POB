using System;
using System.Threading;

namespace destruktory
{
    class FileHandler : IDisposable
    {
        private string fileName;
        private bool disposed = false;

        // Konstruktor wywoływany przy tworzeniu obiektu
        public FileHandler(string fileName)
        {
            this.fileName = fileName;
            Console.WriteLine($"Plik o nazwie {fileName} został otwarty");
        }

        // Destruktor wywoływany automatycznie przy usuwaniu obiektu
        ~FileHandler()
        {
            Dispose(false);
        }

        // Metoda Dispose (wywoływana przez użytkownika)
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Zawiera logikę czyszczenia zasobów
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Zwolnienie zarządzanych zasobów (np. plik)
                    Console.WriteLine($"Plik {fileName} został zamknięty");
                }

                // Zwolnienie niezależnych zasobów (jeśli takie istnieją)
                Console.WriteLine($"Niezarządzane zasoby zostały zwolnione.");

                disposed = true;
            }
        }

        public void ShowContent()
        {
            Console.WriteLine($"Wyświetlanie zawartości pliku {fileName}...");
            // Przykładowa zawartość
            Console.WriteLine("Zawartość pliku: To jest przykładowa zawartość dokumentu.");
        }
    }

    internal class Program
    {
        static void useFile()
        {
            using (FileHandler fileHandler = new FileHandler("dokument.txt"))
            {
                fileHandler.ShowContent();
            }

        }

        static void Main(string[] args)
        {
            // Wywołanie metody useFile w Main
            useFile();

            // Wymuszenie działania GC (można to pominąć, ale jest pokazane dla celów edukacyjnych)
            GC.Collect();                 // Wymusza wykonanie zbierania śmieci
            GC.WaitForPendingFinalizers(); // Czeka na zakończenie procesu finalizowania obiektów

            Console.WriteLine("Program kończy działanie.");
            Thread.Sleep(3000);  // Dajemy czas na zakończenie przed zamknięciem programu
        }
    }
}
