/**************************************************************
 * Contemporary Programming Fall 2016
 * 3045C-001
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * Midterm Exam
 * ************************************************************/
using System;

namespace MidtermFall2016
{
    /// <summary>
    /// Butterfly Class. Models a Butterfly than can attack you
    /// </summary>
    class Butterfly : AnimalAttack
    {
        public Butterfly(String species, String name) : base (species, name) { }
        override public String Attack()
        {
            return "I am " + name + ", a butterfly of the " + species + " species! I will flutter around you!";
        }
    }
}
