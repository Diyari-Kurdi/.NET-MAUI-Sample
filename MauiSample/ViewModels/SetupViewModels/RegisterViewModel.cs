using CommunityToolkit.Mvvm.Messaging;

namespace MauiSample.ViewModels.SetupViewModels;

public partial class RegisterViewModel : ObservableRecipient
{
    #region ObservableProperty

    [ObservableProperty]
    private string _firstName;

    [ObservableProperty]
    private string _lastName;

    [ObservableProperty]
    private string _email;

    [ObservableProperty]
    private string _password;

    #endregion

    #region RelayCommands
    private CancellationTokenSource CancellationTokenSource;

    [RelayCommand]
    async Task RegisterBtn()
    {
        CancellationTokenSource = new();
        try
        {
            //Do Work

            await Application.Current.MainPage.DisplayAlert("سەرکەوتوو بوو", "تکایە ئیمەیڵەکەت بپشکنە بۆ پشتڕاستکردنەوەی هەژمارەکەت، پاشان دەتوانی بچیتەژوورەوە.", "باشە", FlowDirection.RightToLeft);
            Messenger.Send("Register");
        }
        catch (Exception e)
        {
            ToastDuration duration = ToastDuration.Short;
            double fontSize = 14;
            var toast5 = Toast.Make(e.Message, duration, fontSize);
            await toast5.Show(CancellationTokenSource.Token);
        }

    }

    #endregion
}

