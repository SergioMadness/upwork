
using System;
using DataLayer.UpWork;

namespace UpworkWP8.jobs
{
    /// <summary>
    /// Post job
    /// </summary>
    public class PostJob : Service
    {

        #region Fields
        private int buyerTeamId;

        /// <summary>
        /// The reference ID of the client's team that is posting the job. Example: `34567`. 
        /// You can get it from List teams API call.
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

        private string title;

        /// <summary>
        /// The title of the job.
        /// </summary>
        public string Title
        {
            set
            {
                this.title = value;
            }

            get
            {
                return this.title;
            }
        }

        private string jobType;

        /// <summary>
        /// The job type.
        /// </summary>
        public string JobType
        {
            set
            {
                this.jobType = value;
            }

            get
            {
                return this.jobType;
            }
        }

        private string description;

        /// <summary>
        /// The description of the job.
        /// </summary>
        public string Description
        {
            set
            {
                this.description = value;
            }

            get
            {
                return this.description;
            }
        }

        private string visibility;

        /// <summary>
        /// The visibility of the job. 
        /// Values description: 
        /// `public` - the job is available to all users who search for jobs; 
        /// `private` - the job is visible to the employer only; 
        /// `odesk` - the job appears in search results only for Upwork users who are logged in; 
        /// `invite-only` - jobs do not appear in search and are used for jobs where the client wants to control the potential applicants.
        /// </summary>
        public string Visibility
        {
            set
            {
                this.visibility = value;
            }

            get
            {
                return this.visibility;
            }
        }

        private string category;

        /// <summary>
        /// The category of the job according to the list of Categories 2.0. 
        /// It is required if `subcategory2` is used. 
        /// Example: `Web Development`. 
        /// You can get it via Metadata Category (V2) resource.
        /// </summary>
        public string Category
        {
            set
            {
                this.category = value;
            }

            get
            {
                return this.category;
            }
        }

        private string subCategory;

        /// <summary>
        /// The subcategory of the job according to the list of Categories 2.0. 
        /// It is required if `category` and `subcategory` parameters are missed. 
        /// Example: `Web & Mobile Development`. 
        /// You can get it via Metadata Category (v2) resource.
        /// </summary>
        public string SubCategory
        {
            set
            {
                this.subCategory = value;
            }

            get
            {
                return this.subCategory;
            }
        }

        private DateTime startDate;

        /// <summary>
        /// The start date of the job. If the `start_date` is not included, the job defaults to starting immediately. 
        /// Example: `06-15-2011`.
        /// </summary>
        public DateTime StartDate
        {
            set
            {
                this.startDate = value;
            }

            get
            {
                return this.startDate;
            }
        }

        private float budget;

        /// <summary>
        /// The budget for a fixed-price job. 
        /// Example: `100`.
        /// </summary>
        public float Budget
        {
            set
            {
                this.budget = value;
            }

            get
            {
                return this.budget;
            }
        }

        private int duration;

        /// <summary>
        /// The duration of the job in hours. Used for hourly-jobs. 
        /// Example: `90`.
        /// </summary>
        public int Duration
        {
            set
            {
                this.duration = value;
            }

            get
            {
                return this.duration;
            }
        }

        private int skills;

        /// <summary>
        /// The skills required for the job. Use semi-colon ';' to separate the skills.
        /// </summary>
        public int Skills
        {
            set
            {
                this.skills = value;
            }

            get
            {
                return this.skills;
            }
        }

        private int test;

        /// <summary>
        /// Reference of the required test.
        /// </summary>
        public int Test
        {
            set
            {
                this.test = value;
            }

            get
            {
                return this.test;
            }
        }

        private string contractorType;

        /// <summary>
        /// The preferred type of freelancer.
        /// </summary>
        public string ContractorType
        {
            set
            {
                this.contractorType = value;
            }

            get
            {
                return this.contractorType;
            }
        }
        #endregion

        public override object execute()
        {
            throw new NotImplementedException();
        }
    }
}
}
