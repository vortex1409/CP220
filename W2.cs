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
    Project: Week 2 - Lab
    Description: Car Class
    Name: Michael Dorfman
    Date: 1/19/2017
 */

namespace W2___MDORFMAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Creates New Car Object
        Car MyCar = new Car("A Car", 1991);

        // Method Calls MyCar Object From Class
        // Increases Speed Property Value
        private void btnAcc_Click(object sender, EventArgs e)
        {
            MyCar.Accelerate();
            txtSpeed.Text = Convert.ToString(MyCar.speed);
            pbSpeed.Value = pbSpeed.Value + 5;
        }

        // Method Calls MyCar Object From Class
        // Decreases (Brakes) Speed Property Value
        private void btnBrake_Click(object sender, EventArgs e)
        {
            MyCar.Brake();
            txtSpeed.Text = Convert.ToString(MyCar.speed);
            pbSpeed.Value = pbSpeed.Value - 5;
        }
    }

    // Car Class
    class Car
    {
        // Declare Member Variables
        private int _year;
        private string _make;
        private int _speed;
        
        // Speed Property
        public int speed
        {
            get
            {
                return _speed;
            }
        }

        // Car Constructor
        public Car(string make, int year)
        {
            _speed = 0;
            _year = year;
            _make = make;
        }

        // Accelerate Method Increases Speed When Called
        public void Accelerate()
        {
            _speed += 5;
        }

        // Brake Method Decreases Speed When Called
        public void Brake()
        {
            _speed -= 5;
        }
    }

}
