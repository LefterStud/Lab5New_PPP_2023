namespace Lab5_new
{
    /// <summary>
    /// The BasePersonInfo class contains general information about the school person
    /// </summary>
    internal class BasePersonInfo
    {
        private int _age;
        private int _weight;
        private int _height;
        private string _gender;
        private string _location;
        const int MAX_AGE = 120;
        const int MIN_AGE = 7;
        const int MIN_WEIGHT = 25;
        const int MIN_HEIGHT = 90;
        const int MAX_HEIGHT = 220;
        readonly string[] GENDER = { "male", "female" };

        /// <summary>
        /// Creates a new instance of the BasePersonInfo class with the given values.
        /// </summary>
        /// <param name="age">Age of person.</param>
        /// <param name="weight">Weight of person.</param>
        /// <param name="height">Weight of person.</param>
        /// <param name="gender">Gender of person.</param>
        /// <param name="location">Location of birth.</param>
        public BasePersonInfo(int age, int weight, int height, string gender, string location)
        {
            Age = age;
            Weight = weight;
            Height = height;
            Gender = gender;
            Location = location;
        }

        /// <summary>
        /// Setter and getter for the _age field.
        /// Age of person.
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                if (value >= MIN_AGE && value <= MAX_AGE)
                {
                    _age = value;
                }
                else
                {
                    Errors.SetErrorCode(1);
                }
            }

        }

        /// <summary>
        /// Setter and getter for the _weight field.
        /// Weight of person.
        /// </summary>
        public int Weight
        {
            get => _weight;
            set
            {
                if (value >= MIN_WEIGHT)
                {
                    _weight = value;
                }
                else
                {
                    Errors.SetErrorCode(2);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _height field.
        /// Height of person.
        /// </summary>
        public int Height
        {
            get => _height;
            set
            {
                if (value >= MIN_HEIGHT && value <= MAX_HEIGHT)
                {
                    _height = value;
                }
                else
                {
                    Errors.SetErrorCode(3);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _gender field.
        /// Gender of person(Male or Female).
        /// </summary>
        public string Gender
        {
            get => _gender;
            set
            {
                if (value.ToLower() == GENDER[0] || value.ToLower() == GENDER[1])
                {
                    _gender = char.ToUpper(value[0]) + value.Substring(1).ToLower().Trim();
                }
                else
                {
                    Errors.SetErrorCode(4);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _country field.
        /// Country of birth.
        /// </summary>
        public string Location
        {
            get => _location;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _location = char.ToUpper(value[0]) + value.Substring(1).ToLower().Trim();
                }

                else
                {
                    Errors.SetErrorCode(5);
                }
            }
        }


    }
}
