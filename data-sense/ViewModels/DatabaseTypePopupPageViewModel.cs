using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DataSense.Core.Interfaces;
using DataSense.Core.Models;

namespace data_sense.ViewModels
{
    public class DatabaseTypePopupPageViewModel
    {
        private ObservableCollection<string> _databaseTypes;

        public DatabaseTypePopupPageViewModel()
        {
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
            DatabaseTypes = new ObservableCollection<string>(DatabaseType.SupportedTypes);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
