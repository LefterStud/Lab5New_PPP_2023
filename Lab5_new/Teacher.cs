using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Lab5_new
{
    /// <summary>
    /// Teacher class. Contains the properties of the Teacher, 
    /// and also inherits the properties of the SchoolPerson class
    /// </summary>
    public class Teacher : SchoolPerson
    {
        private string _specialization;
        private int _seniority;
        private int _classroomNumber;

        /// <summary>
        /// Creates a new instance of the Teacher class and and inherits the properties of SchoolPerson
        /// </summary>
        /// <param name="age">Age of person.</param>
        /// <param name="weight">Weight of person.</param>
        /// <param name="height">Weight of person.</param>
        /// <param name="gender">Gender of person.</param>
        /// <param name="location">Location of birth.</param>
        /// <param name="name">Name of person.</param>
        /// <param name="phoneNumber">Phone number of person.</param>
        /// <param name="email">Email of person.</param>
        /// <param name="specialization">Specialization of teacher.</param>
        /// <param name="seniority">Seniority of teacher.</param>
        /// <param name="classroomNumber">Which classroom is it in?</param>
        public Teacher(int age, int weight, int height, string gender, string location, string name, 
            string phoneNumber, string email, string specialization, int seniority, int classroomNumber) :
            base(age, weight, height, gender, location, name, phoneNumber, email)
        {
            Name = name;
            Specialization = specialization;
            Seniority = seniority;
            ClassroomNumber = classroomNumber;
        }

        /// <summary>
        /// Setter and getter for the _specialization field.
        /// Teacher's specialization.
        /// </summary>
        public string Specialization
        {
            get => _specialization;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _specialization = value.Trim();
                }
                else
                {
                    Errors.SetErrorCode(12);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _seniority field.
        /// Teacher`s seniority.
        /// </summary>
        public int Seniority
        {
            get => _seniority;
            set
            {
                if (value >= 0)
                {
                    _seniority = value;
                }
                else
                {
                    Errors.SetErrorCode(13);
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _classroomNumber field.
        /// Number of teacher`s classroom.
        /// </summary>
        public int ClassroomNumber
        {
            get => _classroomNumber;
            set
            {
                string classroomStr = value.ToString();
                if (Regex.IsMatch(classroomStr, "^[1-9]\\d{2}$"))
                {
                    _classroomNumber = value;
                }
                else
                {
                    Errors.SetErrorCode(14);
                }
                
            }
        }

        public override string ToString()
        {
            return Errors.ErrorCode > 0 ? Errors.GetError() :
                $"Teacher:\n" +
                $"{base.ToString()}" +
                $"Specialization: {Specialization};\n" +
                $"Seniority: {Seniority};\n" +
                $"ClassroomNumber: {ClassroomNumber};\n";
        }
    }
}
