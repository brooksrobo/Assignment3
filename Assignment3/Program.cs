using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var Stu1 = new Student(5852, "Bob", "dude0101@gmail.com", false);
            var Stu2 = new Student(1018, "Bill", "whatsgoingon@yahoo.com", true);
            var Stu3 = new Student(5001, "Joe", "what@yahoo.com", true);
            var Stu4 = new Student(1897, "Mary", "faces@hotmail.com", false);
            var Stu5 = new Student(7893, "Alex", "AlexJohnson@yahoo.com", true);
            var Stu6 = new Student(9852, "Jeffry", "Jeffry01@yahoo.com", false);
            var Stu7 = new Student(1001, "Mike", "Mach1@gmail.com", false);
            var Stu8 = new Student(8975, "Joanna", "JJ567@yahoo.com", true);
            var Stu9 = new Student(4425,"Tracy", "Savethewhales1@yahoo.com", true);
            var Stu10 = new Student(3211,"Shelly", "By_the_seashore@yahoo.com", false);


            var students = new List<Student>() { Stu1, Stu2, Stu3, Stu4, Stu5, Stu6, Stu7, Stu8, Stu9, Stu10 };

            foreach (var Student in students)
            {
                Console.WriteLine("ID: " + Student.ID);
                Console.WriteLine("Name: " + Student.Name);
                try
                {
                    Console.WriteLine("Email Address: " + Student.EmailAddress);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
            Stu1.Name = "Bobby";

            Stu1.EmailAddress = "beenchanged@gmail.com";

            Console.WriteLine("ID: " + Stu1.ID);
            Console.WriteLine("Name: " + Stu1.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu1.EmailAddress);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
