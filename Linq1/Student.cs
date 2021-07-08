using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student {Name} with ID {Id}, Gender {Gender} and Age {Age} from University with the ID {UniversityId}");
        }
    }
}
