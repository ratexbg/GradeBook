using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{


    public class GradeBook
    {
        private string courseName; // course name for this GradeBook
                                   // property to get and set the course name
        public string CourseName { get; set; } //<-- property
                                               //{
                                               //    get
                                               //    {
                                               //        return courseName;
                                               //    }                       // end get
                                               //    set
                                               //    {
                                               //        courseName = value;
                                               //    }                       // end set
                                               //}                           // end property CourseName

        // display a welcome message to the GradeBook user


        public GradeBook(string name)  //constructor
        {
            CourseName = name;
        }

        public void DisplayMessage()
        {
            // use property CourseName to get the
            // name of the course that this GradeBook represents
            Console.WriteLine("Welcome to the grade book for\n{0}!", CourseName); // display property CourseName
        } // end method DisplayMessage

        public void DetermineClassAvarage()
        {
            int total;
            int gradeCounter;
            int grade;
            double avarage;


            total = 0;
            gradeCounter = 0;



            Console.WriteLine( "enter grade or -1 to quit:");
            grade = Convert.ToInt32(Console.ReadLine());

            while (grade != -1) 
            {
                total = total + grade;
                gradeCounter = gradeCounter + 1;

                Console.Write("enter grade ot -1 to quit:");
                grade = Convert.ToInt32(Console.ReadLine());
            }
            if (gradeCounter != 0)
            {
                avarage = (double)total / gradeCounter;
                Console.WriteLine("\n Total of All 10 grades is {0}", total);
                Console.WriteLine("Class avarage is {0:F}", avarage);
            }
            else Console.WriteLine("no grades were entered");

            //while(gradeCounter <= 10)
            //{
            //    Console.WriteLine("Enter grade:");
            //    grade = Convert.ToInt32(Console.ReadLine());
            //    total = total + grade;
            //    gradeCounter = gradeCounter + 1;
            //}

            //avarage = total / 10;


            //Console.WriteLine("\n Total of All 10 grades is {0}",total);
            //Console.WriteLine("Class avarage is {0}",avarage);






        }
    }           // end

}