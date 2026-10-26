using Architecture.Model.Services;

namespace Architecture.MVP
{
    public class CountryPresenter
    {
        private readonly IView _view;
        private readonly CountryService _countryService;

        public CountryPresenter(IView view)
        {
            _view = view;
            _countryService = new CountryService();
        }

        public async Task GetCountries()
        {
            var countries = (await _countryService.Get()).OrderBy(c => c.Name.Common).Select(c => c.Name.Common).ToList();

            _view.SetCountries(countries);
        }

        public async Task OnGetCountries()
        {
            await GetCountries();
        }
    }
}
