using Architecture.Model.Entities;
using Architecture.Model.Services;
using System.ComponentModel;

namespace Architecture.MVVM
{
    public class CountryViewModel
    {
        public event EventHandler<CountryEventArgs> EventCountries;
        private readonly CountryService _countryService;

        public CountryViewModel()
        {
            _countryService = new CountryService();
        }

        public async void GetCountries()
        {
            var countries = new BindingList<string>();

            foreach (var country in (await _countryService.Get()).OrderBy(c => c.Name.Common).Select(c => c.Name.Common))
            {
                countries.Add(country);
            }

            if (EventCountries != null)
                EventCountries.Invoke(this, new CountryEventArgs() { Countries = countries });
        }

        public async Task OnGetCountries()
        {
            GetCountries();
        }
    }
}