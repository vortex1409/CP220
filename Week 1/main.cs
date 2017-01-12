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
        // Recieves First Name & Last Name
        // Returns First & Last together
        private string getName(string fname, string lname)
        {
            string output = fname + " " + lname;
            return output;
        }

        // getMajor Function
        // Recieves Major
        // Returns Designated Output
        private string getMajor(string iMajor)
        {
            string output = "Major is: " + iMajor;
            return output;
        }

        // Custom Response to Lab Assignment
        private void btnData_Click(object sender, EventArgs e)
        {
            // Declare nStudent of type student
            student nStudent;

            // Applies textbox values to struct members
            nStudent.firstname = txtFirst.Text;
            nStudent.lastname = txtLast.Text;
            nStudent.suid = Convert.ToDouble(txtUID.Text);
            nStudent.major = txtMajor.Text;

            // MessageBox Output Variable
            string mboxdata;

            // Displays Name
            mboxdata = getName(nStudent.firstname, nStudent.lastname);
            MessageBox.Show(mboxdata);

            // Displays Major
            mboxdata = getMajor(nStudent.major);
            MessageBox.Show(mboxdata);
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            // Declare nStudent of type student
            student nStudent;

            // Applies textbox values to struct members
            nStudent.firstname = txtFirst.Text;
            nStudent.lastname = txtLast.Text;
            nStudent.suid = Convert.ToDouble(txtUID.Text);
            nStudent.major = txtMajor.Text;

            // Displays Name
            string mboxdata = getName(nStudent.firstname, nStudent.lastname);
            MessageBox.Show(mboxdata);
        }

        private void btnMajor_Click(object sender, EventArgs e)
        {
            // Declare nStudent of type student
            student nStudent;

            // Applies textbox values to struct members
            nStudent.firstname = txtFirst.Text;
            nStudent.lastname = txtLast.Text;
            nStudent.suid = Convert.ToDouble(txtUID.Text);
            nStudent.major = txtMajor.Text;

            // Displays Name
            string mboxdata = getMajor(nStudent.major);
            MessageBox.Show(mboxdata);
        }
    }
}
