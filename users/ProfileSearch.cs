
namespace UpworkWP8.users
{
    public class ProfileSearch
    {
        #region Fields
        private string query;

        /// <summary>
        /// The search query. At least one of the `q`, `title`, `skill` parameters should be specified.
        /// </summary>
        public string Query
        {
            set
            {
                this.query = value;
            }

            get
            {
                return this.query;
            }
        }

        private string title;

        /// <summary>
        /// Searches for the title in the freelancer's profile. 
        /// At least one of the `q`, `title`, `skill` parameters should be specified.
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

        private string skills;

        /// <summary>
        /// Searches for skills of freelancer's profile. 
        /// At least one of the `q`, `title`, `skill` parameters should be specified.
        /// </summary>
        public string Skills
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

        private string groups;

        /// <summary>
        /// Searches for groups in the freelancer's profile. The freelancer must be a member of the group provided.
        /// </summary>
        public string Groups
        {
            set
            {
                this.groups = value;
            }

            get
            {
                return this.groups;
            }
        }

        private string tests;

        /// <summary>
        /// Searches for tests in the freelancer's profile.
        /// </summary>
        public string Tests
        {
            set
            {
                this.tests = value;
            }

            get
            {
                return this.tests;
            }
        }

        private string testsTop10;

        /// <summary>
        /// Searches for freelancers that are in the top 10 of the test.
        /// </summary>
        public string TestsTop10
        {
            set
            {
                this.testsTop10 = value;
            }

            get
            {
                return this.testsTop10;
            }
        }

        private string testsTop30;

        /// <summary>
        /// Searches for freelancers that are in the top 30 of the test.
        /// </summary>
        public string TestsTop30
        {
            set
            {
                this.testsTop30 = value;
            }

            get
            {
                return this.testsTop30;
            }
        }

        private string category;

        /// <summary>
        /// The category (V2) of the freelancer's profile. Use Metadata resource to get it. You can get it via Metadata Category (v2) resource.
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

        private string region;

        /// <summary>
        /// Searches for profiles of freelancers who live in the region provided. 
        /// Valid values are provided by Metadata Regions resource. 
        /// Example: `Latin America`.
        /// </summary>
        public string Region
        {
            set
            {
                this.region = value;
            }

            get
            {
                return this.region;
            }
        }

        private int feedbackMin;

        /// <summary>
        /// Searches for freelancers with specific feedback score. 
        /// Single values such as `3` or `3,4` (comma-separated values results in OR queries) and ranges such as `[3 TO 4]` are valid.
        /// </summary>
        public int FeedbackMin
        {
            set
            {
                this.feedbackMin = value;
            }

            get
            {
                return this.feedbackMin;
            }
        }

        private int feedbackMax;

        /// <summary>
        /// Searches for freelancers with specific feedback score. 
        /// Single values such as `3` or `3,4` (comma-separated values results in OR queries) and ranges such as `[3 TO 4]` are valid.
        /// </summary>
        public int FeedbackMax
        {
            set
            {
                this.feedbackMax = value;
            }

            get
            {
                return this.feedbackMax;
            }
        }

        /// <summary>
        /// Searches for freelancers with specific feedback score. 
        /// Single values such as `3` or `3,4` (comma-separated values results in OR queries) and ranges such as `[3 TO 4]` are valid.
        /// </summary>
        public string ClientFeedback
        {
            get
            {
                string result = "";

                if (this.feedbackMin < this.feedbackMax)
                {
                    result = this.feedbackMin.ToString() + "-" + this.feedbackMax.ToString();
                }
                if (this.feedbackMin == this.feedbackMax && this.feedbackMax > 0)
                {
                    result = this.feedbackMin.ToString();
                }

                return result;
            }
        }

        private string jobType;

        /// <summary>
        /// The type of the Job.
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

        private string duration;

        /// <summary>
        /// The duration of the job.
        /// </summary>
        public string Duration
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

        private string workload;

        /// <summary>
        /// Indicates the workload for the job.
        /// </summary>
        public string Workload
        {
            set
            {
                this.workload = value;
            }

            get
            {
                return this.workload;
            }
        }

        private int clientHiresMin;

        /// <summary>
        /// A number or range used to filter the search by clients with a number of past hires equal to, more or less than, or within the values provided. 
        /// Single parameters such as `1` or `2,3` are valid (comma-separated values result in `OR` queries). Ranges such as `[10 TO 20]` are also valid. 
        /// Examples: `5` - the number of past hires is to 5; `0-10`: number of past hires is 0 <= n <= 10; `10-` - the number of past hires is >=10; `-5` - the number of past hires is <= 5.
        /// </summary>
        public int ClientHiresMin
        {
            set
            {
                this.clientHiresMin = value;
            }

            get
            {
                return this.clientHiresMin;
            }
        }

        private int clientHiresMax;

        /// <summary>
        /// A number or range used to filter the search by clients with a number of past hires equal to, more or less than, or within the values provided. 
        /// Single parameters such as `1` or `2,3` are valid (comma-separated values result in `OR` queries). Ranges such as `[10 TO 20]` are also valid. 
        /// Examples: `5` - the number of past hires is to 5; `0-10`: number of past hires is 0 <= n <= 10; `10-` - the number of past hires is >=10; `-5` - the number of past hires is <= 5.
        /// </summary>
        public int ClientHiresMax
        {
            set
            {
                this.clientHiresMax = value;
            }

            get
            {
                return this.clientHiresMax;
            }
        }

        /// <summary>
        /// A number or range used to filter the search by clients with a number of past hires equal to, more or less than, or within the values provided. 
        /// Single parameters such as `1` or `2,3` are valid (comma-separated values result in `OR` queries). Ranges such as `[10 TO 20]` are also valid. 
        /// Examples: `5` - the number of past hires is to 5; `0-10`: number of past hires is 0 <= n <= 10; `10-` - the number of past hires is >=10; `-5` - the number of past hires is <= 5.
        /// </summary>
        public string ClientHires
        {
            get
            {
                string result = "";

                if (this.clientHiresMin < this.clientHiresMax)
                {
                    result = this.clientHiresMin.ToString() + "-" + this.clientHiresMax.ToString();
                }
                if (this.clientHiresMin == this.clientHiresMax && this.clientHiresMax > 0)
                {
                    result = this.clientHiresMin.ToString();
                }

                return result;
            }
        }

        private double budgetMin;

        /// <summary>
        /// A number or range used to filter the search by jobs having a budget equal to, more or less than, or within the values provided. 
        /// For example: `[100 TO 1000]` - the budget is between 100 and 1000; `1000` - the budget is equal to 1000. `500-1000` - the budget `b` is 500 <= b <= 1000, `1000-` - the budget is >=1000; `-200` - the budget is <= 200.
        /// </summary>
        public double BudgetMin
        {
            set
            {
                this.budgetMin = value;
            }

            get
            {
                return this.budgetMin;
            }
        }

        private double budgetMax;

        /// <summary>
        /// A number or range used to filter the search by jobs having a budget equal to, more or less than, or within the values provided. 
        /// For example: `[100 TO 1000]` - the budget is between 100 and 1000; `1000` - the budget is equal to 1000. `500-1000` - the budget `b` is 500 <= b <= 1000, `1000-` - the budget is >=1000; `-200` - the budget is <= 200.
        /// </summary>
        public double BudgetMax
        {
            set
            {
                this.budgetMax = value;
            }

            get
            {
                return this.budgetMax;
            }
        }

        /// <summary>
        /// A number or range used to filter the search by jobs having a budget equal to, more or less than, or within the values provided. 
        /// For example: `[100 TO 1000]` - the budget is between 100 and 1000; `1000` - the budget is equal to 1000. `500-1000` - the budget `b` is 500 <= b <= 1000, `1000-` - the budget is >=1000; `-200` - the budget is <= 200.
        /// </summary>
        public string Budget
        {
            get
            {
                string result = "";

                if (this.budgetMin < this.budgetMax)
                {
                    result = this.budgetMin.ToString() + "-" + this.budgetMax.ToString();
                }
                if (this.budgetMin == this.budgetMax && this.budgetMax > 0)
                {
                    result = this.budgetMin.ToString();
                }

                return result;
            }
        }

        private string jobStatus;

        /// <summary>
        /// The current status of the Job.
        /// </summary>
        public string JobStatus
        {
            set
            {
                this.jobStatus = value;
            }

            get
            {
                return this.jobStatus;
            }
        }

        private int daysPosted;

        /// <summary>
        /// Number of days since the job was posted.
        /// </summary>
        public int DaysPosted
        {
            set
            {
                this.daysPosted = value;
            }

            get
            {
                return this.daysPosted;
            }
        }

        private int pageCnt;

        /// <summary>
        /// Pagination, formed as `$offset;$count`. Page size is restricted to be <= 100. Example: page=20;10.
        /// </summary>
        public int PageCnt
        {
            set
            {
                this.pageCnt = value;
            }

            get
            {
                return this.pageCnt;
            }
        }

        private string sort;

        /// <summary>
        /// Sorts the search results by the value provided. Example: `sort=create_time%20desc`.
        /// </summary>
        public string Sort
        {
            set
            {
                this.sort = value;
            }

            get
            {
                return this.sort;
            }
        }
        #endregion
    }
}
