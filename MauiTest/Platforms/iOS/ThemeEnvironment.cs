using Foundation;
using MauiTest.Platforms.iOS;
using MauiTestCore.Interfaces;
using Microsoft.Maui.Platform;
using UIKit;

[assembly: Dependency(typeof(ThemeEnvironment))]
namespace MauiTest.Platforms.iOS
{
    public class ThemeEnvironment : IThemeEnvironment
    {
        public void SetStatusBarColor(Color color, bool darkStatusBarTint)
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                var statusBar = new UIView(UIApplication.SharedApplication.KeyWindow.WindowScene.StatusBarManager.StatusBarFrame);
                statusBar.BackgroundColor = color.ToPlatform();
                UIApplication.SharedApplication.KeyWindow.AddSubview(statusBar);
            }
            else
            {
                var statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
                if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
                {
                    statusBar.BackgroundColor = color.ToPlatform();
                }
            }
            var style = darkStatusBarTint ? UIStatusBarStyle.DarkContent : UIStatusBarStyle.LightContent;
            UIApplication.SharedApplication.SetStatusBarStyle(style, false);
            Platform.GetCurrentUIViewController()?.SetNeedsStatusBarAppearanceUpdate();
        }
    }
}
