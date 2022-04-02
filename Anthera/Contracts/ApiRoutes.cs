namespace Anthera_API.misc
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
        }
    }
}
