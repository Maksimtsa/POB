using System.Net.Http.Headers;

namespace polaWłaściwości
{
    class Car
    {
        // Pola (fields) - bezpośrednie zmienne przechowujące dane
        public string brand; // pole publiczne, brak kontroli dostępu
        public string model; // pole publiczne, brak kontroli dostępu

        // Prywatne pola dla właściwości
        private int _productionYear;
        private decimal _price;
        private string _color;

        // Właściwości (properties) - kontrolują dostęp do danych
        public int ProductionYear
        {
            get { return _productionYear; }
            set
            {
                if (value >= 1886 && value <= DateTime.Now.Year)
                {
                    _productionYear = value;
                }
                else
                {
                    throw new ArgumentException("Rok produkcji musi być między 1886 a obecnym rokiem");
                }
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
                else
                    throw new ArgumentException("Cena nie może być ujemna");
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                //lista dozwolonych kolorów
                string[] allowedColors = { "niebieski", "czarny", "biały", "czerwony"};

                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kolor nie może byc pusty");
                if (Array.IndexOf(allowedColors, value.ToLower()) == -1)
                {
                    string allowedColorsList = "";
                    foreach(string color in allowedColors)
                    {
                        allowedColorsList += color + ", ";
                    }

                    allowedColorsList = allowedColorsList.TrimEnd(',', ' ');
                    throw new ArgumentException($"Kolor musi być jednym z {allowedColorsList}");
                }

                _color = value.ToLower();
            }
        }

        // Konstruktor bezparametrowy
        public Car()
        {
            brand = "Nieznana";
            model = "Nieznany";
            _productionYear = DateTime.Now.Year;
            _price = 0.0m; // Inicjalizowanie ceny na 0
        }

        // Konstruktor z parametrami
        public Car(string brand, string model, int productionYear, decimal price)
        {
            this.brand = brand;
            this.model = model;
            ProductionYear = productionYear; // Zastosowanie właściwości do ustawienia roku produkcji
            Price = price; // Zastosowanie właściwości do ustawienia ceny
        }

        // Nadpisanie metody ToString(), aby wyświetlić szczegóły samochodu
        public override string ToString()
        {
            return $"Marka: {brand}, Model: {model}, Rok produkcji: {ProductionYear}, Cena: {Price}";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Marka: {brand}, Model: {model}, Rok produkcji: {ProductionYear}, Cena: {Price:C}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //tworzenie z urzyciem konstruktora domyślnego
            Car car1 = new Car();
            car1.brand = "Ferrari";
            car1.model = "F430";
            car1.ProductionYear = 2020;
            car1.Price = 1000000.99m;

            car1.DisplayInfo();


            //tworzene obiektu z urzyciem konstruktora z parametrami 
            Car car2 = new Car("BMW", "i5", 2022, 750000);
            car2.DisplayInfo();

            //przykład błędu - próba ustawienia niepoprawnego roku

            try
            {
                car2.ProductionYear = 1900;
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }

            //przykład błędu - próba ustawienia niepoprawnego koloru
            try
            {
                car2.Color = "czarny";
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }

            Console.WriteLine(car1.Color);
        }
    }
}
