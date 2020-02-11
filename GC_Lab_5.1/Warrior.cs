using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._1
{
    public class Warrior : GameCharacter
    {
        private string weaponType;

        public string WeaponType { get => weaponType; set => weaponType = value; }

        public Warrior(string name, int strength, int intelligence, string weaponType) 
            : base(name, strength, intelligence)
        {
            this.weaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() + $" {weaponType}";
        }
    }
}
