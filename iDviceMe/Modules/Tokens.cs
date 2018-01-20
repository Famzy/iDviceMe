using System;
namespace iDviceMe.Modules
{
    public class Tokens
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_discription { get; set; }
        public DateTime expire_date { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:iDviceMe.Modules.Tokens"/> class.
        /// </summary>
        public Tokens()
        {
        }
    }
}
