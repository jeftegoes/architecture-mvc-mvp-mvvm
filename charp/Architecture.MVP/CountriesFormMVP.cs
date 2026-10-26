using System.ComponentModel;

namespace Architecture.MVP
{
    public partial class CountriesFormMVP : Form, IView
    {
        private BindingList<string> _countries = new BindingList<string>();
        private readonly CountryPresenter _countryPresenter;

        public CountriesFormMVP()
        {
            InitializeComponent();
            countriesListBox.DataSource = _countries;
            _countryPresenter = new CountryPresenter(this);
        }

        private async void getCountriesButton_Click(object sender, EventArgs e)
        {
            await _countryPresenter.OnGetCountries();
        }

        public void SetCountries(List<string> countries)
        {
            foreach (var country in countries)
            {
                _countries.Add(country);
            }
        }
    }
}