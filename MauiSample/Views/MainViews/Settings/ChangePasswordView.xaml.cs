namespace MauiSample.Views.MainViews.Settings;

public partial class ChangePasswordView : ContentPage
{
	public ChangePasswordView()
	{
		InitializeComponent();
		this.BindingContext = new ChangePasswordViewModel();
	}

	private void ContentPage_Loaded(object sender, EventArgs e)
	{
		NewPasswordEntry.FontSize = 16;
		ConfirmPasswordEntry.FontSize = 16;
	}
}