using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Project: OOPTest - Question 6
    Description: Casting Cows
    Name: Michael Dorfman
    Class: CP220 - OOP 2
    Date: 04/06/2017 - 10:15 AM (EST)
*/

namespace OOPTest
{
    interface ICommunicate
    {
        void speak();
    }

    public class Cow : ICommunicate
    {

        /*
            This class will

            - implement the attached interface, writing to the console window "mooooo"(0.5 marks)
            
            - will have private fields: name (a string) and height (float) (0.5 marks)
            
            - have a constructor that will take in as parameters the height of the cow 
              and the cow's name and set the fields appropriately (0.5 marks)
            
            - will have an implicit conversion operator that will return a string. 
              The value returned will be the cow's name (0.75 marks)
        */

        private string _name;
        private float _height;

        public Cow(string CowName, float CowHeight)
        {
            name = CowName;
            height = CowHeight;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public float height
        {
            get { return _height; }
            set { _height = value; }
        }


        public void speak()
        {
            Console.WriteLine("mooooo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            /*
                The main will

                - instantiate a variable of type cow with the name of Bessy 
                  and a height of 1.17 (0.5 marks)

                - cast the cow to a string variable (0.25 marks)

                - print out to the console the name of the cow (0.25 marks)

                - have the cow speak (0.25 marks)
            */

            Cow MyCow = new Cow("Bessy", (float)1.17);
            Console.WriteLine("Name: " + MyCow.name);
            MyCow.speak();
            Console.ReadKey();
        }
    }
}
