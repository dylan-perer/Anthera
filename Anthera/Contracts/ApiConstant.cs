﻿namespace Anthera_API.misc
{
    public static class ApiConstant
    {
        public static class Errors
        {
            public const string GenericError = "Sorry, something went wrong. Please try again.";

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

            }
        }

        public static class Requests
        {
            public static class User
            {
                public const string SignedoutSuccessfully = "You are signed out."; 
            }
           
        }

        public static class Db
        {
            public const string ID_PREFER_NOT_TO_SAY = "I'd prefer not to say";
            public const string ABOUT_ME_DEFAULT = "Write something about yourself...";
            public const string HEIGHT_DEFAULT = "163 cm";
            public const string WEIGHT_DEFAULT = "60 kg";
            public const int DEFAULT_PHOTO_LIMIT = 6;

        }
    }
}
