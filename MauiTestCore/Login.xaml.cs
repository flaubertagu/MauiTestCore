namespace MauiTestCore;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
        BindingContext = App.AuthenticateVM;
    }

    #region Login button enability
    private void Username_TextChanged(object sender, TextChangedEventArgs e)
    {
        LoginButtonEnability();
    }

    private void Password_TextChanged(object sender, TextChangedEventArgs e)
    {
        LoginButtonEnability();
    }

    private void LoginButtonEnability()
    {
        if (!string.IsNullOrEmpty(Username.Text) && !string.IsNullOrEmpty(Password.Text))
            LoginButton.IsEnabled = true;
        else
            LoginButton.IsEnabled = false;
    }
    #endregion

    #region Login functions
    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        string username = Username.Text;
        string password = Password.Text;
        await DisplayAlert("Credentials", $"Username: {username}\nPassword: {password}", "Close");
    }

    private void ShowHidePassword_Clicked(object sender, EventArgs e)
    {
        bool isPassword = App.AuthenticateVM.IsPassword;
        App.AuthenticateVM.SetIsPassword(!isPassword);
    }
    #endregion

    #region Lateral buttons functions
    private void ShowHideButtons_Clicked(object sender, EventArgs e)
    {
        bool buttonsIsVisible = App.AuthenticateVM.ButtonsVisible;
        App.AuthenticateVM.ButtonsVisible =! buttonsIsVisible;
    }

    private async void Create_account_Clicked(object sender, System.EventArgs e)
    {
        await Browser.OpenAsync(new Uri("https://flktech.fr/Accounts/RegistrationCompany1"), BrowserLaunchMode.SystemPreferred);
    }

    private async void Legal_notice_Clicked(object sender, System.EventArgs e)
    {
        await Browser.OpenAsync(new Uri("https://flktech.fr/Footer/Copyright"), BrowserLaunchMode.SystemPreferred);
    }

    private async void Copyright_Clicked(object sender, System.EventArgs e)
    {
        await Browser.OpenAsync(new Uri("https://flktech.fr/Footer/TermsOfUse"), BrowserLaunchMode.SystemPreferred);
    }

    private async void LinkedId_Clicked(object sender, System.EventArgs e)
    {
        await Browser.OpenAsync(new Uri("https://www.linkedin.com/company/flktech/?viewAsMember=true"), BrowserLaunchMode.SystemPreferred);
    }

    private async void Facebook_Clicked(object sender, System.EventArgs e)
    {
        await Browser.OpenAsync(new Uri("https://www.facebook.com/FlaubertLK"), BrowserLaunchMode.SystemPreferred);
    }

    private async void Youtube_Clicked(object sender, System.EventArgs e)
    {
        await Browser.OpenAsync(new Uri("https://www.youtube.com/channel/UCAAnQKjd53p6CTkOKHJiQUA"), BrowserLaunchMode.SystemPreferred);
    }
    #endregion
}
