using CommunityToolkit.Maui.Views;
using DataSense.Core.Interfaces;
using DataSense.Core.Models;

namespace data_sense.Views;

public partial class DatabaseConnectionPopup : Popup
{
    private IDatabaseConnectionService _connectionService;
    public event Action<ConnectionStatusEventArgs> ConnectionStatusKnown;

    public DatabaseConnectionPopup(IDatabaseConnectionService connectionService)
    {
        InitializeComponent();
        _connectionService = connectionService;
    }

    private void OnConnectClicked(object sender, SelectionChangedEventArgs e)
    {
        var connectionSettings = (string)e.CurrentSelection.FirstOrDefault();
        
        Close();
    }

    private async void OnConnectClicked(object sender, EventArgs e)
    {
        activityIndicator.IsRunning = true;

        string serverName = ServerNameEntry.Text;
        string databaseName = DatabaseNameEntry.Text;
        string userId = UserIdEntry.Text;
        string password = PasswordEntry.Text;

        DatabaseConfiguration config = new DatabaseConfiguration
        {
            ServerName = serverName,
            DatabaseName = databaseName,
            UserId = userId,
            Password = password,
        };

        var (isConnected, message) = await _connectionService.Connect(config);


        
        if (isConnected)
        {
            // TODO: Connection successful. Close this popup and notify the caller.
            Close();
        }
        else
        {
            ConnectionStatusKnown?.Invoke(new ConnectionStatusEventArgs(isConnected, message));

            // Connection failed. Show an error message to the user.
            // await DisplayAler("Error", "Failed to connect to the database. Please check your connection details and try again.", "OK");
        }
        activityIndicator.IsRunning = false;
    }

}