using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    class TinderHeart : CareBearBase
    {
        public TinderHeart()
        {
            Name = "Tinder Heart";
            BellyBadge = "Cell Phone";
            Color = BearColor.Gold;
        }
        public override void Stare()
        {
            Console.WriteLine("From the hood");        
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Swipes right on {careBearToHug.Name}");
        }
    }
}
