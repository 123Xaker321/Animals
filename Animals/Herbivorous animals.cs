using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class HerbivorousAnimals:AllAnimals
    {
        double HerbFood = 0.2;
        double Weight { get; set; }
        public override double AllAnimalsFood() => AllFoodForOneAnimal = Weight * HerbFood;
        
    }
}
