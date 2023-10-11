namespace Lab5_new
{
    /// <summary>
    /// Student class. Contains the properties of the Student, 
    /// and also imitates the properties of the SchoolPerson class
    /// </summary>
    public class Student : SchoolPerson
    {
        private double _averageMark;
        private int _grade;
        private int _numberOfSubjects;
        private const double MAX_MARK = 12;
        private const int MIN_CLASS = 1;
        private const int MAX_CLASS = 12;
        private const int MAX_SUBJECTS = 30;

        /// <summary>
        /// Creates a new instance of the Student class and and inherits the properties of SchoolPerson
        /// </summary>
        /// <param name="age">Age of person.</param>
        /// <param name="weight">Weight of person.</param>
        /// <param name="height">Weight of person.</param>
        /// <param name="gender">Gender of person.</param>
        /// <param name="location">Location of birth.</param>
        /// <param name="name">Name of person.</param>
        /// <param name="phoneNumber">Phone number of person.</param>
        /// <param name="email">Email of person.</param>
        /// <param name="averageMark">Average mark.</param>
        /// <param name="grade">Grade of student.</param>
        /// <param name="numberOfSubjects">Number of subjects.</param>
        public Student(int age, int weight, int height, string gender, string location, string name, 
            string phoneNumber, string email, double averageMark, int grade, int numberOfSubjects) : 
            base(age, weight, height, gender, location, name, phoneNumber, email)
        {
            AverageMark = averageMark;
            Grade = grade;
            NumberOfSubjects = numberOfSubjects;
            AverageMark = averageMark;
            Grade = grade;
            NumberOfSubjects = numberOfSubjects;
        }

        /// <summary>
        /// Setter and getter for the _averageMark field.
        /// Student`s average mark.
        /// </summary>
        public double AverageMark
        {
            get => _averageMark;
            set
            {
                if (value > 0 && value <= MAX_MARK)
                {
                    _averageMark = value;
                }
                else
                {
                    Errors.SetErrorCode(9);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _grade field.
        /// Student`s grade. 
        /// </summary>
        public int Grade
        {
            get => _grade;
            set
            {
                if (value >= MIN_CLASS && value <= MAX_CLASS)
                {
                    _grade = value;
                }
                else
                {
                    Errors.SetErrorCode(10);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _numberOfSubjects field.
        /// Student`s number of subjects. 
        /// </summary>
        public int NumberOfSubjects
        {
            get => _numberOfSubjects;
            set
            {
                if (value > 0 && value <= MAX_SUBJECTS)
                {
                    _numberOfSubjects = value;
                }
                else
                {
                    Errors.SetErrorCode(11);
                }
            }
        }

        public override string ToString()
        {
            return Errors.ErrorCode > 0 ? Errors.GetError() :
                $"Student:\n" +
                $"{base.ToString()}" +
                $"Average mark: {AverageMark};\n" +
                $"Grade: {Grade};\n" +
                $"Number of Subjects: {NumberOfSubjects};\n";
        }
    }
}
