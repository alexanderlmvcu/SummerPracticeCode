using System;
using System.Collections.Generic;

namespace FoodOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary <string, MenuBase>();
            dictionary.Add("Main Menu", new MenuBase()
            {
                EatingType = "Omnivore",
                Courses = 3,
                Served = true
            });
            dictionary.Add("Gluten Free", new MenuBase()
            {
                EatingType = "Omnivore",
                Courses = 2,
                Served = false
            });
            dictionary.Add("Veggie Monster", new MenuBase()
            {
                EatingType = "Vegetarian",
                Courses = 5,
                Served = true
            });
            dictionary.Add("Halal Hoopla", new MenuBase()
            {
                EatingType = "Religious",
                Courses = 2,
                Served = true
            });
            var menuQuestion = dictionary["Veggie Monster"];
            Console.WriteLine("We have the " + menuQuestion.EatingType + "! Served: " + menuQuestion.Served.ToString());
            Console.ReadKey();
        }
    }
}
