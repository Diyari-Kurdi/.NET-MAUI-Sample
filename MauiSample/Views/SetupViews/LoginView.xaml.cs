using Microsoft.Maui.Platform;
using ContentView = Microsoft.Maui.Controls.ContentView;

namespace MauiSample.Views.SetupViews;

public partial class LoginView : ContentView
{
	public LoginView()
	{
		InitializeComponent();
	}

	private void ContentView_Loaded(object sender, EventArgs e)
	{
		this.BindingContext = new LoginViewModel(this.Navigation);
		//PasswordEntry.FontSize = 16;
	}

	private void EmailEntry_Completed(object sender, EventArgs e)
	{
		PasswordEntry.Focus();
	}

	private void PasswordEntry_Completed(object sender, EventArgs e)
	{
		PasswordEntry.Unfocus();
#if ANDROID
		try
		{
			Platform.CurrentActivity.HideKeyboard(Platform.CurrentActivity.CurrentFocus);
		}
		catch { }
#endif
	}
}