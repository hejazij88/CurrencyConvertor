using CorencyConvertor.Models;
using System.Text.Json;

namespace CorencyConvertor.Services
{
    public class ExchangeRateServices
    {
        private readonly HttpClient _httpClient;

        public ExchangeRateServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ExchangeRateResponse> GetRateAsync(string baseCurrency)
        {
var response = await _httpClient.GetAsync("https://v6.exchangerate-api.com/v6/YOUR_API_KEY/latest/" + baseCurrency);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<ExchangeRateResponse>(json);

            return data;
        }
    }
}
