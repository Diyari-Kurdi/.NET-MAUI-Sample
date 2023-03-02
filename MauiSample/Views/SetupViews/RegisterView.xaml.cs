namespace MauiSample.Views.SetupViews;

public partial class RegisterView : ContentView
{
	public RegisterView()
	{
		InitializeComponent();
	}

	private void ContentView_Loaded(object sender, EventArgs e)
	{
        BindingContext = new RegisterViewModel();
        PasswordEntry.FontSize = 16;
    }

	private void FirstNameEntry_Completed(object sender, EventArgs e)
	{
		LastNameEntry.Focus();
	}

	private void LastNameEntry_Completed(object sender, EventArgs e)
	{
		EmailEntry.Focus();
	}

	private void EmailEntry_Completed(object sender, EventArgs e)
	{
		PasswordEntry.Focus();
	}

}