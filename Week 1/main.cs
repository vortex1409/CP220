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
    Project: Week 1 Lab (No Marks)
    Description: Introduction to Structures
    Name: Michael Dorfman
    Class: CP220 - OOP 2
    Date: 1/12/2017 - 9:47 AM (EST)
*/

namespace Week_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct student
        {

            // Structure (Student)
            // Strings: First Name, Last Name Major
            // Doubles: Student ID
            // Double is assigned to student ID because Int32 cannot hold large numbers

            public string firstname;
            public string lastname;
            public double suid;
            public string major;
        }

        // getName Function
        // Recieves Structure
        // Returns First & Last together
        private string getName(student mystudent)
        {
            string output = mystudent.firstname + " " + mystudent.lastname;
            return output;
        }

        // getMajor Function
        // Recieves Structure
        // Returns Designated Output
        private string getMajor(student mystudent)
        {
            string output = "Major is: " + mystudent.major;
            return output;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            // Declare nStudent of type student
            student nStudent = new student();

            // Applies textbox values to struct members
            nStudent.firstname = txtFirst.Text;
            nStudent.lastname = txtLast.Text;

            // Displays Name
            string mboxdata = getName(nStudent);
            MessageBox.Show(mboxdata);
        }

        private void btnMajor_Click(object sender, EventArgs e)
        {
            // Declare nStudent of type student
            student nStudent = new student();

            // Applies textbox values to struct members
            nStudent.major = txtMajor.Text;

            // Displays Name
            string mboxdata = getMajor(nStudent);
            MessageBox.Show(mboxdata);
        }
    }
}
