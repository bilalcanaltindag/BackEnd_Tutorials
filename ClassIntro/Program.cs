using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bilal";
            int age = 36;

            Course course1 = new Course();
            course1.CourseName = "Angular";
            course1.CourserName = "Bilal Can Altındap";
            course1.Rating = 35;


            Course course2 = new Course();
            course2.CourseName = "React";
            course2.CourserName = "Bilal Can Altındağ";
            course2.Rating = 50;


            Course course3 = new Course();
            course3.CourseName = "Javascript";
            course3.CourserName = "Bilal Altındağ";
            course3.Rating = 70;

            Console.WriteLine(course1.CourseName + " " + course1.CourserName);
            Console.WriteLine(course2.CourseName + " " + course2.CourserName);

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " " + course.CourserName);
                Console.WriteLine("Kurs izlenme oranı: " + course.Rating);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }

        public string CourserName { get; set; }

        public int Rating { get; set; }


    }
}
