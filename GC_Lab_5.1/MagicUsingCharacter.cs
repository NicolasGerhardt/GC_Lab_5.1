using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._1
{
    public class MagicUsingCharacter : GameCharacter
    {
        private int magiclaEntergy;

        public int MagiclaEntergy { get => magiclaEntergy; set => magiclaEntergy = value; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magiclaEntergy) 
            : base(name, strength, intelligence)
        {
            this.magiclaEntergy = magiclaEntergy;
        }

        public override void Play()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{Name} (int {Intelligence}, str {Strength}, magic {magiclaEntergy})";
        }


    }
}
