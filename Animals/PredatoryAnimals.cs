using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class PredatoryAnimals:AllAnimals
    {
        double Kilometers { get; set; }
        double PredFood = 0.01;
        public override double AllAnimalsFood() => AllFoodForOneAnimal = Kilometers * PredFood;
        
    }
}
