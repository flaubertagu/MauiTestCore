using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestCore.Helpers
{
    public static class Settings
    {
        // 0 = default, 1 = light, 2 = dark
        const int theme = 0;
        public static int AppTheme
        {
            get => Preferences.Get(nameof(AppTheme), theme);
            set => Preferences.Set(nameof(AppTheme), value);
        }
    }
}
