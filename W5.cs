using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/*
    Project: Week 5 Lab
    Class: CP220 - OOP II
    Destription: Exceptions & Interfaces
    Name: Michael Dorfman
    Date: 02/09/2017
*/

namespace W5___MDORFMAN
{
    class Program
    {
        static void Main(string[] args)
        {

            // === Question 1 ===
            // - Declares a Int and String
            // - Tries to parse string as an int
            // - Prints Value
            // - Parse String as Int
            // - Prints Value
            // Demonstrates Error Catching using try catch blocks 
            // to show errors in conversions
            int MyInt;
            string MyString;
            Console.WriteLine("============ QUESTION 1 ==============");
            try
            {
                MyString = "22";
                MyInt = int.Parse(MyString);
                Console.WriteLine(MyInt);
                MyString = "Sally";
                MyInt = int.Parse(MyString);
                Console.WriteLine(MyInt);
            }
            catch(Exception ex) // Exception Handling
            {
                // Displays Exception Message
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Disaster Averted");
            }

            // === Question 2 ===
            // - Creates new student object
            // - Assigns values to object fields
            // - Outputs values
            Console.WriteLine("============ QUESTION 2 ==============");
            student NewStudent = new student();
            NewStudent.Name = "Michael Dorfman";
            NewStudent.Age = 20;
            Console.WriteLine(NewStudent.Name);
            Console.WriteLine(NewStudent.Age);

            // Pauses Application
            pause();
        }

        class student
        {
            // Private Fields
            private string _name;
            private int _age;

            // Name Property (RW)
            public string Name
            {
                get
                {
                    return _name;
                }

                set
                {
                    _name = value;
                }
            }

            // Age Property (RW)
            public int Age
            {
                get
                {
                    return _age;
                }

                set
                {
                    _age = value;
                }
            }
            
            // Implicit Int Conversion
            public static implicit operator int(student StudentAge)
            {
                return StudentAge.Age;
            }

            // Explicit String Conversion
            public static explicit operator string (student StudentName)
            {
                return StudentName.Name;
            }
        }

        // Used to Pause Console Application
        static void pause()
        {
            Console.WriteLine("============ END ==============");
            Console.WriteLine("Press Enter to Exit Console Application");
            Console.ReadKey();
        }

    }
}
