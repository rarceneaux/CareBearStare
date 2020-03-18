using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    class TenderHeart : CareBearBase
    {
        public TenderHeart()
        {
            Name = "Tender Heart";
            BellyBadge = "North Memphis";
            Color = BearColor.Browm;
        }

        public override void Stare()
        {
            Console.WriteLine($"{Name} shoots from his heart belly");
        }




    }
}
