﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_5._1
{
    public class GameCharacter
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

        public virtual void Play() { Console.WriteLine("ERROR: not implimented"); }

        public override string ToString()
        {
            return $"{name} (int {intelligence}, str {strength})";
        }
    }

}
