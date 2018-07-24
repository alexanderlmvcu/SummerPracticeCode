using System;
using System.IO;

namespace Delta18
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new SqlDatabase("Server=.\\S2017E;Database=PetsDatabase;Trusted_Connection=true;");
            var pet = new Pet()
            {
                Name = "Sandwich",
                Age = 1,
                IsSpotted = false,
                Color = "Brown"
            };
            UpdatePet(database, pet);
            //foreach (var pet in database.GetAllPets())
            //{
            //    Console.WriteLine($"The pet is name {pet.Name} and is {pet.Age} years old.");
            //}
            //Console.ReadKey();
        }
        static void AddPet(IDatabase database, Pet pet)
        {
            database.Create(pet);
        }
        static void UpdatePet(IDatabase database, Pet pet)
        {
            database.Update(pet);
        }
    }
}
