using CommunityToolkit.Maui.Views;

namespace MauiSample.ViewModels
{
    public partial class UserProfileViewModel : ObservableObject
    {

        [ObservableProperty]
        private string profileSource = "http://www.canyon-news.com/wp-content/uploads/2014/11/John-Wick.png";

        [ObservableProperty]
        private string fullName = User.FullName;

        [ObservableProperty]
        private string email = User.Email;
    }
}
