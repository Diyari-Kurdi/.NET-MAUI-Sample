using CommunityToolkit.Mvvm.Messaging;

namespace MauiSample.Services
{
    public static class Themes
    {

        public static void ChangeMode(Modes mode) 
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            mergedDictionaries.Clear();
            if (mode == Modes.Dark) 
            {
                mergedDictionaries.Add(new DarkTheme());
            }
            else
            {
                mergedDictionaries.Add(new LightTheme());
            }
        }

        private static bool isDark;
        public static Modes Mode
        {
            get
            {
                if (Preferences.Get("IsDark", true))
                {
                    ChangeMode(Modes.Dark);
                    return Modes.Dark;
                }
                else
                {
                    ChangeMode(Modes.Light);
                    return Modes.Light;
                }
            }
            set
            {
                if (value == Modes.Dark)
                {
                    ChangeMode(Modes.Dark);
                    isDark = true;
                }
                else
                {
                    ChangeMode(Modes.Light);
                    isDark = false;
                }
                Preferences.Set("IsDark", isDark);
                WeakReferenceMessenger.Default.Send("ThemeChanged");

            }
        }

    }
    public enum Modes
    {
        Light,
        Dark
    }
}
