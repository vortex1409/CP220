using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyMath;

// Alias
using shortMath = MDORFMAN.MyCoolMathLibrary;

/*
    Project: Week 8 Lab
    Class: CP220 - OOP II
    Destription: Libraries, Namespaces, Assemblies
    Name: Michael Dorfman
    Date: 03/02/2017
*/

namespace W8___MDORFMAN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates Objects
            Rectangle MyRect = new Rectangle(); 
            shortMath.Rectangle NewArea = new shortMath.Rectangle();

            // First Part
            MyRect.Width = 5;
            MyRect.Height = 5;
            Console.WriteLine(Convert.ToString(MyRect.Perimeter));
            MessageBox.Show(Convert.ToString(MyRect.Perimeter));

            line();

            // Second Part
            NewArea.Width = MyRect.Width;
            NewArea.Height = MyRect.Height;
            Console.WriteLine("The area of the rectangle is " + Convert.ToString(NewArea.Area));
            NewArea.PrintArea();

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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class Rectangle
    {
        private float _width, _height;
        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public float Area
        {
            get { return _height * _width; }
        }
        public float Perimeter
        {
            get { return 2 * _height + 2 * _width; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDORFMAN.MyCoolMathLibrary
{
    public class Rectangle
    {
        private float _width, _height;
        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public float Area
        {
            get { return _height * _width; }
        }
        public float Perimeter
        {
            get { return 2 * _height + 2 * _width; }
        }

        public void PrintArea()
        {
            MessageBox.Show("The area of the rectangle is " + Convert.ToString(Area));   
        }
    }
}
