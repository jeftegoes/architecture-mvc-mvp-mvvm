namespace Architecture.MVVM
{
    public partial class CountriesFormMVVM_v1 : Form
    {
        private readonly CountryViewModel _countryViewModel;

        public CountriesFormMVVM_v1()
        {
            InitializeComponent();
            _countryViewModel = new CountryViewModel();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            _countryViewModel.EventCountries += CountryViewModel_EventCountries;
            _countryViewModel.GetCountries();
        }

        private async void CountryViewModel_EventCountries(object source, CountryEventArgs args)
        {
            countriesListBox.DataSource = args.Countries;
        }

        private void showV2FormButton_Click(object sender, EventArgs e)
        {
            var countriesFormMVVM_v2 = new CountriesFormMVVM_v2(_countryViewModel);
            countriesFormMVVM_v2.Show();
        }
    }
}