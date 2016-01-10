using WPDevelopmentLibs.Helpers;

namespace DataLayer.UpWork
{
    public class Settings
    {
        private static string _key;

        private static string _secret;

        private static string _signature_method;

        private static string _nounce;

        public static string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public static string SecretKey
        {
            get { return _secret; }
            set { _secret = value; }
        }

        public static string SignatireMethod
        {
            get
            {
                if (_signature_method == string.Empty || _signature_method == null)
                {
                    _signature_method = Authorization.SIGNATURE_METHOD_HMAC;
                }
                return _signature_method;
            }
            set { _signature_method = value; }
        }

        public static string Nounce
        {
            get
            {
                return ResetNounce();
            }
        }

        public static string ResetNounce()
        {
            _nounce = StringHelper.RandomString(16);
            return _nounce;
        }
    }
}
