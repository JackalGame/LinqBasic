using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.FilterMaleStudent();
            Console.WriteLine("********************************");
            um.FilterFemaleStudents();
            Console.WriteLine("********************************");
            um.SortStudentsByAge();
            Console.WriteLine("********************************");
            um.AllStudentsFromOxford();
            Console.WriteLine("**********************************");


            // Sorting in ascending or descending
            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach(int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            foreach(int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**********************************");
            um.StudentAndUniversityNameCollection();

            /*
            Console.WriteLine("Please enter Uni Id.");
            UserSelectUni(um);
            */

            Console.ReadKey();
        }

        private static void UserSelectUni(UniversityManager um)
        {
            string input = Console.ReadLine();
            try
            {
                int inputAsInt = Convert.ToInt32(input);
                um.AllStudentsFromSpecificUni(inputAsInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong value. Please type a number between 1 & 2.");
                UserSelectUni(um);
            }
        }
    }
}
