using MauiTest.Platforms.Windows;
using MauiTestCore.Interfaces;

[assembly: Dependency(typeof(ThemeEnvironment))]
namespace MauiTest.Platforms.Windows
{
    public class ThemeEnvironment : IThemeEnvironment
    {
        public void SetStatusBarColor(Microsoft.Maui.Graphics.Color color, bool darkStatusBarTint)
        {
        }
    }
}
