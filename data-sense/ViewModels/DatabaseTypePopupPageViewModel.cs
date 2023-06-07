using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DataSense.Core.Interfaces;

namespace data_sense.ViewModels
{
    public class DatabaseTypePopupPageViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;
        private ObservableCollection<string> _databaseTypes;

        public DatabaseTypePopupPageViewModel(IDataService dataService)
        {
            _dataService = dataService;
            LoadData();
        }

        public ObservableCollection<string> DatabaseTypes
        {
            get { return _databaseTypes; }
            set
            {
                _databaseTypes = value;
                OnPropertyChanged();
            }
        }

        private void LoadData()
        {
            DatabaseTypes = new ObservableCollection<string>(_dataService.GetSupportedDatabaseTypes());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
