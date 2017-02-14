using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

/*
    Project: Week 4 Lab
    Class: CP220 - OOP II
    Destription: Abstract Classes & Static Usage
    Name: Michael Dorfman
    Date: 02/02/217
*/

namespace W4___MDORFMAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            // Creating 3 Rectangle Objects with Fixed Width & Height
            rectangle r1 = new rectangle(10, 10);
            rectangle r2 = new rectangle(20, 90);
            rectangle r3 = new rectangle(160, 300);

            // Outputing Area and How many Rectangles were Created
            Console.WriteLine("Rectangle Area: " + r1.area());
            Console.WriteLine("Rectangle Area: " + r2.area());
            Console.WriteLine("Rectangle Area: " + r3.area());
            Console.WriteLine("Rectangle Objects Created: " + r1.count);

            // Creating 2 Circle Objects with Fixed Diameters
            circle s1 = new circle(160);
            circle s2 = new circle(250);

            // Outputing Area and How many Circles were Created
            Console.WriteLine("Circle Area: " + s1.area());
            Console.WriteLine("Circle Area: " + s2.area());
            Console.WriteLine("Cirle Objects Created: " + s1.count);
        }
    }

    // Abstract Shape Class
    abstract class shape
    {
        // Abstract Property
        public abstract double area();

        // Static Backing Field
        static double _count;

        // Readonly Property
        // Returns _count (# of Shapes)
        public double count
        {
            get
            {
                return _count;
            }
        }

        // Constructor
        // Increments Count
        public shape()
        {
            _count++;
        }

    }

    // Rectangle Class (Inherits from Shape)
    class rectangle : shape
    {
        // 2 Fields 
        private double width;
        private double height;

        //Constructor rectangle
        // recieves 2 int's assigns them to fields
        public rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        // Implements the area method area from shape class
        // returns width * height
        public override double area()
        {
            return (width * height);
        }
    }

    // Circle Class (Inherits from Shape Class)
    class circle : shape
    {
        // Fields
        private double diameter;

        // Constructor
        // Recieves a double and sets the diameter
        public circle (double d)
        {
            diameter = d;   
        }

        // Implemtation of the Area Method from the 
        // Abstract Shape Class returns the area
        public override double area()
        {
            return ((3.14 * ( 0.5 * diameter) * (0.5 * diameter)));
        }

    }

}
