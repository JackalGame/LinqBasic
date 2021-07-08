using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        //Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Oxford" });
            universities.Add(new University { Id = 2, Name = "John Moores" });

            students.Add(new Student { Id = 1, Name = "Jack", Gender = "Male", Age = 29, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Fiona", Gender = "Female", Age = 28, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "John", Gender = "Male", Age = 37, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Jamie", Gender = "Trans-Gender", Age = 34, UniversityId = 1 });
            students.Add(new Student { Id = 5, Name = "Mia", Gender = "Female", Age = 26, UniversityId = 1 });
            students.Add(new Student { Id = 6, Name = "Paul", Gender = "Male", Age = 46, UniversityId = 2 });
        }

        public void FilterMaleStudent()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "Male" select student;

            Console.WriteLine("Male Students:-");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FilterFemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "Female" select student;

            Console.WriteLine("Female Students");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by Age:-");

            foreach(Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromOxford()
        {
            IEnumerable<Student> oxStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Name == "Oxford"
                                              select student;

            Console.WriteLine("Students from Oxford:-");

            foreach (Student student in oxStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromSpecificUni(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Id == Id
                                              select student;

            Console.WriteLine($"Students from Uni {Id}:-");

            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection:-");

            foreach(var col in newCollection)
            {
                Console.WriteLine($"Student {col.StudentName} from University {col.UniversityName}");
            }
        }
    }
}
