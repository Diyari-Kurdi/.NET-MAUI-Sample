#if ANDROID
using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif

namespace MauiSample;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif IOS
            handler.PlatformView.BackgroundColor = UIKit.UIColor.FromRGBA(Colors.Transparent.Red,Colors.Transparent.Green,Colors.Transparent.Blue,Colors.Transparent.Alpha);
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
        });
        MainPage = new AppShell();
    }
}
