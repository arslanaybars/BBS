namespace BBS.Util
{
    public static class Constants
    {
        #region Username Credential

        public static class UserCredential
        {
            public const string Username = "labas";
            public const string Password = "labas";
        }

        #endregion

        #region [ Gender ]

        public static class GenderConstants
        {
            public const string Unknown = "Unknown";
            public const string Male = "Male";
            public const string Female = "Female";

            public const int UnknownId = 1;
            public const int MaleId = 2;
            public const int FemaleId = 3;
        }

        #endregion

        #region [ Role ]

        public static class RoleConstants
        {
            public const string Unknown = "Unknown";
            public const string Admin = "Admin";
            public const string Worker = "Worker";
            public const string Guest = "Guest";

            public const int UnknownId = 1;
            public const int AdminId = 2;
            public const int WorkerId = 3;
            public const int GuestId = 4;
        }

        #endregion
    }
}
