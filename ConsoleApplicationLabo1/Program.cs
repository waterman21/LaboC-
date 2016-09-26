using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new Pupil("loic",7);
            Pupil pupil2 = new Pupil("Nico", 6);
            Activity act1 = new Activity("geometrie",true);
            Activity act2 = new Activity("math", true);
            Activity act3 = new Activity("neerlandais", false);
            pupil1.AddActivity(act1);
            pupil1.AddActivity(act2);
            pupil1.AddActivity(act3);

            //System.Console.Write(pupil1.ToString());
            // System.Console.Write(pupil2.ToString());

            List<Pupil> lstPupil = new List<Pupil>()
            {
                new Pupil("Pupil1",6,1),
                new Pupil("Pupil2",7,2),
                new Pupil("Pupil3",7),
                new Pupil("Pupil4",8,2),

            };

            List<Pupil> listPupils = new List<Pupil>()
            {
                new Pupil("michmich",10,3),
                new Pupil("Floflo",9,2),
                new Pupil("ChriChri",7,1),
                new Pupil("Harry",8,2),
                new Pupil("Nico",7,2),

            };

            List<Person> listPersons = new List<Person>()
            {
                new Person("Loic",10),
                new Person("kazzy",4),
                new Person("Ismi",9),



            };

            var listFusion = listPersons.Union(listPupils);

            if (listFusion != null)
            {
                foreach (var fusion in listFusion)
                    System.Console.Write(fusion.ToString());
            }

            /*var pupilGrade1Plus6 = from pupil in lstPupil
                                   where pupil.Age > 6 && pupil.Grade == 1
                                   select pupil;
            */

            var pupilGrade1Plus6 = lstPupil.Where(pupil => pupil.Age > 6 && pupil.Grade == 1);

            if (pupilGrade1Plus6 != null)
            {
                foreach (var pupil in pupilGrade1Plus6)
                    System.Console.Write(pupil.ToString());
            }

           
            List<Pupil> lstPupilsDuplicated = new List<Pupil>()
            {
                new Pupil("Louis",6,6),
                new Pupil("Jean claude",20,6),
                new Pupil("Jean claude",20,6),
                new Pupil("Michelito",8,5),
                new Pupil("Jean claude",20,6),
                new Pupil("Michelito",8,5),
                new Pupil("Jean-pierre",8,4),
                new Pupil("Louis",6,6),
                new Pupil("Louis",6,6),
            };

            IEnumerable<Pupil> listPupilsNoDuplicated = lstPupilsDuplicated.Distinct<Pupil>(new PersonComparer());

            Console.WriteLine(listPupilsNoDuplicated.Count());
           
            System.Console.Read();
        }
    }
}
