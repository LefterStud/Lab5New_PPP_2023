using System.Text.RegularExpressions;
namespace Lab5_new
{
    /// <summary>
    /// Basic class-aggregate, which consists of general information about the school.
    /// Also contains a collection of people related to the school.
    /// </summary>
    public class SchoolPerson
    {
        private BasePersonInfo _basePersonInfo;
        private string _name;
        private string _phoneNumber;
        private string _email;

        /// <summary>
        /// Creates a new instance of the SchoolPerson class that aggregates an instance of the BasePersonInfo class
        /// </summary>
        /// <param name="age">Age of person.</param>
        /// <param name="weight">Weight of person.</param>
        /// <param name="height">Weight of person.</param>
        /// <param name="gender">Gender of person.</param>
        /// <param name="location">Location of birth.</param>
        /// <param name="name">Name of person.</param>
        /// <param name="phoneNumber">Phone number of person.</param>
        /// <param name="email">Email of person.</param>
        public SchoolPerson(int age, int weight, int height, string gender, string location, string name, string phoneNumber, string email)
        {
            BasePersonInfo = new BasePersonInfo(age, weight, height, gender, location);
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Setter and getter for the _name field.
        /// Person`s name.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrEmpty(value) && Regex.IsMatch(value, @"^[A-Za-z ]+$"))
                {
                    _name = value.Trim();
                }
                else
                {
                    Errors.SetErrorCode(6);
                }
                
            }
        }

        /// <summary>
        /// Setter and getter for the _phoneNumber field.
        /// Phone number in the format +ХХХХХХХХХХХХ.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if ((!string.IsNullOrEmpty(value)) && (Regex.IsMatch(value, @"^\+\d{12}$")))
                {
                    _phoneNumber = value.Trim();
                }
                else
                {
                    Errors.SetErrorCode(7);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _email field.
        /// Email in the format example@examp.le
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    _email = value.Trim();
                }
                else
                {
                    Errors.SetErrorCode(8);
                }
            }
        }

        internal BasePersonInfo BasePersonInfo { get => _basePersonInfo; set => _basePersonInfo = value; }

        public override string ToString()
        {
            return Errors.ErrorCode > 0 ? Errors.GetError() : 
                $"Name: {Name};\n" +
                $"Age: {BasePersonInfo.Age};\n" +
                $"Height: {BasePersonInfo.Height};\n" +
                $"Weight: {BasePersonInfo.Weight};\n" +
                $"Gender: {BasePersonInfo.Gender};\n" +
                $"Location: {BasePersonInfo.Location};\n" +
                $"Phone number: {PhoneNumber};\n" +
                $"Email: {Email};\n";
        }
    }
}
