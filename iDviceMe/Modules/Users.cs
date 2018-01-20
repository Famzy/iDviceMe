using System;
namespace iDviceMe.Modules
{
    public class Users

    {
        /// <summary>
        /// Gets or sets the identifier.
        /// This Method conteols the user signing page where the method 
        /// validates that the fileds are not left empty
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
       
        public Users()
        {
        }
       /// <summary>
       /// Initializes a new instance of the <see cref="T:iDviceMe.Modules.Users"/> class.
       /// </summary>
       /// <param name="Username">Username.</param>
       /// <param name="Password">Password.</param>
        public Users(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        /// <summary>
        /// Checks the information. provided by the user to ensure that it is not
        /// blank
        /// </summary>
        /// <returns><c>true</c>, if information was checked, <c>false</c> otherwise.</returns>
        public bool CheckInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }

        ///End of the User Input Section
        /// 
        /// 
        /// 

        ///This Section Handles The User Inputs
        public string FirstName { get; set; }  
        public string MiddleName { get; set; }  
        public string  LastName { get; set; }  
        public DateTime DateTime { get; set; }  

  /// <summary>
  /// Initializes a new instance of the <see cref="T:iDviceMe.Modules.Users"/> class.
  /// </summary>
  /// <param name="firstName">First name.</param>
  /// <param name="middleName">Middle name.</param>
  /// <param name="lastName">Last name.</param>
  /// <param name="dateTime">Date time.</param>
        public Users(string firstName, string middleName, string lastName, DateTime dateTime)  
        {  
            this.FirstName = firstName;  
            this.MiddleName = middleName;  
            this.LastName = lastName;  
            this.DateTime = dateTime;  
        }  
    }
}
