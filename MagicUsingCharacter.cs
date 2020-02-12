using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1_RPG
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;

        public int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence)
        {
            this.magicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"\n\tName: {Name}\n\tStrength: {Strength}\n\tIntelligence: {Intelligence} \n\tMagical Energy: {magicalEnergy}");
        }
    }
}
