﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Paladin : Character
    {
        public Weapon weapon;

        public Paladin(string name, Weapon weapon) : base(name)
        {
            this.weapon = weapon;
        }

        public override void PrintStatsInfo()
        {
            Console.WriteLine("Hail " + this.name + " - take up your " + this.weapon.name + "!");
        }
    }

}
