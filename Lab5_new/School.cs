
namespace Lab5_new
{
    public class School
    {
        private SchoolPerson[] _schoolPersons;

        /// <summary>
        /// Return and set value of _schoolComunity.
        /// </summary>
        public SchoolPerson[] SchoolPersons
        {
            get => _schoolPersons;
            set => _schoolPersons = value;
        }

        /// <summary>
        /// Creates an array of the school class that will contain people associated with the school.
        /// </summary>
        public School()
        {
            _schoolPersons = new SchoolPerson[0];
        }

        /// <summary>
        /// Adds an object to the array.
        /// </summary>
        /// <param name="schoolPersons">An instance of the SchoolPerson class or those derived from SchoolPerson</param>
        public void AddPerson(SchoolPerson schoolPersons)
        {
            Array.Resize(ref _schoolPersons, SchoolPersons.Length + 1);
            SchoolPersons[SchoolPersons.Length - 1] = schoolPersons;
        }

        /// <summary>
        /// Delete an object from the array.
        /// </summary>
        /// <param name="index">The index of the element to be deleteed</param>
        public void DeletePerson(int index)
        {
            if (index >= 0 && index < SchoolPersons.Length)
            {
                Array.Copy(SchoolPersons, index + 1, SchoolPersons, index, SchoolPersons.Length - index - 1);
                Array.Resize(ref _schoolPersons, SchoolPersons.Length - 1);
            }
            else
            {
                Errors.SetErrorCode(18);
            }
        }


        /// <summary>
        /// Edit element of array
        /// </summary>
        /// <param name="index">Index of element to edit</param>
        /// <param name="newPerson">New value</param>
        public void EditSchoolPerson(int index, SchoolPerson newPerson)
        {
            if (index >= 0 && index < SchoolPersons.Length)
            {
                SchoolPersons[index] = newPerson;
            }
            else
            {
                Errors.SetErrorCode(19);
            }
        }
    }
}
