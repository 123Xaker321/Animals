using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Omnivores:AllAnimals
    {
        double HerbFood = 0.2;
        double Weight { get; set; }
        double Kilometers { get; set; }
        double PredFood = 0.01;
        public override double AllAnimalsFood() => AllFoodForOneAnimal = Math.Min(Weight * HerbFood, Kilometers * PredFood);
    }
}
