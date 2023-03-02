using Microsoft.Maui.Controls.Shapes;

namespace MauiSample.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private Geometry user;

    [ObservableProperty]
    private Geometry home;

    [ObservableProperty]
    private Geometry receipt;
}

