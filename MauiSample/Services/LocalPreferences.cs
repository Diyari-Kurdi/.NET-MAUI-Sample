namespace MauiSample.Services;

public static class LocalPreferences
{
    public static Task<UserModel> SetUser(UserModel user)
    {
        Preferences.Set(nameof(user.Email), user.Email);
        Preferences.Set(nameof(user.Password), user.Password);
        return Task.FromResult(user);
    }

    public static UserModel GetUser()
    {
        UserModel user = new() 
        {
            Email = Preferences.Get(nameof(user.Email), ""),
            Password = Preferences.Get(nameof(user.Password), "")
        };

        return user;
    }
}

