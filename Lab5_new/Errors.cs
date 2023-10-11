
namespace Lab5_new
{
    public class Errors
    {
        private static int _errorCode = 0;

        /// <summary>
        /// Setter and getter for the error code.
        /// </summary>
        public static int ErrorCode
        {
            get => _errorCode;
            set => _errorCode = value;
        }

        /// <summary>
        /// Sets the value of the _errorCode field.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        public static void SetErrorCode(int errorCode)
        {
            ErrorCode = errorCode;
        }

        static string[] errorsArray = {
            "",
            "Incorrect age of person!",
            "Incorrect weight of person!",
            "Incorrect height of person!",
            "Incorrect gander of person!",
            "Incorrect location!",
            "Incorrect name!",
            "Incorrect phone number!",
            "Incorrect email!",
            "Incorrect number of classroom!",
            "Incorrect average mark!",
            "Incorrect grade!",
            "Incorrect specialization data!",
            "Incorrect seniority data!",
            "Incorrect classroom number!",
            "Incorrect shift data!",
            "Incorrect shift duration!",
            "Incorrect security service data!",
            "Can't delete this element/incorrect index!",
            "Can't edit this element/incorrect index!"
        };

        /// <summary>
        /// Return curent error.
        /// </summary>
        /// <returns>Current error.</returns>
        public static string GetError()
        {
            return errorsArray[ErrorCode];
        }
    }
}
