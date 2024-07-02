using Newtonsoft.Json;
using PillsTelegramBot.Models;

namespace PillsTelegramBot
{
    internal class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Pill>> GetPillsAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseData = await response.Content.ReadAsStringAsync();
                List<Pill> pills = JsonConvert.DeserializeObject<List<Pill>>(responseData);

                return pills;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return null;
            }
        }

        public async Task<Pill> GetPillAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseData = await response.Content.ReadAsStringAsync();

                Pill pill = JsonConvert.DeserializeObject<Pill>(responseData);
                return pill;
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine($"Request error: {e.Message}");
                return null;
            }
        }
    }
}
