namespace MauiSample.ViewModels;
public partial class ResetPageViewModel : ObservableObject
{
    public ResetPageViewModel()
    {

    }

    [ObservableProperty]
    private string email;
    private CancellationTokenSource CancellationTokenSource;
    [RelayCommand]
    public async Task Submit()
    {
        CancellationTokenSource = new();
        try
        {
            //Do Work
        }
        catch
        {
            ToastDuration duration = ToastDuration.Short;
            double fontSize = 14;
            var toast5 = Toast.Make("ناونیشانی ئیمەیڵ هەڵەیە.", duration, fontSize);
            await toast5.Show(CancellationTokenSource.Token);
        }
    }
}

