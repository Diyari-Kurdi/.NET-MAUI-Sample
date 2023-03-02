using CommunityToolkit.Mvvm.Messaging;
using PanCardView;


namespace MauiSample;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {

        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();

        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseCardsView()
            .UseSharpnadoTabs(loggerEnable: false)
            .ConfigureFonts(fonts =>
            {
                #region Vazirmatn
                fonts.AddFont("Vazirmatn-Black.ttf", "Vazir-Black");
                fonts.AddFont("Vazirmatn-Bold.ttf", "Vazir-Bold");
                fonts.AddFont("Vazirmatn-ExtraBold.ttf", "Vazir-ExtraBold");
                fonts.AddFont("Vazirmatn-ExtraLight.ttf", "Vazir-ExtraLight");
                fonts.AddFont("Vazirmatn-Light.ttf", "Vazir-Light");
                fonts.AddFont("Vazirmatn-Medium.ttf", "Vazir-Medium");
                fonts.AddFont("Vazirmatn-Regular.ttf", "Vazir-Regular");
                fonts.AddFont("Vazirmatn-SemiBold.ttf", "Vazir-SemiBold");
                fonts.AddFont("Vazirmatn-Thin.ttf", "Vazir-Thin");
                #endregion
            });
        builder.Services.AddSingleton<WeakReferenceMessenger>();

        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoginViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();

        builder.Services.AddSingleton<ResetAccountPopUp>();
        builder.Services.AddSingleton<ResetPageViewModel>();

        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<TransactionViewModel>();

        builder.Services.AddSingleton<RegisterViewModel>();

        return builder.Build();
    }
}