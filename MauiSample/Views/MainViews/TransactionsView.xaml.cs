namespace MauiSample.Views.MainViews;

public partial class TransactionsView : ContentView
{
	public TransactionsView()
	{
		InitializeComponent();
	}

	private async void ContentView_Loaded(object sender, EventArgs e)
	{
		this.BindingContext = new TransactionViewModel();
        uint duration = 10 * 60 * 1000;
        await Task.WhenAll
        (
          Icon.RotateTo(307 * 360, duration),
          Icon.RotateXTo(251 * 360, duration),
          Icon.RotateYTo(199 * 360, duration)
        );
    }
}