using CommunityToolkit.Maui.Views;
using data_sense.Views;
using DataSense.Core.Interfaces;
using DataSense.Services.Factories;

namespace data_sense;
public partial class MainPage : ContentPage
{
    int count = 0;
    private readonly IDataService _dataService;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        //if (count == 1)
        //	CounterBtn.Text = $"Clicked {count} time";
        //else
        //	CounterBtn.Text = $"Clicked {count} times";

        //SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private async void OnConnectClicked(object sender, EventArgs e)
    {
        var databaseTypePopupPage = new DatabaseTypePopupPage();
        databaseTypePopupPage.DatabaseTypeSelected += OnDatabaseTypeSelected;
        this.ShowPopup(databaseTypePopupPage);
    }

    private void OnDatabaseTypeSelected(string selectedDatabaseType)
    {
        var connectionService = ConnectionServiceFactory.GetConnectionService(selectedDatabaseType);
        var connectionPopupPage = new DatabaseConnectionPopup(connectionService);
        this.ShowPopup(connectionPopupPage);
    }

}

