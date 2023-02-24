using HealthyPool.Data.Repositories;
using HealthyPool.ViewModels;
using Microsoft.Extensions.Logging;

namespace HealthyPool;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddScoped<PoolRepository>();
        builder.Services.AddScoped<MainPageViewModel>();
        builder.Services.AddScoped<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}