/**************************************************************
 * Contemporary Programming Fall 2016
 * 3045C-001
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * Midterm Exam
 * ************************************************************/
using System;
using System.Collections.Generic;

namespace MidtermFall2016
{
    class MyMain
    {
        static void Main(string[] args)
        {
            List<AnimalAttack> animalAttack = new List<AnimalAttack>();
            animalAttack.Add(new Wombat("Lasiorhinus krefftii", "Wally"));
            animalAttack.Add(new Wombat("Vombatus ursinus", "Wanda"));
            animalAttack.Add(new Python("Antaresia maculosa", "Pauline"));
            animalAttack.Add(new Butterfly("Morpho menelaus", "Brenda"));

            for (int i = 0; i < animalAttack.Count; i++)
            {
                Console.WriteLine(animalAttack[i].Attack());
            }

        }
    }
}
