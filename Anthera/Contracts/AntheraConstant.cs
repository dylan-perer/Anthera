namespace Anthera_API.misc
{
    public static class AntheraConstant
    {
        public static string ERROR = "ERROR";
        public static string DEV_ERROR = "DEV_ERROR";



        public static class Errors
        {
            public static object GenericErrorObj = new { errors = "Sorry, something went wrong. Please try again." };
            public static string GenericError = "Sorry, something went wrong. Please try again.";


            public static class Requests
            {
                public const string NonUniqueEmailAddress = "Sorry, email already in use. Please signin or try again.";
                public const string EmailAdressIsRequired = "Email address is required.";

                public const string InvalidGender = "Gender value is invalid.";
                public const string GenderIsRequired = "Gender value is required.";

                public const string InvalidHereTo = "Here to value is invalid.";
                public const string HereToIsRequired = "Here to value is required.";

                public const string InvalidSexPreference = "Sex preference value is invalid.";
                public const string SexPreferenceRequired = "Sex preference value is required.";

                public const string InvalidDate = "Invalid date.";
                public const string InvalidMaxDob = "Sorry, your age can't be over 99 years old.";
                public const string InvalidMinDob = "Sorry, you need to be atleast 18 years old to join.";
                public const string DobIsRequired = "Dob is required.";


                public const string EmailOrPasswordInvalid = "Sorry, email or password is incorrect. Pleas try again.";
                public const string ConfirmPasswordIsInvalid = "Sorry, passwords don't match. Pleas try again.";

                public const string RefreshTokenIsInvalid = "Refresh token is invalid.";

                public const string InvalidJobTitle = "Job Title to value is invalid.";
                public const string JobTitleIsRequired = "Job Title to value is required.";

                public const string InvalidChildren = "Children to value is invalid.";
                public const string ChildrenIsRequired = "Children to value is required.";

            }
        }

        public static class Requests
        {
            public static class User
            {
                public const string SignedoutSuccessfully = "You are signed out.";
                public const int FileSize = 5000001;
                public const int InterestMax = 25;
            }

        }

    }
}
