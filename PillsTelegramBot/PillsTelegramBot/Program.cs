using PillsTelegramBot;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apiService = new ApiService();
            var pills = apiService.GetPillsAsync("https://localhost:7036/api/pill");

            foreach (var pill in pills.Result)
            {
                Console.WriteLine(pill.Name);
                Console.WriteLine(pill.Category);
                Console.WriteLine(pill.Manufacturer);
            }
        }
    }
}
