using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class GradeBookTest
    {
         public static void Main(string[] args)
        {

            GradeBook myGradeBook1 = new GradeBook("welcome to c#");

            GradeBook myGradeBook2 = new GradeBook("welcome to java");


            Console.WriteLine("Initial course name is:'{0}' \n ", myGradeBook1.CourseName);

            Console.WriteLine("Initial course name is:'{0}' \n ", myGradeBook2.CourseName);

            //myGradeBook.CourseName = Console.ReadLine();

            Console.WriteLine();

            myGradeBook1.DetermineClassAvarage();



            //string nameOfCourse = Console.ReadLine();

            //Console.WriteLine();

           // myGradeBook.DisplayMessage();







            //dog newDog = new dog();

            //newDog.DisplayMessage();
        }
        
    }
}
