using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class AllAnimals
    {
        public double AllFoodForOneAnimal { get; set; }
        public abstract double AllAnimalsFood();
    
        public string AnimName { get; set; }
        public int AnimID { get; set; }
        public string TypeOfFood { get; set; }
        

        
    }
}
