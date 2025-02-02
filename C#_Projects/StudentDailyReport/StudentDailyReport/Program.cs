﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.Read();

            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.Read();//This makes sure to slow it all down and leave all data onscreen until closed by user

            Console.WriteLine("What is your name?");
            Console.ReadLine();//This will read the question and give time to answer
            string yourName = Console.ReadLine();//This sets the variable for the line below
            Console.WriteLine("Hello " + yourName);//This will provide a greeting using the variable
            Console.Read();

            Console.WriteLine("What course are you on?");
            Console.ReadLine();
            Console.Read();

            Console.WriteLine("What page number?");
            Console.ReadLine();
            Console.Read();

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.");
            Console.ReadLine();
            Console.Read();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");
            Console.ReadLine();
            Console.Read();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            Console.ReadLine();
            Console.Read();

            Console.WriteLine("How many hours did you study today?");
            Console.ReadLine();
            Console.Read();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            Console.Read();

        }
    }
}
