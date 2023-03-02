namespace MauiSample.Views.MainViews.Settings;

public partial class AccountView : ContentPage
{
	public AccountView()
	{
		InitializeComponent();

		this.BindingContext = new AccountViewModel();
    }
}