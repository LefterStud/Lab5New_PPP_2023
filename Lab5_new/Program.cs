using System;

namespace Lab5_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Певні константи для випадкової генерації значень.
            const double MIN_MARK = 0.0;
            const double MAX_MARK = 12.0;
            const int MIN_AGE = 10;
            const int MAX_AGE = 90;
            const int MIN_WEIGHT = 40;
            const int MAX_WEIGHT = 100;
            const int MIN_HEIGHT = 100;
            const int MAX_HEIGHT = 200;
            const int MIN_CLASS = 1;
            const int MAX_CLASS = 12;
            const int MAX_SUBJECTS = 30;
            string[] GENDER = { "Male", "Female" };
            string[] CITY = { "Lviv", "Kharkiv", "Kyiv", "Odesa" };
            string[] NAMES = {
                 "Alice",
                 "Bob",
                 "Charlie",
                 "David",
                 "Emma",
                 "Frank",
                 "Grace",
                 "Henry",
                 "Isabel",
                 "Jack"
            };
            const int MIN_DURATION = 1;
            const int MAX_DURATION = 12;
            string[] SHIFT = { "day", "night" };
            Random r = new Random();
            Student student1 = new Student(r.Next(MIN_AGE, MAX_AGE), r.Next(MIN_WEIGHT, MAX_WEIGHT), r.Next(MIN_HEIGHT, MAX_HEIGHT), GENDER[r.Next(GENDER.Length)], CITY[r.Next(CITY.Length)], NAMES[r.Next(NAMES.Length)], "+380111111111", "test1@gmail1.com", r.NextDouble() * (MAX_MARK - MIN_MARK) + MIN_MARK, r.Next(MIN_CLASS, MAX_CLASS), r.Next(MAX_SUBJECTS));
            Student student2 = new Student(r.Next(MIN_AGE, MAX_AGE), r.Next(MIN_WEIGHT, MAX_WEIGHT), r.Next(MIN_HEIGHT, MAX_HEIGHT), GENDER[r.Next(GENDER.Length)], CITY[r.Next(CITY.Length)], NAMES[r.Next(NAMES.Length)], "+380222222222", "test1@gmail1.com", r.NextDouble() * (MAX_MARK - MIN_MARK) + MIN_MARK, r.Next(MIN_CLASS, MAX_CLASS), r.Next(MAX_SUBJECTS));
            Teacher teacher = new Teacher(r.Next(MIN_AGE, MAX_AGE), r.Next(MIN_WEIGHT, MAX_WEIGHT), r.Next(MIN_HEIGHT, MAX_HEIGHT), GENDER[r.Next(GENDER.Length)], CITY[r.Next(CITY.Length)], NAMES[r.Next(NAMES.Length)], "+380222222222", "test1@gmail1.com", "Math", r.Next(50), 344);
            Guard guard = new Guard(r.Next(MIN_AGE, MAX_AGE), r.Next(MIN_WEIGHT, MAX_WEIGHT), r.Next(MIN_HEIGHT, MAX_HEIGHT), GENDER[r.Next(GENDER.Length)], CITY[r.Next(CITY.Length)], NAMES[r.Next(NAMES.Length)], "+380222222222", "test1@gmail1.com", SHIFT[r.Next(SHIFT.Length)], r.Next(MIN_DURATION, MAX_DURATION), "SeqServ");

            School schoolPersons = new School();
            schoolPersons.AddPerson(student1);
            schoolPersons.AddPerson(student2);
            schoolPersons.AddPerson(teacher);
            schoolPersons.AddPerson(guard);
            foreach (var person in schoolPersons.SchoolPersons)
            {
                Console.WriteLine("--------------------------------------------\n" + person);
            }
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine("Delete element #2");
            Console.WriteLine("////////////////////////////////////////////////////////////");
            schoolPersons.DeletePerson(1);
            foreach (var person in schoolPersons.SchoolPersons)
            {
                Console.WriteLine("--------------------------------------------\n" + person);
            }
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine("Edit element 1");
            Console.WriteLine("////////////////////////////////////////////////////////////");

            Student example = new Student(10, 30, 100, "Male", "Zhmerinka", "Oleg", "+000000000000", "ecample@example.com", 0.1, 1, 1);
            schoolPersons.EditSchoolPerson(0, example);
            foreach (var person in schoolPersons.SchoolPersons)
            {
                Console.WriteLine("--------------------------------------------\n" + person);
            }

        }
    }
}