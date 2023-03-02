using Microsoft.Maui.Controls.Shapes;


namespace MauiSample.ViewModels.MainViewsModels;

public partial class HomeViewModel : ObservableObject
{
    #region SVG Data
    [ObservableProperty]
    private Geometry down = SVGs.CircleDown;
    [ObservableProperty]
    private Geometry up = SVGs.CircleUp;
    #endregion

    #region Parameters

    private static readonly string Sign = "$";

    [ObservableProperty]
    private string profilePictureSource = "http://www.canyon-news.com/wp-content/uploads/2014/11/John-Wick.png"; //User.ProfilePictureSource;

    [ObservableProperty]
    private string userName = User.FullName;

    [ObservableProperty]
    private Geometry pathData = SVGs.Opened_Eye;

    [ObservableProperty]
    private string balance = "5,000" + Sign;

    private static readonly Image img1 = new()
    {
        Source = "https://images.pexels.com/photos/556414/pexels-photo-556414.jpeg"
    };
    private static readonly Image img2 = new()
    {
        Source = "https://images.pexels.com/photos/541484/sun-flower-blossom-bloom-pollen-541484.jpeg"
    };

    [ObservableProperty]
    private Image[] images = { img1, img2 };

    private int position;
    public int Position
    {
        get
        {
            return position;
        }
        set
        {
            position = value;
            Source = Images[value].Source;
        }
    }

    [ObservableProperty]
    private ImageSource _source;
    #endregion

    #region Commands

    [RelayCommand]
    private void Show_Hide_DataPath()
    {
        if (PathData == SVGs.Opened_Eye)
        {
            PathData = SVGs.Closed_Eye;
            Balance = Sign + "****";
        }
        else
        {
            PathData = SVGs.Opened_Eye;
            Balance = "5,000" + Sign;
        }
    }

    #endregion
}

