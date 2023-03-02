using Microsoft.Maui.Controls.Shapes;

namespace MauiSample.ViewModels.MainViewsModels
{
    public partial class TransactionViewModel : ObservableObject
    {
        [ObservableProperty]
        private static Geometry backButtonIcon = SVGs.ArrowBack;
    }
}
