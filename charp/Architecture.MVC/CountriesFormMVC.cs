using System.ComponentModel;

namespace Architecture.MVC
{
    public partial class CountriesFormMVC : Form
    {
        public BindingList<string> countries = new BindingList<string>();
        private readonly CountryController _countryController;

        public CountriesFormMVC()
        {
            InitializeComponent();
            countriesListBox.DataSource = countries;
            _countryController = new CountryController(this);
        }

        private async void getCountriesButton_Click(object sender, EventArgs e)
        {
            await _countryController.OnGetCountries();
        }
    }
}