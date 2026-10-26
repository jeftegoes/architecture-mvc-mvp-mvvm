using System.ComponentModel;

namespace Architecture.MVVM
{
    public class CountryEventArgs : EventArgs
    {
        public BindingList<string> Countries { get; set; }
    }
}
