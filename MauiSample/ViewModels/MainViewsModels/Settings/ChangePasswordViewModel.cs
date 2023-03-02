using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls.Shapes;

namespace MauiSample.ViewModels.MainViewsModels.Settings;

public partial class ChangePasswordViewModel : ObservableObject
{
    [ObservableProperty]
    private static Geometry backButtonIcon = SVGs.ArrowBack;

    [RelayCommand]
    public async Task ResetPassword()
    {
        await Shell.Current.ShowPopupAsync(new ResetAccountPopUp());
    }

    [RelayCommand]
    private void SendBackButton()
    {
        App.Current.MainPage.SendBackButtonPressed();
    }
}

