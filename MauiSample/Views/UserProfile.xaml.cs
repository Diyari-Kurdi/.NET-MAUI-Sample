using CommunityToolkit.Maui.Views;

namespace MauiSample.Views;

public partial class UserProfile : Popup
{
    public UserProfile()
    {
        InitializeComponent();
        this.BindingContext = new UserProfileViewModel();
    }

    private void Popup_Opened(object sender, PopupOpenedEventArgs e)
    {
        var width = DeviceDisplay.MainDisplayInfo.Width / 3;
        var height = DeviceDisplay.MainDisplayInfo.Height / 3;

        this.Size = new Size(width - 40, this.Size.Height);
    }
}