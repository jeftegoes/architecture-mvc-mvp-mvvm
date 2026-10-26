using System.Text.Json;
using Architecture.Model.Entities;

namespace Architecture.Model.Services
{
    public class CountryService
    {
        private const string BASE_URL = "https://restcountries.com/";
        public CountryService() { }

        public async Task<List<Country>> Get()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BASE_URL);
                var response = await client.GetAsync("v3.1/all");
                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Country>>(json);
            }
        }
    }
}
