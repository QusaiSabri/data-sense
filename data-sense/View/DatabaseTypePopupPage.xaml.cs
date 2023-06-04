using System;
using Microsoft.Maui.Controls;

namespace data_sense.View;

public partial class DatabaseTypePopupPage : ContentPage
{
    public event Action<string> DatabaseTypeSelected;

    public DatabaseTypePopupPage()
    {
        InitializeComponent();
    }

    private void OnDatabaseTypeSelected(object sender, EventArgs e)
    {
        DatabaseTypeSelected?.Invoke(DatabaseTypePicker.SelectedItem.ToString());
        Navigation.PopAsync(); / close the popup/
    }
}
