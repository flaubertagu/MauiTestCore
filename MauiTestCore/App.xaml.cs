using MauiTestCore.Helpers;
using MauiTestCore.ViewModels;

namespace MauiTestCore;

public partial class App : Application
{
    public static AuthenticateVM AuthenticateVM { get; set; }
    public static SystemTheme SystemTheme { get; set; }
    public App()
	{
		InitializeComponent();
        SystemTheme = new SystemTheme();
        AuthenticateVM = new AuthenticateVM();
        MainPage = new AppShell();
	}

    protected override void OnStart()
    {
        base.OnStart();
        SystemTheme.SetUserTheme();
    }

	protected override void OnSleep()
	{
		base.OnSleep();
        SystemTheme.SetUserTheme();
        RequestedThemeChanged += App_RequestedThemeChanged;
    }

	protected override void OnResume()
	{
		base.OnResume();
        SystemTheme.SetUserTheme();
        RequestedThemeChanged += App_RequestedThemeChanged;
    }

    private void App_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            SystemTheme.SetUserTheme();
        });
    }
}