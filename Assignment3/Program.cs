using System;

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

            Stu1.Name = "Bobby";

            Stu1.EmailAddress = "beenchanged@gmail.com";

            Console.WriteLine("ID: " + Stu1.ID);
            Console.WriteLine("Name: " + Stu1.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu1.EmailAddress);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("ID: " + Stu2.ID);
            Console.WriteLine("Name: " + Stu2.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu2.EmailAddress);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("ID: " + Stu3.ID);
            Console.WriteLine("Name: " + Stu3.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu3.EmailAddress);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("ID: " + Stu4.ID);
            Console.WriteLine("Name: " + Stu4.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu4.EmailAddress);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("ID: " + Stu5.ID);
            Console.WriteLine("Name: " + Stu5.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu5.EmailAddress);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine("ID: " + Stu6.ID);
            Console.WriteLine("Name: " + Stu6.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu6.EmailAddress);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Console.WriteLine("ID: " + Stu7.ID);
            Console.WriteLine("Name: " + Stu7.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu7.EmailAddress);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine("ID: " + Stu8.ID);
            Console.WriteLine("Name: " + Stu8.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu8.EmailAddress);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine("ID: " + Stu9.ID);
            Console.WriteLine("Name: " + Stu9.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu9.EmailAddress);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine("ID: " + Stu10.ID);
            Console.WriteLine("Name: " + Stu10.Name);
            try
            {
                Console.WriteLine("Email Address: " + Stu10.EmailAddress);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
