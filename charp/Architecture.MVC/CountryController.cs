using Architecture.Model.Services;

namespace Architecture.MVC
{
    public class CountryController
    {
        private readonly CountriesFormMVC _countriesForm;
        private readonly CountryService _countryService;

        public CountryController(CountriesFormMVC countriesForm)
        {
            _countriesForm = countriesForm;
            _countryService = new CountryService();
        }

        public async Task GetCountries()
        {
            var countries = await _countryService.Get();

            _countriesForm.countries.Clear();
            foreach (var country in countries.OrderBy(c => c.Name.Common).Select(c => c.Name.Common))
            {
                _countriesForm.countries.Add(country);
            }
        }

        public async Task OnGetCountries()
        {
            await GetCountries();
        }
    }
}
