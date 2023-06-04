namespace data_sense;
public partial class MainPage : ContentPage
{
	int count = 0;

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
        var popupPage = new DatabaseTypePopupPage();
        popupPage.DatabaseTypeSelected += OnDatabaseTypeSelected;
        await Navigation.PushAsync(popupPage);
    }

    private void OnDatabaseTypeSelected(string selectedDatabaseType)
    {
        // use the selectedDatabaseType here
    }
}

