using MauiTestCore.Interfaces;
#if ANDROID
using MauiTest.Platforms.Android;
#endif
#if IOS
using MauiTest.Platforms.iOS;
#endif
#if MACCATALYST
using MauiTest.Platforms.MacCatalyst;
#endif
#if WINDOWS
using MauiTest.Platforms.Windows;
#endif

namespace MauiTest
{
    public static class MyDependencies
    {
        public static void Register()
        {
            DependencyService.Register<IThemeEnvironment, ThemeEnvironment>();
        }
    }
}
