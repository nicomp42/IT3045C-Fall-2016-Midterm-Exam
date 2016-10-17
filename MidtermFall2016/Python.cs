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
    /// Python Class. Models a Python than can attack you
    /// </summary>
    class Python : AnimalAttack
    {
        public Python(String species, String name) : base (species, name){}
        override public String Attack()
        {
            return "I am " + name + ", a python of the " + species + " species! I will bite you and then constrict you!";
        }
    }
}
