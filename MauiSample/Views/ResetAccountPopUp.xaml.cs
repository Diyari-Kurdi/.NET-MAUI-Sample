using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Platform;

namespace MauiSample.Views;

public partial class ResetAccountPopUp : Popup
{
    public ResetAccountPopUp()
    {
        InitializeComponent();
        this.BindingContext = new ResetPageViewModel();
    }
    private void Popup_Opened(object sender, CommunityToolkit.Maui.Core.PopupOpenedEventArgs e)
    {
        var width = DeviceDisplay.MainDisplayInfo.Width / 3;

        this.Size = new Size(width - 30, this.Size.Height);
    }
}