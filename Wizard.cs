using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1_RPG
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber) : base(name, strength, intelligence, magicalEnergy)
        {
            this.spellNumber = spellNumber;
        }

        public override void Play()
        {
            Console.WriteLine($"\n\tName: {Name}\n\tStrength: {Strength}\n\tIntelligence: {Intelligence}\n\tMagical Energy: {MagicalEnergy}\n\tSpell Number: {spellNumber} ");
        }
    }
}
