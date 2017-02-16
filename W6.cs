using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Project: Week 6 Lab
    Class: CP220 - OOP II
    Destription: Lists & Enumeration
    Name: Michael Dorfman
    Date: 02/16/2017
*/

namespace W6___MDORFMAN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questions 1

            // Declaring & Populating an Array
            string[] pets = { "dog", "cat", "parakeet", "guinea pig", "dire rabbit", "hamster", "ferret", "velociraptor" };

            // Adds an S to every entry in the Array
            // Prints the Array
            for (int i = 0; i < pets.Length; i++)
            {
                pets[i] = pets[i] + "s";
                Console.WriteLine("Index: " + i + " contains " + pets[i]);
            }

            line();

            // Prints the Pets Array
            foreach (string var in pets)
            {
                Console.WriteLine(var);
            }

            /*
                You cannot use a foreach loop to alter the elements inside an array
                as you cannot use the iterator to select the current index value and change
                its contents.

                You can only move through the data, not alter it.
            */

            line();

            // Creates new List with Contents
            // Prints the List to Console
            List<string> PetList = new List<string>() { "dog", "cat", "parakeet", "guinea pig", "dire rabbit", "hamster", "ferret", "velociraptor" };
            PetList.ForEach(Console.WriteLine);

            line();

            // Question 2

            EnemiesEnum badArmy = new EnemiesEnum();
            // write the foreach statment here
            foreach(string var in badArmy)
            {
                Console.WriteLine(var);
            }

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

    public class EnemyEnumerator : IEnumerator
    {
        private string[] _theList;
        private int _index = -1;

        public EnemyEnumerator(string[] incomingArrayOfBadGuys)
        {
            //initialize _thelist to be the same size as the incoming array
            _theList = new string[incomingArrayOfBadGuys.Length];
            for (int i = 0; i < incomingArrayOfBadGuys.Length; i++)
            {
                // copy the contents of incomingArrayOfBadGuys to _theList
                // do it
                _theList[i] = incomingArrayOfBadGuys[i];
            }
        }
        public object Current
        {
            get
            {
                // if the system is asking for the current value (asked implicitly by a foreach)
                // we need to throw an invalidoperationexception if the pointer is set to -1,
                // or if it is equal to or greater than the number of items in the list
                // otherwise we will return the item from the list that is currently being point at by the index

                // -- do it here
                if(_index == -1)
                {
                    throw new InvalidOperationException();
                }
                else if(_index >= _theList.Length)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    return _theList[_index];
                }
            }

        }
        public void Reset()
        {
            // we need to reset the index value when the system calls this function
            _index = -1;
        }

        public bool MoveNext()
        {
            // when the system calls the movenext function we need to move the index value
            //  only if it is safe to do so.
            // need to return true if we did change the index, otherwise return a false

            // ---- do it
            if(_index < _theList.Length -1)
            {
                _index++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class EnemiesEnum : IEnumerable
    {
        // this enumerator will always have the following creatures array in it
        private string[] _enemies = { "orc", "dragon", "college student", "rat", "mouse", "litterer", "vandal", "ninja"};
        
        // when the system asks for an enumerator from this enumeration, 
        //  we need to create a new enumerator (of the enenmy enumerator type) and send in the _enemies 
        //  array to its constructor
        public IEnumerator GetEnumerator()
        {
            return new EnemyEnumerator(_enemies);// --- i have no idea what goes here
        }

    }

}
