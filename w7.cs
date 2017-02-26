using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Project: Week 7 Lab
    Class: CP220 - OOP II
    Destription: Generics
    Name: Michael Dorfman
    Date: 02/23/2017
*/

namespace W7___MDORFMAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== QUESTION 1 ===");

            // Creates Random Object
            Random rnd = new Random();

            // Creates Generic madLabClass Object
            madLabClass<int> myInstance = new madLabClass<int>(5);

            // Populates Generic Array from Object
            for (int i = 0; i < 5; i++)
            {
                myInstance.genericArray[i] = rnd.Next(5, 100);
            }

            // Outputs Values from Generic Array
            for (int i = 0; i < 10; i++)
            {
                myInstance.GetValue();
            }
            
            line();

            Console.Write("=== QUESTION 2 === ");
            line();

            // Calls talkToMe Method using Generic Types
            madLabClass<string>.talkToMe<string, int>("Sukhoi Su-35 Multirole fighter", 55, "T-90MS Main Battle Tank");       
            pause();
        }

        // Used to Pause Console Application
        static void pause()
        {
            Console.WriteLine("============ END ==============");
            Console.WriteLine("Press Any Key to Exit Console Application");
            Console.ReadKey();
        }

        // Used to Insert Line to Seperate Sections
        static void line()
        {
            Console.WriteLine("");
        }
    }

    public class madLabClass<T>
    {
        //Fields
        private int _index;
        public T[] genericArray;

        // Property (RW)
        public int index
        {
            get
            {
                return _index;
            }

            set
            {
                _index = value;
            }
        }

        //Constructor
        public madLabClass(int SIZE)
        {
            index = 0;
            genericArray = new T[SIZE];
        }

        //Methods
        public void GetValue()
        {
            
            if (index > genericArray.Length - 1)
            {
                index = 0;
                Console.WriteLine(Convert.ToString(genericArray[index]));
                index++;
            }
            else
            {
                Console.WriteLine(Convert.ToString(genericArray[index]));
                index++;
            }
            
        }
        
        // Generic Method Prints Objects & Types
        public static void talkToMe<T1, T2>(T1 AIR, T2 R55, T1 LAND)
        {
            Console.WriteLine("== TYPES ==");
            Console.WriteLine(Convert.ToString(AIR.GetType()));
            Console.WriteLine(Convert.ToString(R55.GetType()));
            Console.WriteLine(Convert.ToString(LAND.GetType()));
            Console.WriteLine("== VALUES ==");
            Console.WriteLine(Convert.ToString(AIR));
            Console.WriteLine(Convert.ToString(R55));
            Console.WriteLine(Convert.ToString(LAND));
        }
    }
}
