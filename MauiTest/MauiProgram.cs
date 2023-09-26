using CommunityToolkit.Maui;
using LocalizationResourceManager.Maui;
using MauiTestCore;
using MauiTestCore.Resources;
using Microsoft.Extensions.Logging;

namespace MauiTest
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<MauiTestCore.App>()
                .UseMauiCommunityToolkit()
                .UseLocalizationResourceManager(settings =>
                {
                    settings.RestoreLatestCulture(true);
                    settings.AddResource(AppResources.ResourceManager);
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("SF_Bold.ttf", "SF_bold");
                    fonts.AddFont("SF_Medium.ttf", "SF_medium");
                    fonts.AddFont("SF_Regular.ttf", "SF_regular");
                    fonts.AddFont("SF_Light.ttf", "SF_light");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<MainPage>();

            MyDependencies.Register();
            return builder.Build();
        }
    }
}