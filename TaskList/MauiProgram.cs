using Microsoft.Extensions.Logging;

namespace TaskList
{
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
                    fonts.AddFont("aptos-light.ttf", "AptosLight");
                    fonts.AddFont("aptos.ttf", "Aptos");
                    fonts.AddFont("aptos-bold.ttf", "AptosBold");
                    fonts.AddFont("aptos-italic.ttf", "AptosItalic");
                    fonts.AddFont("aptos-semibold.ttf", "AptosSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
