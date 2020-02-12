using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1_RPG
{
    class Warrior : GameCharacter
    {
        private string weaponType;

        public string WeaponType { get => weaponType; set => weaponType = value; }

        public Warrior(string name, int strength, int intelligence, string weaponType) : base(name, strength, intelligence)
        {
            this.weaponType = weaponType;
        }
        public override void Play()
        {
            Console.WriteLine($"\n\tName: {Name}\n\tStrength: {Strength}\n\tIntelligence: {Intelligence}\n\tWeapon Type: {weaponType}");
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
