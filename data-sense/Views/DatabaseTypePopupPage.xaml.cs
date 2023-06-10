using CommunityToolkit.Maui.Views;
using data_sense.ViewModels;
using DataSense.Core.Interfaces;
using data_sense.Views;
using DataSense.Services.Factories;

namespace data_sense.Views;

public partial class DatabaseTypePopupPage : Popup
{
    public event Action<string> DatabaseTypeSelected;

    public DatabaseTypePopupPage()
    {
        InitializeComponent();
        BindingContext = new DatabaseTypePopupPageViewModel();
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedDatabaseType = (string)e.CurrentSelection.FirstOrDefault();
        DatabaseTypeSelected?.Invoke(selectedDatabaseType);
        Close();
    }



    private void OnButtonCloseClicked(object sender, EventArgs e)
    {
        Close();
    }

}
