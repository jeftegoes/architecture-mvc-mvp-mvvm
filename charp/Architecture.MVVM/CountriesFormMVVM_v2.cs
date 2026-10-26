namespace Architecture.MVVM
{
    public partial class CountriesFormMVVM_v2 : Form
    {
        private readonly CountryViewModel _countryViewModel;

        public CountriesFormMVVM_v2(CountryViewModel countryViewModel)
        {
            InitializeComponent();
            _countryViewModel = countryViewModel;
            _countryViewModel.EventCountries += CountryViewModel_EventCountries;
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {

        }

        private async void CountryViewModel_EventCountries(object source, CountryEventArgs args)
        {
            countriesListBox.DataSource = args.Countries;
        }
    }
}