using System.Diagnostics;

namespace Lab5_new
{
    /// <summary>
    /// Guard class. Contains the properties of the guard, 
    /// and also imitates the properties of the SchoolPerson class
    /// </summary>
    internal class Guard : SchoolPerson
    {
        private string _shift;
        private int _shiftDuration;
        private string _securityService;
        private const int MIN_DURATION = 1;
        private const int MAX_DURATION = 12;
        readonly string[] SHIFT = { "day", "night" };

        /// <summary>
        /// Creates a new instance of the Guard class and and inherits the properties of SchoolPerson
        /// </summary>
        /// <param name="age">Age of person.</param>
        /// <param name="weight">Weight of person.</param>
        /// <param name="height">Weight of person.</param>
        /// <param name="gender">Gender of person.</param>
        /// <param name="location">Location of birth.</param>
        /// <param name="name">Name of person.</param>
        /// <param name="phoneNumber">Phone number of person.</param>
        /// <param name="email">Email of person.</param>
        /// <param name="shift">Shift of guard.</param>
        /// <param name="shiftDuration">Shift duration.</param>
        /// <param name="securityService">Security service.</param>
        public Guard(int age, int weight, int height, string gender, string location, string name,
            string phoneNumber, string email, string shift, int shiftDuration, string securityService) :
            base(age, weight, height, gender, location, name, phoneNumber, email)
        {
            Shift = shift;
            ShiftDuration = shiftDuration;
            SecurityService = securityService; ;
        }

        /// <summary>
        /// Setter and getter for the _shift field.
        /// Guard`s shift.
        /// </summary>
        public string Shift
        {
            get => _shift;
            set
            {
                if ((value.ToLower() == SHIFT[0] || value.ToLower() == SHIFT[1]))
                {
                    _shift = value;
                }
                else
                {
                    Errors.SetErrorCode(15);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _shiftDuration field.
        /// Guard`s shift duration.
        /// </summary>
        public int ShiftDuration
        {
            get => _shiftDuration;
            set
            {
                if (value >= MIN_DURATION && value <= MAX_DURATION)
                {
                    _shiftDuration = value;
                }
                else
                {
                    Errors.SetErrorCode(16);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _securityService field.
        /// Guard`s security service.
        /// </summary>
        public string SecurityService
        {
            get { return _securityService; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _securityService = value;
                }
                else
                {
                    Errors.SetErrorCode(17);
                }
            }
        }

        public override string ToString()
        {
            return Errors.ErrorCode > 0 ? Errors.GetError() :
                $"Guard:\n" +
                $"{base.ToString()}" +
                $"Shift: {Shift};\n" +
                $"ShiftDuration: {ShiftDuration};\n" +
                $"SecurityService: {SecurityService};\n";
        }
    }
}
