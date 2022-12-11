internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> countries = new Dictionary<string, string>();

        GetDictionary(ref countries);

        SearchCapital(countries);
    }

    static void SearchCapital(Dictionary<string, string> countries)
    {
        const string ExitCommand = "esc";

        bool isWorking = true;

        Console.Write("Введите страну с большой буквы: ");
        string country = Console.ReadLine();

        while (isWorking)
        {
            if (countries.ContainsKey(country))
            {
                Console.WriteLine($"\nСтрана - {country}, столица - {countries[country]}");
                Console.Write($"\nВведите страну с большой буквы или введите {ExitCommand}: ");
                country = Console.ReadLine();

                if (country == ExitCommand)
                    isWorking = false;
            }
            else
            {
                Console.WriteLine("\nТакой страны нет в базе.");
                Console.Write($"\nВведите страну с большой буквы или введите {ExitCommand}: ");
                country = Console.ReadLine();

                if (country == ExitCommand)
                    isWorking = false;
            }
        }
    }

    static void GetDictionary(ref Dictionary<string, string> countries)
    {
        countries.Add("Россия", "Москва");
        countries.Add("Белоруссия", "Минск");
        countries.Add("Китай", "Пекин");
        countries.Add("Германия", "Берлин");
        countries.Add("Армения", "Ереван");
    }
}