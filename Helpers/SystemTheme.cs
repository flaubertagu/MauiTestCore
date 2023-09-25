using MauiTestCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestCore.Helpers
{
    public class SystemTheme
    {
        public void SetUserTheme()
        {
            UpdateTitleBarColor();
        }

        public int GetThemeId()
        {
            int themeId = 0;
            switch (Settings.AppTheme)
            {
                //default
                case 0:
                    App.Current.UserAppTheme = AppTheme.Unspecified;
                    if (IsDarkTheme() == false)
                        themeId = 1;
                    else
                        themeId = 2;
                    break;
                //light
                case 1:
                    themeId = 1;
                    break;
                //dark
                case 2:
                    themeId = 2;
                    break;
            }
            return themeId;
        }

        public void UpdateTitleBarColor()
        {
            var nav = App.Current.MainPage as NavigationPage;

            Color backgroundColor;
            Color textColor;
            int appTheme = GetThemeId();
            if (appTheme == 1)
            {
                backgroundColor = Colors.White;
                textColor = Colors.DarkBlue;
            }
            else
            {
                backgroundColor = Colors.Black;
                textColor = Colors.White;
            }

            DependencyService.Get<IThemeEnvironment>().SetStatusBarColor(backgroundColor, true);
            if (nav != null)
            {
                nav.BarBackgroundColor = backgroundColor;
                nav.BarTextColor = textColor;
            }
        }

        public bool IsDarkTheme()
        {
            if (AppInfo.RequestedTheme == AppTheme.Light)
                return false;
            else
                return true;
        }
    }
}
