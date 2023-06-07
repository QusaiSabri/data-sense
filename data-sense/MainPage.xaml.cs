using CommunityToolkit.Maui.Views;
using data_sense.Views;
using DataSense.Core.Interfaces;

namespace data_sense;
public partial class MainPage : ContentPage
{
    int count = 0;
    private readonly IDataService _dataService;

    public MainPage(IDataService dataService)
    {
        InitializeComponent();
        _dataService = dataService;
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
        this.ShowPopup(new DatabaseTypePopupPage(_dataService));
    }

}

