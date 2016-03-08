namespace UpworkWP8
{
    public class Constants
    {
        public class Urls
        {
            /// <summary>
            /// Base url
            /// </summary>
            public const string BASE_URL = "https://www.upwork.com";
            //
            /// <summary>
            /// JSON format
            /// </summary>
            public const string FORMAT_JSON = "json";
            //
            /// <summary>
            /// XML format
            /// </summary>
            public const string FORMAT_XML = "xml";

            #region Authorization
            //
            //
            /// <summary>
            /// Get OAuth token url
            /// </summary>
            public const string URL_TOKEN_REQUEST = BASE_URL + "/api/auth/v1/oauth/token/request";
            //
            /// <summary>
            /// Authorization url
            /// </summary>
            public const string URL_AUTH_PAGE = BASE_URL + "/services/api/auth";
            //
            /// <summary>
            /// Get token url
            /// </summary>
            public const string URL_TOKEN_ACCESS = BASE_URL + "/api/auth/v1/oauth/token/access";

            #endregion

            #region Jobs
            //
            /// <summary>
            /// Search job url in JSON format
            /// </summary>
            public const string URL_JOB_SEARCH_JSON = BASE_URL + "/api/profiles/v2/search/jobs." + FORMAT_JSON;
            //
            /// <summary>
            /// Search job url in XML format
            /// </summary>
            public const string URL_JOB_SEARCH_XML = BASE_URL + "/api/profiles/v2/search/jobs." + FORMAT_XML;
            //
            /// <summary>
            /// Job list url in JSON format
            /// </summary>
            public const string URL_JOB_LIST_JSON = BASE_URL + "/api/hr/v2/jobs." + FORMAT_JSON;
            //
            /// <summary>
            /// Job list url in XML format
            /// </summary>
            public const string URL_JOB_LIST_XML = BASE_URL + "/api/hr/v2/jobs." + FORMAT_XML;
            //
            /// <summary>
            /// Post job in XML
            /// </summary>
            public const string URL_JOB_POST_XML = BASE_URL + "/api/hr/v2/jobs." + FORMAT_XML;
            //
            /// <summary>
            /// Post job in JSON format
            /// </summary>
            public const string URL_JOB_POST_JSON = BASE_URL + "/api/hr/v2/jobs." + FORMAT_JSON;

            /// <summary>
            /// Get url to job service
            /// </summary>
            public static string GetJobUrl(string jobKey, string format)
            {
                return BASE_URL + "/api/hr/v2/jobs/" + jobKey + "." + format;
            }

            /// <summary>
            /// Get url to update job service
            /// </summary>
            public static string GetUpdateJobUrl(string jobKey, string format)
            {
                return BASE_URL + "/api/hr/v2/jobs/" + jobKey + "." + format;
            }

            /// <summary>
            /// Get url to delete job service
            /// </summary>
            public static string GetDeleteJobUrl(string jobKey, string format)
            {
                return BASE_URL + "/api/hr/v2/jobs/" + jobKey + "." + format;
            }

            /// <summary>
            /// Get url to job profile service
            /// </summary>
            public static string GetProfileJobUrl(string jobKey, string format)
            {
                return BASE_URL + "/api/profiles/v1/jobs/" + jobKey + "." + format;
            }

            /// <summary>
            /// Get url to invite service
            /// </summary>
            public static string GetInviteToJobUrl(string jobKey, string format)
            {
                return BASE_URL + "/api/hr/v1/jobs/" + jobKey + "/candidates." + format;
            }

            #endregion

            #region Current user

            //
            /// <summary>
            /// Current user info in XML
            /// </summary>
            public const string URL_USER_INFO_XML = BASE_URL + "/api/auth/v1/info." + FORMAT_XML;
            //
            /// <summary>
            /// Current user info in JSON
            /// </summary>
            public const string URL_USER_INFO_JSON = BASE_URL + "/api/auth/v1/info." + FORMAT_JSON;
            //
            /// <summary>
            /// User info by ID
            /// </summary>
            public static string GetUserInfoByIdUrl(string userId, string format)
            {
                return BASE_URL + "/api/hr/v2/users/" + userId + "." + format;
            }
            //
            /// <summary>
            /// Current user permissions in JSON
            /// </summary>
            public const string URL_USER_PERMISSIONS_JSON = BASE_URL + "/api/hr/v2/userroles." + FORMAT_JSON;
            //
            /// <summary>
            /// Current user permissions in XML
            /// </summary>
            public const string URL_USER_PERMISSIONS_XML = BASE_URL + "/api/hr/v2/userroles." + FORMAT_XML;


            #endregion

            #region Freelancers

            //
            /// <summary>
            /// Search for freelancers in XML
            /// </summary>
            public const string URL_FREELANCER_INFO_XML = BASE_URL + "/api/profiles/v2/search/providers." + FORMAT_XML;
            //
            /// <summary>
            /// Search for freelancers in JSON
            /// </summary>
            public const string URL_FREELANCER_INFO_JSON = BASE_URL + "/api/profiles/v2/search/providers." + FORMAT_JSON;
            //
            /// <summary>
            /// Get url to freelancer brief
            /// </summary>
            public static string GetBriefUrl(string profileKey, string format)
            {
                return BASE_URL + "/api/profiles/v1/providers/" + profileKey + "/brief." + format;
            }
            //
            /// <summary>
            /// Get url to freelancer's profile
            /// </summary>
            public static string GetProfileUrl(string profileKey, string format)
            {
                return BASE_URL + "/api/profiles/v1/providers/" + profileKey + "." + format;
            }

            #endregion
        }
    }
}
