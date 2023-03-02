namespace MauiSample.ViewModels.MainViewsModels
{
    public partial class MenuViewModel : ObservableObject
    {

        private readonly INavigation Navigation;
        public MenuViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        public bool IsToggled
        {
            get
            {
                if (Themes.Mode == Modes.Dark)
                {
                    return true;
                }
                return false;

            }
            set
            {
                if (value)
                {
                    Themes.Mode = Modes.Dark;
                }
                else
                {
                    Themes.Mode = Modes.Light;
                }
                OnPropertyChanged(nameof(IsToggled));
            }
        }

        #region Commands

        [RelayCommand]
        private void ToggleSwitcher()
        {
            if (IsToggled)
            {
                IsToggled = false;
                return;
            }
            IsToggled = true;
        }

        [RelayCommand]
        private async Task ChangePassword()
        {
            await Navigation.PushAsync(new ChangePasswordView());
        }

        [RelayCommand]
        private async Task Account()
        {
            await Navigation.PushAsync(new AccountView());
        }

        [RelayCommand]
        private static async Task Logout()
        {
            //await CrossFirebaseAuth.Current.SignOutAsync();

            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

        #endregion
    }
}
