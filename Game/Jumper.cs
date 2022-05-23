using System;
using System.Collections.Generic;


namespace Unit03.Game 
{
    public class Jumper
    {
        public Jumper()
        {

        }

        public string[] Parachute()
        {
            string[] parachute = {"  ___   ", " /___\\  ", " \\   /  ", "  \\ /",};
            return parachute;
        }

        // public string[] BreakParachute(string[] parachute)
        // {
        //     parachute.Remove[0];
        // }

        public string NewWord() {
            return "Check Jumper.NewWord()";
        }
    }
}