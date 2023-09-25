using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTestCore.ViewModels
{
    public partial class AuthenticateVM : ObservableObject
    {
        public const string MsgInitConfig = "Searching for existing configuration. Please wait";

        #region Show Hide password
        public void SetIsPassword(bool isPassword)
        {
            IsPassword = isPassword;
            if (isPassword)
                ShowHidePassword = "hide.png";
            else
                ShowHidePassword = "lock.png";
        }
        private bool _isPassword = true;
        public bool IsPassword
        {
            get => _isPassword;
            set
            {
                _isPassword = value;
                OnPropertyChanged(nameof(IsPassword));
            }
        }
        private string _showHidePassword = string.Empty;
        public string ShowHidePassword
        {
            get => _showHidePassword;
            set
            {
                _showHidePassword = value;
                OnPropertyChanged(nameof(ShowHidePassword));
            }
        }
        #endregion

        #region Side bar button visibility
        private bool _buttonsVisible = false;
        public bool ButtonsVisible
        {
            get => _buttonsVisible;
            set
            {
                _buttonsVisible = value;
                OnPropertyChanged(nameof(ButtonsVisible));
            }
        }
        #endregion
    }
}
