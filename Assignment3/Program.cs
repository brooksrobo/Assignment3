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

            Stu1.EmailAddress = "Who@yahoo.com";

            Console.WriteLine("ID: " + Stu1.ID);
            Console.WriteLine("Name: " + Stu1.Name);
            if (Stu1.Visible == true)
            {
                Console.WriteLine("Email Address: " + Stu1.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email Address is classified");
            }

            Console.WriteLine("ID: " + Stu2.ID);
            Console.WriteLine("Name: " + Stu2.Name);
            if (Stu2.Visible == true)
            {
                Console.WriteLine("Email Address: " + Stu2.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email Address is classified");
            }

            Console.WriteLine("ID: " + Stu3.ID);
            Console.WriteLine("Name: " + Stu3.Name);
            if (Stu3.Visible == true)
            {
                Console.WriteLine("Email Address: " + Stu3.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email Address is classified");
            }

            Console.WriteLine("ID: " + Stu4.ID);
            Console.WriteLine("Name: " + Stu4.Name);
            if (Stu4.Visible == true)
            {
                Console.WriteLine("Email Address: " + Stu4.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email Address is classified");
            }

            Console.WriteLine("ID: " + Stu5.ID);
            Console.WriteLine("Name: " + Stu5.Name);
            if (Stu5.Visible == true)
            {
                Console.WriteLine("Email Address: " + Stu5.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email Address is classified");
            }

            Console.WriteLine("ID: " + Stu6.ID);
            Console.WriteLine("Name: " + Stu6.Name);
            if (Stu6.Visible == true)
            {
                Console.WriteLine("Email Address: " + Stu6.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email Address is classified");
            }
            Console.WriteLine("ID: " + Stu7.ID);
            Console.WriteLine("Name: " + Stu7.Name);
            if (Stu7.Visible == true)
            {
                Console.WriteLine("Email Address: " + Stu7.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email Address is classified");
            }

            Console.WriteLine("ID: " + Stu8.ID);
            Console.WriteLine("Name: " + Stu8.Name);
            if (Stu8.Visible == true)
            {
                Console.WriteLine("Email Address: " + Stu8.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email Address is classified");
            }

            Console.WriteLine("ID: " + Stu9.ID);
            Console.WriteLine("Name: " + Stu9.Name);
            if (Stu9.Visible == true)
            {
                Console.WriteLine("Email Address: " + Stu9.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email Address is classified");
            }

            Console.WriteLine("ID: " + Stu10.ID);
            Console.WriteLine("Name: " + Stu10.Name);
            if (Stu10.Visible == true)
            {
                Console.WriteLine("Email Address: " + Stu10.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email Address is classified");
            }
        }
    }
}
