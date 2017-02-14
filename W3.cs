using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Project: Week 3 Lab
    Destription: Extensive Classes with Polymorphism
    Name: Michael Dorfman
    Date: 01/26/2017
*/

namespace W3___MDORFMAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Function
        // Recieves Animal Class
        // Calls Animal Class Move Function
        public void move(Animal NewAnimal)
        {
            NewAnimal.Move();
        }

        // Button Click Event
        // Creates New Dog
        // New Dog Calls Function Speak
        private void btnDogSpeak_Click(object sender, EventArgs e)
        {
            Dog DSPEAK = new Dog();
            DSPEAK.Speak();
        }

        // Button Click Event
        // Creates New Dog
        // New Dog is passed to move function (in form)
        private void btnDogMove_Click(object sender, EventArgs e)
        {
            Dog DMOVE = new Dog();
            move(DMOVE);
        }

        // Button Click Event
        // Creates New Cat
        // New Cat Calls Function Speak
        private void btnCatSpeak_Click(object sender, EventArgs e)
        {
            Cat CSPEAK = new Cat();
            CSPEAK.Speak();
        }

        // Button Click Event
        // Creates New Cat
        // New Cat is passed to move function (in form)
        private void btnCatMove_Click(object sender, EventArgs e)
        {
            Cat CMOVE = new Cat();
            move(CMOVE);
        }
    }

    // Animal Class
    // Contains 2 Functions
    // Virtual Keyword allows other classes to override
    // the base class
    public class Animal
    {
        public virtual void Speak()
        {
            MessageBox.Show("Grrrrr.....");
        }

        public virtual void Move()
        {
            MessageBox.Show("Location Changed");
        }
    }

    // Pet Class (Inherits from Animal)
    // Contains Name Field (Read-Only)
    // Contains Constructor with 1 Parameter (String)
    public class Pet : Animal
    {
        // Field
        private string _name;

        // Get Only (Get = Read)
        public string name
        {
            get { return _name; }
        }

        // Constructor (With Parameter)
        public Pet(string name)
        {
            _name = name;
        }
    }

    // Dog Class
    // Inherits From Animal Class
    // Contains 2 Functions
    // Speak Function (MSGBOX)
    // Move Function (MSGBOX)
    // Functions Override Base Class (OVERRIDE)
    public class Dog : Animal
    {
        public override void Speak()
        {
            MessageBox.Show("Bork");
        }

        public override void Move()
        {
            MessageBox.Show("obediently changes position");
        }
    }

    // Cat Class
    // Inherits From Animal Class
    // Contains 2 Functions
    // Speak Function (MSGBOX)
    // Move Function (MSGBOX)
    // Functions Override Base Class (OVERRIDE)
    public class Cat : Animal
    {
        public override void Speak()
        {
            MessageBox.Show("Meow");
        }

        public override void Move()
        {
            MessageBox.Show("glares at you and stays put");
        }
    }

}
