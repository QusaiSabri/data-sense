using CommunityToolkit.Mvvm.ComponentModel;

namespace data_sense.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {

        public BaseViewModel()
        {

        }
        [ObservableProperty]
        bool loading;

        [ObservableProperty]
        string databaseType;

        [ObservableProperty]
        string selectedDatabase;

    }
}
