using MauiTest.Platforms.MacCatalyst;
using MauiTestCore.Interfaces;

[assembly: Dependency(typeof(ThemeEnvironment))]
namespace MauiTest.Platforms.MacCatalyst
{
    public class ThemeEnvironment : IThemeEnvironment
    {
        public void SetStatusBarColor(Microsoft.Maui.Graphics.Color color, bool darkStatusBarTint)
        {

        }
    }
}
