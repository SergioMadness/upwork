
using System;

namespace UpworkWP8.users
{
    /// <summary>
    /// User profile
    /// </summary>
    public class User : Service
    {
        private string id;

        /// <summary>
        /// The reference ID of the user or special value `me` to get information about the currently authenticated user. 
        /// Examples: `me`, `33333`.
        /// </summary>
        public string Id
        {
            set
            {
                this.id = value;
            }

            get
            {
                return this.id;
            }
        }

        public override object execute()
        {
            throw new NotImplementedException();
        }
    }
}
