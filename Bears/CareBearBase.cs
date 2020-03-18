﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    abstract class CareBearBase
    {
        public BearColor Color { get; protected set; }
        public string BellyBadge { get; protected set; }
        public string Name { get; protected set; }

        public abstract void Stare();
        
        public void Care(string humanToCareFor)
        {
            Console.WriteLine($"{Name} cares deeply for {humanToCareFor}.");
        }

        public virtual void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"{Name} runs over to {careBearToHug.Name} and squeezes them, pressing" +
                $"and {careBearToHug.BellyBadge} together");
        }
    }

  
}
