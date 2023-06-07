using CommunityToolkit.Maui;
using data_sense.ViewModels;
using DataSense.Core.Interfaces;
using DataSense.Core.Models;
using DataSense.Services.Services;
using Microsoft.Extensions.Logging;

namespace data_sense;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();

        builder.Services.AddSingleton<IDataService, DataService>();
        builder.Services.AddSingleton<DatabaseTypePopupPageViewModel>();
        builder.Services.AddSingleton<DatabaseConfiguration>();
        builder.Services.AddSingleton<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}