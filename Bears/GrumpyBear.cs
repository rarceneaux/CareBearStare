using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    internal class GrumpyBear : CareBearBase
    {
        public GrumpyBear()
        {
            BellyBadge = "Rain Cloud";
            Color = BearColor.Blue;
            Name = "Grumpy Bear";
        }
        public override void Stare()
        {
            Console.WriteLine($"{Name} in the hood");
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Grumpy Bear hates hugs and instead shuns {careBearToHug.Name}."); 
        }
    }
}
