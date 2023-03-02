using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace MauiSample;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
public class MainActivity : MauiAppCompatActivity
{
    [IntDefinition("Android.Views.View.SystemUiFlagLightNavigationBar", JniField = "android/view/View.SYSTEM_UI_FLAG_LIGHT_NAVIGATION_BAR")]
    public SystemUiFlags LightNavigationBar = SystemUiFlags.Visible;
    public void ChangeNavColor()
    {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
        {
            if (Preferences.Default.Get("IsDark", true))
            {
                Window.SetNavigationBarColor(Android.Graphics.Color.Rgb(23, 27, 35));
            }
            else
            {
                
                
                Window.SetNavigationBarColor(Color.FromArgb("#EEF1F6").ToAndroid());
                LightNavigationBar = SystemUiFlags.LightNavigationBar;
                Window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightNavigationBar;
            }
        }
    }

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        if (Preferences.ContainsKey("IsDark"))
        {
            ChangeNavColor();
        }
        else
        {
            Preferences.Default.Set("IsDark", true);
            ChangeNavColor();
        }
    }

    //long lastPress;

    //public override void OnBackPressed()
    //{
    //    long currentTime = DateTime.UtcNow.Ticks / TimeSpan.TicksPerMillisecond;

    //    if (currentTime - lastPress > 5000)
    //    {
    //        Toast.Make("دووبارە بگەڕێوە بۆ دەرچوون", ToastDuration.Long).Show();
    //        lastPress = currentTime;
    //    }
    //    else
    //    {
    //        base.OnBackPressed();
    //    }
    //}
}
