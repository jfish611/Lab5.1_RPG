using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1_RPG
{
    class GameCharacter
    {
        private string name;
        private int strength;
        private int intelligence;

        public string Name { get => name; set => name = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
        }

        public virtual void Play()
        {
            Console.WriteLine($"\n\tName: {name}\n\tStrength: {strength}\n\tIntelligence: {intelligence}");
        }
        //public override string ToString()
        //{
        //    return $"\n\tName: {name}\n\tStrength: {strength}\n\tIntelligence: {intelligence}";
        //}
    }
}
