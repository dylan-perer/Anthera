namespace Anthera.API.misc
{
    public static class ApiRoutes
    {
        private const string Base = "api";
        private const string Version = "/v1";
        private const string ApiV1 = Base + Version;

        public static class HTTP_ACTIONS
        {
            public const string GET = "get";
            public const string POST = "post";
            public const string DELETE = "delete";
            public const string PUT = "put";
        }

        public static class Identity
        {
            public const string ControllerV1 = ApiV1 + "/identity";
            public const string Signup = "signup";
            public const string Signin = "signin";
            public const string Signout = "signout";
            public const string RefreshToken = "refreshtoken";

        }
        public static class User
        {
            public const string ControllerV1 = ApiV1 + "/user";
            public const string Profile = "profile";
            public const string Basicinfo = "basicinfo";
            public const string WorkAndEducation = "workandeducation";
            public const string Children = "children";
            public const string Weight = "weight";
            public const string Height = "height";
            public const string Religion = "religion";
            public const string Personality = "personality";
            public const string Drinking = "drinking";
            public const string Smoking = "smoking";
            public const string HereTo = "hereto";
            public const string AboutMe = "aboutme";
            public const string Relationship = "relationship";
            public const string ProfilePicture = "profilePicture";
            public const string Gallery = "gallery";
            public const string EducationLevel = "educationlevel";
        }
    }
}
