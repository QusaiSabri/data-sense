using CommunityToolkit.Maui.Views;
using data_sense.ViewModels;
using DataSense.Core.Interfaces;

namespace data_sense.Views;

public partial class DatabaseTypePopupPage : Popup
{
    public event Action<string> DatabaseTypeSelected;

    public DatabaseTypePopupPage(IDataService dataService)
    {
        InitializeComponent();
        BindingContext = new DatabaseTypePopupPageViewModel(dataService);
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedDatabaseType = (string)e.CurrentSelection.FirstOrDefault();
        // use the selectedDatabaseType here
    }

    private void OnButtonCloseClicked(object sender, EventArgs e)
    {
        Close();
    }

}
