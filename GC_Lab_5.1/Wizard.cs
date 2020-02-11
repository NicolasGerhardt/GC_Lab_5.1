using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._1
{
    class Wizard : MagicUsingCharacter
    {

        private int spellNumber;

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }

        public Wizard(string name, int strength, int intelligence, int magiclaEntergy, int spellNumber)
            : base(name, strength, intelligence, magiclaEntergy)
        {
            this.spellNumber = spellNumber;
        }

        public override void Play()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() + $" {spellNumber} Spells";
        }
    }
}
