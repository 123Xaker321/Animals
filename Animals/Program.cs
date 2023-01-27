using System;
using System.Collections.Generic;
using System.IO;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<AllAnimals> AnimList = new List<AllAnimals>();
            AnimList.Add(new PredatoryAnimals() { AnimName = "Leo", AnimID = 1234, TypeOfFood = "Meat" });
            AnimList.Add(new HerbivorousAnimals() { AnimName = "Mich", AnimID = 2334, TypeOfFood = "Plant" });
            AnimList.Add(new Omnivores() { AnimName = "Lemon", AnimID = 3748, });
            AnimList.Add(new HerbivorousAnimals() { AnimName = "Umka", AnimID = 2019, TypeOfFood = "Plant"});
            AnimList.Add(new Omnivores() { AnimName = "Shustrik", AnimID = 3289, });
            AnimList.Add(new PredatoryAnimals() { AnimName = "Volt", AnimID = 1728, TypeOfFood = "Meat" });
            foreach (AllAnimals item in AnimList)
            {
                
                Console.WriteLine($"Name = {item.AnimName}, ID = {item.AnimID}, Food = {item.AllFoodForOneAnimal} kg of {item.TypeOfFood}");
            }
            StreamWriter strw = new StreamWriter("Animals.txt");
            foreach (AllAnimals item in AnimList)
            {

                strw.WriteLine($"Name = {item.AnimName}, ID = {item.AnimID}, Food = {item.AllFoodForOneAnimal} kg of {item.TypeOfFood}");
            }
            strw.Close();


        }
    }
}


