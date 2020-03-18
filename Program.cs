using System;
using CareBearStare.Bears;
using System.Collections.Generic;
using System.Linq;

namespace CareBearStare
{
    class Program
    {
        static void Main(string[] args)
        {
            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            var tinderHeart = new TinderHeart();

            var careBears = new List<CareBearBase> { grumpyBear, tenderHeart, tinderHeart };
            foreach (var bear in careBears)
            {
                bear.Care("Nathan");
                bear.Stare();
            }

            var namesThatStartWithT = careBears.Where(bear => bear.Name.StartsWith('T'));
            var careBearNames = careBears.Select(bear => bear.Name);

            /*LINQ*/

        }
    }
}
