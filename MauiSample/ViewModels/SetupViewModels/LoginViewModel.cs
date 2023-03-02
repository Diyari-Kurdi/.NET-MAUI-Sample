using CommunityToolkit.Maui.Views;

namespace MauiSample.ViewModels.SetupViewModels;

public partial class LoginViewModel : ObservableObject
{
    public LoginViewModel(INavigation navigation)
    {
        Navigation = navigation;
    }
    #region Observable Property

    [ObservableProperty]
    private string _email;
    [ObservableProperty]
    private string _password;
    private CancellationTokenSource CancellationTokenSource;

    public INavigation Navigation { get; }

    #endregion

    #region Commands

    [RelayCommand]
    public static async Task ResetPassword()
    {
        await Shell.Current.ShowPopupAsync(new ResetAccountPopUp());
    }

    [RelayCommand]
    public async Task Login()
    {
        CancellationTokenSource = new();
        try
        {
            if (!String.IsNullOrWhiteSpace(Email) && !String.IsNullOrWhiteSpace(Password))
            {
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
            else
            {
                await Toast.Make("تکایە زانیاریەکان پڕ بکەوە", ToastDuration.Long, 14).Show();

                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
        }
        catch (Exception ex)
        {
            await Toast.Make(ex.Message, ToastDuration.Long, 14).Show(CancellationTokenSource.Token);
        }

    }

    #endregion

}
