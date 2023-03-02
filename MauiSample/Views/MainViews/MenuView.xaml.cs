namespace MauiSample.Views.MainViews;

public partial class MenuView : ContentView
{
	public MenuView()
	{
		InitializeComponent();
		
	}

	private void ContentView_Loaded(object sender, EventArgs e)
	{
        this.BindingContext = new MenuViewModel(this.Navigation);
    }
}