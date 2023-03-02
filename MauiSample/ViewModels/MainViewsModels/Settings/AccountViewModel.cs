using Microsoft.Maui.Controls.Shapes;

namespace MauiSample.ViewModels.MainViewsModels.Settings
{
    public partial class AccountViewModel : ObservableObject
    {
        [ObservableProperty]
        private Geometry camera = SVGs.Camera;

        [ObservableProperty]
        private static Geometry backButtonIcon = SVGs.ArrowBack;

        [ObservableProperty]
        private ImageSource profilePicture = "man";

        [RelayCommand]
        private async Task<FileResult> PickAnImage()
        {
            try
            {
                PickOptions options = new()
                {
                    PickerTitle = "وێنەیەک هەڵبژێرە",
                    FileTypes = FilePickerFileType.Images
                };
                var result = await FilePicker.Default.PickAsync(options);
                if (result != null)
                {
                    var stream = await result.OpenReadAsync();
                    ProfilePicture = ImageSource.FromStream(() => stream);

                }

                return result;
            }
            catch (Exception)
            {
                // The user canceled or something went wrong
            }

            return null;
        }

        [RelayCommand]
        private static void SendBackButton() 
        {
            App.Current.MainPage.SendBackButtonPressed();
        }

        [RelayCommand]
        private static Task LinkToFacebook()
        {
            Console.WriteLine("Facebook Connection");
            return Task.CompletedTask;
        }

        [RelayCommand]
        private static Task LinkToGoogle()
        {
            Console.WriteLine("Google Connection");
            return Task.CompletedTask;
        }
    }
}
