using MauiAndroidDragEventBug.Handlers;
using Microsoft.Extensions.Logging;

namespace MauiAndroidDragEventBug;

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
        builder.ConfigureMauiHandlers(handlers =>
        {
            handlers.AddHandler(typeof(Border), typeof(BorderHandler));
        });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}