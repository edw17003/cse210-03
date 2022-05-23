using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit03.Game 
{
    public class Jumper
    {
        //string that holds an array of parachute values
        private string[] parachute = {"  ___   ", " /___\\  ", " \\   /  ", "  \\ /"};
        //constructor
        public Jumper() 
        {

        }
        //returns the parachute
        public string[] getParachute()
        {
            return this.parachute;
        }
        //breaks (removes) the parachute from top down
        public void breakParachute()
        {
            this.parachute = parachute.Skip(1).ToArray();
        }
    }
}