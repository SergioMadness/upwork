using System;

namespace UpworkWP8.jobs
{
    /// <summary>
    /// Get job list
    /// </summary>
    public class JobList : Service
    {
        #region Fields
        private int buyerTeamId;

        /// <summary>
        /// The reference ID of the client's team. 
        /// Example: `34567`. You can get it from List teams API call.
        /// </summary>
        public int BuyerTeamId
        {
            set
            {
                this.buyerTeamId = value;
            }

            get
            {
                return this.buyerTeamId;
            }
        }

        private bool includeSubTeams;

        /// <summary>
        /// If set to `1`, the response includes information about sub teams.
        /// </summary>
        public bool IncludeSubTeams
        {
            set
            {
                this.includeSubTeams = value;
            }

            get
            {
                return this.includeSubTeams;
            }
        }

        private int createdBy;

        /// <summary>
        /// The user ID. Example: `created_by=1234`.
        /// </summary>
        public int CreatedBy
        {
            set
            {
                this.createdBy = value;
            }

            get
            {
                return this.createdBy;
            }
        }

        private string status;

        /// <summary>
        /// The status of the job.
        /// </summary>
        public string Status
        {
            set
            {
                this.status = value;
            }

            get
            {
                return this.status;
            }
        }

        private DateTime from;

        /// <summary>
        /// Filters by 'from' time. Example: `created_time_from=2008-09-09T00:00:01`.
        /// </summary>
        public DateTime From
        {
            set
            {
                this.from = value;
            }

            get
            {
                return this.from;
            }
        }

        private DateTime to;

        /// <summary>
        /// Filters by 'to' time. Example: `created_time_to=2009-01-20T11:59:59`.
        /// </summary>
        public DateTime To
        {
            set
            {
                this.to = value;
            }

            get
            {
                return this.to;
            }
        }

        private int limit;

        /// <summary>
        /// Pagination, formed as `$offset;$count`. Example: `page=20;10`
        /// </summary>
        public int Limit
        {
            set
            {
                this.limit = value;
            }

            get
            {
                return this.limit;
            }
        }

        private int offset;

        /// <summary>
        /// Pagination, formed as `$offset;$count`. Example: `page=20;10`
        /// </summary>
        public int Offset
        {
            set
            {
                this.offset = value;
            }

            get
            {
                return this.offset;
            }
        }

        /// <summary>
        /// Pagination, formed as `$offset;$count`. Example: `page=20;10`
        /// </summary>
        public string Page
        {
            get
            {
                string result = this.offset.ToString();

                if (this.limit > 0)
                {
                    result += "," + this.limit.ToString();
                }

                return result;
            }
        }

        private string orderBy;

        /// <summary>
        /// Sorts results by the value defined. Example: `order_by=created_time`.
        /// </summary>
        public string OrderBy
        {
            set
            {
                this.orderBy = value;
            }

            get
            {
                return this.orderBy;
            }
        } 
        #endregion

        public override object execute()
        {
            throw new NotImplementedException();
        }
    }
}
