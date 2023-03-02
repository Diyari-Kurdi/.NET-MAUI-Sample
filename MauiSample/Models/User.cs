namespace MauiSample.Models
{
    public static class User
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public static string Email { get; set; }

        public static string ProfilePictureSource { get; set; }

        public static decimal Balance { get; set; }
    }
}
