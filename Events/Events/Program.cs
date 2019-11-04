using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //public delegate void EventHandler(string name, int cash);
    class Program
    {

        static void Main(string[] args)
        {
            List<University> students = new List<University>();
            //Students students = new Students();
            students.Add(new University(1, "Jonas", 36, 4.5, true));
            students.Add(new University(2, "Kazys", 54, 3.3, false));
            students.Add(new University(3, "Jurgis", 43, 2.4, false));
            students.Add(new University(4, "Albinas", 56, 5.0, true));
            students.Add(new University(5, "Darius", 19, 4.9, true));
            students.Add(new University(6, "Juozapas", 24, 2.8, false));
            students.Add(new University(7, "Antanina", 38, 4.6, true));

            var byAvgMark = (students.OrderBy(s => s.avarageMark)).ToList();
            byAvgMark.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();

            var byAge = (students.OrderByDescending(s => s.age)).ToList();
            byAge.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();

            var byAgeAndAvgMark = (students.OrderBy(s => s.age).ThenByDescending(s => s.avarageMark)).ToList();
            byAgeAndAvgMark.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();



            


            /*university.ForEach(Console.WriteLine);

            List<Students> canDrink = university.FindAll(student => student.age > 32 );

            canDrink.ForEach(student => Console.WriteLine(student.name + " " + student.age));

            university.FindAll(s => s.avarageMark > 3).ForEach(s => Console.WriteLine(s.name));

            university.FindAll(stud => stud.avarageMark < 4 && stud.name.Length <=6)
                .ForEach(s => Console.WriteLine(s.name));*/

            /*var canDrink = (from s in students
                           where s.age > 20
                           select s).ToList();
            

            //canDrink.ToList();
            
            foreach(University i in canDrink)
            {
                Console.WriteLine(i);
            }

            var gettingTuition = from s in students
                                 where s.avarageMark > 4 && s.isGettingTuition == true
                                 select s.name;

            foreach(string i in gettingTuition)
            {
                Console.WriteLine(i);
            }

            var avgMark = from s in students
                          where s.avarageMark < 4 && s.name.Length < 7
                          select s;

            foreach(University i in avgMark)
            {
                Console.WriteLine(i);
            }*/

            List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9,10};

            var oddNumbers = from s in numbers
                             where s % 2 != 0
                             select s;

            foreach(int i in oddNumbers)
            {Console.WriteLine(i);}

            Console.WriteLine();

            //numbers.FindAll(s => s % 5 == 0).ForEach(s => Console.WriteLine(s));

                        



             Console.ReadKey();
        }
    }
}
