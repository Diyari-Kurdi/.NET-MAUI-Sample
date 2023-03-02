using CommunityToolkit.Mvvm.Messaging;

namespace MauiSample.Views;

public partial class LoginPage : ContentPage,IRecipient<string>
{
    public LoginPage(MainPageViewModel mpvm)
    {
        InitializeComponent();
        this.BindingContext = mpvm;
        ChangeTheme();
        WeakReferenceMessenger.Default.Register(this);
    }

    private void ChangeTheme()
    {
        if (Themes.Mode == Modes.Dark)
        {
            StatusBar.StatusBarColor = Color.FromArgb("#222631");
            StatusBar.StatusBarStyle = StatusBarStyle.LightContent;
        }
        else
        {
            StatusBar.StatusBarColor = Colors.White;
            StatusBar.StatusBarStyle = StatusBarStyle.DarkContent;
        }

    }
    private void ThemeChanger_Clicked(object sender, EventArgs e)
    {
        if (Themes.Mode == Modes.Dark)
        {
            Themes.Mode = Modes.Light;
        }
        else
        {
            Themes.Mode = Modes.Dark;
        }
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        try
        {
            Switcher.SelectedIndex = 0;
            //if (!String.IsNullOrWhiteSpace(GetUser().Email) && !String.IsNullOrWhiteSpace(GetUser().Password))
            //{

            //    await CrossFirebaseAuth.Current.SignInWithEmailAndPasswordAsync(GetUser().Email, GetUser().Password);
            //    await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            //}

        }
        catch { }
    }

    public void Receive(string message)
    {
        if (message == "Register")
        {
            Switcher.SelectedIndex = 0;
        }
        else if (message == "ThemeChanged") 
        {
            ChangeTheme();
        }
    }
}