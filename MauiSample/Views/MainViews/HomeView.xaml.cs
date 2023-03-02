namespace MauiSample.Views.MainViews;

public partial class HomeView : ContentView
{
    public HomeView()
    {
        InitializeComponent();
        
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        this.BindingContext = new HomeViewModel();
        //Shell.Current.SendBackButtonPressed();
    }
}