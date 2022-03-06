using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string course1 = "Yazılım Kampı";
            string course2 = "Programlama Kampı";
            string course3 = "React Kampı";
            string course4 = "Angular Kampı";

            string[] courses = new string[] { "Yazılım Kampı" , "Programlama Kampı" , "React Kampı" , "Angular Kampı"};

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("Sayfa Sonu");

            foreach (string course in courses)  //dizilerin tamamını dönmek için
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Foreach Sonu");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
