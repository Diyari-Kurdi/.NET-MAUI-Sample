using CommunityToolkit.Mvvm.Messaging;

namespace MauiSample.Views;

public partial class MainPage : ContentPage, IRecipient<string>
{
    public MainPage(MainPageViewModel mpvm)
    {
        InitializeComponent();
        this.BindingContext = mpvm;
    }

    private void ChangeTheme()
    {
        if (Themes.Mode == Modes.Dark)
        {
            StatusBar.StatusBarColor = Color.FromArgb("#171B23");
            StatusBar.StatusBarStyle = StatusBarStyle.LightContent;
        }
        else
        {
            StatusBar.StatusBarColor = Color.FromArgb("#EEF1F6");
            StatusBar.StatusBarStyle = StatusBarStyle.DarkContent;
        }
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        Hostview.SelectedIndex = 1;
        ChangeTheme();

        //On Android 11 we have a problem with TouchEffect we have to Reset Effects when its loaded;
        foreach (var tabItem in Hostview.Tabs)
        {
            Sharpnado.Tabs.Effects.TouchEffect.SetColor(tabItem, Colors.Transparent);
        }
    }

    public void Receive(string message)
    {
        if (message == "ThemeChanged")
        {
            ChangeTheme();
        }
    }
}