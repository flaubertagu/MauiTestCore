using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestCore.Interfaces
{
    public interface IThemeEnvironment
    {
        void SetStatusBarColor(Microsoft.Maui.Graphics.Color color, bool darkStatusBarTint);
    }
}
