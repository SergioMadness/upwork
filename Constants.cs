namespace DataLayer.UpWork
{
    public class Constants
    {
        public class Urls
        {
            public const string BASE_URL = "https://www.upwork.com";

            public const string TOKEN_REQUEST = BASE_URL + "/api/auth/v1/oauth/token/request";
            public const string AUTH_PAGE = BASE_URL + "/services/api/auth";
            public const string TOKEN_ACCESS = BASE_URL + "/api/auth/v1/oauth/token/access";
        }
    }
}
