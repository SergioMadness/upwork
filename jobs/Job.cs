using System;

namespace UpworkWP8.jobs
{
    /// <summary>
    /// Job by key service
    /// </summary>
    public class Job : Service
    {
        #region Fields
        private string key;

        /// <summary>
        /// Job key. For example: `~0150f0d859bb3453d0`.
        /// </summary>
        public string Key
        {
            set
            {
                this.key = value;
            }

            get
            {
                return this.key;
            }
        } 
        #endregion

        public override object execute()
        {
            throw new NotImplementedException();
        }
    }
}
