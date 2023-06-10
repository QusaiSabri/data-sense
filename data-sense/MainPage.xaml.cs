using CommunityToolkit.Maui.Views;
using data_sense.Views;
using DataSense.Core.Interfaces;
using DataSense.Core.Models;
using DataSense.Services.Factories;
using DataSense.Services.Services;

namespace data_sense;
public partial class MainPage : ContentPage
{
    int count = 0;
    private IServiceProvider _services;

    public MainPage(IServiceProvider services)
    {
        InitializeComponent();
        _services = services;

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
        var connectionService = ConnectionServiceFactory.GetConnectionService(selectedDatabaseType, _services);
        var connectionPopup = new DatabaseConnectionPopup(connectionService);
        connectionPopup.ConnectionStatusKnown += OnConnectionStatusKnown;
        this.ShowPopup(connectionPopup);

    }



    private async void OnConnectionStatusKnown(ConnectionStatusEventArgs args)
    {
        if (args.IsConnected)
        {
            await DisplayAlert("Connection Status", "Connection successful!", "OK");
        }
        else
        {
            await DisplayAlert("Connection Status", $"Connection failed. {args.Message}", "OK");

        }
    }


}

