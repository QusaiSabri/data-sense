using CommunityToolkit.Maui.Views;

namespace data_sense.View;

public partial class DatabaseTypePopupPage : Popup
{
    public event Action<string> DatabaseTypeSelected;

    public DatabaseTypePopupPage()
    {
        InitializeComponent();
    }

    private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedDatabaseType = (string)e.CurrentSelection.FirstOrDefault();
        // use the selectedDatabaseType here
    }

}
