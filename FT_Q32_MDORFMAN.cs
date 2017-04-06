using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Project: Question 32 - Final Exam
    Description: Twin Classes
    Name: Michael Dorfman
    Class: CP220 - OOP 2
    Date: 04/06/2017 - 11:06 AM (EST)
*/

namespace CP220_EXAM_Q32_MDORFMAN
{
    class Program
    {

        public class ClassA : ClassB
        {

            /*
                ClassA will

                - extend ClassB (0.5 marks)
                - have a private field called link that will be of type ClassA (0.5 marks)
                - have a set and get property that will set and return the private field (0.5 marks)
            */

            private ClassA _link;

            public ClassA link
            {
                get { return _link; }
                set { _link = value; }
            }
        }

        public class ClassB
        {

            /*
                ClassB will have a public method called Calculate (0.25 marks)

                - This method will take in 2 integers as parameters (0.5 marks)
                - This method will return an integer. The return value will be 
                  the product (multiplication) of the two values. (0.5 marks)
            */

            public int Calculate(int A, int B)
            {
                return A * B;
            }
        }

        static void Main(string[] args)
        {

            /*
                In the main function

                - instantiate a variable of classA (0.25 marks)
                - have this variable calculate 12 and 3 (0.25 marks)
                - print out the result of the variable calculation (0.25 marks)
            */

            ClassA ObjA = new ClassA();
            Console.WriteLine("Output = " + ObjA.Calculate(12, 3));
            Console.ReadKey();
        }
    }
}
