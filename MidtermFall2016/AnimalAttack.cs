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
    abstract class AnimalAttack
    {
        private String mName, mSpecies;

        public String name
        {
            get { return mName; }
            set { mName = value; }
        }
        public String species
        {
            get { return mSpecies; }
            set { mSpecies = value; }
        }
        public abstract String Attack();
        public AnimalAttack(String species, String name)
        {
            this.species = species;
            this.name = name;
        }
    }
}
