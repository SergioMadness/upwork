
using System;

namespace UpworkWP8.jobs
{
    /// <summary>
    /// Invite freelancer
    /// </summary>
    public class InviteFreelancer : Job
    {
        #region Fields

        private string profileKey;

        /// <summary>
        /// The unique freelancer's key. 
        /// Example: `~~677961dcd7f65c01`. 
        /// Either `profile_key` or `provider__reference` parameter should be specified.
        /// </summary>
        public string ProfileKey
        {
            set
            {
                this.profileKey = value;
            }

            get
            {
                return this.profileKey
            }
        }

        private int providerId;

        /// <summary>
        /// The freelancer's reference ID.
        /// Example: `12345`. 
        /// It is used if the `profile_key` param is absent.
        /// </summary>
        public int ProviderId
        {
            set
            {
                this.providerId = value;
            }

            get
            {
                return this.providerId;
            }
        }

        private string coverLetter;

        /// <summary>
        /// The text of the cover letter.
        /// </summary>
        public string Cover
        {
            set
            {
                this.coverLetter = value;
            }

            get
            {
                return this.coverLetter;
            }
        }

        #endregion

        public override object execute()
        {
            throw new NotImplementedException();
        }
    }
}
