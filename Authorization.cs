using System;
using WPDevelopmentLibs.Helpers;
using DataLayer.Libs.Helpers.Net;
using System.Net;
using System.Collections.Generic;
using UpworkWP8.interfaces;

namespace UpworkWP8
{
    public class Authorization : Service
    {
        public const string SIGNATURE_METHOD_HMAC = "HMAC-SHA1";
        public const string SIGNATURE_METHOD_RSA = "RSA-SHA1";
        public const string SIGNATURE_METHOD_PLAINTEXT = "PLAINTEXT";

        public string CurrentSignatureType = SIGNATURE_METHOD_HMAC;
        public string OAuthToken, OAuthTokenSecret;

        public void GetRequestToken()
        {
            string timestamp = DateHelpers.DateTimeToUnitTimeStamp(DateTime.UtcNow).ToString();

            SimpleConnector connector = new SimpleConnector();
            connector.SetServerName(Constants.Urls.URL_TOKEN_REQUEST);
            connector.AddParam("oauth_consumer_key", Settings.Key);
            connector.AddParam("oauth_nonce", Settings.Nounce);
            connector.AddParam("oauth_timestamp", timestamp);
            connector.AddParam("oauth_signature_method", Settings.SignatireMethod);
            connector.AddParam("oauth_signature", this.generateSignature(this.CurrentSignatureType, "POST", Constants.Urls.URL_TOKEN_REQUEST, connector.GetParams(), Settings.SecretKey + "&"));

            connector.OnRequestComplete += this.parseResponse;
            connector.OnRequestComplete += this.onRequestComplete;

            connector.SendPost();
        }

        public void GetAccessToken(string verifier)
        {
            string timestamp = DateHelpers.DateTimeToUnitTimeStamp(DateTime.UtcNow).ToString();

            SimpleConnector connector = new SimpleConnector();
            connector.SetServerName(Constants.Urls.URL_TOKEN_ACCESS);
            connector.AddParam("oauth_token", this.OAuthToken);
            connector.AddParam("oauth_consumer_key", Settings.Key);
            connector.AddParam("oauth_nonce", Settings.Nounce);
            connector.AddParam("oauth_timestamp", timestamp);
            connector.AddParam("oauth_verifier", verifier);
            connector.AddParam("oauth_signature_method", Settings.SignatireMethod);
            connector.AddParam("oauth_signature", this.generateSignature(this.CurrentSignatureType, "POST", Constants.Urls.URL_TOKEN_ACCESS, connector.GetParams(), Settings.SecretKey + "&" + this.OAuthTokenSecret));
            connector.OnRequestComplete += parseAccessToken;
            connector.OnRequestComplete += this.onRequestComplete;
            connector.SendPost();
        }

        private void parseAccessToken(string token)
        {
            Console.WriteLine("asd");
        }

        private void parseResponse(string resp)
        {
            Dictionary<string, string> paramList = StringHelper.ParseQueryString(resp);
            if (paramList.ContainsKey("oauth_token"))
            {
                this.OAuthToken = paramList["oauth_token"];
                this.OAuthTokenSecret = paramList["oauth_token_secret"];
            }
        }

        private string generateSignature(string type, string method, string url, Dictionary<string, string> paramList, string key)
        {
            string result = "";

            if (type == SIGNATURE_METHOD_HMAC)
            {
                result = EncodingHelper.EncodeHMACSHA1(method + "&" + StringHelper.UrlEncode(url) + "&" + StringHelper.UrlEncode(StringHelper.Concate(paramList, true)), key);
            }
            else
            {
                throw new NotImplementedException("Signature method is not implemented");
            }

            return result;
        }
    }
}
